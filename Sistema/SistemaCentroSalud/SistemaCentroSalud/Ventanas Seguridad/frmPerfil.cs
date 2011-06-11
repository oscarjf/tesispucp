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

namespace SistemaCentroSalud.Ventanas_Seguridad
{
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();

            clsComun.redimensionarVentana(this, 463, 345);
            clsComun.redimensionarTabControl(tbcPerfil, 459, 318);
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            List<clsArea> lstAreas = clsGestorLogico.up_SelArea("TODOS", "TODOS");
            llenarComboArea(lstAreas);
            cboAreaBuscar.SelectedIndex = 0;
            cboAreaDetalle.SelectedIndex = 0;
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
            clsComun.redimensionarVentana(this, 574, 345);
            clsComun.redimensionarTabControl(tbcPerfil, 569, 318);

            cboAreaDetalle.Focus();
            clsComun.redimensionarTabControl(tbcPerfil, 570, 318);
            clsComun.redimensionarVentana(this, 575, 345);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                clsComun.redimensionarTabControl(tbcPerfil, 570, 318);
                clsComun.redimensionarVentana(this, 575, 345);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                clsComun.redimensionarTabControl(tbcPerfil, 570, 318);
                clsComun.redimensionarVentana(this, 575, 345);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarVentana())
            {
            }
        }
    }
}
