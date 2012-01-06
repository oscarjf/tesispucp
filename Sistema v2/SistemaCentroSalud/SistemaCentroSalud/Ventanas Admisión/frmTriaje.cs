using System;
using System.Data;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud
{
    public partial class frmTriaje : Form
    {
        private frmPrincipal ventanaPrincipal;
        private DataTable dtPacientes;
        private int numAccion;
        private int numIdPaciente;
        private int numIdEmpleado;
        private int numIdHistoriaClinica;
        private string strGrupoSanguineo;
        private string strFactorSanguineo;

        public frmTriaje(frmPrincipal ventanaPrincipal)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventanaPrincipal;
            numIdEmpleado = ventanaPrincipal.getIdEmpleado();
        }

        private void frmTriaje_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            cargarComboTipoDocumento();
            cargarComboModoIngreso();
            cboTipoDocumentoBuscar.SelectedIndex = 0;
            cboModoIngreso.SelectedIndex = 0;
            cboGrupoSanguineo.SelectedIndex = 0;
            cboFactorSanguineo.SelectedIndex = 0;
        }

        private void cargarComboTipoDocumento()
        {
            clsTipoDocumento objTipoDocumento = new clsTipoDocumento();

            DataTable dt = ctrTipoDocumento.seleccionarTiposDocumentosCriterios(objTipoDocumento);

            objTipoDocumento.Nombre = "SELECCIONAR";

            cboTipoDocumentoBuscar.Items.Add(objTipoDocumento);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objTipoDocumento = new clsTipoDocumento();

                objTipoDocumento.IdTipoDocumento = Int32.Parse(dt.Rows[i]["IdTipoDocumento"].ToString());
                objTipoDocumento.Nombre = dt.Rows[i]["Nombre"].ToString();
                objTipoDocumento.NumeroDigitos = dt.Rows[i]["NumeroDigitos"].ToString();

                cboTipoDocumentoBuscar.Items.Add(objTipoDocumento);
            }
        }

        private void cargarComboModoIngreso()
        {
            clsModoIngreso objModoIngreso = new clsModoIngreso();

            DataTable dt = ctrModoIngreso.seleccionarModosIngresoCriterios(objModoIngreso);

            objModoIngreso.Nombre = "SELECCIONAR";

            cboModoIngreso.Items.Add(objModoIngreso);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objModoIngreso = new clsModoIngreso();

                objModoIngreso.IdModoIngreso = Int32.Parse(dt.Rows[i]["IdModoIngreso"].ToString());
                objModoIngreso.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboModoIngreso.Items.Add(objModoIngreso);
            }
        }

        private void cargarGrilla()
        {
            int numIndice = 0;

            dgvPacientes.DataMember = null;

            for (int i = 0; i < dtPacientes.Rows.Count; i++)
            {
                if (numIndice != Int32.Parse(dtPacientes.Rows[i]["IdPersona"].ToString()))
                {
                    numIndice = Int32.Parse(dtPacientes.Rows[i]["IdPersona"].ToString());

                    string strGrupoSanguineo = dtPacientes.Rows[i]["GrupoSanguineo"].ToString();
                    string strFactorSanguineo = dtPacientes.Rows[i]["FactorSanguineo"].ToString();
                    string strIdTipoDocumento = dtPacientes.Rows[i]["IdTipoDocumento"].ToString();
                    string strTipoDocumento = "";
                    

                    if (strIdTipoDocumento.CompareTo("") != 0)
                    {
                        strTipoDocumento = dtPacientes.Rows[i]["TipoDocumento"].ToString();
                    }

                    dgvPacientes.Rows.Add(new String[] { dtPacientes.Rows[i]["IdPersona"].ToString(), 
                                                     dtPacientes.Rows[i]["Paterno"].ToString(),
                                                     dtPacientes.Rows[i]["Materno"].ToString(),
                                                     dtPacientes.Rows[i]["Nombres"].ToString(),
                                                     strTipoDocumento,
                                                     dtPacientes.Rows[i]["NumeroDocumento"].ToString(),
                                                     dtPacientes.Rows[i]["IdHistoriaClinica"].ToString(),
                                                     dtPacientes.Rows[i]["NumeroHistoriaClinica"].ToString(),
                                                     strGrupoSanguineo,
                                                     strFactorSanguineo });
                }
            }

            dgvPacientes.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtTemperatura.Clear();
            txtFrecuenciaCardiaca.Clear();
            txtFrecuenciaRespiratoria.Clear();
            txtPresionArterial.Clear();
            cboGrupoSanguineo.SelectedIndex = 0;
            cboFactorSanguineo.SelectedIndex = 0;
            txtPeso.Clear();
            txtTalla.Clear();
            cboModoIngreso.SelectedIndex = 0;
            rtxtObservaciones.Clear();
            txtIdExamenFisico.Text = "0";
            txtIdEpisodio.Text = "0";
        }

        private bool validarFormulario()
        {
            if (numIdEmpleado != 0 && numIdPaciente != 0 && numIdHistoriaClinica != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void mostrarInformacion(clsTriaje objTriaje, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtTemperatura.Text = objTriaje.Temperatura;
                txtFrecuenciaCardiaca.Text = objTriaje.FrecuenciaCardiaca;
                txtFrecuenciaRespiratoria.Text = objTriaje.FrecuenciaRespiratoria;
                txtPresionArterial.Text = objTriaje.PresionArterial;
                if (strGrupoSanguineo.CompareTo("") != 0)
                {
                    cboGrupoSanguineo.Text = strGrupoSanguineo;
                }
                if (strFactorSanguineo.CompareTo("") != 0)
                {
                    cboFactorSanguineo.Text = strFactorSanguineo;
                }
                txtPeso.Text = objTriaje.Peso;
                txtTalla.Text = objTriaje.Talla;
                int i;
                for (i = 0; i < cboModoIngreso.Items.Count; i++)
                {
                    if (objTriaje.IdModoIngreso == ((clsModoIngreso)cboModoIngreso.Items[i]).IdModoIngreso)
                    {
                        cboModoIngreso.SelectedIndex = i;
                        break;
                    }
                }
                rtxtObservaciones.Text = objTriaje.Observaciones;
                txtIdExamenFisico.Text = objTriaje.IdExamenFisico.ToString();
                txtIdEpisodio.Text = objTriaje.IdEpisodio.ToString();
            }
            else
            {
                if (strGrupoSanguineo.CompareTo("") != 0)
                {
                    cboGrupoSanguineo.Text = strGrupoSanguineo;
                }
                if (strFactorSanguineo.CompareTo("") != 0)
                {
                    cboFactorSanguineo.Text = strFactorSanguineo;
                }
            }

            if (numAccion == clsComun.VER)
            {
                txtTemperatura.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtFrecuenciaCardiaca.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtFrecuenciaRespiratoria.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtPresionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboGrupoSanguineo.Enabled = false;
                cboFactorSanguineo.Enabled = false;
                txtPeso.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtTalla.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboModoIngreso.Enabled = false;
                rtxtObservaciones.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;

                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtTemperatura.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtFrecuenciaCardiaca.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtFrecuenciaRespiratoria.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtPresionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboGrupoSanguineo.Enabled = true;
                cboFactorSanguineo.Enabled = true;
                txtPeso.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtTalla.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboModoIngreso.Enabled = true;
                rtxtObservaciones.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;

                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.tabSiguiente(tbcTriaje, tbpBuscar, tbpDetalle);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                numAccion = clsComun.INSERTAR;

                numIdPaciente = Int32.Parse(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString());
                numIdHistoriaClinica = Int32.Parse(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[6].Value.ToString());
                strGrupoSanguineo = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[8].Value.ToString();
                strFactorSanguineo = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[9].Value.ToString();

                limpiarFormulario();

                mostrarInformacion(null, numAccion);

                txtTemperatura.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdPaciente = Int32.Parse(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString());
                numIdHistoriaClinica = Int32.Parse(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[6].Value.ToString());
                strGrupoSanguineo = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[8].Value.ToString();
                strFactorSanguineo = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[9].Value.ToString();

                limpiarFormulario();

                clsTriaje objTriaje = new clsTriaje();
                objTriaje.IdEmpleado = numIdEmpleado;
                objTriaje.IdPaciente = numIdPaciente;
                objTriaje.IdHistoriaClinica = numIdHistoriaClinica;

                objTriaje = ctrTriaje.seleccionarTriaje(objTriaje);

                if (objTriaje != null)
                {
                    mostrarInformacion(objTriaje, numAccion);
                    txtTemperatura.Focus();
                }
                else
                {
                    MessageBox.Show("El paciente no ha pasado por triaje el día de hoy", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdPaciente = Int32.Parse(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString());
                numIdHistoriaClinica = Int32.Parse(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[6].Value.ToString());
                strGrupoSanguineo = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[8].Value.ToString();
                strFactorSanguineo = dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[9].Value.ToString();

                limpiarFormulario();

                clsTriaje objTriaje = new clsTriaje();
                objTriaje.IdEmpleado = numIdEmpleado;
                objTriaje.IdPaciente = numIdPaciente;
                objTriaje.IdHistoriaClinica = numIdHistoriaClinica;

                objTriaje = ctrTriaje.seleccionarTriaje(objTriaje);

                if (objTriaje != null)
                {
                    mostrarInformacion(objTriaje, numAccion);
                    txtTemperatura.Focus();
                }
                else
                {
                    MessageBox.Show("El paciente no ha pasado por triaje el día de hoy", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.tabAnterior(tbcTriaje, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                txtPaternoBuscar.Focus();
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;

                if (validarFormulario())
                {
                    clsTriaje objTriaje = new clsTriaje();
                    objTriaje.IdEmpleado = numIdEmpleado;
                    objTriaje.IdPaciente = numIdPaciente;
                    objTriaje.IdHistoriaClinica = numIdHistoriaClinica;
                    objTriaje.GrupoSanguineo = cboGrupoSanguineo.Text;
                    objTriaje.FactorSanguineo = cboFactorSanguineo.Text;
                    objTriaje.IdModoIngreso = ((clsModoIngreso)cboModoIngreso.SelectedItem).IdModoIngreso;
                    objTriaje.Temperatura = txtTemperatura.Text;
                    objTriaje.FrecuenciaCardiaca = txtFrecuenciaCardiaca.Text;
                    objTriaje.FrecuenciaRespiratoria = txtFrecuenciaRespiratoria.Text;
                    objTriaje.PresionArterial = txtPresionArterial.Text;
                    objTriaje.Peso = txtPeso.Text;
                    objTriaje.Talla = txtTalla.Text;
                    objTriaje.Observaciones = rtxtObservaciones.Text;
                    objTriaje.IdExamenFisico = Int32.Parse(txtIdExamenFisico.Text);
                    objTriaje.IdEpisodio = Int32.Parse(txtIdEpisodio.Text);

                    if (numAccion == clsComun.INSERTAR)
                    {
                        if (ctrTriaje.registrarTriaje(objTriaje))
                        {
                            MessageBox.Show("El triaje se registró exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.tabAnterior(tbcTriaje, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtPaternoBuscar.Focus();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el triaje", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        if (ctrTriaje.modificarTriaje(objTriaje))
                        {
                            MessageBox.Show("El triaje se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.tabAnterior(tbcTriaje, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtPaternoBuscar.Focus();

                            //dtPacientes = ctrPaciente.seleccionarPacientes(objPaciente);
                            //cargarGrilla();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el triaje", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrió un error mientras se intentaba registrar el triaje\nVuelva a ingresar al sistema e inténtelo nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcTriaje, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtPaternoBuscar.Focus();
        }

        private void cboTipoDocumentoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboTipoDocumentoBuscar.SelectedIndex > 0)
                {
                    txtNumeroDocumentoBuscar.Clear();
                    txtNumeroDocumentoBuscar.MaxLength = Int32.Parse(((clsTipoDocumento)cboTipoDocumentoBuscar.SelectedItem).NumeroDigitos);
                    txtNumeroDocumentoBuscar.Enabled = true;
                }
                else
                {
                    txtNumeroDocumentoBuscar.Clear();
                    txtNumeroDocumentoBuscar.Enabled = false;
                }

                buscarCriterios(sender, e);
            }
            catch
            {
            }
        }

        private void tbcTriaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcTriaje.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcTriaje_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsPaciente objPaciente = new clsPaciente();
                objPaciente.Paterno = txtPaternoBuscar.Text;
                objPaciente.Materno = txtMaternoBuscar.Text;
                objPaciente.Nombres = txtNombresBuscar.Text;
                objPaciente.NumeroHistoriaClinica = txtNumeroHistoriaClinicaBuscar.Text;
                objPaciente.IdTipoDocumento = ((clsTipoDocumento)cboTipoDocumentoBuscar.SelectedItem).IdTipoDocumento;
                objPaciente.NumeroDocumento = txtNumeroDocumentoBuscar.Text;

                dtPacientes = ctrPaciente.seleccionarPacientesCriterios(objPaciente);
                cargarGrilla();
            }
            catch
            {
            }
        }
    }
}
