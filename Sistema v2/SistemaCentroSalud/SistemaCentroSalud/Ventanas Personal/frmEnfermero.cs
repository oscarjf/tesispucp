using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Personal
{
    public partial class frmEnfermero : Form
    {
        private DataTable dtEnfermeros;
        private int numAccion;
        private int numIdEnfermero;
        private string strRutaFoto = "";
        private bool blnCambioFoto = false;

        private string strUsuario;
        private string strContrasena;

        public frmEnfermero()
        {
            InitializeComponent();

            clsEnfermero objEnfermero = new clsEnfermero();
            objEnfermero.IdArea = 0;
            objEnfermero.Estado = "TODOS";

            dtEnfermeros = ctrEnfermero.seleccionarEnfermerosCriterios(objEnfermero);

            cargarGrilla();
        }

        private void frmEnfermero_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            cargarComboTipoDocumento();
            cargarComboPais();
            cargarCombosDepartamento();
            cargarCombosArea();
            cargarComboPerfil();

            cboAreaBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;

            dgvEnfermeros.Refresh();
        }

        private void cargarComboTipoDocumento()
        {
            clsTipoDocumento objTipoDocumento = new clsTipoDocumento();

            DataTable dt = ctrTipoDocumento.seleccionarTiposDocumento(objTipoDocumento);

            objTipoDocumento.Nombre = "SELECCIONAR";

            cboTipoDocumento.Items.Add(objTipoDocumento);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objTipoDocumento = new clsTipoDocumento();

                objTipoDocumento.IdTipoDocumento = Int32.Parse(dt.Rows[i]["IdTipoDocumento"].ToString());
                objTipoDocumento.Nombre = dt.Rows[i]["Nombre"].ToString();
                objTipoDocumento.NumeroDigitos = dt.Rows[i]["NumeroDigitos"].ToString();

                cboTipoDocumento.Items.Add(objTipoDocumento);
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

        private void cargarCombosArea()
        {
            clsArea objArea = new clsArea();
            objArea.TipoArea = "MÉDICA";

            DataTable dt = ctrArea.seleccionarAreasCriterios(objArea);

            objArea.Nombre = "SELECCIONAR";

            cboArea.Items.Add(objArea);

            objArea = new clsArea();
            objArea.Nombre = "TODAS";

            cboAreaBuscar.Items.Add(objArea);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objArea = new clsArea();

                objArea.IdArea = Int32.Parse(dt.Rows[i]["IdArea"].ToString());
                objArea.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboArea.Items.Add(objArea);
                cboAreaBuscar.Items.Add(objArea);
            }
        }

        private void cargarComboPerfil()
        {
            clsPerfil objPerfil = new clsPerfil();
            objPerfil.TipoEmpleado = "ENFERMERO";

            DataTable dt = ctrPerfil.seleccionarPerfilesCriterios(objPerfil);

            objPerfil.Nombre = "SELECCIONAR";

            cboPerfil.Items.Add(objPerfil);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objPerfil = new clsPerfil();

                objPerfil.IdPerfil = Int32.Parse(dt.Rows[i]["IdPerfil"].ToString());
                objPerfil.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboPerfil.Items.Add(objPerfil);
            }
        }

        private void cargarGrilla()
        {
            dgvEnfermeros.DataMember = null;

            for (int i = 0; i < dtEnfermeros.Rows.Count; i++)
            {
                dgvEnfermeros.Rows.Add(new String[] { dtEnfermeros.Rows[i]["IdPersona"].ToString(), 
                                                 dtEnfermeros.Rows[i]["Paterno"].ToString(),
                                                 dtEnfermeros.Rows[i]["Materno"].ToString(),
                                                 dtEnfermeros.Rows[i]["Nombres"].ToString(),
                                                 dtEnfermeros.Rows[i]["NumeroLicencia"].ToString(),
                                                 dtEnfermeros.Rows[i]["Estado"].ToString() });

                if (dtEnfermeros.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvEnfermeros.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvEnfermeros.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvEnfermeros.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvEnfermeros.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvEnfermeros.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvEnfermeros.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dgvEnfermeros.Rows[i].Cells[4].Style.ForeColor = Color.White;
                    dgvEnfermeros.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    dgvEnfermeros.Rows[i].Cells[5].Style.ForeColor = Color.White;
                    dgvEnfermeros.Rows[i].Cells[5].Style.BackColor = Color.Red;
                }
            }

            dgvEnfermeros.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtPaternoBuscar.Clear();
            txtMaternoBuscar.Clear();
            txtNombresBuscar.Clear();
            txtNumeroLicenciaBuscar.Clear();
            cboAreaBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtNombres.Clear();
            cboSexo.SelectedIndex = 0;
            cboEstadoCivil.SelectedIndex = 0;
            dtpFechaNacimiento.Value = DateTime.Now;
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
            txtNumeroLicencia.Clear();
            cboArea.SelectedIndex = 0;
            cboPerfil.SelectedIndex = 0;
            //lbxEspecialidades.Items.Clear();
            pbxFoto.Image = Properties.Resources.FotoPredeterminado;
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreoElectronico.Clear();
            strRutaFoto = "";
            blnCambioFoto = false;
        }

        private void mostrarInformacion(clsEnfermero objEnfermero, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtPaterno.Text = objEnfermero.Paterno;
                txtMaterno.Text = objEnfermero.Materno;
                txtNombres.Text = objEnfermero.Nombres;
                cboSexo.Text = objEnfermero.Sexo;
                cboEstadoCivil.Text = objEnfermero.EstadoCivil;
                dtpFechaNacimiento.Value = objEnfermero.FechaNacimiento;
                cboTipoDocumento.Text = objEnfermero._TipoDocumento;
                txtNumeroDocumento.Text = objEnfermero.NumeroDocumento;
                cboPais.Text = objEnfermero.Pais;
                cboDepartamento.Text = objEnfermero.DepartamentoNacimiento;
                cboProvincia.Text = objEnfermero.ProvinciaNacimiento;
                cboDistrito.Text = objEnfermero.DistritoNacimiento;
                cboDepartamentoDomicilio.Text = objEnfermero.DepartamentoDomicilio;
                cboProvinciaDomicilio.Text = objEnfermero.ProvinciaDomicilio;
                cboDistritoDomicilio.Text = objEnfermero.DistritoDomicilio;
                txtDireccion.Text = objEnfermero.Direccion;
                txtNumeroLicencia.Text = objEnfermero.NumeroLicencia;
                cboArea.Text = objEnfermero._Area;
                cboPerfil.Text = objEnfermero._Perfil;
                txtTelefono.Text = objEnfermero.Telefono;
                txtCelular.Text = objEnfermero.Celular;
                txtCorreoElectronico.Text = objEnfermero.CorreoElectronico;

                try
                {
                    if (objEnfermero.Foto.CompareTo("") != 0)
                    {
                        pbxFoto.Image = Image.FromFile(objEnfermero.Foto);
                        strRutaFoto = objEnfermero.Foto;
                    }
                    else
                    {
                        pbxFoto.Image = Properties.Resources.NoFoto;
                    }
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }

            if (numAccion == clsComun.VER)
            {
                txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboSexo.Enabled = false;
                cboEstadoCivil.Enabled = false;
                dtpFechaNacimiento.Enabled = false;
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
                txtNumeroLicencia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboArea.Enabled = false;
                btnTomarFoto.Visible = false;
                btnBuscarFoto.Visible = false;
                btnQuitarFoto.Visible = false;
                cboPerfil.Enabled = false;
                txtTelefono.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtCelular.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtCorreoElectronico.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;

                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboSexo.Enabled = true;
                cboEstadoCivil.Enabled = true;
                dtpFechaNacimiento.Enabled = true;
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
                txtNumeroLicencia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboArea.Enabled = true;
                btnTomarFoto.Visible = true;
                btnBuscarFoto.Visible = true;
                btnQuitarFoto.Visible = true;
                cboPerfil.Enabled = true;
                txtTelefono.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtCelular.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtCorreoElectronico.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;

                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.redimensionarTabControl(tbcEnfermero, 788, 492);
            clsComun.redimensionarVentana(this, 794, 519);
            clsComun.tabSiguiente(tbcEnfermero, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtPaterno.Text.CompareTo("") != 0)
            {
                if (txtMaterno.Text.CompareTo("") != 0)
                {
                    if (txtNombres.Text.CompareTo("") != 0)
                    {
                        if (cboTipoDocumento.SelectedIndex > 0)
                        {
                            if (txtNumeroDocumento.Text.Length == 0 || txtNumeroDocumento.Text.Length == Int32.Parse(((clsTipoDocumento)cboTipoDocumento.SelectedItem).NumeroDigitos))
                            {
                                if (txtNumeroLicencia.Text.CompareTo("") != 0)
                                {
                                    if (txtNumeroLicencia.Text.Length == 7)
                                    {
                                        if (ctrEnfermero.validarNumeroLicencia(numIdEnfermero, txtNumeroLicencia.Text))
                                        {
                                            if (cboArea.SelectedIndex != 0)
                                            {
                                                if (cboPerfil.SelectedIndex != 0)
                                                {
                                                    if (txtCorreoElectronico.Text.CompareTo("") != 0)
                                                    {
                                                        if (clsComun.validarCorreoElectronico(txtCorreoElectronico.Text))
                                                        {
                                                            if (ctrEmpleado.validarCorreoElectronico(numIdEnfermero, txtCorreoElectronico.Text))
                                                            {
                                                                return true;
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("El correo electrónico ya ha sido registrado\nVerifique el correo electrónico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                txtCorreoElectronico.Focus();
                                                                return false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Formato de correo electrónico incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                            txtCorreoElectronico.Focus();
                                                            return false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Debe ingresar el correo electrónico del enfermero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                        txtCorreoElectronico.Focus();
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe seleccionar el perfil de acceso del enfermero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    cboPerfil.Focus();
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Debe seleccionar un área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                cboArea.Focus();
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El número de licencia ingresado ya existe. Verifique el código del enfermero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            txtNumeroLicencia.Focus();
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El número de licencia debe tener 7 dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        txtNumeroLicencia.Focus();
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe ingresar el número de licencia del enfermero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtNumeroLicencia.Focus();
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El documento debe tener " + Int32.Parse(((clsTipoDocumento)cboTipoDocumento.SelectedItem).NumeroDigitos) + " dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtNumeroDocumento.Focus();
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar un tipo de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cboTipoDocumento.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar el nombre del enfermero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombres.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el apellido materno del enfermero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaterno.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el apellido paterno del enfermero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPaterno.Focus();
                return false;
            }
        }

        private void enviarCorreo(string strDestinatario, string strPaterno, string strMaterno, string strNombres, string strUsuario, string strContrasena)
        {
            if (!clsComun.enviarCorreo(strDestinatario, strPaterno, strMaterno, strNombres, strUsuario, strContrasena))
            {
                if (MessageBox.Show("Ocurrió un error mientras se intentaban enviar los datos de cuenta al correo electrónico del empleado administrativo", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                {
                    enviarCorreo(strDestinatario, strPaterno, strMaterno, strNombres, strUsuario, strContrasena);
                }
            }
        }

        private void guardarFoto()
        {
            try
            {
                pbxFoto.Image.Save(strRutaFoto);
            }
            catch
            {
                if (MessageBox.Show("Ocurrió un error mientras se intentaba guardar la foto", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) != DialogResult.Cancel)
                {
                    guardarFoto();
                }
                else
                {
                    strRutaFoto = "";
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdEnfermero = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtPaterno.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.redimensionarTabControl(tbcEnfermero, 579, 417);
                clsComun.redimensionarVentana(this, 583, 443);
                clsComun.tabAnterior(tbcEnfermero, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                txtPaternoBuscar.Focus();
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;

                if (validarFormulario())
                {
                    clsEnfermero objEnfermero = new clsEnfermero();
                    objEnfermero.IdEnfermero = numIdEnfermero;
                    objEnfermero.Paterno = txtPaterno.Text;
                    objEnfermero.Materno = txtMaterno.Text;
                    objEnfermero.Nombres = txtNombres.Text;
                    objEnfermero.Sexo = clsComun.seleccionarToVacio(cboSexo.Text);
                    objEnfermero.EstadoCivil = clsComun.seleccionarToVacio(cboEstadoCivil.Text);
                    objEnfermero.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                    objEnfermero.IdTipoDocumento = ((clsTipoDocumento)cboTipoDocumento.SelectedItem).IdTipoDocumento;
                    objEnfermero.NumeroDocumento = txtNumeroDocumento.Text;
                    objEnfermero.Pais = clsComun.seleccionarToVacio(cboPais.Text);
                    objEnfermero.DepartamentoNacimiento = cboDepartamento.Text;
                    objEnfermero.ProvinciaNacimiento = cboProvincia.Text;
                    objEnfermero.DistritoNacimiento = cboDistrito.Text;
                    objEnfermero.DepartamentoDomicilio = clsComun.seleccionarToVacio(cboDepartamentoDomicilio.Text);
                    objEnfermero.ProvinciaDomicilio = cboProvinciaDomicilio.Text;
                    objEnfermero.DistritoDomicilio = cboDistritoDomicilio.Text;
                    objEnfermero.Direccion = txtDireccion.Text;
                    objEnfermero.NumeroLicencia = txtNumeroLicencia.Text;
                    objEnfermero.IdArea = ((clsArea)cboArea.SelectedItem).IdArea;
                    objEnfermero.Foto = strRutaFoto;
                    objEnfermero.IdPerfil = ((clsPerfil)cboPerfil.SelectedItem).IdPerfil;
                    objEnfermero.Telefono = txtTelefono.Text;
                    objEnfermero.Celular = txtCelular.Text;
                    objEnfermero.CorreoElectronico = txtCorreoElectronico.Text;
                    
                    if (blnCambioFoto)
                    {
                        guardarFoto();
                    }

                    objEnfermero.Foto = strRutaFoto;

                    if (numAccion == clsComun.INSERTAR)
                    {
                        objEnfermero.Usuario = ctrEmpleado.generarNombreUsuario(numIdEnfermero, txtPaterno.Text, txtMaterno.Text, txtNombres.Text);
                        objEnfermero.Contrasena = clsSeguridad.generarContrasenaAleatoria(8);

                        if (ctrEnfermero.registrarEnfermero(objEnfermero))
                        {
                            enviarCorreo(txtCorreoElectronico.Text, objEnfermero.Paterno, objEnfermero.Materno, objEnfermero.Nombres, objEnfermero.Usuario, objEnfermero.Contrasena);

                            if (MessageBox.Show("El enfermero se registró exitosamente\n¿Desea seguir registrando enfermeros?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                limpiarFormulario();

                                txtPaterno.Focus();
                            }
                            else
                            {
                                clsComun.redimensionarTabControl(tbcEnfermero, 579, 417);
                                clsComun.redimensionarVentana(this, 583, 443);
                                clsComun.tabAnterior(tbcEnfermero, tbpBuscar, tbpDetalle);

                                limpiarFormulario();

                                txtPaternoBuscar.Focus();

                                dtEnfermeros = ctrEnfermero.seleccionarEnfermeros(objEnfermero);
                                cargarGrilla();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el enfermero", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        objEnfermero.Usuario = strUsuario;
                        objEnfermero.Contrasena = strContrasena;

                        if (ctrEnfermero.modificarEnfermero(objEnfermero))
                        {
                            MessageBox.Show("El enfermero se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.redimensionarTabControl(tbcEnfermero, 579, 417);
                            clsComun.redimensionarVentana(this, 583, 443);
                            clsComun.tabAnterior(tbcEnfermero, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtPaternoBuscar.Focus();

                            dtEnfermeros = ctrEnfermero.seleccionarEnfermeros(objEnfermero);
                            cargarGrilla();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el enfermero", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.redimensionarTabControl(tbcEnfermero, 579, 417);
            clsComun.redimensionarVentana(this, 583, 443);
            clsComun.tabAnterior(tbcEnfermero, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtPaternoBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvEnfermeros.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdEnfermero = Int32.Parse(dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsEnfermero objEnfermero = new clsEnfermero();
                objEnfermero.IdEnfermero = numIdEnfermero;

                objEnfermero = ctrEnfermero.seleccionarEnfermero(objEnfermero);

                mostrarInformacion(objEnfermero, numAccion);

                txtPaterno.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un enfermero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEnfermeros.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdEnfermero = Int32.Parse(dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsEnfermero objEnfermero = new clsEnfermero();
                objEnfermero.IdEnfermero = numIdEnfermero;

                objEnfermero = ctrEnfermero.seleccionarEnfermero(objEnfermero);

                strUsuario = objEnfermero.Usuario;
                strContrasena = objEnfermero.Contrasena;

                mostrarInformacion(objEnfermero, numAccion);

                txtPaterno.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un enfermero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEnfermeros.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este enfermero?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdEnfermero = Int32.Parse(dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[0].Value.ToString());

                    clsEnfermero objEnfermero = new clsEnfermero();
                    objEnfermero.IdEnfermero = numIdEnfermero;

                    if (ctrEnfermero.eliminarEnfermero(objEnfermero))
                    {
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[5].Value = "INACTIVO";

                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[4].Style.ForeColor = Color.White;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[4].Style.BackColor = Color.Red;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[5].Style.ForeColor = Color.White;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[5].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El enfermero se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el enfermero", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un enfermero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvEnfermeros.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este enfermero?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdEnfermero = Int32.Parse(dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[0].Value.ToString());

                    clsEnfermero objEnfermero = new clsEnfermero();
                    objEnfermero.IdEnfermero = numIdEnfermero;

                    if (ctrEnfermero.recuperarEnfermero(objEnfermero))
                    {
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[5].Value = "ACTIVO";

                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[4].Style.ForeColor = Color.Black;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[4].Style.BackColor = Color.White;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[5].Style.ForeColor = Color.Black;
                        dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[5].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El enfermero se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el enfermero", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un enfermero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFoto = new OpenFileDialog();
            ofdFoto.Title = "Seleccionar foto";
            ofdFoto.Filter = "Archivos JPG (*.jpg)|*.jpg";
            ofdFoto.FilterIndex = 2;
            ofdFoto.RestoreDirectory = true;

            DialogResult drFoto = ofdFoto.ShowDialog();

            if (drFoto == DialogResult.OK)
            {
                Image imgFoto = Image.FromFile(ofdFoto.FileName);

                if (imgFoto.Width <= 240 && imgFoto.Height <= 288)
                {
                    this.pbxFoto.Image = Image.FromFile(ofdFoto.FileName);

                    //strRutaFoto = AppDomain.CurrentDomain.BaseDirectory + "Fotos\\" + DateTime.Now;

                    //pbxFoto.Image.Save(strRutaFoto);
                }
                else
                {
                    MessageBox.Show("La imagen no debe sobrepasar los 240 x 288 pixeles", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnBuscarFoto_Click(sender, e);
                }
            }
        }

        private void btnQuitarFoto_Click(object sender, EventArgs e)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                pbxFoto.Image = Properties.Resources.NoFoto;
                strRutaFoto = "";
            }
            else
            {
                pbxFoto.Image = Properties.Resources.FotoPredeterminado;
                strRutaFoto = "";
            }
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex != 0)
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

        private void tbcEnfermero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcEnfermero.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcEnfermero_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsEnfermero objEnfermero = new clsEnfermero();
                objEnfermero.Paterno = txtPaternoBuscar.Text;
                objEnfermero.Materno = txtMaternoBuscar.Text;
                objEnfermero.Nombres = txtNombresBuscar.Text;
                objEnfermero.NumeroLicencia = txtNumeroLicenciaBuscar.Text;
                objEnfermero.IdArea = ((clsArea)cboAreaBuscar.SelectedItem).IdArea;
                objEnfermero.Estado = cboEstadoBuscar.Text;

                dtEnfermeros = ctrEnfermero.seleccionarEnfermerosCriterios(objEnfermero);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvEnfermeros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEnfermeros.Rows[dgvEnfermeros.CurrentRow.Index].Cells[5].Value.ToString().CompareTo("ACTIVO") == 0)
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
