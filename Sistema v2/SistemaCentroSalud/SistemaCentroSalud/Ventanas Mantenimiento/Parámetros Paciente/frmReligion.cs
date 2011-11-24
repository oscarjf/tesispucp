using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmReligion : Form
    {
        private DataTable dtReligiones;
        private int numAccion;
        private int numIdReligion;

        public frmReligion()
        {
            InitializeComponent();
        }

        private void frmReligion_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarGrilla()
        {
            dgvReligiones.DataMember = null;

            for (int i = 0; i < dtReligiones.Rows.Count; i++)
            {
                dgvReligiones.Rows.Add(new String[] { dtReligiones.Rows[i]["IdReligion"].ToString(), 
                                                 dtReligiones.Rows[i]["Nombre"].ToString(),
                                                 dtReligiones.Rows[i]["Estado"].ToString() });

                if (dtReligiones.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvReligiones.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvReligiones.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvReligiones.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvReligiones.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
            }

            dgvReligiones.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtNombreBuscar.Clear();
            cboEstadoBuscar.SelectedIndex = 0;
            txtNombreDetalle.Clear();
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarInformacion(clsReligion objReligion, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objReligion.Nombre;
                rtxtDescripcionDetalle.Text = objReligion.Descripcion;
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

            clsComun.tabSiguiente(tbcReligion, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de la religión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdReligion = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                clsReligion objReligion = new clsReligion();
                objReligion.IdReligion = numIdReligion;
                objReligion.Nombre = txtNombreDetalle.Text;
                objReligion.Descripcion = rtxtDescripcionDetalle.Text;

                if (numAccion == clsComun.INSERTAR)
                {
                    if (ctrReligion.registrarReligion(objReligion))
                    {
                        if (MessageBox.Show("La religión se registró exitosamente\n¿Desea seguir registrando religiones?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            limpiarFormulario();

                            txtNombreDetalle.Focus();
                        }
                        else
                        {
                            clsComun.tabAnterior(tbcReligion, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtReligiones = ctrReligion.seleccionarReligiones(objReligion);
                            cargarGrilla();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar la religión", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else if (numAccion == clsComun.MODIFICAR)
                {
                    if (ctrReligion.modificarReligion(objReligion))
                    {
                        MessageBox.Show("La religión se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsComun.tabAnterior(tbcReligion, tbpBuscar, tbpDetalle);

                        limpiarFormulario();

                        txtNombreBuscar.Focus();

                        dtReligiones = ctrReligion.seleccionarReligiones(objReligion);
                        cargarGrilla();
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar la religión", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    clsComun.tabAnterior(tbcReligion, tbpBuscar, tbpDetalle);

                    limpiarFormulario();

                    txtNombreBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcReligion, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvReligiones.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdReligion = Int32.Parse(dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsReligion objReligion = new clsReligion();
                objReligion.IdReligion = numIdReligion;

                objReligion = ctrReligion.seleccionarReligion(objReligion);

                mostrarInformacion(objReligion, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una religión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvReligiones.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdReligion = Int32.Parse(dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsReligion objReligion = new clsReligion();
                objReligion.IdReligion = numIdReligion;

                objReligion = ctrReligion.seleccionarReligion(objReligion);

                mostrarInformacion(objReligion, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una religión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReligiones.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar esta religión?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdReligion = Int32.Parse(dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[0].Value.ToString());

                    clsReligion objReligion = new clsReligion();
                    objReligion.IdReligion = numIdReligion;

                    if (ctrReligion.eliminarReligion(objReligion))
                    {
                        dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[2].Value = "INACTIVO";

                        dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("La religión se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar la religión", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una religión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvReligiones.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar esta religión?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdReligion = Int32.Parse(dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[0].Value.ToString());

                    clsReligion objReligion = new clsReligion();
                    objReligion.IdReligion = numIdReligion;

                    if (ctrReligion.recuperarReligion(objReligion))
                    {
                        dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[2].Value = "ACTIVO";

                        dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("La religión se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar la religión", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una religión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcReligion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcReligion.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcReligion_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsReligion objReligion = new clsReligion();
                objReligion.Nombre = txtNombreBuscar.Text;
                objReligion.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtReligiones = ctrReligion.seleccionarReligionesCriterios(objReligion);
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
                clsReligion objReligion = new clsReligion();
                objReligion.Nombre = txtNombreBuscar.Text;
                objReligion.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtReligiones = ctrReligion.seleccionarReligionesCriterios(objReligion);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvReligiones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReligiones.Rows[dgvReligiones.CurrentRow.Index].Cells[2].Value.ToString().CompareTo("ACTIVO") == 0)
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
