using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud
{
    public partial class frmArea : Form
    {
        private DataTable dtAreas;
        private int numAccion;
        private int numIdArea;

        public frmArea()
        {
            InitializeComponent();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboTipoBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarGrilla()
        {
            dgvAreas.DataMember = null;

            for (int i = 0; i < dtAreas.Rows.Count; i++)
            {
                dgvAreas.Rows.Add(new String[] { dtAreas.Rows[i]["IdArea"].ToString(), 
                                                 dtAreas.Rows[i]["Nombre"].ToString(),
                                                 dtAreas.Rows[i]["TipoArea"].ToString(), 
                                                 dtAreas.Rows[i]["Estado"].ToString() });

                if (dtAreas.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvAreas.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvAreas.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvAreas.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvAreas.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvAreas.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvAreas.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }

            dgvAreas.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtNombreBuscar.Clear();
            cboTipoBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;
            txtNombreDetalle.Clear();
            cboTipoDetalle.SelectedIndex = 0;
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarInformacion(clsArea objArea, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objArea.Nombre;
                cboTipoDetalle.Text = objArea.TipoArea;
                rtxtDescripcionDetalle.Text = objArea.Descripcion;
            }
            
            if (numAccion == clsComun.VER)
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboTipoDetalle.Enabled = false;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;

                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboTipoDetalle.Enabled = true;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;

                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.tabSiguiente(tbcArea, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                if (cboTipoDetalle.SelectedIndex != 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el tipo de área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboTipoDetalle.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;
            
            numIdArea = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                clsArea objArea = new clsArea();
                objArea.IdArea = numIdArea;
                objArea.Nombre = txtNombreDetalle.Text;
                objArea.Descripcion = rtxtDescripcionDetalle.Text;
                objArea.TipoArea = cboTipoDetalle.SelectedItem.ToString();

                if (numAccion == clsComun.INSERTAR)
                {
                    if (ctrArea.registrarArea(objArea))
                    {
                        if (MessageBox.Show("El área se registró exitosamente\n¿Desea seguir registrando áreas?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            limpiarFormulario();

                            txtNombreDetalle.Focus();
                        }
                        else
                        {
                            clsComun.tabAnterior(tbcArea, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtAreas = ctrArea.seleccionarAreas(objArea);
                            cargarGrilla();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el área", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else if (numAccion == clsComun.MODIFICAR)
                {
                    if (ctrArea.modificarArea(objArea))
                    {
                        MessageBox.Show("El área se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsComun.tabAnterior(tbcArea, tbpBuscar, tbpDetalle);

                        limpiarFormulario();

                        txtNombreBuscar.Focus();

                        dtAreas = ctrArea.seleccionarAreas(objArea);
                        cargarGrilla();
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el área", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    clsComun.tabAnterior(tbcArea, tbpBuscar, tbpDetalle);

                    limpiarFormulario();

                    txtNombreBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcArea, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvAreas.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdArea = Int32.Parse(dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsArea objArea = new clsArea();
                objArea.IdArea = numIdArea;

                objArea = ctrArea.seleccionarArea(objArea);

                mostrarInformacion(objArea, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAreas.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdArea = Int32.Parse(dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsArea objArea = new clsArea();
                objArea.IdArea = numIdArea;

                objArea = ctrArea.seleccionarArea(objArea);

                mostrarInformacion(objArea, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAreas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar esta área?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdArea = Int32.Parse(dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[0].Value.ToString());

                    clsArea objArea = new clsArea();
                    objArea.IdArea = numIdArea;

                    if (ctrArea.eliminarArea(objArea))
                    {
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[3].Value = "INACTIVO";

                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El área se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el área", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvAreas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar esta área?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdArea = Int32.Parse(dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[0].Value.ToString());

                    clsArea objArea = new clsArea();
                    objArea.IdArea = numIdArea;

                    if (ctrArea.recuperarArea(objArea))
                    {
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[3].Value = "ACTIVO";
                        
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El área se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el área", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcArea.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcArea_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsArea objArea = new clsArea();
                objArea.Nombre = txtNombreBuscar.Text;
                objArea.TipoArea = cboTipoBuscar.SelectedItem.ToString();
                objArea.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtAreas = ctrArea.seleccionarAreasCriterios(objArea);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvAreas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAreas.Rows[dgvAreas.CurrentRow.Index].Cells[3].Value.ToString().CompareTo("ACTIVO") == 0)
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
