using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmEtnia : Form
    {
        private DataTable dtEtnias;
        private int numAccion;
        private int numIdEtnia;

        public frmEtnia()
        {
            InitializeComponent();
        }

        private void frmEtnia_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarGrilla()
        {
            dgvEtnias.DataMember = null;

            for (int i = 0; i < dtEtnias.Rows.Count; i++)
            {
                dgvEtnias.Rows.Add(new String[] { dtEtnias.Rows[i]["IdEtnia"].ToString(), 
                                                 dtEtnias.Rows[i]["Codigo"].ToString(), 
                                                 dtEtnias.Rows[i]["Nombre"].ToString(),
                                                 dtEtnias.Rows[i]["Estado"].ToString() });

                if (dtEtnias.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvEtnias.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvEtnias.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvEtnias.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvEtnias.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvEtnias.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvEtnias.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }

            dgvEtnias.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtNombreBuscar.Clear();
            txtCodigoBuscar.Clear();
            cboEstadoBuscar.SelectedIndex = 0;
            txtNombreDetalle.Clear();
            txtCodigoDetalle.Clear();
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarInformacion(clsEtnia objEtnia, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objEtnia.Nombre;
                txtCodigoDetalle.Text = objEtnia.Codigo;
                rtxtDescripcionDetalle.Text = objEtnia.Descripcion;
            }

            if (numAccion == clsComun.VER)
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtCodigoDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;

                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtCodigoDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;

                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.tabSiguiente(tbcEtnia, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                if (txtCodigoDetalle.Text.CompareTo("") != 0)
                {
                    if (ctrEtnia.validarCodigo(numIdEtnia, txtCodigoDetalle.Text))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El código de etnia ingresado ya existe. Verifique el código de etnia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigoDetalle.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el código de la etnia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoDetalle.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de la etnia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdEtnia = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                clsEtnia objEtnia = new clsEtnia();
                objEtnia.IdEtnia = numIdEtnia;
                objEtnia.Codigo = txtCodigoDetalle.Text;
                objEtnia.Nombre = txtNombreDetalle.Text;
                objEtnia.Descripcion = rtxtDescripcionDetalle.Text;
                
                if (numAccion == clsComun.INSERTAR)
                {
                    if (ctrEtnia.registrarEtnia(objEtnia))
                    {
                        if (MessageBox.Show("La etnia se registró exitosamente\n¿Desea seguir registrando etnias?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            limpiarFormulario();

                            txtNombreDetalle.Focus();
                        }
                        else
                        {
                            clsComun.tabAnterior(tbcEtnia, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtEtnias = ctrEtnia.seleccionarEtnias(objEtnia);
                            cargarGrilla();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar la etnia", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else if (numAccion == clsComun.MODIFICAR)
                {
                    if (ctrEtnia.modificarEtnia(objEtnia))
                    {
                        MessageBox.Show("La etnia se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsComun.tabAnterior(tbcEtnia, tbpBuscar, tbpDetalle);

                        limpiarFormulario();

                        txtNombreBuscar.Focus();

                        dtEtnias = ctrEtnia.seleccionarEtnias(objEtnia);
                        cargarGrilla();
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar la etnia", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    clsComun.tabAnterior(tbcEtnia, tbpBuscar, tbpDetalle);

                    limpiarFormulario();

                    txtNombreBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcEtnia, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvEtnias.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdEtnia = Int32.Parse(dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsEtnia objEtnia = new clsEtnia();
                objEtnia.IdEtnia = numIdEtnia;

                objEtnia = ctrEtnia.seleccionarEtnia(objEtnia);

                mostrarInformacion(objEtnia, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una etnia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEtnias.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdEtnia = Int32.Parse(dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsEtnia objEtnia = new clsEtnia();
                objEtnia.IdEtnia = numIdEtnia;

                objEtnia = ctrEtnia.seleccionarEtnia(objEtnia);

                mostrarInformacion(objEtnia, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una etnia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEtnias.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar esta etnia?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdEtnia = Int32.Parse(dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[0].Value.ToString());

                    clsEtnia objEtnia = new clsEtnia();
                    objEtnia.IdEtnia = numIdEtnia;

                    if (ctrEtnia.eliminarEtnia(objEtnia))
                    {
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[3].Value = "INACTIVO";

                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("La etnia se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar la etnia", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una etnia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvEtnias.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar esta etnia?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdEtnia = Int32.Parse(dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[0].Value.ToString());

                    clsEtnia objEtnia = new clsEtnia();
                    objEtnia.IdEtnia = numIdEtnia;

                    if (ctrEtnia.recuperarEtnia(objEtnia))
                    {
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[3].Value = "ACTIVO";

                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("La etnia se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar la etnia", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una etnia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcEtnia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcEtnia.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcEtnia_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void buscarCriterios(object sender, EventArgs e)
        {
            try
            {
                clsEtnia objEtnia = new clsEtnia();
                objEtnia.Nombre = txtNombreBuscar.Text;
                objEtnia.Codigo = txtCodigoBuscar.Text;
                objEtnia.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtEtnias = ctrEtnia.seleccionarEtniasCriterios(objEtnia);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvEtnias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEtnias.Rows[dgvEtnias.CurrentRow.Index].Cells[3].Value.ToString().CompareTo("ACTIVO") == 0)
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
