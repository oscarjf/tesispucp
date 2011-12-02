using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Personal
{
    public partial class frmDoctor : Form
    {
        private DataTable dtDoctores;
        private int numAccion;
        private int numIdDoctor;
        private string strRutaFoto = "";

        public frmDoctor()
        {
            InitializeComponent();      
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            cargarComboEspecialidad();
            cargarComboTipoDocumento();
            cargarComboPais();
            cargarCombosDepartamento();
            cargarCombosArea();
            cargarComboPerfil();

            cboAreaBuscar.SelectedIndex = 0;
            //cboEspecialidadBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;

            //clsDoctor objD = new clsDoctor();

            //dtDoctores = ctrDoctor.seleccionarDoctores(objD);

            //cargarGrilla();
        }

        private void cargarComboEspecialidad()
        {
            clsEspecialidad objEspecialidad = new clsEspecialidad();
            
            DataTable dt = ctrEspecialidad.seleccionarEspecialidades(objEspecialidad);

            objEspecialidad.Nombre = "TODAS";

            cboEspecialidadBuscar.Items.Add(objEspecialidad);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objEspecialidad = new clsEspecialidad();

                objEspecialidad.IdEspecialidad = Int32.Parse(dt.Rows[i]["IdEspecialidad"].ToString());
                objEspecialidad.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboEspecialidadBuscar.Items.Add(objEspecialidad);
            }
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
            objPerfil.TipoPersonal = "DOCTOR";

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

        private void cargarListaEspecialidades(int numIdArea)
        {
            lbxEspecialidades.Items.Clear();

            clsEspecialidad objEspecialidad = new clsEspecialidad();
            objEspecialidad.IdArea = numIdArea;

            DataTable dt = ctrEspecialidad.seleccionarEspecialidadesCriterios(objEspecialidad);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objEspecialidad = new clsEspecialidad();

                objEspecialidad.IdEspecialidad = Int32.Parse(dt.Rows[i]["IdEspecialidad"].ToString());
                objEspecialidad.Nombre = dt.Rows[i]["Nombre"].ToString();

                lbxEspecialidades.Items.Add(objEspecialidad);
            }
        }

        private void cargarComboEspecialidades(int numIdArea)
        {
            cboEspecialidadBuscar.Items.Clear();

            clsEspecialidad objEspecialidad = new clsEspecialidad();
            objEspecialidad.Nombre = "TODAS";

            cboEspecialidadBuscar.Items.Add(objEspecialidad);

            objEspecialidad = new clsEspecialidad();
            objEspecialidad.IdArea = numIdArea;

            DataTable dt = ctrEspecialidad.seleccionarEspecialidadesCriterios(objEspecialidad);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objEspecialidad = new clsEspecialidad();

                objEspecialidad.IdEspecialidad = Int32.Parse(dt.Rows[i]["IdEspecialidad"].ToString());
                objEspecialidad.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboEspecialidadBuscar.Items.Add(objEspecialidad);
            }
        }

        private void cargarGrilla()
        {
            dgvDoctores.DataMember = null;

            for (int i = 0; i < dtDoctores.Rows.Count; i++)
            {
                dgvDoctores.Rows.Add(new String[] { dtDoctores.Rows[i]["IdPersona"].ToString(), 
                                                 dtDoctores.Rows[i]["Paterno"].ToString(),
                                                 dtDoctores.Rows[i]["Materno"].ToString(),
                                                 dtDoctores.Rows[i]["Nombres"].ToString(),
                                                 dtDoctores.Rows[i]["CMP"].ToString(),
                                                 dtDoctores.Rows[i]["Estado"].ToString() });

                if (dtDoctores.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvDoctores.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvDoctores.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvDoctores.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvDoctores.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvDoctores.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvDoctores.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dgvDoctores.Rows[i].Cells[4].Style.ForeColor = Color.White;
                    dgvDoctores.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    dgvDoctores.Rows[i].Cells[5].Style.ForeColor = Color.White;
                    dgvDoctores.Rows[i].Cells[5].Style.BackColor = Color.Red;
                }
            }

            dgvDoctores.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtPaternoBuscar.Clear();
            txtMaternoBuscar.Clear();
            txtNombresBuscar.Clear();
            txtCMPBuscar.Clear();
            cboAreaBuscar.SelectedIndex = 0;
            //cboEspecialidadBuscar.SelectedIndex = 0;
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
            txtCMP.Clear();
            cboArea.SelectedIndex = 0;
            lbxEspecialidades.Items.Clear();
            lbxEspecialidadesDoctor.Items.Clear();
            cboPerfil.SelectedIndex = 0;
            //lbxEspecialidades.Items.Clear();
            lbxEspecialidades.Items.Clear();
            pbxFoto.Image = Properties.Resources.FotoPredeterminado;
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreoElectronico.Clear();
        }

        private void mostrarInformacion(clsDoctor objDoctor, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtPaterno.Text = objDoctor.Paterno;
                txtMaterno.Text = objDoctor.Materno;
                txtNombres.Text = objDoctor.Nombres;
                cboSexo.Text = objDoctor.Sexo;
                cboEstadoCivil.Text = objDoctor.EstadoCivil;
                dtpFechaNacimiento.Value = objDoctor.FechaNacimiento;
                cboTipoDocumento.Text = objDoctor._TipoDocumento;
                txtNumeroDocumento.Text = objDoctor.NumeroDocumento;
                cboPais.Text = objDoctor.Pais;
                cboDepartamento.Text = objDoctor.DepartamentoNacimiento;
                cboProvincia.Text = objDoctor.ProvinciaNacimiento;
                cboDistrito.Text = objDoctor.DistritoNacimiento;
                cboDepartamentoDomicilio.Text = objDoctor.DepartamentoDomicilio;
                cboProvinciaDomicilio.Text = objDoctor.ProvinciaDomicilio;
                cboDistritoDomicilio.Text = objDoctor.DistritoDomicilio;
                txtDireccion.Text = objDoctor.Direccion;
                txtCMP.Text = objDoctor.CMP;
                cboArea.Text = objDoctor._Area;
                for (int i = 0; i < objDoctor._Especialidades.Count; i++)
                {
                    lbxEspecialidadesDoctor.Items.Add(objDoctor._Especialidades[i]);
                }
                cboPerfil.Text = objDoctor._Perfil;
                txtTelefono.Text = objDoctor.Telefono;
                txtCelular.Text = objDoctor.Celular;
                txtCorreoElectronico.Text = objDoctor.CorreoElectronico;
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
                txtCMP.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboArea.Enabled = false;
                btnTodoDerecha.Visible = false;
                btnDerecha.Visible = false;
                btnIzquierda.Visible = false;
                btnTodoIzquierda.Visible = false;
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
                txtCMP.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboArea.Enabled = true;
                btnTodoDerecha.Visible = true;
                btnDerecha.Visible = true;
                btnIzquierda.Visible = true;
                btnTodoIzquierda.Visible = true;
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

            clsComun.redimensionarTabControl(tbcDoctor, 788, 492);
            clsComun.redimensionarVentana(this, 794, 519);
            clsComun.tabSiguiente(tbcDoctor, tbpBuscar, tbpDetalle);
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
                                if (txtCMP.Text.CompareTo("") != 0)
                                {
                                    if (txtCMP.Text.Length == 5)
                                    {
                                        if (ctrDoctor.validarCMP(numIdDoctor, txtCMP.Text))
                                        {
                                            if (cboArea.SelectedIndex != 0)
                                            {
                                                if (lbxEspecialidadesDoctor.Items.Count != 0)
                                                {
                                                    if (cboPerfil.SelectedIndex != 0)
                                                    {
                                                        if (txtCorreoElectronico.Text.CompareTo("") != 0)
                                                        {
                                                            if (clsComun.validarCorreoElectronico(txtCorreoElectronico.Text))
                                                            {
                                                                if (ctrEmpleado.validarCorreoElectronico(numIdDoctor, txtCorreoElectronico.Text))
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
                                                            MessageBox.Show("Debe ingresar el correo electrónico del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                            txtCorreoElectronico.Focus();
                                                            return false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Debe seleccionar el perfil de acceso del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                        cboPerfil.Focus();
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe seleccionar al menos una especialidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    cboArea.Focus();
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
                                            MessageBox.Show("El código CMP ingresado ya existe. Verifique el código del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            txtCMP.Focus();
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El código CMP debe tener 5 dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        txtCMP.Focus();
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe ingresar el código CMP del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtCMP.Focus();
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
                        MessageBox.Show("Debe ingresar el nombre del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombres.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el apellido materno del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaterno.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el apellido paterno del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPaterno.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdDoctor = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtPaterno.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                clsDoctor objDoctor = new clsDoctor();
                objDoctor.IdDoctor = numIdDoctor;
                objDoctor.Paterno = txtPaterno.Text;
                objDoctor.Materno = txtMaterno.Text;
                objDoctor.Nombres = txtNombres.Text;
                objDoctor.Sexo = clsComun.seleccionarToVacio(cboSexo.Text);
                objDoctor.EstadoCivil = clsComun.seleccionarToVacio(cboEstadoCivil.Text);
                objDoctor.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                objDoctor.IdTipoDocumento = ((clsTipoDocumento)cboTipoDocumento.SelectedItem).IdTipoDocumento;
                objDoctor.NumeroDocumento = txtNumeroDocumento.Text;
                objDoctor.Pais = clsComun.seleccionarToVacio(cboPais.Text);
                objDoctor.DepartamentoNacimiento = cboDepartamento.Text;
                objDoctor.ProvinciaNacimiento = cboProvincia.Text;
                objDoctor.DistritoNacimiento = cboDistrito.Text;
                objDoctor.DepartamentoDomicilio = clsComun.seleccionarToVacio(cboDepartamentoDomicilio.Text);
                objDoctor.ProvinciaDomicilio = cboProvinciaDomicilio.Text;
                objDoctor.DistritoDomicilio = cboDistritoDomicilio.Text;
                objDoctor.Direccion = txtDireccion.Text;
                objDoctor.CMP = txtCMP.Text;
                objDoctor.IdArea = ((clsArea)cboArea.SelectedItem).IdArea;
                string strListaIdEspecialidades = strListaIdEspecialidades = ((clsEspecialidad)lbxEspecialidadesDoctor.Items[0]).IdEspecialidad + "";
                
                for (int i = 1; i < lbxEspecialidadesDoctor.Items.Count; i++)
                {
                    strListaIdEspecialidades += "," + ((clsEspecialidad)lbxEspecialidadesDoctor.Items[i]).IdEspecialidad;
                }
                objDoctor.ListaIdEspecialidades = strListaIdEspecialidades;
                objDoctor.Foto = strRutaFoto;
                objDoctor.IdPerfil = ((clsPerfil)cboPerfil.SelectedItem).IdPerfil;
                objDoctor.Telefono = txtTelefono.Text;
                objDoctor.Celular = txtCelular.Text;
                objDoctor.CorreoElectronico = txtCorreoElectronico.Text;
                objDoctor.Usuario = ctrEmpleado.generarNombreUsuario(numIdDoctor, txtPaterno.Text, txtMaterno.Text, txtNombres.Text);
                objDoctor.Contrasena = clsSeguridad.generarContrasenaAleatoria(8);

                if (numAccion == clsComun.INSERTAR)
                {
                    if (ctrDoctor.registrarDoctor(objDoctor))
                    {
                        clsComun.enviarCorreo(txtCorreoElectronico.Text, objDoctor.Paterno, objDoctor.Materno, objDoctor.Nombres, objDoctor.Usuario, objDoctor.Contrasena);

                        if (MessageBox.Show("El doctor se registró exitosamente\n¿Desea seguir registrando doctores?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            limpiarFormulario();

                            txtPaterno.Focus();
                        }
                        else
                        {
                            clsComun.redimensionarTabControl(tbcDoctor, 579, 417);
                            clsComun.redimensionarVentana(this, 583, 443);
                            clsComun.tabAnterior(tbcDoctor, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtPaternoBuscar.Focus();

                            dtDoctores = ctrDoctor.seleccionarDoctores(objDoctor);
                            cargarGrilla();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el doctor", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else if (numAccion == clsComun.MODIFICAR)
                {
                    if (ctrDoctor.modificarDoctor(objDoctor))
                    {
                        MessageBox.Show("El doctor se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsComun.redimensionarTabControl(tbcDoctor, 579, 417);
                        clsComun.redimensionarVentana(this, 583, 443);
                        clsComun.tabAnterior(tbcDoctor, tbpBuscar, tbpDetalle);
                        
                        limpiarFormulario();

                        txtPaternoBuscar.Focus();

                        dtDoctores = ctrDoctor.seleccionarDoctores(objDoctor);
                        cargarGrilla();
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el doctor", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    clsComun.redimensionarTabControl(tbcDoctor, 579, 417);
                    clsComun.redimensionarVentana(this, 583, 443);
                    clsComun.tabAnterior(tbcDoctor, tbpBuscar, tbpDetalle);

                    limpiarFormulario();

                    txtPaternoBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.redimensionarTabControl(tbcDoctor, 579, 417);
            clsComun.redimensionarVentana(this, 583, 443);
            clsComun.tabAnterior(tbcDoctor, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtPaternoBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdDoctor = Int32.Parse(dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsDoctor objDoctor = new clsDoctor();
                objDoctor.IdDoctor = numIdDoctor;

                objDoctor = ctrDoctor.seleccionarDoctor(objDoctor);

                mostrarInformacion(objDoctor, numAccion);

                txtPaterno.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdDoctor = Int32.Parse(dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsDoctor objDoctor = new clsDoctor();
                objDoctor.IdDoctor = numIdDoctor;

                objDoctor = ctrDoctor.seleccionarDoctor(objDoctor);

                mostrarInformacion(objDoctor, numAccion);

                txtPaterno.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este doctor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdDoctor = Int32.Parse(dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[0].Value.ToString());

                    clsDoctor objDoctor = new clsDoctor();
                    objDoctor.IdDoctor = numIdDoctor;

                    if (ctrDoctor.eliminarDoctor(objDoctor))
                    {
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[5].Value = "INACTIVO";

                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[4].Style.ForeColor = Color.White;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[4].Style.BackColor = Color.Red;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[5].Style.ForeColor = Color.White;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[5].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("El doctor se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el doctor", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este doctor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdDoctor = Int32.Parse(dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[0].Value.ToString());

                    clsDoctor objDoctor = new clsDoctor();
                    objDoctor.IdDoctor = numIdDoctor;

                    if (ctrDoctor.recuperarDoctor(objDoctor))
                    {
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[5].Value = "ACTIVO";

                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[4].Style.ForeColor = Color.Black;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[4].Style.BackColor = Color.White;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[5].Style.ForeColor = Color.Black;
                        dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[5].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El doctor se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el doctor", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboArea.SelectedIndex > 0)
            {
                cargarListaEspecialidades(((clsArea)cboArea.SelectedItem).IdArea);
            }
            else
            {
                lbxEspecialidades.Items.Clear();
            }
        }

        private void btnTodoDerecha_Click(object sender, EventArgs e)
        {
            bool blnEncontrado = false;

            foreach (clsEspecialidad objEspecialidad in lbxEspecialidades.Items)
            {
                foreach (clsEspecialidad objEspecialidadDoctor in lbxEspecialidadesDoctor.Items)
                {
                    if (objEspecialidad.IdEspecialidad == objEspecialidadDoctor.IdEspecialidad)
                    {
                        blnEncontrado = true;
                        break;
                    }
                }

                if (!blnEncontrado)
                {
                    lbxEspecialidadesDoctor.Items.Add(objEspecialidad);
                    blnEncontrado = false;
                }
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (lbxEspecialidades.SelectedItems.Count > 0)
            {
                bool blnEncontrado = false;

                foreach (clsEspecialidad objEspecialidadDoctor in lbxEspecialidadesDoctor.Items)
                {
                    if (((clsEspecialidad)lbxEspecialidades.SelectedItem).IdEspecialidad == objEspecialidadDoctor.IdEspecialidad)
                    {
                        blnEncontrado = true;
                        break;
                    }
                }

                if (!blnEncontrado)
                {
                    lbxEspecialidadesDoctor.Items.Add(lbxEspecialidades.SelectedItem);
                    blnEncontrado = false;
                }
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (lbxEspecialidadesDoctor.SelectedItems.Count > 0)
            {
                lbxEspecialidadesDoctor.Items.Remove(lbxEspecialidadesDoctor.SelectedItem);
            }
        }

        private void btnTodoIzquierda_Click(object sender, EventArgs e)
        {
            lbxEspecialidadesDoctor.Items.Clear();
        }

        private void tbcDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcDoctor.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcDoctor_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsDoctor objDoctor = new clsDoctor();
                objDoctor.Paterno = txtPaternoBuscar.Text;
                objDoctor.Materno = txtMaternoBuscar.Text;
                objDoctor.Nombres = txtNombresBuscar.Text;
                objDoctor.CMP = txtCMPBuscar.Text;
                objDoctor.IdArea = ((clsArea)cboAreaBuscar.SelectedItem).IdArea;
                if (objDoctor.IdArea != 0)
                {
                    objDoctor.ListaIdEspecialidades = ((clsEspecialidad)cboEspecialidadBuscar.SelectedItem).IdEspecialidad + "";
                }
                else
                {
                    objDoctor.ListaIdEspecialidades = "0";
                }
                objDoctor.Estado = cboEstadoBuscar.Text;

                dtDoctores = ctrDoctor.seleccionarDoctoresCriterios(objDoctor);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void cboAreaBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboAreaBuscar.SelectedIndex > 0)
                {
                    cargarComboEspecialidades(((clsArea)cboAreaBuscar.SelectedItem).IdArea);
                    cboEspecialidadBuscar.Enabled = true;
                    cboEspecialidadBuscar.SelectedIndex = 0;
                }
                else
                {
                    cboEspecialidadBuscar.Items.Clear();
                    cboEspecialidadBuscar.Enabled = false;
                }

                buscarCriterios(sender, e);
            }
            catch
            {
            }
        }

        private void dgvDoctores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoctores.Rows[dgvDoctores.CurrentRow.Index].Cells[5].Value.ToString().CompareTo("ACTIVO") == 0)
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