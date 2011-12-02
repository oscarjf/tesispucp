using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmConsultorio : Form
    {
        private DataTable dtConsultorios;
        private int numAccion;
        private int numIdConsultorio;

        public frmConsultorio()
        {
            InitializeComponent();
        }

        private void frmConsultorio_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            cargarCombosPabellon();

            cboPabellonBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarCombosPabellon()
        {
            clsPabellon objPabellon = new clsPabellon();
            
            DataTable dt = ctrPabellon.seleccionarPabellonesCriterios(objPabellon);

            objPabellon.Nombre = "TODOS";

            cboPabellonBuscar.Items.Add(objPabellon);
            cboPabellonDetalle.Items.Add(objPabellon);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objPabellon = new clsPabellon();

                objPabellon.IdPabellon = Int32.Parse(dt.Rows[i]["IdPabellon"].ToString());
                objPabellon.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboPabellonBuscar.Items.Add(objPabellon);
                cboPabellonDetalle.Items.Add(objPabellon);
            }
        }

        private void cargarGrilla()
        {
            dgvConsultorios.DataMember = null;

            for (int i = 0; i < dtConsultorios.Rows.Count; i++)
            {
                dgvConsultorios.Rows.Add(new String[] { dtConsultorios.Rows[i]["IdConsultorio"].ToString(), 
                                                 dtConsultorios.Rows[i]["Pabellon"].ToString(),
                                                 dtConsultorios.Rows[i]["Piso"].ToString(),
                                                 dtConsultorios.Rows[i]["Numero"].ToString(), 
                                                 dtConsultorios.Rows[i]["Estado"].ToString() });

                if (dtConsultorios.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvConsultorios.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvConsultorios.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvConsultorios.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvConsultorios.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvConsultorios.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvConsultorios.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dgvConsultorios.Rows[i].Cells[4].Style.ForeColor = Color.White;
                    dgvConsultorios.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
            }

            dgvConsultorios.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtPisoBuscar.Clear();
            txtNumeroBuscar.Clear();
            cboPabellonBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;
            txtPisoDetalle.Clear();
            txtNumeroDetalle.Clear();
            cboPabellonDetalle.SelectedIndex = 0;
        }

        private void mostrarInformacion(clsConsultorio objConsultorio, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtPisoDetalle.Text = objConsultorio.Piso;
                txtNumeroDetalle.Text = objConsultorio.Numero;

                int i;
                for (i = 0; i < cboPabellonDetalle.Items.Count; i++)
                {
                    if (objConsultorio.IdPabellon == ((clsPabellon)cboPabellonDetalle.Items[i]).IdPabellon)
                    {
                        break;
                    }
                }
                cboPabellonDetalle.SelectedIndex = i;
            }

            if (numAccion == clsComun.VER)
            {
                txtPisoDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtNumeroDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboPabellonDetalle.Enabled = false;
                
                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtPisoDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtNumeroDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboPabellonDetalle.Enabled = true;
                
                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.tabSiguiente(tbcConsultorio, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (cboPabellonDetalle.SelectedIndex != 0)
            {
                if (txtPisoDetalle.Text.CompareTo("") != 0)
                {
                    if (txtNumeroDetalle.Text.CompareTo("") != 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar el número de consultorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNumeroDetalle.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el número de piso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPisoDetalle.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el pabellón", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPabellonDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdConsultorio = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            cboPabellonDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.tabAnterior(tbcConsultorio, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                cboPabellonBuscar.Focus();
            }
            else
            {
                if (validarFormulario())
                {
                    clsConsultorio objConsultorio = new clsConsultorio();
                    objConsultorio.IdConsultorio = numIdConsultorio;
                    objConsultorio.Piso = txtPisoDetalle.Text;
                    objConsultorio.Numero = txtNumeroDetalle.Text;
                    objConsultorio.IdPabellon = ((clsPabellon)cboPabellonDetalle.SelectedItem).IdPabellon;

                    if (numAccion == clsComun.INSERTAR)
                    {
                        if (ctrConsultorio.registrarConsultorio(objConsultorio))
                        {
                            if (MessageBox.Show("El consultorio se registró exitosamente\n¿Desea seguir registrando consultorios?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                limpiarFormulario();

                                cboPabellonDetalle.Focus();
                            }
                            else
                            {
                                clsComun.tabAnterior(tbcConsultorio, tbpBuscar, tbpDetalle);

                                limpiarFormulario();

                                cboPabellonBuscar.Focus();

                                dtConsultorios = ctrConsultorio.seleccionarConsultorios(objConsultorio);
                                cargarGrilla();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el consultorio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        if (ctrConsultorio.modificarConsultorio(objConsultorio))
                        {
                            MessageBox.Show("El consultorio se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.tabAnterior(tbcConsultorio, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            cboPabellonBuscar.Focus();

                            dtConsultorios = ctrConsultorio.seleccionarConsultorios(objConsultorio);
                            cargarGrilla();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el consultorio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
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
            clsComun.tabAnterior(tbcConsultorio, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            cboPabellonBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvConsultorios.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdConsultorio = Int32.Parse(dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsConsultorio objConsultorio = new clsConsultorio();
                objConsultorio.IdConsultorio = numIdConsultorio;

                objConsultorio = ctrConsultorio.seleccionarConsultorio(objConsultorio);

                mostrarInformacion(objConsultorio, numAccion);

                cboPabellonDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un consultorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvConsultorios.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdConsultorio = Int32.Parse(dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsConsultorio objConsultorio = new clsConsultorio();
                objConsultorio.IdConsultorio = numIdConsultorio;


                objConsultorio = ctrConsultorio.seleccionarConsultorio(objConsultorio);

                mostrarInformacion(objConsultorio, numAccion);

                cboPabellonDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un consultorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvConsultorios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este consultorio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdConsultorio = Int32.Parse(dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[0].Value.ToString());

                    clsConsultorio objConsultorio = new clsConsultorio();
                    objConsultorio.IdConsultorio = numIdConsultorio;

                    if (ctrConsultorio.eliminarConsultorio(objConsultorio))
                    {
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[4].Value = "INACTIVO";

                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[4].Style.ForeColor = Color.White;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[4].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El consultorio se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el consultorio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un consultorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvConsultorios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este consultorio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdConsultorio = Int32.Parse(dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[0].Value.ToString());

                    clsConsultorio objConsultorio = new clsConsultorio();
                    objConsultorio.IdConsultorio = numIdConsultorio;

                    if (ctrConsultorio.recuperarConsultorio(objConsultorio))
                    {
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[4].Value = "ACTIVO";

                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[4].Style.ForeColor = Color.Black;
                        dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[4].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El consultorio se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el consultorio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un consultorio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcConsultorio.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcConsultorio_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsConsultorio objConsultorio = new clsConsultorio();
                objConsultorio.IdPabellon = ((clsPabellon)cboPabellonBuscar.SelectedItem).IdPabellon;
                objConsultorio.Piso = txtPisoBuscar.Text;
                objConsultorio.Numero = txtNumeroBuscar.Text;
                objConsultorio.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtConsultorios = ctrConsultorio.seleccionarConsultoriosCriterios(objConsultorio);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvConsultorios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvConsultorios.Rows[dgvConsultorios.CurrentRow.Index].Cells[4].Value.ToString().CompareTo("ACTIVO") == 0)
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
