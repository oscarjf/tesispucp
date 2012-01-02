using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmPais : Form
    {
        private DataTable dtPaises;
        private int numAccion;
        private int numIdPais;

        public frmPais()
        {
            InitializeComponent();

            clsPais objPais = new clsPais();
            objPais.Estado = "TODOS";

            dtPaises = ctrPais.seleccionarPaisesCriterios(objPais);

            cargarGrilla();
        }

        private void frmPais_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;

            dgvPaises.Refresh();
        }

        private void cargarGrilla()
        {
            dgvPaises.DataMember = null;

            for (int i = 0; i < dtPaises.Rows.Count; i++)
            {
                dgvPaises.Rows.Add(new String[] { dtPaises.Rows[i]["IdPais"].ToString(), 
                                                 dtPaises.Rows[i]["Nombre"].ToString(),
                                                 dtPaises.Rows[i]["Estado"].ToString() });

                if (dtPaises.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvPaises.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvPaises.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvPaises.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvPaises.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
            }

            dgvPaises.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtNombreBuscar.Clear();
            cboEstadoBuscar.SelectedIndex = 0;
            txtNombreDetalle.Clear();
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarInformacion(clsPais objPais, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objPais.Nombre;
                rtxtDescripcionDetalle.Text = objPais.Descripcion;
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

            clsComun.tabSiguiente(tbcPais, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del país", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdPais = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.tabAnterior(tbcPais, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                txtNombreBuscar.Focus();
            }
            else
            {
                if (validarFormulario())
                {
                    clsPais objPais = new clsPais();
                    objPais.IdPais = numIdPais;
                    objPais.Nombre = txtNombreDetalle.Text;
                    objPais.Descripcion = rtxtDescripcionDetalle.Text;

                    if (numAccion == clsComun.INSERTAR)
                    {
                        if (ctrPais.registrarPais(objPais))
                        {
                            if (MessageBox.Show("El país se registró exitosamente\n¿Desea seguir registrando países?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                limpiarFormulario();

                                txtNombreDetalle.Focus();
                            }
                            else
                            {
                                clsComun.tabAnterior(tbcPais, tbpBuscar, tbpDetalle);

                                limpiarFormulario();

                                txtNombreBuscar.Focus();

                                dtPaises = ctrPais.seleccionarPaises(objPais);
                                cargarGrilla();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el país", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        if (ctrPais.modificarPais(objPais))
                        {
                            MessageBox.Show("El país se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.tabAnterior(tbcPais, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtPaises = ctrPais.seleccionarPaises(objPais);
                            cargarGrilla();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el país", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
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
            clsComun.tabAnterior(tbcPais, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPaises.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdPais = Int32.Parse(dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsPais objPais = new clsPais();
                objPais.IdPais = numIdPais;

                objPais = ctrPais.seleccionarPais(objPais);

                mostrarInformacion(objPais, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un país", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPaises.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdPais = Int32.Parse(dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsPais objPais = new clsPais();
                objPais.IdPais = numIdPais;

                objPais = ctrPais.seleccionarPais(objPais);

                mostrarInformacion(objPais, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un país", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPaises.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este país?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdPais = Int32.Parse(dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[0].Value.ToString());

                    clsPais objPais = new clsPais();
                    objPais.IdPais = numIdPais;

                    if (ctrPais.eliminarPais(objPais))
                    {
                        dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[2].Value = "INACTIVO";

                        dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El país se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el país", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un país", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvPaises.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este país?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdPais = Int32.Parse(dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[0].Value.ToString());

                    clsPais objPais = new clsPais();
                    objPais.IdPais = numIdPais;

                    if (ctrPais.recuperarPais(objPais))
                    {
                        dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[2].Value = "ACTIVO";

                        dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El país se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el país", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un país", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcPais.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcPais_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsPais objPais = new clsPais();
                objPais.Nombre = txtNombreBuscar.Text;
                objPais.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtPaises = ctrPais.seleccionarPaisesCriterios(objPais);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvPaises_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPaises.Rows[dgvPaises.CurrentRow.Index].Cells[2].Value.ToString().CompareTo("ACTIVO") == 0)
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
