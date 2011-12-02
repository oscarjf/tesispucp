using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmPabellon : Form
    {
        private DataTable dtPabellones;
        private int numAccion;
        private int numIdPabellon;

        public frmPabellon()
        {
            InitializeComponent();
        }

        private void frmPabellon_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarGrilla()
        {
            dgvPabellones.DataMember = null;

            for (int i = 0; i < dtPabellones.Rows.Count; i++)
            {
                dgvPabellones.Rows.Add(new String[] { dtPabellones.Rows[i]["IdPabellon"].ToString(), 
                                                 dtPabellones.Rows[i]["Nombre"].ToString(),
                                                 dtPabellones.Rows[i]["Estado"].ToString() });

                if (dtPabellones.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvPabellones.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvPabellones.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvPabellones.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvPabellones.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
            }

            dgvPabellones.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtNombreBuscar.Clear();
            cboEstadoBuscar.SelectedIndex = 0;
            txtNombreDetalle.Clear();
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarInformacion(clsPabellon objPabellon, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objPabellon.Nombre;
                rtxtDescripcionDetalle.Text = objPabellon.Descripcion;
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

            clsComun.tabSiguiente(tbcPabellon, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del pabellón", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdPabellon = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                clsPabellon objPabellon = new clsPabellon();
                objPabellon.IdPabellon = numIdPabellon;
                objPabellon.Nombre = txtNombreDetalle.Text;
                objPabellon.Descripcion = rtxtDescripcionDetalle.Text;
                
                if (numAccion == clsComun.INSERTAR)
                {
                    if (ctrPabellon.registrarPabellon(objPabellon))
                    {
                        if (MessageBox.Show("El pabellón se registró exitosamente\n¿Desea seguir registrando pabellones?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            limpiarFormulario();

                            txtNombreDetalle.Focus();
                        }
                        else
                        {
                            clsComun.tabAnterior(tbcPabellon, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtPabellones = ctrPabellon.seleccionarPabellones(objPabellon);
                            cargarGrilla();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el pabellón", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else if (numAccion == clsComun.MODIFICAR)
                {
                    if (ctrPabellon.modificarPabellon(objPabellon))
                    {
                        MessageBox.Show("El pabellón se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsComun.tabAnterior(tbcPabellon, tbpBuscar, tbpDetalle);

                        limpiarFormulario();

                        txtNombreBuscar.Focus();

                        dtPabellones = ctrPabellon.seleccionarPabellones(objPabellon);
                        cargarGrilla();
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el pabellón", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    clsComun.tabAnterior(tbcPabellon, tbpBuscar, tbpDetalle);

                    limpiarFormulario();

                    txtNombreBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcPabellon, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPabellones.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdPabellon = Int32.Parse(dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsPabellon objPabellon = new clsPabellon();
                objPabellon.IdPabellon = numIdPabellon;

                objPabellon = ctrPabellon.seleccionarPabellon(objPabellon);

                mostrarInformacion(objPabellon, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pabellón", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPabellones.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdPabellon = Int32.Parse(dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsPabellon objPabellon = new clsPabellon();
                objPabellon.IdPabellon = numIdPabellon;

                objPabellon = ctrPabellon.seleccionarPabellon(objPabellon);

                mostrarInformacion(objPabellon, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pabellón", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPabellones.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este pabellón?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdPabellon = Int32.Parse(dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[0].Value.ToString());

                    clsPabellon objPabellon = new clsPabellon();
                    objPabellon.IdPabellon = numIdPabellon;

                    if (ctrPabellon.eliminarPabellon(objPabellon))
                    {
                        dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[2].Value = "INACTIVO";

                        dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        
                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El pabellón se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el pabellón", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pabellón", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvPabellones.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este pabellón?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdPabellon = Int32.Parse(dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[0].Value.ToString());

                    clsPabellon objPabellon = new clsPabellon();
                    objPabellon.IdPabellon = numIdPabellon;

                    if (ctrPabellon.recuperarPabellon(objPabellon))
                    {
                        dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[2].Value = "ACTIVO";

                        dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        
                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El pabellón se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el pabellón", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pabellón", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcPabellon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcPabellon.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcPabellon_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsPabellon objPabellon = new clsPabellon();
                objPabellon.Nombre = txtNombreBuscar.Text;
                objPabellon.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtPabellones = ctrPabellon.seleccionarPabellonesCriterios(objPabellon);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvPabellones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPabellones.Rows[dgvPabellones.CurrentRow.Index].Cells[2].Value.ToString().CompareTo("ACTIVO") == 0)
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
