using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmLaboratorio : Form
    {
        private DataTable dtLaboratorios;
        private int numAccion;
        private int numIdLaboratorio;

        public frmLaboratorio()
        {
            InitializeComponent();
        }

        private void frmLaboratorio_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarGrilla()
        {
            dgvLaboratorios.DataMember = null;

            for (int i = 0; i < dtLaboratorios.Rows.Count; i++)
            {
                dgvLaboratorios.Rows.Add(new String[] { dtLaboratorios.Rows[i]["IdLaboratorio"].ToString(), 
                                                 dtLaboratorios.Rows[i]["Codigo"].ToString(), 
                                                 dtLaboratorios.Rows[i]["Nombre"].ToString(),
                                                 dtLaboratorios.Rows[i]["Estado"].ToString() });

                if (dtLaboratorios.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvLaboratorios.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvLaboratorios.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvLaboratorios.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvLaboratorios.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvLaboratorios.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvLaboratorios.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }

            dgvLaboratorios.ClearSelection();
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

        private void mostrarInformacion(clsLaboratorio objLaboratorio, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objLaboratorio.Nombre;
                txtCodigoDetalle.Text = objLaboratorio.Codigo;
                rtxtDescripcionDetalle.Text = objLaboratorio.Descripcion;
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

            clsComun.tabSiguiente(tbcLaboratorio, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                if (txtCodigoDetalle.Text.CompareTo("") != 0)
                {
                    if (ctrLaboratorio.validarCodigo(numIdLaboratorio, txtCodigoDetalle.Text))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El código de laboratorio ingresado ya existe. Verifique el código de laboratorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigoDetalle.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el código del laboratorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoDetalle.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del laboratorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdLaboratorio = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                clsLaboratorio objLaboratorio = new clsLaboratorio();
                objLaboratorio.IdLaboratorio = numIdLaboratorio;
                objLaboratorio.Codigo = txtCodigoDetalle.Text;
                objLaboratorio.Nombre = txtNombreDetalle.Text;
                objLaboratorio.Descripcion = rtxtDescripcionDetalle.Text;

                if (numAccion == clsComun.INSERTAR)
                {
                    if (ctrLaboratorio.registrarLaboratorio(objLaboratorio))
                    {
                        if (MessageBox.Show("El laboratorio se registró exitosamente\n¿Desea seguir registrando laboratorios?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            limpiarFormulario();

                            txtNombreDetalle.Focus();
                        }
                        else
                        {
                            clsComun.tabAnterior(tbcLaboratorio, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtLaboratorios = ctrLaboratorio.seleccionarLaboratorios(objLaboratorio);
                            cargarGrilla();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el laboratorio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else if (numAccion == clsComun.MODIFICAR)
                {
                    if (ctrLaboratorio.modificarLaboratorio(objLaboratorio))
                    {
                        MessageBox.Show("El laboratorio se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsComun.tabAnterior(tbcLaboratorio, tbpBuscar, tbpDetalle);

                        limpiarFormulario();

                        txtNombreBuscar.Focus();

                        dtLaboratorios = ctrLaboratorio.seleccionarLaboratorios(objLaboratorio);
                        cargarGrilla();
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el laboratorio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    clsComun.tabAnterior(tbcLaboratorio, tbpBuscar, tbpDetalle);

                    limpiarFormulario();

                    txtNombreBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcLaboratorio, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvLaboratorios.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdLaboratorio = Int32.Parse(dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsLaboratorio objLaboratorio = new clsLaboratorio();
                objLaboratorio.IdLaboratorio = numIdLaboratorio;

                objLaboratorio = ctrLaboratorio.seleccionarLaboratorio(objLaboratorio);

                mostrarInformacion(objLaboratorio, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un laboratorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvLaboratorios.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdLaboratorio = Int32.Parse(dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsLaboratorio objLaboratorio = new clsLaboratorio();
                objLaboratorio.IdLaboratorio = numIdLaboratorio;

                objLaboratorio = ctrLaboratorio.seleccionarLaboratorio(objLaboratorio);

                mostrarInformacion(objLaboratorio, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un laboratorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLaboratorios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este laboratorio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdLaboratorio = Int32.Parse(dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[0].Value.ToString());

                    clsLaboratorio objLaboratorio = new clsLaboratorio();
                    objLaboratorio.IdLaboratorio = numIdLaboratorio;

                    if (ctrLaboratorio.eliminarLaboratorio(objLaboratorio))
                    {
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[3].Value = "INACTIVO";

                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El laboratorio se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el laboratorio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un laboratorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvLaboratorios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este laboratorio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdLaboratorio = Int32.Parse(dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[0].Value.ToString());

                    clsLaboratorio objLaboratorio = new clsLaboratorio();
                    objLaboratorio.IdLaboratorio = numIdLaboratorio;

                    if (ctrLaboratorio.recuperarLaboratorio(objLaboratorio))
                    {
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[3].Value = "ACTIVO";

                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El laboratorio se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el laboratorio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un laboratorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcLaboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcLaboratorio.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcLaboratorio_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsLaboratorio objLaboratorio = new clsLaboratorio();
                objLaboratorio.Nombre = txtNombreBuscar.Text;
                objLaboratorio.Codigo = txtCodigoBuscar.Text;
                objLaboratorio.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtLaboratorios = ctrLaboratorio.seleccionarLaboratoriosCriterios(objLaboratorio);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvLaboratorios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLaboratorios.Rows[dgvLaboratorios.CurrentRow.Index].Cells[3].Value.ToString().CompareTo("ACTIVO") == 0)
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
