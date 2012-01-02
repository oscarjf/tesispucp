using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud
{
    public partial class frmEspecialidad : Form
    {
        private DataTable dtEspecialidades;
        private int numAccion;
        private int numIdEspecialidad;

        public frmEspecialidad()
        {
            InitializeComponent();

            clsEspecialidad objEspecialidad = new clsEspecialidad();
            objEspecialidad.IdArea = 0;
            objEspecialidad.Estado = "TODOS";

            dtEspecialidades = ctrEspecialidad.seleccionarEspecialidadesCriterios(objEspecialidad);

            cargarGrilla();
        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            cargarCombosArea();

            cboAreaBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;

            dgvEspecialidades.Refresh();
        }

        private void cargarCombosArea()
        {
            clsArea objArea = new clsArea();
            objArea.TipoArea = "MÉDICA";

            DataTable dt = ctrArea.seleccionarAreasCriterios(objArea);

            objArea.Nombre = "TODAS";

            cboAreaBuscar.Items.Add(objArea);
            cboAreaDetalle.Items.Add(objArea);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objArea = new clsArea();

                objArea.IdArea = Int32.Parse(dt.Rows[i]["IdArea"].ToString());
                objArea.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboAreaBuscar.Items.Add(objArea);
                cboAreaDetalle.Items.Add(objArea);
            }
        }

        private void cargarGrilla()
        {
            dgvEspecialidades.DataMember = null;

            for (int i = 0; i < dtEspecialidades.Rows.Count; i++)
            {
                dgvEspecialidades.Rows.Add(new String[] { dtEspecialidades.Rows[i]["IdEspecialidad"].ToString(), 
                                                 dtEspecialidades.Rows[i]["Nombre"].ToString(),
                                                 dtEspecialidades.Rows[i]["Area"].ToString(), 
                                                 dtEspecialidades.Rows[i]["Estado"].ToString() });

                if (dtEspecialidades.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvEspecialidades.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvEspecialidades.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvEspecialidades.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvEspecialidades.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvEspecialidades.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvEspecialidades.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }

            dgvEspecialidades.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtNombreBuscar.Clear();
            cboAreaBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;
            txtNombreDetalle.Clear();
            cboAreaDetalle.SelectedIndex = 0;
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarInformacion(clsEspecialidad objEspecialidad, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objEspecialidad.Nombre;

                int i;
                for (i = 0; i < cboAreaDetalle.Items.Count; i++)
                {
                    if (objEspecialidad.IdArea == ((clsArea)cboAreaDetalle.Items[i]).IdArea)
                    {
                        break;
                    }
                }
                cboAreaDetalle.SelectedIndex = i;
                rtxtDescripcionDetalle.Text = objEspecialidad.Descripcion;
            }

            if (numAccion == clsComun.VER)
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboAreaDetalle.Enabled = false;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;

                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboAreaDetalle.Enabled = true;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;

                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.tabSiguiente(tbcEspecialidad, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                if (cboAreaDetalle.SelectedIndex != 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboAreaDetalle.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de la especialidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdEspecialidad = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.tabAnterior(tbcEspecialidad, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                txtNombreBuscar.Focus();
            }
            else
            {
                if (validarFormulario())
                {
                    clsEspecialidad objEspecialidad = new clsEspecialidad();
                    objEspecialidad.IdEspecialidad = numIdEspecialidad;
                    objEspecialidad.Nombre = txtNombreDetalle.Text;
                    objEspecialidad.Descripcion = rtxtDescripcionDetalle.Text;
                    objEspecialidad.IdArea = ((clsArea)cboAreaDetalle.SelectedItem).IdArea;

                    if (numAccion == clsComun.INSERTAR)
                    {
                        if (ctrEspecialidad.registrarEspecialidad(objEspecialidad))
                        {
                            if (MessageBox.Show("La especialidad se registró exitosamente\n¿Desea seguir registrando especialidades?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                limpiarFormulario();

                                txtNombreDetalle.Focus();
                            }
                            else
                            {
                                clsComun.tabAnterior(tbcEspecialidad, tbpBuscar, tbpDetalle);

                                limpiarFormulario();

                                txtNombreBuscar.Focus();

                                dtEspecialidades = ctrEspecialidad.seleccionarEspecialidades(objEspecialidad);
                                cargarGrilla();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar la especialidad", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        if (ctrEspecialidad.modificarEspecialidad(objEspecialidad))
                        {
                            MessageBox.Show("La especialidad se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.tabAnterior(tbcEspecialidad, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtEspecialidades = ctrEspecialidad.seleccionarEspecialidades(objEspecialidad);
                            cargarGrilla();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar la especialidad", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
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
            clsComun.tabAnterior(tbcEspecialidad, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdEspecialidad = Int32.Parse(dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsEspecialidad objEspecialidad = new clsEspecialidad();
                objEspecialidad.IdEspecialidad = numIdEspecialidad;

                objEspecialidad = ctrEspecialidad.seleccionarEspecialidad(objEspecialidad);

                mostrarInformacion(objEspecialidad, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una especialidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdEspecialidad = Int32.Parse(dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsEspecialidad objEspecialidad = new clsEspecialidad();
                objEspecialidad.IdEspecialidad = numIdEspecialidad;

                objEspecialidad = ctrEspecialidad.seleccionarEspecialidad(objEspecialidad);

                mostrarInformacion(objEspecialidad, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una especialidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar esta especialidad?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdEspecialidad = Int32.Parse(dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[0].Value.ToString());

                    clsEspecialidad objEspecialidad = new clsEspecialidad();
                    objEspecialidad.IdEspecialidad = numIdEspecialidad;

                    if (ctrEspecialidad.eliminarEspecialidad(objEspecialidad))
                    {
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[3].Value = "INACTIVO";

                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("La especialidad se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar la especialidad", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una especialidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar esta especialidad?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdEspecialidad = Int32.Parse(dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[0].Value.ToString());

                    clsEspecialidad objEspecialidad = new clsEspecialidad();
                    objEspecialidad.IdEspecialidad = numIdEspecialidad;

                    if (ctrEspecialidad.recuperarEspecialidad(objEspecialidad))
                    {
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[3].Value = "ACTIVO";

                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("La especialidad se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar la especialidad", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una especialidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcEspecialidad.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcEspecialidad_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsEspecialidad objEspecialidad = new clsEspecialidad();
                objEspecialidad.Nombre = txtNombreBuscar.Text;
                objEspecialidad.IdArea = ((clsArea)cboAreaBuscar.SelectedItem).IdArea;
                objEspecialidad.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtEspecialidades = ctrEspecialidad.seleccionarEspecialidadesCriterios(objEspecialidad);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvEspecialidades_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEspecialidades.Rows[dgvEspecialidades.CurrentRow.Index].Cells[3].Value.ToString().CompareTo("ACTIVO") == 0)
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
