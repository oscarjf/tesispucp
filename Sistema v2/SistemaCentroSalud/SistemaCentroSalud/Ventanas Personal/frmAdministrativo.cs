using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Personal
{
    public partial class frmAdministrativo : Form
    {
        private DataTable dtAdministrativos;
        private int numAccion;
        private int numIdAdministrativo;
        private string strRutaFoto = "";
        private bool blnCambioFoto = false;

        public frmAdministrativo()
        {
            InitializeComponent();
        }

        private void frmAdministrativo_Load(object sender, EventArgs e)
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

            //clsAdministrativo objA = new clsAdministrativo();

            //dtAdministrativos = ctrAdministrativo.seleccionarAdministrativos(objA);

            //cargarGrilla();
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
                objTipoDocumento.NumeroDigitos = dt.Rows[i]["NUMERODIGITOS"].ToString();

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
            objArea.TipoArea = "ADMINISTRATIVA";

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
            objPerfil.TipoPersonal = "ADMINISTRATIVO";

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
            dgvAdministrativos.DataMember = null;

            for (int i = 0; i < dtAdministrativos.Rows.Count; i++)
            {
                dgvAdministrativos.Rows.Add(new String[] { dtAdministrativos.Rows[i]["IdPersona"].ToString(), 
                                                 dtAdministrativos.Rows[i]["Paterno"].ToString(),
                                                 dtAdministrativos.Rows[i]["Materno"].ToString(),
                                                 dtAdministrativos.Rows[i]["Nombres"].ToString(),
                                                 dtAdministrativos.Rows[i]["Estado"].ToString() });

                if (dtAdministrativos.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvAdministrativos.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvAdministrativos.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvAdministrativos.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvAdministrativos.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvAdministrativos.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvAdministrativos.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dgvAdministrativos.Rows[i].Cells[4].Style.ForeColor = Color.White;
                    dgvAdministrativos.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
            }

            dgvAdministrativos.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtPaternoBuscar.Clear();
            txtMaternoBuscar.Clear();
            txtNombresBuscar.Clear();
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

        private void mostrarInformacion(clsAdministrativo objAdministrativo, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtPaterno.Text = objAdministrativo.Paterno;
                txtMaterno.Text = objAdministrativo.Materno;
                txtNombres.Text = objAdministrativo.Nombres;
                cboSexo.Text = objAdministrativo.Sexo;
                cboEstadoCivil.Text = objAdministrativo.EstadoCivil;
                dtpFechaNacimiento.Value = objAdministrativo.FechaNacimiento;
                cboTipoDocumento.Text = objAdministrativo._TipoDocumento;
                txtNumeroDocumento.Text = objAdministrativo.NumeroDocumento;
                cboPais.Text = objAdministrativo.Pais;
                cboDepartamento.Text = objAdministrativo.DepartamentoNacimiento;
                cboProvincia.Text = objAdministrativo.ProvinciaNacimiento;
                cboDistrito.Text = objAdministrativo.DistritoNacimiento;
                cboDepartamentoDomicilio.Text = objAdministrativo.DepartamentoDomicilio;
                cboProvinciaDomicilio.Text = objAdministrativo.ProvinciaDomicilio;
                cboDistritoDomicilio.Text = objAdministrativo.DistritoDomicilio;
                txtDireccion.Text = objAdministrativo.Direccion;
                cboArea.Text = objAdministrativo._Area;
                cboPerfil.Text = objAdministrativo._Perfil;
                txtTelefono.Text = objAdministrativo.Telefono;
                txtCelular.Text = objAdministrativo.Celular;
                txtCorreoElectronico.Text = objAdministrativo.CorreoElectronico;

                try
                {
                    if (objAdministrativo.Foto.CompareTo("") != 0)
                    {
                        pbxFoto.Image = Image.FromFile(objAdministrativo.Foto);
                        strRutaFoto = objAdministrativo.Foto;
                    }
                    else
                    {
                        pbxFoto.Image = Properties.Resources.NoFoto;
                    }
                }
                catch(Exception ex)
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

            clsComun.redimensionarTabControl(tbcAdministrativo, 786, 426);
            clsComun.redimensionarVentana(this, 790, 452);
            clsComun.tabSiguiente(tbcAdministrativo, tbpBuscar, tbpDetalle);
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
                                if (cboArea.SelectedIndex != 0)
                                {
                                    if (cboPerfil.SelectedIndex != 0)
                                    {
                                        if (txtCorreoElectronico.Text.CompareTo("") != 0)
                                        {
                                            if (clsComun.validarCorreoElectronico(txtCorreoElectronico.Text))
                                            {
                                                if (ctrEmpleado.validarCorreoElectronico(numIdAdministrativo, txtCorreoElectronico.Text))
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
                                            MessageBox.Show("Debe ingresar el correo electrónico del empleado administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            txtCorreoElectronico.Focus();
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe seleccionar el perfil de acceso del empleado administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("Debe ingresar el nombre del empleado administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombres.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el apellido materno del empleado administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaterno.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el apellido paterno del empleado administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            numIdAdministrativo = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtPaterno.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.redimensionarTabControl(tbcAdministrativo, 582, 419);
                clsComun.redimensionarVentana(this, 585, 445);
                clsComun.tabAnterior(tbcAdministrativo, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                txtPaternoBuscar.Focus();
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;

                if (validarFormulario())
                {
                    clsAdministrativo objAdministrativo = new clsAdministrativo();
                    objAdministrativo.IdAdministrativo = numIdAdministrativo;
                    objAdministrativo.Paterno = txtPaterno.Text;
                    objAdministrativo.Materno = txtMaterno.Text;
                    objAdministrativo.Nombres = txtNombres.Text;
                    objAdministrativo.Sexo = clsComun.seleccionarToVacio(cboSexo.Text);
                    objAdministrativo.EstadoCivil = clsComun.seleccionarToVacio(cboEstadoCivil.Text);
                    objAdministrativo.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                    objAdministrativo.IdTipoDocumento = ((clsTipoDocumento)cboTipoDocumento.SelectedItem).IdTipoDocumento;
                    objAdministrativo.NumeroDocumento = txtNumeroDocumento.Text;
                    objAdministrativo.Pais = clsComun.seleccionarToVacio(cboPais.Text);
                    objAdministrativo.DepartamentoNacimiento = cboDepartamento.Text;
                    objAdministrativo.ProvinciaNacimiento = cboProvincia.Text;
                    objAdministrativo.DistritoNacimiento = cboDistrito.Text;
                    objAdministrativo.DepartamentoDomicilio = clsComun.seleccionarToVacio(cboDepartamentoDomicilio.Text);
                    objAdministrativo.ProvinciaDomicilio = cboProvinciaDomicilio.Text;
                    objAdministrativo.DistritoDomicilio = cboDistritoDomicilio.Text;
                    objAdministrativo.Direccion = txtDireccion.Text;
                    objAdministrativo.IdArea = ((clsArea)cboArea.SelectedItem).IdArea;
                    objAdministrativo.Foto = strRutaFoto;
                    objAdministrativo.IdPerfil = ((clsPerfil)cboPerfil.SelectedItem).IdPerfil;
                    objAdministrativo.Telefono = txtTelefono.Text;
                    objAdministrativo.Celular = txtCelular.Text;
                    objAdministrativo.CorreoElectronico = txtCorreoElectronico.Text;
                    objAdministrativo.Usuario = ctrEmpleado.generarNombreUsuario(numIdAdministrativo, txtPaterno.Text, txtMaterno.Text, txtNombres.Text);
                    objAdministrativo.Contrasena = clsSeguridad.generarContrasenaAleatoria(8);

                    if (blnCambioFoto)
                    {
                        guardarFoto();
                    }

                    objAdministrativo.Foto = strRutaFoto;

                    if (numAccion == clsComun.INSERTAR)
                    {
                        if (ctrAdministrativo.registrarAdministrativo(objAdministrativo))
                        {
                            enviarCorreo(txtCorreoElectronico.Text, objAdministrativo.Paterno, objAdministrativo.Materno, objAdministrativo.Nombres, objAdministrativo.Usuario, objAdministrativo.Contrasena);

                            if (MessageBox.Show("El empleado administrativo se registró exitosamente\n¿Desea seguir registrando empleados administrativos?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                limpiarFormulario();

                                txtPaterno.Focus();
                            }
                            else
                            {
                                clsComun.redimensionarTabControl(tbcAdministrativo, 582, 419);
                                clsComun.redimensionarVentana(this, 585, 445);
                                clsComun.tabAnterior(tbcAdministrativo, tbpBuscar, tbpDetalle);

                                limpiarFormulario();

                                txtPaternoBuscar.Focus();

                                dtAdministrativos = ctrAdministrativo.seleccionarAdministrativos(objAdministrativo);
                                cargarGrilla();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el empleado administrativo", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        if (ctrAdministrativo.modificarAdministrativo(objAdministrativo))
                        {
                            MessageBox.Show("El empleado administrativo se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.redimensionarTabControl(tbcAdministrativo, 582, 419);
                            clsComun.redimensionarVentana(this, 585, 445);
                            clsComun.tabAnterior(tbcAdministrativo, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtPaternoBuscar.Focus();

                            dtAdministrativos = ctrAdministrativo.seleccionarAdministrativos(objAdministrativo);
                            cargarGrilla();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el empleado administrativo", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
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
            clsComun.redimensionarTabControl(tbcAdministrativo, 582, 419);
            clsComun.redimensionarVentana(this, 585, 445);
            clsComun.tabAnterior(tbcAdministrativo, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtPaternoBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvAdministrativos.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdAdministrativo = Int32.Parse(dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsAdministrativo objAdministrativo = new clsAdministrativo();
                objAdministrativo.IdAdministrativo = numIdAdministrativo;

                objAdministrativo = ctrAdministrativo.seleccionarAdministrativo(objAdministrativo);

                mostrarInformacion(objAdministrativo, numAccion);

                txtPaterno.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un empleado administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAdministrativos.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdAdministrativo = Int32.Parse(dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsAdministrativo objAdministrativo = new clsAdministrativo();
                objAdministrativo.IdAdministrativo = numIdAdministrativo;

                objAdministrativo = ctrAdministrativo.seleccionarAdministrativo(objAdministrativo);

                mostrarInformacion(objAdministrativo, numAccion);

                txtPaterno.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un empleado administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAdministrativos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este empleado administrativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdAdministrativo = Int32.Parse(dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[0].Value.ToString());

                    clsAdministrativo objAdministrativo = new clsAdministrativo();
                    objAdministrativo.IdAdministrativo = numIdAdministrativo;

                    if (ctrAdministrativo.eliminarAdministrativo(objAdministrativo))
                    {
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[4].Value = "INACTIVO";

                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[4].Style.ForeColor = Color.White;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[4].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El empleado administrativo se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el empleado administrativo", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un empleado administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvAdministrativos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este empleado administrativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdAdministrativo = Int32.Parse(dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[0].Value.ToString());

                    clsAdministrativo objAdministrativo = new clsAdministrativo();
                    objAdministrativo.IdAdministrativo = numIdAdministrativo;

                    if (ctrAdministrativo.recuperarAdministrativo(objAdministrativo))
                    {
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[4].Value = "ACTIVO";

                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[4].Style.ForeColor = Color.Black;
                        dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[4].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El empleado administrativo se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el empleado administrativo", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un empleado administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                    strRutaFoto = AppDomain.CurrentDomain.BaseDirectory + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".jpg";
                    
                    blnCambioFoto = true;
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

        private void tbcAdministrativo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcAdministrativo.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcAdministrativo_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsAdministrativo objAdministrativo = new clsAdministrativo();
                objAdministrativo.Paterno = txtPaternoBuscar.Text;
                objAdministrativo.Materno = txtMaternoBuscar.Text;
                objAdministrativo.Nombres = txtNombresBuscar.Text;
                objAdministrativo.IdArea = ((clsArea)cboAreaBuscar.SelectedItem).IdArea;
                objAdministrativo.Estado = cboEstadoBuscar.Text;

                dtAdministrativos = ctrAdministrativo.seleccionarAdministrativosCriterios(objAdministrativo);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvAdministrativos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[4].Value.ToString().CompareTo("ACTIVO") == 0)
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
