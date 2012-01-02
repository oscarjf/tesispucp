using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmCPT : Form
    {
        private DataTable dtCPTs;
        private int numAccion;
        private int numIdCPT;

        public frmCPT()
        {
            InitializeComponent();

            clsCPT objCPT = new clsCPT();
            objCPT.Estado = "TODOS";

            dtCPTs = ctrCPT.seleccionarCPTsCriterios(objCPT);

            cargarGrilla();
        }

        private void frmCPT_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;

            dgvCPTs.Refresh();
        }

        private void cargarGrilla()
        {
            dgvCPTs.DataMember = null;

            for (int i = 0; i < dtCPTs.Rows.Count; i++)
            {
                dgvCPTs.Rows.Add(new String[] { dtCPTs.Rows[i]["IdCPT"].ToString(), 
                                                 dtCPTs.Rows[i]["Codigo"].ToString(), 
                                                 dtCPTs.Rows[i]["Nombre"].ToString(),
                                                 dtCPTs.Rows[i]["Estado"].ToString() });

                if (dtCPTs.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvCPTs.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvCPTs.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvCPTs.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvCPTs.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvCPTs.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvCPTs.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }

            dgvCPTs.ClearSelection();
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

        private void mostrarInformacion(clsCPT objCPT, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objCPT.Nombre;
                txtCodigoDetalle.Text = objCPT.Codigo;
                rtxtDescripcionDetalle.Text = objCPT.Descripcion;
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

            clsComun.tabSiguiente(tbcCPT, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                if (txtCodigoDetalle.Text.CompareTo("") != 0)
                {
                    if (ctrCPT.validarCodigo(numIdCPT, txtCodigoDetalle.Text))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El código de CPT ingresado ya existe. Verifique el código de CPT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigoDetalle.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el código del CPT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoDetalle.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del CPT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdCPT = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.tabAnterior(tbcCPT, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                txtNombreBuscar.Focus();
            }
            else
            {
                if (validarFormulario())
                {
                    clsCPT objCPT = new clsCPT();
                    objCPT.IdCPT = numIdCPT;
                    objCPT.Codigo = txtCodigoDetalle.Text;
                    objCPT.Nombre = txtNombreDetalle.Text;
                    objCPT.Descripcion = rtxtDescripcionDetalle.Text;

                    if (numAccion == clsComun.INSERTAR)
                    {
                        if (ctrCPT.registrarCPT(objCPT))
                        {
                            if (MessageBox.Show("El CPT se registró exitosamente\n¿Desea seguir registrando CPTs?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                limpiarFormulario();

                                txtNombreDetalle.Focus();
                            }
                            else
                            {
                                clsComun.tabAnterior(tbcCPT, tbpBuscar, tbpDetalle);

                                limpiarFormulario();

                                txtNombreBuscar.Focus();

                                dtCPTs = ctrCPT.seleccionarCPTs(objCPT);
                                cargarGrilla();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el CPT", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        if (ctrCPT.modificarCPT(objCPT))
                        {
                            MessageBox.Show("El CPT se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.tabAnterior(tbcCPT, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtCPTs = ctrCPT.seleccionarCPTs(objCPT);
                            cargarGrilla();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el CPT", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
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
            clsComun.tabAnterior(tbcCPT, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvCPTs.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdCPT = Int32.Parse(dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsCPT objCPT = new clsCPT();
                objCPT.IdCPT = numIdCPT;

                objCPT = ctrCPT.seleccionarCPT(objCPT);

                mostrarInformacion(objCPT, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un CPT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCPTs.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdCPT = Int32.Parse(dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsCPT objCPT = new clsCPT();
                objCPT.IdCPT = numIdCPT;

                objCPT = ctrCPT.seleccionarCPT(objCPT);

                mostrarInformacion(objCPT, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un CPT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCPTs.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este CPT?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdCPT = Int32.Parse(dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[0].Value.ToString());

                    clsCPT objCPT = new clsCPT();
                    objCPT.IdCPT = numIdCPT;

                    if (ctrCPT.eliminarCPT(objCPT))
                    {
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[3].Value = "INACTIVO";

                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El CPT se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el CPT", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un CPT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvCPTs.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este CPT?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdCPT = Int32.Parse(dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[0].Value.ToString());

                    clsCPT objCPT = new clsCPT();
                    objCPT.IdCPT = numIdCPT;

                    if (ctrCPT.recuperarCPT(objCPT))
                    {
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[3].Value = "ACTIVO";

                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El CPT se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el CPT", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un CPT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcCPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcCPT.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcCPT_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsCPT objCPT = new clsCPT();
                objCPT.Nombre = txtNombreBuscar.Text;
                objCPT.Codigo = txtCodigoBuscar.Text;
                objCPT.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtCPTs = ctrCPT.seleccionarCPTsCriterios(objCPT);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvCPTs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCPTs.Rows[dgvCPTs.CurrentRow.Index].Cells[3].Value.ToString().CompareTo("ACTIVO") == 0)
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
