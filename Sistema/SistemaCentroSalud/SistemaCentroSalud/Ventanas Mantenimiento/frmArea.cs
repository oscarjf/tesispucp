using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;

namespace SistemaCentroSalud
{
    public partial class frmArea : Form
    {
        //List<clsArea> lstAreas = new List<clsArea>();
        DataTable dtAreas;
        private int numIdArea = 0;
        private int numAccion = 0;

        public frmArea()
        {
            InitializeComponent();

            cboTipoBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;

            txtNombreBuscar.Focus();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            dtAreas = clsGestorBD.up_SelArea(0, "", "", "", clsGestorBD.SELECTALL);

            llenarGrilla(dtAreas);
        }

        private void llenarGrilla(DataTable dtTabla)
        {
            dgvAreas.DataMember = null;

            for (int i = 0; i < dtTabla.Rows.Count; i++)
            {
                string strIdArea = dtTabla.Rows[i][0].ToString();
                string strNombreArea = dtTabla.Rows[i][1].ToString();
                string strTipoArea = dtTabla.Rows[i][3].ToString();
                string strEstadoArea = dtTabla.Rows[i][4].ToString();
                
                string[] strFila = { strIdArea, strNombreArea, strTipoArea, strEstadoArea };

                dgvAreas.Rows.Add(strFila);

                if (strEstadoArea.CompareTo("INACTIVO") == 0)
                {
                    dgvAreas.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvAreas.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvAreas.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvAreas.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvAreas.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvAreas.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }
        }

        private bool validarVentana()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                if (cboTipoDetalle.Text.CompareTo("") != 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el tipo de área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void limpiarCampos()
        {
            txtNombreBuscar.Clear();
            cboTipoBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;

            txtNombreDetalle.Clear();
            cboTipoDetalle.SelectedIndex = -1;
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarDatos(int numAccion, DataTable dtArea)
        {
            txtNombreDetalle.Text = dtArea.Rows[0][1].ToString();
            cboTipoDetalle.Text = dtArea.Rows[0][3].ToString();
            rtxtDescripcionDetalle.Text = dtArea.Rows[0][2].ToString();

            if (numAccion == clsGestorBD.VER)
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboTipoDetalle.Enabled = false;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboTipoDetalle.Enabled = true;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            }
        }

        private void tbcArea_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcArea.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();

            clsComun.tabSiguiente(tbcArea, tbpBuscar, tbpDetalle);

            txtNombreDetalle.Focus();

            numAccion = clsGestorBD.INSERT;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvAreas.RowCount > 0)
            {
                try
                {
                    numAccion = clsGestorBD.VER;

                    numIdArea = Int32.Parse(dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[0].Value.ToString());

                    DataTable dtArea = clsGestorBD.up_SelArea(numIdArea, "", "", "", clsGestorBD.SELECT);

                    mostrarDatos(numAccion, dtArea);

                    clsComun.tabSiguiente(tbcArea, tbpBuscar, tbpDetalle);
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAreas.RowCount > 0)
            {
                try
                {
                    numAccion = clsGestorBD.UPDATE;

                    numIdArea = Int32.Parse(dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[0].Value.ToString());

                    DataTable dtArea = clsGestorBD.up_SelArea(numIdArea, "", "", "", clsGestorBD.SELECT);

                    mostrarDatos(numAccion, dtArea);

                    clsComun.tabSiguiente(tbcArea, tbpBuscar, tbpDetalle);
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            if (dgvAreas.RowCount > 0)
            {
                try
                {
                    numIdArea = Int32.Parse(dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[0].Value.ToString());
                    if (clsGestorBD.up_ManArea(numIdArea, "", "", "", clsGestorBD.DELETE))
                    {
                        MessageBox.Show("El área se inactivó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        limpiarCampos();

                        DataTable dtTemporal = clsGestorBD.up_SelArea(0, "", "", "", clsGestorBD.SELECTALL);

                        llenarGrilla(dtTemporal);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba inactivar el área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvAreas.RowCount > 0)
            {
                try
                {
                    numIdArea = Int32.Parse(dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[0].Value.ToString());
                    if (clsGestorBD.up_ManArea(numIdArea, "", "", "", clsGestorBD.RECOVER))
                    {
                        MessageBox.Show("El área se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCampos();

                        DataTable dtTemporal = clsGestorBD.up_SelArea(0, "", "", "", clsGestorBD.SELECTALL);

                        llenarGrilla(dtTemporal);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba activar el área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (clsGestorBD.up_ManArea(numIdArea, txtNombreDetalle.Text, cboTipoDetalle.Text, rtxtDescripcionDetalle.Text, numAccion))
                {
                    if (numAccion == clsGestorBD.INSERT)
                    {
                        if (MessageBox.Show("El área se registró exitosamente\n¿Desea seguir registrando áreas?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            limpiarCampos();
                        }
                        else
                        {
                            limpiarCampos();

                            DataTable dtTemporal = clsGestorBD.up_SelArea(0, "", "", "", clsGestorBD.SELECTALL);

                            llenarGrilla(dtTemporal);

                            clsComun.tabAnterior(tbcArea, tbpBuscar, tbpDetalle);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El área se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCampos();

                        DataTable dtTemporal = clsGestorBD.up_SelArea(0, "", "", "", clsGestorBD.SELECTALL);

                        llenarGrilla(dtTemporal);

                        clsComun.tabAnterior(tbcArea, tbpBuscar, tbpDetalle);
                    }
                }
                else
                {
                    if (numAccion == clsGestorBD.INSERT)
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba registrar el área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba actualizar el área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

            DataTable dtTemporal = clsGestorBD.up_SelArea(0, "", "", "", clsGestorBD.SELECTALL);

            llenarGrilla(dtTemporal);

            clsComun.tabAnterior(tbcArea, tbpBuscar, tbpDetalle);
        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtAreas = clsGestorBD.up_SelArea(0, txtNombreBuscar.Text, cboTipoBuscar.Text, cboEstadoBuscar.Text, clsGestorBD.SELECTCUSTOM);
                llenarGrilla(dtAreas);
            }
            catch
            {
            }
        }

        private void cboTipoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtAreas = clsGestorBD.up_SelArea(0, txtNombreBuscar.Text, cboTipoBuscar.Text, cboEstadoBuscar.Text, clsGestorBD.SELECTCUSTOM);
                llenarGrilla(dtAreas);
            }
            catch
            {
            }
        }

        private void cboEstadoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtAreas = clsGestorBD.up_SelArea(0, txtNombreBuscar.Text, cboTipoBuscar.Text, cboEstadoBuscar.Text, clsGestorBD.SELECTCUSTOM);
                llenarGrilla(dtAreas);
            }
            catch
            {
            }
        }

        private void dgvAreas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[3].Value.ToString().CompareTo("ACTIVO") == 0)
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
    }
}
