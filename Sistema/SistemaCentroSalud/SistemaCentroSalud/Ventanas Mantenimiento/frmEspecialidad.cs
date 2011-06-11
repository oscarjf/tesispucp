using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control;
using Comun;

namespace SistemaCentroSalud
{
    public partial class frmEspecialidad : Form
    {
        DataTable dtEspecialidad;
        private int numIdEspecialidad = 0;
        private int numAccion = 0;

        public frmEspecialidad()
        {
            InitializeComponent();

            cboEstadoBuscar.SelectedIndex = 0;

            txtNombreBuscar.Focus();
        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            dtEspecialidad = clsGestorBD.up_SelEspecialidad(0, "", "", clsGestorBD.SELECTALL);

            llenarGrilla(dtEspecialidad);
        }

        private void llenarGrilla(DataTable dtTabla)
        {
            dgvEspecialidades.DataMember = null;

            for (int i = 0; i < dtTabla.Rows.Count; i++)
            {
                string strIdEspecialidad = dtTabla.Rows[i][0].ToString();
                string strNombreEspecialidad = dtTabla.Rows[i][1].ToString();
                string strEstadoEspecialidad = dtTabla.Rows[i][3].ToString();

                string[] strFila = { strIdEspecialidad, strNombreEspecialidad, strEstadoEspecialidad };

                dgvEspecialidades.Rows.Add(strFila);

                if (strEstadoEspecialidad.CompareTo("INACTIVO") == 0)
                {
                    dgvEspecialidades.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvEspecialidades.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvEspecialidades.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvEspecialidades.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
            }
        }

        private bool validarVentana()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de la especialidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void limpiarCampos()
        {
            txtNombreBuscar.Clear();
            cboEstadoBuscar.SelectedIndex = 0;

            txtNombreDetalle.Clear();
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarDatos(int numAccion, DataTable dtEspecialidad)
        {
            txtNombreDetalle.Text = dtEspecialidad.Rows[0][1].ToString();
            rtxtDescripcionDetalle.Text = dtEspecialidad.Rows[0][2].ToString();

            if (numAccion == clsGestorBD.VER)
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            }
        }

        private void tbcEspecialidad_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcEspecialidad.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();

            clsComun.tabSiguiente(tbcEspecialidad, tbpBuscar, tbpDetalle);

            txtNombreDetalle.Focus();

            numAccion = clsGestorBD.INSERT;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.RowCount > 0)
            {
                try
                {
                    numAccion = clsGestorBD.VER;

                    numIdEspecialidad = Int32.Parse(dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[0].Value.ToString());

                    DataTable dtEspecialidad = clsGestorBD.up_SelEspecialidad(numIdEspecialidad, "", "", clsGestorBD.SELECT);

                    mostrarDatos(numAccion, dtEspecialidad);

                    clsComun.tabSiguiente(tbcEspecialidad, tbpBuscar, tbpDetalle);
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.RowCount > 0)
            {
                try
                {
                    numAccion = clsGestorBD.UPDATE;

                    numIdEspecialidad = Int32.Parse(dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[0].Value.ToString());

                    DataTable dtEspecialidad = clsGestorBD.up_SelEspecialidad(numIdEspecialidad, "", "", clsGestorBD.SELECT);

                    mostrarDatos(numAccion, dtEspecialidad);

                    clsComun.tabSiguiente(tbcEspecialidad, tbpBuscar, tbpDetalle);
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.RowCount > 0)
            {
                try
                {
                    numIdEspecialidad = Int32.Parse(dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[0].Value.ToString());
                    if (clsGestorBD.up_ManEspecialidad(numIdEspecialidad, "", "", clsGestorBD.DELETE))
                    {
                        MessageBox.Show("La especialidad se inactivó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCampos();

                        DataTable dtTemporal = clsGestorBD.up_SelEspecialidad(0, "", "", clsGestorBD.SELECTALL);

                        llenarGrilla(dtTemporal);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba inactivar la especialidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.RowCount > 0)
            {
                try
                {
                    numIdEspecialidad = Int32.Parse(dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[0].Value.ToString());
                    if (clsGestorBD.up_ManEspecialidad(numIdEspecialidad, "", "", clsGestorBD.RECOVER))
                    {
                        MessageBox.Show("La especialidad se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCampos();

                        DataTable dtTemporal = clsGestorBD.up_SelEspecialidad(0, "", "", clsGestorBD.SELECTALL);

                        llenarGrilla(dtTemporal);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba activar la especialidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarVentana())
            {
                if (clsGestorBD.up_ManEspecialidad(numIdEspecialidad, txtNombreDetalle.Text, rtxtDescripcionDetalle.Text, numAccion))
                {
                    if (numAccion == clsGestorBD.INSERT)
                    {
                        if (MessageBox.Show("La especialidad se registró exitosamente\n¿Desea seguir registrando especialidades?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            limpiarCampos();
                        }
                        else
                        {
                            limpiarCampos();

                            DataTable dtTemporal = clsGestorBD.up_SelEspecialidad(0, "", "", clsGestorBD.SELECTALL);

                            llenarGrilla(dtTemporal);

                            clsComun.tabAnterior(tbcEspecialidad, tbpBuscar, tbpDetalle);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La especialidad se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCampos();

                        DataTable dtTemporal = clsGestorBD.up_SelEspecialidad(0, "", "", clsGestorBD.SELECTALL);

                        llenarGrilla(dtTemporal);

                        clsComun.tabAnterior(tbcEspecialidad, tbpBuscar, tbpDetalle);
                    }
                }
                else
                {
                    if (numAccion == clsGestorBD.INSERT)
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba registrar la especialidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba actualizar la especialidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

            DataTable dtTemporal = clsGestorBD.up_SelEspecialidad(0, "", "", clsGestorBD.SELECTALL);

            llenarGrilla(dtTemporal);

            clsComun.tabAnterior(tbcEspecialidad, tbpBuscar, tbpDetalle);
        }

        private void dgvEspecialidades_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[2].Value.ToString().CompareTo("ACTIVO") == 0)
            {
                btnInactivar.Visible = true;
                btnActivar.Visible = false;
            }
            else
            {
                btnInactivar.Visible = false;
                btnActivar.Visible = true;
            }
        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtEspecialidad = clsGestorBD.up_SelEspecialidad(0, txtNombreBuscar.Text, cboEstadoBuscar.Text, clsGestorBD.SELECTCUSTOM);
                llenarGrilla(dtEspecialidad);
            }
            catch
            {
            }
        }

        private void cboEstadoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtEspecialidad = clsGestorBD.up_SelEspecialidad(0, txtNombreBuscar.Text, cboEstadoBuscar.Text, clsGestorBD.SELECTCUSTOM);
                llenarGrilla(dtEspecialidad);
            }
            catch
            {
            }
        }
    }
}
