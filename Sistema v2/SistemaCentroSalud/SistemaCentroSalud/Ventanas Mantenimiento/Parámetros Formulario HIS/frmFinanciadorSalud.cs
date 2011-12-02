using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmFinanciadorSalud : Form
    {
        private DataTable dtFinanciadoresSalud;
        private int numAccion;
        private int numIdFinanciadorSalud;

        public frmFinanciadorSalud()
        {
            InitializeComponent();
        }

        private void frmFinanciadorSalud_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarGrilla()
        {
            dgvFinanciadoresSalud.DataMember = null;

            for (int i = 0; i < dtFinanciadoresSalud.Rows.Count; i++)
            {
                dgvFinanciadoresSalud.Rows.Add(new String[] { dtFinanciadoresSalud.Rows[i]["IdFinanciadorSalud"].ToString(), 
                                                 dtFinanciadoresSalud.Rows[i]["Codigo"].ToString(), 
                                                 dtFinanciadoresSalud.Rows[i]["Nombre"].ToString(),
                                                 dtFinanciadoresSalud.Rows[i]["Estado"].ToString() });

                if (dtFinanciadoresSalud.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvFinanciadoresSalud.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvFinanciadoresSalud.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvFinanciadoresSalud.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvFinanciadoresSalud.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvFinanciadoresSalud.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvFinanciadoresSalud.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }

            dgvFinanciadoresSalud.ClearSelection();
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

        private void mostrarInformacion(clsFinanciadorSalud objFinanciadorSalud, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objFinanciadorSalud.Nombre;
                txtCodigoDetalle.Text = objFinanciadorSalud.Codigo;
                rtxtDescripcionDetalle.Text = objFinanciadorSalud.Descripcion;
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

            clsComun.tabSiguiente(tbcFinanciadorSalud, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                if (txtCodigoDetalle.Text.CompareTo("") != 0)
                {
                    if (ctrFinanciadorSalud.validarCodigo(numIdFinanciadorSalud, txtCodigoDetalle.Text))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El código de financiador de salud ingresado ya existe. Verifique el código de financiador de salud", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigoDetalle.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el código del financiador de salud", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoDetalle.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del financiador de salud", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdFinanciadorSalud = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.tabAnterior(tbcFinanciadorSalud, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                txtNombreBuscar.Focus();
            }
            else
            {
                if (validarFormulario())
                {
                    clsFinanciadorSalud objFinanciadorSalud = new clsFinanciadorSalud();
                    objFinanciadorSalud.IdFinanciadorSalud = numIdFinanciadorSalud;
                    objFinanciadorSalud.Codigo = txtCodigoDetalle.Text;
                    objFinanciadorSalud.Nombre = txtNombreDetalle.Text;
                    objFinanciadorSalud.Descripcion = rtxtDescripcionDetalle.Text;

                    if (numAccion == clsComun.INSERTAR)
                    {
                        if (ctrFinanciadorSalud.registrarFinanciadorSalud(objFinanciadorSalud))
                        {
                            if (MessageBox.Show("El financiador de salud se registró exitosamente\n¿Desea seguir registrando financiadores de salud?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                limpiarFormulario();

                                txtNombreDetalle.Focus();
                            }
                            else
                            {
                                clsComun.tabAnterior(tbcFinanciadorSalud, tbpBuscar, tbpDetalle);

                                limpiarFormulario();

                                txtNombreBuscar.Focus();

                                dtFinanciadoresSalud = ctrFinanciadorSalud.seleccionarFinanciadoresSalud(objFinanciadorSalud);
                                cargarGrilla();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el financiador de salud", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        if (ctrFinanciadorSalud.modificarFinanciadorSalud(objFinanciadorSalud))
                        {
                            MessageBox.Show("El financiador de salud se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.tabAnterior(tbcFinanciadorSalud, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtFinanciadoresSalud = ctrFinanciadorSalud.seleccionarFinanciadoresSalud(objFinanciadorSalud);
                            cargarGrilla();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el financiador de salud", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcFinanciadorSalud, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvFinanciadoresSalud.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdFinanciadorSalud = Int32.Parse(dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsFinanciadorSalud objFinanciadorSalud = new clsFinanciadorSalud();
                objFinanciadorSalud.IdFinanciadorSalud = numIdFinanciadorSalud;

                objFinanciadorSalud = ctrFinanciadorSalud.seleccionarFinanciadorSalud(objFinanciadorSalud);

                mostrarInformacion(objFinanciadorSalud, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un financiador de salud", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvFinanciadoresSalud.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdFinanciadorSalud = Int32.Parse(dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsFinanciadorSalud objFinanciadorSalud = new clsFinanciadorSalud();
                objFinanciadorSalud.IdFinanciadorSalud = numIdFinanciadorSalud;

                objFinanciadorSalud = ctrFinanciadorSalud.seleccionarFinanciadorSalud(objFinanciadorSalud);

                mostrarInformacion(objFinanciadorSalud, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un financiador de salud", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFinanciadoresSalud.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este financiador de salud?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdFinanciadorSalud = Int32.Parse(dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[0].Value.ToString());

                    clsFinanciadorSalud objFinanciadorSalud = new clsFinanciadorSalud();
                    objFinanciadorSalud.IdFinanciadorSalud = numIdFinanciadorSalud;

                    if (ctrFinanciadorSalud.eliminarFinanciadorSalud(objFinanciadorSalud))
                    {
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[3].Value = "INACTIVO";

                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El financiador de salud se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el financiador de salud", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un financiador de salud", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvFinanciadoresSalud.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este financiador de salud?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdFinanciadorSalud = Int32.Parse(dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[0].Value.ToString());

                    clsFinanciadorSalud objFinanciadorSalud = new clsFinanciadorSalud();
                    objFinanciadorSalud.IdFinanciadorSalud = numIdFinanciadorSalud;

                    if (ctrFinanciadorSalud.recuperarFinanciadorSalud(objFinanciadorSalud))
                    {
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[3].Value = "ACTIVO";

                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El financiador de salud se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el financiador de salud", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un financiador de salud", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcFinanciadorSalud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcFinanciadorSalud.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcFinanciadorSalud_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsFinanciadorSalud objFinanciadorSalud = new clsFinanciadorSalud();
                objFinanciadorSalud.Nombre = txtNombreBuscar.Text;
                objFinanciadorSalud.Codigo = txtCodigoBuscar.Text;
                objFinanciadorSalud.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtFinanciadoresSalud = ctrFinanciadorSalud.seleccionarFinanciadoresSaludCriterios(objFinanciadorSalud);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvFinanciadoresSalud_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFinanciadoresSalud.Rows[dgvFinanciadoresSalud.CurrentRow.Index].Cells[3].Value.ToString().CompareTo("ACTIVO") == 0)
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
