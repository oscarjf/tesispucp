using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmUnidadProductoraServicios : Form
    {
        private DataTable dtUnidadesProductorasServicios;
        private int numAccion;
        private int numIdUnidadProductoraServicio;
        
        public frmUnidadProductoraServicios()
        {
            InitializeComponent();

            clsUnidadProductoraServicio objUnidadProductoraServicio = new clsUnidadProductoraServicio();
            objUnidadProductoraServicio.Estado = "TODOS";

            dtUnidadesProductorasServicios = ctrUnidadProductoraServicio.seleccionarUnidadesProductorasServicioCriterios(objUnidadProductoraServicio);

            cargarGrilla();
        }

        private void frmUnidadProductoraServicios_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;

            dgvUnidadesProductorasServicio.Refresh();
        }

        private void cargarGrilla()
        {
            dgvUnidadesProductorasServicio.DataMember = null;

            for (int i = 0; i < dtUnidadesProductorasServicios.Rows.Count; i++)
            {
                dgvUnidadesProductorasServicio.Rows.Add(new String[] { dtUnidadesProductorasServicios.Rows[i]["IdUnidadProductoraServicio"].ToString(), 
                                                 dtUnidadesProductorasServicios.Rows[i]["Codigo"].ToString(), 
                                                 dtUnidadesProductorasServicios.Rows[i]["Nombre"].ToString(),
                                                 dtUnidadesProductorasServicios.Rows[i]["Estado"].ToString() });

                if (dtUnidadesProductorasServicios.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvUnidadesProductorasServicio.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvUnidadesProductorasServicio.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvUnidadesProductorasServicio.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvUnidadesProductorasServicio.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvUnidadesProductorasServicio.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvUnidadesProductorasServicio.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }

            dgvUnidadesProductorasServicio.ClearSelection();
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

        private void mostrarInformacion(clsUnidadProductoraServicio objUnidadProductoraServicio, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objUnidadProductoraServicio.Nombre;
                txtCodigoDetalle.Text = objUnidadProductoraServicio.Codigo;
                rtxtDescripcionDetalle.Text = objUnidadProductoraServicio.Descripcion;
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

            clsComun.tabSiguiente(tbcUnidadProductoraServicio, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                if (txtCodigoDetalle.Text.CompareTo("") != 0)
                {
                    if (ctrUnidadProductoraServicio.validarCodigo(numIdUnidadProductoraServicio, txtCodigoDetalle.Text))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El código de unidad productora de servicio ingresado ya existe. Verifique el código de unidad productora de servicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigoDetalle.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el código de la unidad productora de servicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoDetalle.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de la unidad productora de servicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdUnidadProductoraServicio = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.tabAnterior(tbcUnidadProductoraServicio, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                txtNombreBuscar.Focus();
            }
            else
            {
                if (validarFormulario())
                {
                    clsUnidadProductoraServicio objUnidadProductoraServicio = new clsUnidadProductoraServicio();
                    objUnidadProductoraServicio.IdUnidadProductoraServicio = numIdUnidadProductoraServicio;
                    objUnidadProductoraServicio.Codigo = txtCodigoDetalle.Text;
                    objUnidadProductoraServicio.Nombre = txtNombreDetalle.Text;
                    objUnidadProductoraServicio.Descripcion = rtxtDescripcionDetalle.Text;

                    if (numAccion == clsComun.INSERTAR)
                    {
                        if (ctrUnidadProductoraServicio.registrarUnidadProductoraServicio(objUnidadProductoraServicio))
                        {
                            if (MessageBox.Show("La unidad productora de servicio se registró exitosamente\n¿Desea seguir registrando unidades productoras de servicio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                limpiarFormulario();

                                txtNombreDetalle.Focus();
                            }
                            else
                            {
                                clsComun.tabAnterior(tbcUnidadProductoraServicio, tbpBuscar, tbpDetalle);

                                limpiarFormulario();

                                txtNombreBuscar.Focus();

                                dtUnidadesProductorasServicios = ctrUnidadProductoraServicio.seleccionarUnidadesProductorasServicio(objUnidadProductoraServicio);
                                cargarGrilla();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar la unidad productora de servicio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        if (ctrUnidadProductoraServicio.modificarUnidadProductoraServicio(objUnidadProductoraServicio))
                        {
                            MessageBox.Show("La unidad productora de servicio se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.tabAnterior(tbcUnidadProductoraServicio, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtUnidadesProductorasServicios = ctrUnidadProductoraServicio.seleccionarUnidadesProductorasServicio(objUnidadProductoraServicio);
                            cargarGrilla();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar la unidad productora de servicio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
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
            clsComun.tabAnterior(tbcUnidadProductoraServicio, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvUnidadesProductorasServicio.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdUnidadProductoraServicio = Int32.Parse(dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsUnidadProductoraServicio objUnidadProductoraServicio = new clsUnidadProductoraServicio();
                objUnidadProductoraServicio.IdUnidadProductoraServicio = numIdUnidadProductoraServicio;

                objUnidadProductoraServicio = ctrUnidadProductoraServicio.seleccionarUnidadProductoraServicio(objUnidadProductoraServicio);

                mostrarInformacion(objUnidadProductoraServicio, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una unidad productora de servicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUnidadesProductorasServicio.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdUnidadProductoraServicio = Int32.Parse(dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsUnidadProductoraServicio objUnidadProductoraServicio = new clsUnidadProductoraServicio();
                objUnidadProductoraServicio.IdUnidadProductoraServicio = numIdUnidadProductoraServicio;

                objUnidadProductoraServicio = ctrUnidadProductoraServicio.seleccionarUnidadProductoraServicio(objUnidadProductoraServicio);

                mostrarInformacion(objUnidadProductoraServicio, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una unidad productora de servicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUnidadesProductorasServicio.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar esta unidad productora de servicio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdUnidadProductoraServicio = Int32.Parse(dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[0].Value.ToString());

                    clsUnidadProductoraServicio objUnidadProductoraServicio = new clsUnidadProductoraServicio();
                    objUnidadProductoraServicio.IdUnidadProductoraServicio = numIdUnidadProductoraServicio;

                    if (ctrUnidadProductoraServicio.eliminarUnidadProductoraServicio(objUnidadProductoraServicio))
                    {
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[3].Value = "INACTIVO";

                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("La unidad productora de servicio se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar la unidad productora de servicio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una unidad productora de servicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvUnidadesProductorasServicio.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar esta unidad productora de servicio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdUnidadProductoraServicio = Int32.Parse(dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[0].Value.ToString());

                    clsUnidadProductoraServicio objUnidadProductoraServicio = new clsUnidadProductoraServicio();
                    objUnidadProductoraServicio.IdUnidadProductoraServicio= numIdUnidadProductoraServicio;

                    if (ctrUnidadProductoraServicio.recuperarUnidadProductoraServicio(objUnidadProductoraServicio))
                    {
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[3].Value = "ACTIVO";

                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("La unidad productora de servicio se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar la unidad productora de servicio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una unidad productora de servicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcUnidadProductoraServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcUnidadProductoraServicio.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcUnidadProductoraServicio_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsUnidadProductoraServicio objUnidadProductoraServicio = new clsUnidadProductoraServicio();
                objUnidadProductoraServicio.Nombre = txtNombreBuscar.Text;
                objUnidadProductoraServicio.Codigo = txtCodigoBuscar.Text;
                objUnidadProductoraServicio.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtUnidadesProductorasServicios = ctrUnidadProductoraServicio.seleccionarUnidadesProductorasServicioCriterios(objUnidadProductoraServicio);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvUnidadesProductorasServicios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUnidadesProductorasServicio.Rows[dgvUnidadesProductorasServicio.CurrentRow.Index].Cells[3].Value.ToString().CompareTo("ACTIVO") == 0)
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
