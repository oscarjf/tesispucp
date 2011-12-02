using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmModoIngreso : Form
    {
        private DataTable dtModosIngreso;
        private int numAccion;
        private int numIdModoIngreso;

        public frmModoIngreso()
        {
            InitializeComponent();
        }

        private void frmModoIngreso_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarGrilla()
        {
            dgvModosIngreso.DataMember = null;

            for (int i = 0; i < dtModosIngreso.Rows.Count; i++)
            {
                dgvModosIngreso.Rows.Add(new String[] { dtModosIngreso.Rows[i]["IdModoIngreso"].ToString(), 
                                                 dtModosIngreso.Rows[i]["Nombre"].ToString(),
                                                 dtModosIngreso.Rows[i]["Estado"].ToString() });

                if (dtModosIngreso.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvModosIngreso.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvModosIngreso.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvModosIngreso.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvModosIngreso.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
            }

            dgvModosIngreso.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtNombreBuscar.Clear();
            cboEstadoBuscar.SelectedIndex = 0;
            txtNombreDetalle.Clear();
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarInformacion(clsModoIngreso objModoIngreso, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objModoIngreso.Nombre;
                rtxtDescripcionDetalle.Text = objModoIngreso.Descripcion;
            }

            if (numAccion == clsComun.VER)
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;

                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;

                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.tabSiguiente(tbcModoIngreso, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del modo de ingreso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdModoIngreso = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                clsModoIngreso objModoIngreso = new clsModoIngreso();
                objModoIngreso.IdModoIngreso = numIdModoIngreso;
                objModoIngreso.Nombre = txtNombreDetalle.Text;
                objModoIngreso.Descripcion = rtxtDescripcionDetalle.Text;

                if (numAccion == clsComun.INSERTAR)
                {
                    if (ctrModoIngreso.registrarModoIngreso(objModoIngreso))
                    {
                        if (MessageBox.Show("El modo de ingreso se registró exitosamente\n¿Desea seguir registrando modos de ingreso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            limpiarFormulario();

                            txtNombreDetalle.Focus();
                        }
                        else
                        {
                            clsComun.tabAnterior(tbcModoIngreso, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtModosIngreso = ctrModoIngreso.seleccionarModosIngreso(objModoIngreso);
                            cargarGrilla();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el modo de ingreso", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else if (numAccion == clsComun.MODIFICAR)
                {
                    if (ctrModoIngreso.modificarModoIngreso(objModoIngreso))
                    {
                        MessageBox.Show("El modo de ingreso se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsComun.tabAnterior(tbcModoIngreso, tbpBuscar, tbpDetalle);

                        limpiarFormulario();

                        txtNombreBuscar.Focus();

                        dtModosIngreso = ctrModoIngreso.seleccionarModosIngreso(objModoIngreso);
                        cargarGrilla();
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el modo de ingreso", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    clsComun.tabAnterior(tbcModoIngreso, tbpBuscar, tbpDetalle);

                    limpiarFormulario();

                    txtNombreBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcModoIngreso, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvModosIngreso.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdModoIngreso = Int32.Parse(dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsModoIngreso objModoIngreso = new clsModoIngreso();
                objModoIngreso.IdModoIngreso = numIdModoIngreso;

                objModoIngreso = ctrModoIngreso.seleccionarModoIngreso(objModoIngreso);

                mostrarInformacion(objModoIngreso, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un modo de ingreso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvModosIngreso.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdModoIngreso = Int32.Parse(dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsModoIngreso objModoIngreso = new clsModoIngreso();
                objModoIngreso.IdModoIngreso = numIdModoIngreso;

                objModoIngreso = ctrModoIngreso.seleccionarModoIngreso(objModoIngreso);

                mostrarInformacion(objModoIngreso, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un modo de ingreso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvModosIngreso.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este modo de ingreso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdModoIngreso = Int32.Parse(dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[0].Value.ToString());

                    clsModoIngreso objModoIngreso = new clsModoIngreso();
                    objModoIngreso.IdModoIngreso = numIdModoIngreso;

                    if (ctrModoIngreso.eliminarModoIngreso(objModoIngreso))
                    {
                        dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[2].Value = "INACTIVO";

                        dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El modo de ingreso se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el modo de ingreso", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un modo de ingreso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvModosIngreso.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este modo de ingreso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdModoIngreso = Int32.Parse(dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[0].Value.ToString());

                    clsModoIngreso objModoIngreso = new clsModoIngreso();
                    objModoIngreso.IdModoIngreso = numIdModoIngreso;

                    if (ctrModoIngreso.recuperarModoIngreso(objModoIngreso))
                    {
                        dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[2].Value = "ACTIVO";

                        dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El modo de ingreso se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el modo de ingreso", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un modo de ingreso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcModoIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcModoIngreso.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcModoIngreso_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsModoIngreso objModoIngreso = new clsModoIngreso();
                objModoIngreso.Nombre = txtNombreBuscar.Text;
                objModoIngreso.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtModosIngreso = ctrModoIngreso.seleccionarModosIngresoCriterios(objModoIngreso);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvModosIngreso_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModosIngreso.Rows[dgvModosIngreso.CurrentRow.Index].Cells[2].Value.ToString().CompareTo("ACTIVO") == 0)
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
