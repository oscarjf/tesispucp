using System;
using System.Globalization;
using System.Windows.Forms;
using Comun;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Schedule;
using DevComponents.Schedule.Model;
using Modelo;
using System.Collections.Generic;

namespace SistemaCentroSalud
{
    public partial class frmDisponibilidad : Form
    {
        private int numNumeroSemana;
        private bool blnCambios = true;
        private int numIntervaloTiempo; //FALTA MODIFICAR
        private int numId = -1;
        private List<clsDetalleDisponibilidad> lstDisponibilidad = new List<clsDetalleDisponibilidad>();

        public frmDisponibilidad()
        {
            InitializeComponent();
        }

        private void frmDisponibilidad_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            numNumeroSemana = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(Convert.ToDateTime(mcCalendario.SelectionStart), CalendarWeekRule.FirstDay, DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);
            numIntervaloTiempo = 20;
            cvCalendario.TimeSlotDuration = numIntervaloTiempo;
        }

        private void mcCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (mcCalendario.SelectionStart >= DateTime.Now.Date)
            {
                int numSemana = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(Convert.ToDateTime(mcCalendario.SelectionStart), CalendarWeekRule.FirstDay, DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);

                if (blnCambios)
                {
                    numNumeroSemana = numSemana;
                }

                cvCalendario.WeekViewStartDate = mcCalendario.SelectionStart.AddDays(0 - (int)mcCalendario.SelectionStart.DayOfWeek);
                cvCalendario.WeekViewEndDate = mcCalendario.SelectionStart.AddDays(6 - (int)mcCalendario.SelectionStart.DayOfWeek);
            }
        }

        private void frmDisponibilidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (blnCambios)
            {
                if (MessageBox.Show("Hay cambios que no se han guardado y se perderán\n¿Desea guardar los cambios realizados?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    
                }
            }

            clsVentanas.VentanaHorarioActiva = false;
            this.Dispose();
        }

        private bool esFechaSeleccionada(DateTime dtInicio, DateTime dtFin)
        {
            if (cvCalendario.DateSelectionStart.HasValue && cvCalendario.DateSelectionEnd.HasValue)
            {
                if (cvCalendario.DateSelectionStart.Value <= dtInicio && cvCalendario.DateSelectionEnd.Value >= dtFin)
                    return true;
            }

            return false;
        }

        private void ShowContextMenu(ButtonItem cm)
        {
            cm.Popup(MousePosition);
        }

        private void InContentMouseUp(BaseView view, MouseEventArgs e)
        {
            DateTime dtInicio, dtFin;

            if (cvCalendario.GetDateSelectionFromPoint(e.Location, out dtInicio, out dtFin))
            {
                if (esFechaSeleccionada(dtInicio, dtFin) == false)
                {
                    cvCalendario.DateSelectionStart = dtInicio;
                    cvCalendario.DateSelectionEnd = dtFin;
                }
            }

            for (int i = biEnBlanco.SubItems.Count - 1; i > 3; i--)
            {
                biEnBlanco.SubItems.RemoveAt(i);
            }

            if (dtInicio >= DateTime.Now.Date)
            {
                ShowContextMenu(biEnBlanco);
            }
        }

        private void BaseViewMouseUp(object sender, MouseEventArgs e)
        {
            BaseView view = sender as BaseView;
            eViewArea area = view.GetViewAreaFromPoint(e.Location);

            if (area == eViewArea.InContent)
            {
                InContentMouseUp(view, e);
            }
        }

        private void AppointmentViewMouseUp(object sender)
        {
            AppointmentView view = sender as AppointmentView;

            view.IsSelected = true;

            biEliminar.Enabled = (view.Appointment.IsRecurringInstance == false);
            
            if (view.Appointment.StartTime >= DateTime.Now.Date)
            {
                if (view.Appointment.Subject.CompareTo("LIBRE") == 0 || view.Appointment.Subject.CompareTo("OCUPADO") == 0)
                {
                    biRegistro.Tag = view;
                    ShowContextMenu(biRegistro);
                }
                else
                {
                    biCita.Tag = view;
                    ShowContextMenu(biCita);
                }
            }
        }

        private void cvCalendario_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (sender is BaseView)
                {
                    BaseViewMouseUp(sender, e);
                }
                else if (sender is AppointmentView)
                {
                    AppointmentViewMouseUp(sender);
                }
            }
        }

        private Appointment AddNewAppointment(DateTime dtInicio, DateTime dtFin, bool blnCita, string strDescripcion)
        {
            Appointment appointment = new Appointment();
            
            appointment.Id = numId;
            appointment.StartTime = dtInicio;
            appointment.EndTime = dtFin;

            if (blnCita)
            {
                appointment.EndTime = dtInicio.AddMinutes(numIntervaloTiempo);
                
                appointment.Subject = "CITA";

                appointment.Description = strDescripcion;
                appointment.Tooltip = strDescripcion;

                appointment.CategoryColor = Appointment.CategoryGreen;
                appointment.TimeMarkedAs = Appointment.TimerMarkerTentative;
            }
            else
            {
                appointment.Subject = "LIBRE";

                appointment.Description = "";
                appointment.Tooltip = "";

                appointment.CategoryColor = Appointment.CategoryBlue;
                appointment.TimeMarkedAs = Appointment.TimerMarkerFree;
            }

            appointment.Locked = true;

            cvCalendario.CalendarModel.Appointments.Add(appointment);

            clsDetalleDisponibilidad objDetalleDisponibilidad = new clsDetalleDisponibilidad();
            objDetalleDisponibilidad.IdDisponibilidad = 1; //FALTA MODIFICAR
            objDetalleDisponibilidad.IdDetalleDisponibilidad = appointment.Id;
            objDetalleDisponibilidad.Fecha = appointment.StartTime.Date;
            objDetalleDisponibilidad.HoraInicio = appointment.StartTime;
            objDetalleDisponibilidad.HoraFin = appointment.EndTime;

            lstDisponibilidad.Add(objDetalleDisponibilidad);

            numId = numId - 1;

            return (appointment);
        }

        private void biDisponible_Click(object sender, EventArgs e)
        {
            DateTime dtInicio = cvCalendario.DateSelectionStart.GetValueOrDefault();
            DateTime dtFin = cvCalendario.DateSelectionEnd.GetValueOrDefault();

            AddNewAppointment(dtInicio, dtFin, false, "");
        }

        public void setearCita()
        {
            DateTime dtInicio = cvCalendario.DateSelectionStart.GetValueOrDefault();
            DateTime dtFin = cvCalendario.DateSelectionEnd.GetValueOrDefault();

            string strDescripcion = "DÍA: " + dtInicio.ToShortDateString() + "\n\nHORA: " + dtInicio.ToShortTimeString() + "\n\nPACIENTE: CHICANA VIVAR, WILDER JOSUE";

            AddNewAppointment(dtInicio, dtFin, true, strDescripcion);
        }

        private void biProgramarCita_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente ventanaBuscarPaciente = new frmBuscarPaciente(this);
            ventanaBuscarPaciente.Show();
        }

        private void biEliminar_Click(object sender, EventArgs e)
        {
            ButtonItem mi = sender as ButtonItem;
            AppointmentView view = mi.Parent.Tag as AppointmentView;

            if (view != null)
            {
                for (int i = 0; i < lstDisponibilidad.Count; i++)
                {
                    if (lstDisponibilidad[i].IdDetalleDisponibilidad == view.Appointment.Id)
                    {
                        lstDisponibilidad.RemoveAt(i);
                        break;
                    }
                }
                
                cvCalendario.CalendarModel.Appointments.Remove(view.Appointment);
            }
        }
        
        private void biLibre_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            AppointmentView view = bi.Parent.Tag as AppointmentView;

            if (view != null)
            {
                view.Appointment.Subject = "LIBRE";
                view.Appointment.CategoryColor = Appointment.CategoryBlue;
                view.Appointment.TimeMarkedAs = bi.Text.Equals(Appointment.TimerMarkerDefault) ? null : Appointment.TimerMarkerFree;
            }
        }

        private void biOcupado_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            AppointmentView view = bi.Parent.Tag as AppointmentView;

            if (view != null)
            {
                view.Appointment.Subject = "OCUPADO";
                view.Appointment.CategoryColor = Appointment.CategoryRed;
                view.Appointment.TimeMarkedAs = bi.Text.Equals(Appointment.TimerMarkerDefault) ? null : Appointment.TimerMarkerBusy;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (blnCambios)
            {
                if (MessageBox.Show("Hay cambios que no se han guardado y se perderán\n¿Desea guardar los cambios realizados?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {

                }
            }

            clsVentanas.VentanaHorarioActiva = false;
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void biCita_Click(object sender, EventArgs e)
        {

        }
    }
}
