using System;
using System.Data;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud
{
    public partial class frmPaciente : Form
    {
        private frmPrincipal ventanaPrincipal;
        private DataTable dtPacientes;
        private int numAccion;
        private int numIdPaciente;

        public frmPaciente(frmPrincipal ventanaPrincipal)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventanaPrincipal;
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            cargarComboEtnia();
            cargarComboReligion();
            cargarComboOcupacion();
            cargarComboIdioma();

            cargarCombosTipoDocumento();
            cargarComboPais();
            cargarCombosDepartamento();

            cboTipoDocumentoBuscar.SelectedIndex = 0;

            //clsPaciente objP = new clsPaciente();

            //dtPacientes = ctrPaciente.seleccionarPacientes(objP);

            //cargarGrilla();
        }

        private void cargarComboEtnia()
        {
            clsEtnia objEtnia = new clsEtnia();

            DataTable dt = ctrEtnia.seleccionarEtnias(objEtnia);

            objEtnia.Nombre = "SELECCIONAR";

            cboEtnia.Items.Add(objEtnia);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objEtnia = new clsEtnia();

                objEtnia.IdEtnia = Int32.Parse(dt.Rows[i]["IdEtnia"].ToString());
                objEtnia.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboEtnia.Items.Add(objEtnia);
            }
        }

        private void cargarComboReligion()
        {
            clsReligion objReligion = new clsReligion();

            DataTable dt = ctrReligion.seleccionarReligiones(objReligion);

            objReligion.Nombre = "SELECCIONAR";

            cboReligion.Items.Add(objReligion);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objReligion = new clsReligion();

                objReligion.IdReligion = Int32.Parse(dt.Rows[i]["IdReligion"].ToString());
                objReligion.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboReligion.Items.Add(objReligion);
            }
        }

        private void cargarComboOcupacion()
        {
            clsOcupacion objOcupacion = new clsOcupacion();

            DataTable dt = ctrOcupacion.seleccionarOcupaciones(objOcupacion);

            objOcupacion.Nombre = "SELECCIONAR";

            cboOcupacion.Items.Add(objOcupacion);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objOcupacion = new clsOcupacion();

                objOcupacion.IdOcupacion = Int32.Parse(dt.Rows[i]["IdOcupacion"].ToString());
                objOcupacion.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboOcupacion.Items.Add(objOcupacion);
            }
        }

        private void cargarComboIdioma()
        {
            clsIdioma objIdioma = new clsIdioma();

            DataTable dt = ctrIdioma.seleccionarIdiomas(objIdioma);

            objIdioma.Nombre = "SELECCIONAR";

            cboIdioma.Items.Add(objIdioma);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objIdioma = new clsIdioma();

                objIdioma.IdIdioma = Int32.Parse(dt.Rows[i]["IdIdioma"].ToString());
                objIdioma.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboIdioma.Items.Add(objIdioma);
            }
        }

        private void cargarCombosTipoDocumento()
        {
            clsTipoDocumento objTipoDocumento = new clsTipoDocumento();

            DataTable dt = ctrTipoDocumento.seleccionarTiposDocumento(objTipoDocumento);

            objTipoDocumento.Nombre = "SELECCIONAR";

            cboTipoDocumento.Items.Add(objTipoDocumento);
            cboTipoDocumentoBuscar.Items.Add(objTipoDocumento);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objTipoDocumento = new clsTipoDocumento();

                objTipoDocumento.IdTipoDocumento = Int32.Parse(dt.Rows[i]["IdTipoDocumento"].ToString());
                objTipoDocumento.Nombre = dt.Rows[i]["Nombre"].ToString();
                objTipoDocumento.NumeroDigitos = dt.Rows[i]["NUMERODIGITOS"].ToString();

                cboTipoDocumento.Items.Add(objTipoDocumento);
                cboTipoDocumentoBuscar.Items.Add(objTipoDocumento);
            }
        }

        private void cargarComboPais()
        {
            clsPais objPais = new clsPais();

            DataTable dt = ctrPais.seleccionarPaises(objPais);

            objPais.Nombre = "SELECCIONAR";

            cboPais.Items.Add(objPais);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objPais = new clsPais();

                objPais.IdPais = Int32.Parse(dt.Rows[i]["IdPais"].ToString());
                objPais.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboPais.Items.Add(objPais);
            }
        }

        private void cargarCombosDepartamento()
        {
            clsUbigeo objUbigeo = new clsUbigeo();

            DataTable dt = ctrUbigeo.seleccionarDepartamentos();

            objUbigeo.Descripcion = "SELECCIONAR";

            cboDepartamento.Items.Add(objUbigeo);
            cboDepartamentoDomicilio.Items.Add(objUbigeo);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objUbigeo = new clsUbigeo();

                objUbigeo.IdUbigeo = Int32.Parse(dt.Rows[i]["IdUbigeo"].ToString());
                objUbigeo.CodDepartamento = dt.Rows[i]["CodDepartamento"].ToString();
                objUbigeo.Descripcion = dt.Rows[i]["Descripcion"].ToString();

                cboDepartamento.Items.Add(objUbigeo);
                cboDepartamentoDomicilio.Items.Add(objUbigeo);
            }
        }

        private void cargarComboProvincia(string strCodDepartamento)
        {
            cboProvincia.Items.Clear();

            clsUbigeo objUbigeo = new clsUbigeo();

            DataTable dt = ctrUbigeo.seleccionarProvincias(strCodDepartamento);

            objUbigeo.Descripcion = "SELECCIONAR";

            cboProvincia.Items.Add(objUbigeo);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objUbigeo = new clsUbigeo();

                objUbigeo.IdUbigeo = Int32.Parse(dt.Rows[i]["IdUbigeo"].ToString());
                objUbigeo.CodProvincia = dt.Rows[i]["CodProvincia"].ToString();
                objUbigeo.Descripcion = dt.Rows[i]["Descripcion"].ToString();

                cboProvincia.Items.Add(objUbigeo);
            }
        }

        private void cargarComboDistrito(string strCodDepartamento, string strCodProvincia)
        {
            cboDistrito.Items.Clear();

            clsUbigeo objUbigeo = new clsUbigeo();

            DataTable dt = ctrUbigeo.seleccionarDistritos(strCodDepartamento, strCodProvincia);

            objUbigeo.Descripcion = "SELECCIONAR";

            cboDistrito.Items.Add(objUbigeo);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objUbigeo = new clsUbigeo();

                objUbigeo.IdUbigeo = Int32.Parse(dt.Rows[i]["IdUbigeo"].ToString());
                objUbigeo.CodDistrito = dt.Rows[i]["CodDistrito"].ToString();
                objUbigeo.Descripcion = dt.Rows[i]["Descripcion"].ToString();

                cboDistrito.Items.Add(objUbigeo);
            }
        }

        private void cargarComboProvinciaDomicilio(string strCodDepartamento)
        {
            cboProvinciaDomicilio.Items.Clear();

            clsUbigeo objUbigeo = new clsUbigeo();

            DataTable dt = ctrUbigeo.seleccionarProvincias(strCodDepartamento);

            objUbigeo.Descripcion = "SELECCIONAR";

            cboProvinciaDomicilio.Items.Add(objUbigeo);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objUbigeo = new clsUbigeo();

                objUbigeo.IdUbigeo = Int32.Parse(dt.Rows[i]["IdUbigeo"].ToString());
                objUbigeo.CodProvincia = dt.Rows[i]["CodProvincia"].ToString();
                objUbigeo.Descripcion = dt.Rows[i]["Descripcion"].ToString();

                cboProvinciaDomicilio.Items.Add(objUbigeo);
            }
        }

        private void cargarComboDistritoDomicilio(string strCodDepartamento, string strCodProvincia)
        {
            cboDistritoDomicilio.Items.Clear();

            clsUbigeo objUbigeo = new clsUbigeo();

            DataTable dt = ctrUbigeo.seleccionarDistritos(strCodDepartamento, strCodProvincia);

            objUbigeo.Descripcion = "SELECCIONAR";

            cboDistritoDomicilio.Items.Add(objUbigeo);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objUbigeo = new clsUbigeo();

                objUbigeo.IdUbigeo = Int32.Parse(dt.Rows[i]["IdUbigeo"].ToString());
                objUbigeo.CodDistrito = dt.Rows[i]["CodDistrito"].ToString();
                objUbigeo.Descripcion = dt.Rows[i]["Descripcion"].ToString();

                cboDistritoDomicilio.Items.Add(objUbigeo);
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
                                                     dtPacientes.Rows[i]["NumeroHistoriaClinica"].ToString(), });
                }
            }

            dgvPacientes.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtPaternoBuscar.Clear();
            txtMaternoBuscar.Clear();
            txtNombresBuscar.Clear();
            txtNumeroHistoriaClinicaBuscar.Clear();
            cboTipoDocumentoBuscar.SelectedIndex = 0;
            txtNumeroDocumentoBuscar.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtNombres.Clear();
            cboSexo.SelectedIndex = 0;
            dtpFechaNacimiento.Value = DateTime.Now;
            cboReligion.SelectedIndex = 0;
            cboEtnia.SelectedIndex = 0;
            cboOcupacion.SelectedIndex = 0;
            cboIdioma.SelectedIndex = 0;
            cboEstadoCivil.SelectedIndex = 0;
            cboTipoDocumento.SelectedIndex = 0;
            //txtNumeroDocumento.Clear();
            cboPais.SelectedIndex = 0;
            //cboDepartamento.SelectedIndex = 0;
            //cboProvincia.SelectedIndex = 0;
            //cboDistrito.SelectedIndex = 0;
            cboDepartamentoDomicilio.SelectedIndex = 0;
            //cboProvinciaDomicilio.SelectedIndex = 0;
            //cboDistritoDomicilio.SelectedIndex = 0;
            txtDireccion.Clear();
            //lbxEspecialidades.Items.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreoElectronico.Clear();
            txtNumeroHistoriaClinica.Clear();
        }

        private void mostrarInformacion(clsPaciente objPaciente, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtPaterno.Text = objPaciente.Paterno;
                txtMaterno.Text = objPaciente.Materno;
                txtNombres.Text = objPaciente.Nombres;
                cboSexo.Text = objPaciente.Sexo;
                dtpFechaNacimiento.Value = objPaciente.FechaNacimiento;
                cboReligion.Text = objPaciente._Religion;
                cboEtnia.Text = objPaciente._Etnia;
                cboOcupacion.Text = objPaciente._Ocupacion;
                cboIdioma.Text = objPaciente._Idioma;
                cboEstadoCivil.Text = objPaciente.EstadoCivil;
                cboTipoDocumento.Text = objPaciente._TipoDocumento;
                txtNumeroDocumento.Text = objPaciente.NumeroDocumento;
                cboPais.Text = objPaciente.Pais;
                cboDepartamento.Text = objPaciente.DepartamentoNacimiento;
                cboProvincia.Text = objPaciente.ProvinciaNacimiento;
                cboDistrito.Text = objPaciente.DistritoNacimiento;
                cboDepartamentoDomicilio.Text = objPaciente.DepartamentoDomicilio;
                cboProvinciaDomicilio.Text = objPaciente.ProvinciaDomicilio;
                cboDistritoDomicilio.Text = objPaciente.DistritoDomicilio;
                txtDireccion.Text = objPaciente.Direccion;
                txtTelefono.Text = objPaciente.Telefono;
                txtCelular.Text = objPaciente.Celular;
                txtCorreoElectronico.Text = objPaciente.CorreoElectronico;
                txtNumeroHistoriaClinica.Text = objPaciente.NumeroHistoriaClinica;
            }

            if (numAccion == clsComun.VER)
            {
                txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboSexo.Enabled = false;
                dtpFechaNacimiento.Enabled = false;
                cboReligion.Enabled = false;
                cboEtnia.Enabled = false;
                cboOcupacion.Enabled = false;
                cboIdioma.Enabled = false;
                cboEstadoCivil.Enabled = false;
                cboTipoDocumento.Enabled = false;
                txtNumeroDocumento.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboPais.Enabled = false;
                cboDepartamento.Enabled = false;
                cboProvincia.Enabled = false;
                cboDistrito.Enabled = false;
                cboDepartamentoDomicilio.Enabled = false;
                cboProvinciaDomicilio.Enabled = false;
                cboDistritoDomicilio.Enabled = false;
                txtDireccion.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtTelefono.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtCelular.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtCorreoElectronico.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtNumeroHistoriaClinica.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;

                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboSexo.Enabled = true;
                dtpFechaNacimiento.Enabled = true;
                cboReligion.Enabled = true;
                cboEtnia.Enabled = true;
                cboOcupacion.Enabled = true;
                cboIdioma.Enabled = true;
                cboEstadoCivil.Enabled = true;
                cboTipoDocumento.Enabled = true;
                txtNumeroDocumento.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboPais.Enabled = true;
                //cboDepartamento.Enabled = true;
                //cboProvincia.Enabled = true;
                //cboDistrito.Enabled = true;
                cboDepartamentoDomicilio.Enabled = true;
                //cboProvinciaDomicilio.Enabled = true;
                //cboDistritoDomicilio.Enabled = true;
                txtDireccion.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtTelefono.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtCelular.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtCorreoElectronico.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtNumeroHistoriaClinica.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;

                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.tabSiguiente(tbcPaciente, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNumeroHistoriaClinica.Text.CompareTo("") == 0)
            {
                return true;
            }
            else
            {
                if (ctrPaciente.validarNumeroHistoriaClinica(numIdPaciente, txtNumeroHistoriaClinica.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdPaciente = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtPaterno.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                clsPaciente objPaciente = new clsPaciente();
                objPaciente.IdPaciente = numIdPaciente;
                objPaciente.Paterno = txtPaterno.Text;
                objPaciente.Materno = txtMaterno.Text;
                objPaciente.Nombres = txtNombres.Text;
                objPaciente.Sexo = clsComun.seleccionarToVacio(cboSexo.Text);
                objPaciente.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                objPaciente.IdReligion = ((clsReligion)cboReligion.SelectedItem).IdReligion;
                objPaciente.IdEtnia = ((clsEtnia)cboEtnia.SelectedItem).IdEtnia;
                objPaciente.IdOcupacion = ((clsOcupacion)cboOcupacion.SelectedItem).IdOcupacion;
                objPaciente.IdIdioma = ((clsIdioma)cboIdioma.SelectedItem).IdIdioma;
                objPaciente.EstadoCivil = clsComun.seleccionarToVacio(cboEstadoCivil.Text);
                objPaciente.IdTipoDocumento = ((clsTipoDocumento)cboTipoDocumento.SelectedItem).IdTipoDocumento;
                objPaciente.NumeroDocumento = txtNumeroDocumento.Text;
                objPaciente.Pais = clsComun.seleccionarToVacio(cboPais.Text);
                objPaciente.DepartamentoNacimiento = cboDepartamento.Text;
                objPaciente.ProvinciaNacimiento = cboProvincia.Text;
                objPaciente.DistritoNacimiento = cboDistrito.Text;
                objPaciente.DepartamentoDomicilio = clsComun.seleccionarToVacio(cboDepartamentoDomicilio.Text);
                objPaciente.ProvinciaDomicilio = cboProvinciaDomicilio.Text;
                objPaciente.DistritoDomicilio = cboDistritoDomicilio.Text;
                objPaciente.Direccion = txtDireccion.Text;
                objPaciente.Telefono = txtTelefono.Text;
                objPaciente.Celular = txtCelular.Text;
                objPaciente.CorreoElectronico = txtCorreoElectronico.Text;
                objPaciente.NumeroHistoriaClinica = txtNumeroHistoriaClinica.Text;
                objPaciente.IdEmpleado = ventanaPrincipal.obtenerIdEmpleado();
                
                if (numAccion == clsComun.INSERTAR)
                {
                    if (ctrPaciente.registrarPaciente(objPaciente))
                    {
                        if (MessageBox.Show("El paciente se registró exitosamente\n¿Desea seguir registrando pacientes?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            limpiarFormulario();

                            txtPaterno.Focus();
                        }
                        else
                        {
                            clsComun.tabAnterior(tbcPaciente, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtPaternoBuscar.Focus();

                            dtPacientes = ctrPaciente.seleccionarPacientes(objPaciente);
                            cargarGrilla();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el paciente", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else if (numAccion == clsComun.MODIFICAR)
                {
                    if (ctrPaciente.modificarPaciente(objPaciente))
                    {
                        MessageBox.Show("El paciente se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsComun.tabAnterior(tbcPaciente, tbpBuscar, tbpDetalle);

                        limpiarFormulario();

                        txtPaternoBuscar.Focus();

                        dtPacientes = ctrPaciente.seleccionarPacientes(objPaciente);
                        cargarGrilla();
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el paciente", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    clsComun.tabAnterior(tbcPaciente, tbpBuscar, tbpDetalle);

                    limpiarFormulario();

                    txtPaternoBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcPaciente, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtPaternoBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdPaciente = Int32.Parse(dgvPacientes.Rows[dgvPacientes.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsPaciente objPaciente = new clsPaciente();
                objPaciente.IdPaciente = numIdPaciente;

                objPaciente = ctrPaciente.seleccionarPaciente(objPaciente);

                mostrarInformacion(objPaciente, numAccion);

                txtPaterno.Focus();
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

                limpiarFormulario();

                clsPaciente objPaciente = new clsPaciente();
                objPaciente.IdPaciente = numIdPaciente;

                objPaciente = ctrPaciente.seleccionarPaciente(objPaciente);

                mostrarInformacion(objPaciente, numAccion);

                txtPaterno.Focus();
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

        private void tbcPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcPaciente.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcPaciente_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex > 0)
            {
                txtNumeroDocumento.Clear();
                txtNumeroDocumento.MaxLength = Int32.Parse(((clsTipoDocumento)cboTipoDocumento.SelectedItem).NumeroDigitos);
                txtNumeroDocumento.Enabled = true;
            }
            else
            {
                txtNumeroDocumento.Clear();
                txtNumeroDocumento.Enabled = false;
            }
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPais.SelectedItem.ToString().ToUpper().CompareTo("PERÚ") == 0)
            {
                cboDepartamento.SelectedIndex = 0;
                cboDepartamento.Enabled = true;
            }
            else
            {
                cboDepartamento.SelectedIndex = -1;
                cboDepartamento.Enabled = false;
            }
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedIndex > 0)
            {
                cargarComboProvincia(((clsUbigeo)cboDepartamento.SelectedItem).CodDepartamento);
                cboProvincia.SelectedIndex = 0;
                cboProvincia.Enabled = true;
            }
            else
            {
                cboProvincia.SelectedIndex = -1;
                cboProvincia.Enabled = false;
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedIndex > 0)
            {
                cargarComboDistrito(((clsUbigeo)cboDepartamento.SelectedItem).CodDepartamento, ((clsUbigeo)cboProvincia.SelectedItem).CodProvincia);
                cboDistrito.SelectedIndex = 0;
                cboDistrito.Enabled = true;
            }
            else
            {
                cboDistrito.SelectedIndex = -1;
                cboDistrito.Enabled = false;
            }
        }

        private void cboDepartamentoDomicilio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamentoDomicilio.SelectedIndex > 0)
            {
                cargarComboProvinciaDomicilio(((clsUbigeo)cboDepartamentoDomicilio.SelectedItem).CodDepartamento);
                cboProvinciaDomicilio.SelectedIndex = 0;
                cboProvinciaDomicilio.Enabled = true;
            }
            else
            {
                cboProvinciaDomicilio.SelectedIndex = -1;
                cboProvinciaDomicilio.Enabled = false;
            }
        }

        private void cboProvinciaDomicilio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvinciaDomicilio.SelectedIndex > 0)
            {
                cargarComboDistritoDomicilio(((clsUbigeo)cboDepartamentoDomicilio.SelectedItem).CodDepartamento, ((clsUbigeo)cboProvinciaDomicilio.SelectedItem).CodProvincia);
                cboDistritoDomicilio.SelectedIndex = 0;
                cboDistritoDomicilio.Enabled = true;
            }
            else
            {
                cboDistritoDomicilio.SelectedIndex = -1;
                cboDistritoDomicilio.Enabled = false;
            }
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
