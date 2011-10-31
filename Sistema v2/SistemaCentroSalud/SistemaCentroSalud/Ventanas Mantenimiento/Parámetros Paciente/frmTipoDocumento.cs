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
using Control;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmTipoDocumento : Form
    {
        private DataTable dtTiposDocumento;
        private int numAccion;
        private int numIdTipoDocumento;

        public frmTipoDocumento()
        {
            InitializeComponent();
        }

        private void frmTipoDocumento_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarGrilla()
        {
            dgvTiposDocumento.DataMember = null;

            for (int i = 0; i < dtTiposDocumento.Rows.Count; i++)
            {
                dgvTiposDocumento.Rows.Add(new String[] { dtTiposDocumento.Rows[i]["IdTipoDocumento"].ToString(), 
                                                 dtTiposDocumento.Rows[i]["Nombre"].ToString(),
                                                 dtTiposDocumento.Rows[i]["NumeroDigitos"].ToString(), 
                                                 dtTiposDocumento.Rows[i]["Estado"].ToString() });

                if (dtTiposDocumento.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvTiposDocumento.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvTiposDocumento.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvTiposDocumento.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvTiposDocumento.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvTiposDocumento.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvTiposDocumento.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }

            dgvTiposDocumento.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtNombreBuscar.Clear();
            cboEstadoBuscar.SelectedIndex = 0;
            txtNombreDetalle.Clear();
            txtNumeroDigitosDetalle.Clear();
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarInformacion(clsTipoDocumento objTipoDocumento, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objTipoDocumento.Nombre;
                txtNumeroDigitosDetalle.Text = objTipoDocumento.NumeroDigitos;
                rtxtDescripcionDetalle.Text = objTipoDocumento.Descripcion;
            }

            if (numAccion == clsComun.VER)
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtNumeroDigitosDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;

                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtNumeroDigitosDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;

                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.tabSiguiente(tbcTipoDocumento, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                if (txtNumeroDigitosDetalle.Text.Length != 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Debe ingresar el número de dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumeroDigitosDetalle.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del tipo de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdTipoDocumento = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                clsTipoDocumento objTipoDocumento = new clsTipoDocumento();
                objTipoDocumento.IdTipoDocumento = numIdTipoDocumento;
                objTipoDocumento.Nombre = txtNombreDetalle.Text;
                objTipoDocumento.Descripcion = rtxtDescripcionDetalle.Text;
                objTipoDocumento.NumeroDigitos = txtNumeroDigitosDetalle.Text;

                if (numAccion == clsComun.INSERTAR)
                {
                    if (ctrTipoDocumento.registrarTipoDocumento(objTipoDocumento))
                    {
                        if (MessageBox.Show("El tipo de documento se registró exitosamente\n¿Desea seguir registrando tipos de documento?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            limpiarFormulario();

                            txtNombreDetalle.Focus();
                        }
                        else
                        {
                            clsComun.tabAnterior(tbcTipoDocumento, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtTiposDocumento = ctrTipoDocumento.seleccionarTiposDocumento(objTipoDocumento);
                            cargarGrilla();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el tipo de documento", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else if (numAccion == clsComun.MODIFICAR)
                {
                    if (ctrTipoDocumento.modificarTipoDocumento(objTipoDocumento))
                    {
                        MessageBox.Show("El tipo de documento se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsComun.tabAnterior(tbcTipoDocumento, tbpBuscar, tbpDetalle);

                        limpiarFormulario();

                        txtNombreBuscar.Focus();

                        dtTiposDocumento = ctrTipoDocumento.seleccionarTiposDocumento(objTipoDocumento);
                        cargarGrilla();
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el tipo de documento", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    clsComun.tabAnterior(tbcTipoDocumento, tbpBuscar, tbpDetalle);

                    limpiarFormulario();

                    txtNombreBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcTipoDocumento, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvTiposDocumento.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdTipoDocumento = Int32.Parse(dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsTipoDocumento objTipoDocumento = new clsTipoDocumento();
                objTipoDocumento.IdTipoDocumento = numIdTipoDocumento;

                objTipoDocumento = ctrTipoDocumento.seleccionarTipoDocumento(objTipoDocumento);

                mostrarInformacion(objTipoDocumento, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvTiposDocumento.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdTipoDocumento = Int32.Parse(dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsTipoDocumento objTipoDocumento = new clsTipoDocumento();
                objTipoDocumento.IdTipoDocumento = numIdTipoDocumento;

                objTipoDocumento = ctrTipoDocumento.seleccionarTipoDocumento(objTipoDocumento);

                mostrarInformacion(objTipoDocumento, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTiposDocumento.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este tipo de documento?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdTipoDocumento = Int32.Parse(dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[0].Value.ToString());

                    clsTipoDocumento objTipoDocumento = new clsTipoDocumento();
                    objTipoDocumento.IdTipoDocumento = numIdTipoDocumento;

                    if (ctrTipoDocumento.eliminarTipoDocumento(objTipoDocumento))
                    {
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[3].Value = "INACTIVO";

                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El tipo de documento se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el tipo de documento", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvTiposDocumento.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este tipo de documento?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdTipoDocumento = Int32.Parse(dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[0].Value.ToString());

                    clsTipoDocumento objTipoDocumento = new clsTipoDocumento();
                    objTipoDocumento.IdTipoDocumento = numIdTipoDocumento;

                    if (ctrTipoDocumento.recuperarTipoDocumento(objTipoDocumento))
                    {
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[3].Value = "ACTIVO";

                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El tipo de documento se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el tipo de documento", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcTipoDocumento.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcTipoDocumento_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                clsTipoDocumento objTipoDocumento = new clsTipoDocumento();
                objTipoDocumento.Nombre = txtNombreBuscar.Text;
                objTipoDocumento.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtTiposDocumento = ctrTipoDocumento.seleccionarTiposDocumentosCriterios(objTipoDocumento);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void cboEstadoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clsTipoDocumento objTipoDocumento = new clsTipoDocumento();
                objTipoDocumento.Nombre = txtNombreBuscar.Text;
                objTipoDocumento.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtTiposDocumento = ctrTipoDocumento.seleccionarTiposDocumentosCriterios(objTipoDocumento);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvTiposDocumento_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTiposDocumento.Rows[dgvTiposDocumento.CurrentRow.Index].Cells[3].Value.ToString().CompareTo("ACTIVO") == 0)
            {
                btnEliminar.Visible = true;
                btnActivar.Visible = false;
            }
            else
            {
                btnEliminar.Visible = false;
                btnActivar.Visible = true;
            }
        }


    }
}
