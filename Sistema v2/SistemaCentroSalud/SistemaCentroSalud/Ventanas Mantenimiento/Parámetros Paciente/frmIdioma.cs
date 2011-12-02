using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmIdioma : Form
    {
        private DataTable dtIdiomas;
        private int numAccion;
        private int numIdIdioma;

        public frmIdioma()
        {
            InitializeComponent();
        }

        private void frmIdioma_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarGrilla()
        {
            dgvIdiomas.DataMember = null;

            for (int i = 0; i < dtIdiomas.Rows.Count; i++)
            {
                dgvIdiomas.Rows.Add(new String[] { dtIdiomas.Rows[i]["IdIdioma"].ToString(), 
                                                 dtIdiomas.Rows[i]["Nombre"].ToString(),
                                                 dtIdiomas.Rows[i]["Estado"].ToString() });

                if (dtIdiomas.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvIdiomas.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvIdiomas.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvIdiomas.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvIdiomas.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
            }

            dgvIdiomas.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtNombreBuscar.Clear();
            cboEstadoBuscar.SelectedIndex = 0;
            txtNombreDetalle.Clear();
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarInformacion(clsIdioma objIdioma, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objIdioma.Nombre;
                rtxtDescripcionDetalle.Text = objIdioma.Descripcion;
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

            clsComun.tabSiguiente(tbcIdioma, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del idioma", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdIdioma = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.tabAnterior(tbcIdioma, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                txtNombreBuscar.Focus();
            }
            else
            {
                if (validarFormulario())
                {
                    clsIdioma objIdioma = new clsIdioma();
                    objIdioma.IdIdioma = numIdIdioma;
                    objIdioma.Nombre = txtNombreDetalle.Text;
                    objIdioma.Descripcion = rtxtDescripcionDetalle.Text;

                    if (numAccion == clsComun.INSERTAR)
                    {
                        if (ctrIdioma.registrarIdioma(objIdioma))
                        {
                            if (MessageBox.Show("El idioma se registró exitosamente\n¿Desea seguir registrando idiomas?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                limpiarFormulario();

                                txtNombreDetalle.Focus();
                            }
                            else
                            {
                                clsComun.tabAnterior(tbcIdioma, tbpBuscar, tbpDetalle);

                                limpiarFormulario();

                                txtNombreBuscar.Focus();

                                dtIdiomas = ctrIdioma.seleccionarIdiomas(objIdioma);
                                cargarGrilla();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el idioma", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        if (ctrIdioma.modificarIdioma(objIdioma))
                        {
                            MessageBox.Show("El idioma se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.tabAnterior(tbcIdioma, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtIdiomas = ctrIdioma.seleccionarIdiomas(objIdioma);
                            cargarGrilla();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el idioma", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
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
            clsComun.tabAnterior(tbcIdioma, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvIdiomas.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdIdioma = Int32.Parse(dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsIdioma objIdioma = new clsIdioma();
                objIdioma.IdIdioma = numIdIdioma;

                objIdioma = ctrIdioma.seleccionarIdioma(objIdioma);

                mostrarInformacion(objIdioma, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un idioma", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvIdiomas.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdIdioma = Int32.Parse(dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsIdioma objIdioma = new clsIdioma();
                objIdioma.IdIdioma = numIdIdioma;

                objIdioma = ctrIdioma.seleccionarIdioma(objIdioma);

                mostrarInformacion(objIdioma, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un idioma", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvIdiomas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este idioma?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdIdioma = Int32.Parse(dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[0].Value.ToString());

                    clsIdioma objIdioma = new clsIdioma();
                    objIdioma.IdIdioma = numIdIdioma;

                    if (ctrIdioma.eliminarIdioma(objIdioma))
                    {
                        dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[2].Value = "INACTIVO";

                        dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El idioma se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el idioma", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un idioma", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvIdiomas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este idioma?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdIdioma = Int32.Parse(dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[0].Value.ToString());

                    clsIdioma objIdioma = new clsIdioma();
                    objIdioma.IdIdioma = numIdIdioma;

                    if (ctrIdioma.recuperarIdioma(objIdioma))
                    {
                        dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[2].Value = "ACTIVO";

                        dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El idioma se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el idioma", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un idioma", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcIdioma.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcIdioma_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsIdioma objIdioma = new clsIdioma();
                objIdioma.Nombre = txtNombreBuscar.Text;
                objIdioma.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtIdiomas = ctrIdioma.seleccionarIdiomasCriterios(objIdioma);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvIdiomas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIdiomas.Rows[dgvIdiomas.CurrentRow.Index].Cells[2].Value.ToString().CompareTo("ACTIVO") == 0)
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
