using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comun;
using Modelo;
using Logica;
using Control;

namespace SistemaCentroSalud.Ventanas_Seguridad
{
    public partial class frmPerfil : Form
    {
        DataTable dtPerfil;
        private int numIdPerfil = 0;
        private int numAccion = 0;

        public frmPerfil()
        {
            InitializeComponent();

            clsComun.redimensionarVentana(this, 463, 345);
            //clsComun.redimensionarTabControl(tbcPerfil, 459, 318);
        }


        private void frmPerfil_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            List<clsArea> lstAreas = clsGestorLogico.up_SelArea("TODOS", "TODOS");
            llenarComboArea(lstAreas);
            cboAreaBuscar.SelectedIndex = 0;
            cboAreaDetalle.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;

            dtPerfil = clsGestorBD.up_SelPerfil(0, "", "", "", clsGestorBD.SELECTALL);

            llenarGrilla(dtPerfil);

        }


        private void llenarGrilla(DataTable dtTabla)
        {
            dgvPerfiles.DataMember = null;
            //dgvDoctores.Rows.Clear();

            for (int i = 0; i < dtTabla.Rows.Count; i++)
            {
                string strIdPerfil = dtTabla.Rows[i][0].ToString();
                string strNombre = dtTabla.Rows[i][1].ToString();
                string strTipoPersonal = dtTabla.Rows[i][2].ToString();
                string strEstadoPerfil = dtTabla.Rows[i][3].ToString();

                string[] strFila = { strIdPerfil, strNombre, "AREA MEDICA UNO", strEstadoPerfil };

                dgvPerfiles.Rows.Add(strFila);

                if (strEstadoPerfil.CompareTo("INACTIVO") == 0)
                {
                    dgvPerfiles.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    dgvPerfiles.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    dgvPerfiles.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvPerfiles.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvPerfiles.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvPerfiles.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvPerfiles.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvPerfiles.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }
        }        

        private void llenarComboArea(List<clsArea> lstAreas)
        {
            clsArea objArea = new clsArea();
            objArea.StrNombre = "SELECCIONAR";

            cboAreaBuscar.Items.Add(objArea);
            cboAreaDetalle.Items.Add(objArea);

            for (int i = 0; i < lstAreas.Count; i++)
            {
                cboAreaBuscar.Items.Add(lstAreas[i]);
                cboAreaDetalle.Items.Add(lstAreas[i]);
            }
        }

        private bool validarVentana()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                if (cboAreaDetalle.Text.CompareTo("SELECCIONAR") != 0)
                {
                    if (lbxAccesosPermitidos.Items.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar al menos un permiso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombreDetalle.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboAreaDetalle.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del perfil","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clsComun.tabSiguiente(tbcPerfil, tbpBuscar, tbpDetalle);
            
            txtNombreDetalle.Focus();
            clsComun.redimensionarTabControl(tbcPerfil, 570, 318);
            clsComun.redimensionarVentana(this, 575, 345);
            numAccion = clsGestorBD.INSERT;
        }

        private void mostrarDatos(int numAccion, DataTable dtPerfil)
        {
            txtNombreDetalle.Text = dtPerfil.Rows[0][1].ToString();
            cboAreaDetalle.Text = "AREA MEDICA UNO";
            
            if (numAccion == clsGestorBD.VER)
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboAreaDetalle.Enabled = false;
            }
            else
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboAreaDetalle.Enabled = true;
            }
        }

        private void mostrarAccesos(int numAccion, DataTable dtAccesos)
        {
            for (int i = 0; i < dtAccesos.Rows.Count; i++)
            {
                string strNombreAcceso = dtAccesos.Rows[i][0].ToString();
                lbxAccesosPermitidos.Items.Add(strNombreAcceso);
            }

            if (numAccion == clsGestorBD.VER)
            {
                lbxAccesosPermitidos.Enabled = false;
            }
            else
            {
                lbxAccesosPermitidos.Enabled = true;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                try
                {
                    clsComun.redimensionarTabControl(tbcPerfil, 570, 318);
                    clsComun.redimensionarVentana(this, 575, 345);

                    numAccion = clsGestorBD.VER;

                    numIdPerfil = Int32.Parse(dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[0].Value.ToString());

                    DataTable dtPerfil = clsGestorBD.up_SelPerfil(numIdPerfil, "", "", "", clsGestorBD.SELECT);

                    mostrarDatos(numAccion, dtPerfil);

                    clsComun.tabSiguiente(tbcPerfil, tbpBuscar, tbpDetalle);
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un perfil", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                try
                {
                    clsComun.redimensionarTabControl(tbcPerfil, 570, 318);
                    clsComun.redimensionarVentana(this, 575, 345);

                    numAccion = clsGestorBD.UPDATE;

                    numIdPerfil = Int32.Parse(dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[0].Value.ToString());

                    DataTable dtPerfil = clsGestorBD.up_SelPerfil(numIdPerfil, "", "", "", clsGestorBD.SELECT);
                    DataTable dtAccesos = clsGestorBD.up_SelVentanas(numIdPerfil,"",0);

                    mostrarDatos(numAccion, dtPerfil);
                    mostrarAccesos(numAccion, dtAccesos);

                    clsComun.tabSiguiente(tbcPerfil, tbpBuscar, tbpDetalle);
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un perfil", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            DataTable dtTemporal = clsGestorBD.up_SelPerfil(0, "", "", "", clsGestorBD.SELECTALL);
            llenarGrilla(dtTemporal);

            clsComun.tabAnterior(tbcPerfil, tbpBuscar, tbpDetalle);
            clsComun.redimensionarTabControl(tbcPerfil, 459, 318);
            clsComun.redimensionarVentana(this, 463, 345);
        }

        private void tbcPerfil_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcPerfil.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void btnTodoDerecha_Click(object sender, EventArgs e)
        {
            if (!lbxAccesosPermitidos.Items.Contains("Paciente"))
            {
                lbxAccesosPermitidos.Items.Add("Paciente");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Cita"))
            {
                lbxAccesosPermitidos.Items.Add("Cita");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Consulta"))
            {
                lbxAccesosPermitidos.Items.Add("Consulta");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Doctor"))
            {
                lbxAccesosPermitidos.Items.Add("Doctor");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Enfermero"))
            {
                lbxAccesosPermitidos.Items.Add("Enfermero");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Técnico"))
            {
                lbxAccesosPermitidos.Items.Add("Técnico");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Administrativo"))
            {
                lbxAccesosPermitidos.Items.Add("Administrativo");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Historia Clínica Completa"))
            {
                lbxAccesosPermitidos.Items.Add("Historia Clínica Completa");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Historia Clínica"))
            {
                lbxAccesosPermitidos.Items.Add("Historia Clínica");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Formulario HIS"))
            {
                lbxAccesosPermitidos.Items.Add("Formulario HIS");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Áreas"))
            {
                lbxAccesosPermitidos.Items.Add("Áreas");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Especialidades Médicas"))
            {
                lbxAccesosPermitidos.Items.Add("Especialidades Médicas");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Horario"))
            {
                lbxAccesosPermitidos.Items.Add("Horario");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Perfil"))
            {
                lbxAccesosPermitidos.Items.Add("Perfil");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Auditoría"))
            {
                lbxAccesosPermitidos.Items.Add("Auditoría");
            }
            if (!lbxAccesosPermitidos.Items.Contains("Respaldo"))
            {
                lbxAccesosPermitidos.Items.Add("Respaldo");
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            try
            {
                string strNombreNodo = tvAccesos.SelectedNode.Text;

                if (strNombreNodo.CompareTo("Admisión") == 0)
                {
                    if (!lbxAccesosPermitidos.Items.Contains("Paciente"))
                    {
                        lbxAccesosPermitidos.Items.Add("Paciente");
                    }
                    if (!lbxAccesosPermitidos.Items.Contains("Cita"))
                    {
                        lbxAccesosPermitidos.Items.Add("Cita");
                    }
                    if (!lbxAccesosPermitidos.Items.Contains("Consulta"))
                    {
                        lbxAccesosPermitidos.Items.Add("Consulta");
                    }
                }
                else if (strNombreNodo.CompareTo("Personal") == 0)
                {
                    if (!lbxAccesosPermitidos.Items.Contains("Doctor"))
                    {
                        lbxAccesosPermitidos.Items.Add("Doctor");
                    }
                    if (!lbxAccesosPermitidos.Items.Contains("Enfermero"))
                    {
                        lbxAccesosPermitidos.Items.Add("Enfermero");
                    }
                    if (!lbxAccesosPermitidos.Items.Contains("Técnico"))
                    {
                        lbxAccesosPermitidos.Items.Add("Técnico");
                    }
                    if (!lbxAccesosPermitidos.Items.Contains("Administrativo"))
                    {
                        lbxAccesosPermitidos.Items.Add("Administrativo");
                    }
                }
                else if (strNombreNodo.CompareTo("Doctor") == 0)
                {
                    if (!lbxAccesosPermitidos.Items.Contains("Historia Clínica Completa"))
                    {
                        lbxAccesosPermitidos.Items.Add("Historia Clínica Completa");
                    }
                    if (!lbxAccesosPermitidos.Items.Contains("Historia Clínica"))
                    {
                        lbxAccesosPermitidos.Items.Add("Historia Clínica");
                    }
                    if (!lbxAccesosPermitidos.Items.Contains("Formulario HIS"))
                    {
                        lbxAccesosPermitidos.Items.Add("Formulario HIS");
                    }
                }
                else if (strNombreNodo.CompareTo("Mantenimiento") == 0)
                {
                    if (!lbxAccesosPermitidos.Items.Contains("Áreas"))
                    {
                        lbxAccesosPermitidos.Items.Add("Áreas");
                    }
                    if (!lbxAccesosPermitidos.Items.Contains("Especialidades Médicas"))
                    {
                        lbxAccesosPermitidos.Items.Add("Especialidades Médicas");
                    }
                    if (!lbxAccesosPermitidos.Items.Contains("Horario"))
                    {
                        lbxAccesosPermitidos.Items.Add("Horario");
                    }
                }
                else if (strNombreNodo.CompareTo("Seguridad") == 0)
                {
                    if (!lbxAccesosPermitidos.Items.Contains("Perfil"))
                    {
                        lbxAccesosPermitidos.Items.Add("Perfil");
                    }
                    if (!lbxAccesosPermitidos.Items.Contains("Auditoría"))
                    {
                        lbxAccesosPermitidos.Items.Add("Auditoría");
                    }
                    if (!lbxAccesosPermitidos.Items.Contains("Respaldo"))
                    {
                        lbxAccesosPermitidos.Items.Add("Respaldo");
                    }
                }
                else if (strNombreNodo.CompareTo("Reportes") == 0)
                {
                    //FALTA
                }
                else
                {
                    if (!lbxAccesosPermitidos.Items.Contains(tvAccesos.SelectedNode.Text))
                    {
                        lbxAccesosPermitidos.Items.Add(tvAccesos.SelectedNode.Text);
                    }
                }
            }
            catch
            {
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            try
            {
                lbxAccesosPermitidos.Items.Remove(lbxAccesosPermitidos.SelectedItem);
            }
            catch
            {
            }
        }

        private void btnTodoIzquierda_Click(object sender, EventArgs e)
        {
            lbxAccesosPermitidos.Items.Clear();
        }

        private void limpiarCampos()
        {
            txtNombreDetalle.Clear();
            cboAreaDetalle.SelectedIndex = 0;
            lbxAccesosPermitidos.Items.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarVentana())
            {
                if (clsGestorBD.up_ManPerfil(numIdPerfil, txtNombreDetalle.Text, "DOCTOR", "ACTIVO", numAccion))
                {
                    if (numAccion == clsGestorBD.INSERT)
                    {
                        for(int i=0;i<lbxAccesosPermitidos.Items.Count;i++)
                        {
                            DataTable dtId = clsGestorBD.up_SelVentanas(numIdPerfil, lbxAccesosPermitidos.Items[i].ToString(), 1);
                            int numIdVentana=Int32.Parse(dtId.Rows[0][0].ToString());
                            clsGestorBD.up_ManPerfilxVentana(numIdPerfil, numIdVentana, numAccion);
                        }
                        
                        if (MessageBox.Show("El Perfil se registró exitosamente\n¿Desea seguir registrando perfiles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            limpiarCampos();
                        }
                        else
                        {
                            limpiarCampos();

                            DataTable dtTemporal = clsGestorBD.up_SelPerfil(0, "", "", "", clsGestorBD.SELECTALL);

                            llenarGrilla(dtTemporal);

                            clsComun.tabAnterior(tbcPerfil, tbpBuscar, tbpDetalle);
                            clsComun.redimensionarTabControl(tbcPerfil, 459, 318);
                            clsComun.redimensionarVentana(this, 463, 345);
                            
                        }
                    }
                    else
                    {

                        for (int i = 0; i < lbxAccesosPermitidos.Items.Count; i++)
                        {
                            DataTable dtId = clsGestorBD.up_SelVentanas(numIdPerfil, lbxAccesosPermitidos.Items[i].ToString(), 1);
                            int numIdVentana = Int32.Parse(dtId.Rows[0][0].ToString());
                            clsGestorBD.up_ManPerfilxVentana(numIdPerfil, numIdVentana, numAccion);
                        }
                        
                        MessageBox.Show("El Perfil se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCampos();

                        DataTable dtTemporal = clsGestorBD.up_SelPerfil(0, "", "", "", clsGestorBD.SELECTALL);

                        llenarGrilla(dtTemporal);

                        clsComun.tabAnterior(tbcPerfil, tbpBuscar, tbpDetalle);
                        clsComun.redimensionarTabControl(tbcPerfil, 459, 318);
                        clsComun.redimensionarVentana(this, 463, 345);
                    }
                }
                else
                {
                    if (numAccion == clsGestorBD.INSERT)
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba registrar el Perfil", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba actualizar el Perfil", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
