using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Comun;
using Control;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Schedule;
using DevComponents.Schedule.Model;
using Modelo;

namespace SistemaCentroSalud
{
    public partial class frmDisponibilidad : Form
    {
        private int numNumeroSemana;
        private int numIntervaloTiempo; //FALTA MODIFICAR
        private int numIdDisponibilidad;
        private int numId = -1;
        private List<clsDetalleDisponibilidad> lstDetalleDisponibilidad = new List<clsDetalleDisponibilidad>();
        private string strListaEliminados = "";

        public frmDisponibilidad(int numIdDisponibilidad)
        {
            InitializeComponent();
            this.numIdDisponibilidad = numIdDisponibilidad;
        }

        private void frmDisponibilidad_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            numNumeroSemana = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(Convert.ToDateTime(mcCalendario.SelectionStart), CalendarWeekRule.FirstDay, DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);
            numIntervaloTiempo = 20;
            cvCalendario.TimeSlotDuration = numIntervaloTiempo;

            cargarDisponibilidad();
        }

        private void cargarDisponibilidad()
        {
            clsDetalleDisponibilidad objDetalleDisponibilidad = new clsDetalleDisponibilidad();
            objDetalleDisponibilidad.FechaElegida = mcCalendario.SelectionStart;
            objDetalleDisponibilidad.IdDisponibilidadDoctor = numIdDisponibilidad;
            objDetalleDisponibilidad.DetalleXML = clsComun.Serializar(lstDetalleDisponibilidad);

            DataTable dtDetalleDisponibilidad = new DataTable();

            dtDetalleDisponibilidad = ctrDisponibilidad.seleccionarDetallesDisponibilidad(objDetalleDisponibilidad);

            for (int i = 0; i < dtDetalleDisponibilidad.Rows.Count; i++)
            {
                Appointment appointment = new Appointment();

                appointment.Id = Int32.Parse(dtDetalleDisponibilidad.Rows[i]["IdDetalleDisponibilidad"].ToString());
                appointment.StartTime = DateTime.Parse(dtDetalleDisponibilidad.Rows[i]["HoraInicio"].ToString());
                appointment.EndTime = DateTime.Parse(dtDetalleDisponibilidad.Rows[i]["HoraFin"].ToString());

                appointment.Subject = "LIBRE";

                appointment.Description = "";
                appointment.Tooltip = "";

                appointment.CategoryColor = Appointment.CategoryBlue;
                appointment.TimeMarkedAs = Appointment.TimerMarkerFree;

                appointment.Locked = true;

                cvCalendario.CalendarModel.Appointments.Add(appointment);
            }
        }

        private void mcCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            //int numSemana = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(Convert.ToDateTime(mcCalendario.SelectionStart), CalendarWeekRule.FirstDay, DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);

            //if (blnCambios)
            //{
            //    numNumeroSemana = numSemana;
            //}

            cvCalendario.WeekViewStartDate = mcCalendario.SelectionStart.AddDays(0 - (int)mcCalendario.SelectionStart.DayOfWeek);
            cvCalendario.WeekViewEndDate = mcCalendario.SelectionStart.AddDays(6 - (int)mcCalendario.SelectionStart.DayOfWeek);
        }

        private void frmDisponibilidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lstDetalleDisponibilidad.Count > 0 || strListaEliminados.CompareTo("") != 0)
            {
                if (MessageBox.Show("Hay cambios que no se han guardado y se perderán\n¿Desea guardar los cambios realizados?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    btnGuardar_Click(sender, e);
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
            else
            {
                MessageBox.Show("No se pueden editar fechas anteriores", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                biRegistro.Tag = view;
                ShowContextMenu(biRegistro);
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

        private Appointment AddNewAppointment(DateTime dtInicio, DateTime dtFin, string strDescripcion)
        {
            Appointment appointment = new Appointment();
            
            appointment.Id = numId;
            appointment.StartTime = dtInicio;
            appointment.EndTime = dtFin;

            appointment.Subject = "LIBRE";

            appointment.Description = "";
            appointment.Tooltip = "";

            appointment.CategoryColor = Appointment.CategoryBlue;
            appointment.TimeMarkedAs = Appointment.TimerMarkerFree;

            appointment.Locked = true;

            cvCalendario.CalendarModel.Appointments.Add(appointment);

            clsDetalleDisponibilidad objDetalleDisponibilidad = new clsDetalleDisponibilidad();
            objDetalleDisponibilidad._IdDisponibilidad = numIdDisponibilidad;
            objDetalleDisponibilidad._IdDetalleDisponibilidad = appointment.Id;
            objDetalleDisponibilidad._Fecha = appointment.StartTime.Date;
            objDetalleDisponibilidad._HoraInicio = appointment.StartTime;
            objDetalleDisponibilidad._HoraFin = appointment.EndTime;

            lstDetalleDisponibilidad.Add(objDetalleDisponibilidad);

            numId = numId - 1;

            return (appointment);
        }

        private void biDisponible_Click(object sender, EventArgs e)
        {
            DateTime dtInicio = cvCalendario.DateSelectionStart.GetValueOrDefault();
            DateTime dtFin = cvCalendario.DateSelectionEnd.GetValueOrDefault();

            AddNewAppointment(dtInicio, dtFin, "");
        }

        private void biEliminar_Click(object sender, EventArgs e)
        {
            ButtonItem mi = sender as ButtonItem;
            AppointmentView view = mi.Parent.Tag as AppointmentView;

            if (view != null)
            {
                if (view.Appointment.Id < 0)
                {
                    for (int i = 0; i < lstDetalleDisponibilidad.Count; i++)
                    {
                        if (lstDetalleDisponibilidad[i]._IdDetalleDisponibilidad == view.Appointment.Id)
                        {
                            lstDetalleDisponibilidad.RemoveAt(i);
                            break;
                        }
                    }

                    cvCalendario.CalendarModel.Appointments.Remove(view.Appointment);
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro(a) de que desea eliminar esta disponibilidad?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        strListaEliminados = strListaEliminados + "," + view.Appointment.Id;

                        cvCalendario.CalendarModel.Appointments.Remove(view.Appointment);
                    }
                }
            }
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (lstDetalleDisponibilidad.Count > 0 || strListaEliminados.CompareTo("") != 0)
            {
                if (MessageBox.Show("Hay cambios que no se han guardado y se perderán\n¿Desea guardar los cambios realizados?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    btnGuardar_Click(sender, e);
                }
            }

            clsVentanas.VentanaHorarioActiva = false;
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsDetalleDisponibilidad objDetalleDisponibilidad = new clsDetalleDisponibilidad();
            objDetalleDisponibilidad.IdDisponibilidadDoctor = numIdDisponibilidad;
            objDetalleDisponibilidad.DetalleXML = clsComun.Serializar(lstDetalleDisponibilidad);
            objDetalleDisponibilidad.ListaEliminados = strListaEliminados;

            if (ctrDisponibilidad.registrarDetalleDisponibilidad(objDetalleDisponibilidad))
            {
                MessageBox.Show("La disponibilidad se registró exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar la disponibilidad", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                {
                    btnGuardar_Click(sender, e);
                }
            }

            lstDetalleDisponibilidad.Clear();
            strListaEliminados = "";

            cvCalendario.CalendarModel.Appointments.Clear();
            cargarDisponibilidad();
        }
    }
}
