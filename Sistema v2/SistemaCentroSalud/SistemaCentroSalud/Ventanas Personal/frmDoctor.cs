using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Control;
using Comun;

namespace SistemaCentroSalud.Ventanas_Personal
{
    public partial class frmDoctor : Form
    {
        private DataTable dtDoctores;
        private int numAccion;
        private int numIdDoctor;
        private string strRutaFoto = "Properties.Resources.FotoPredeterminado";

        public frmDoctor()
        {
            InitializeComponent();      
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            //GRID: 788, 492		569, 417 
            //FORM: 794, 519		573, 443
            
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            cargarComboEspecialidad();
            cargarComboTipoDocumento();
            cargarComboPais();
            cargarCombosDepartamento();
            cargarComboArea();
            cargarComboPerfil();

            cboEspecialidadBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;
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

        private void cargarComboArea()
        {
            clsArea objArea = new clsArea();
            objArea.TipoArea = "MÉDICA";

            DataTable dt = ctrArea.seleccionarAreasCriterios(objArea);

            objArea.Nombre = "SELECCIONAR";

            cboArea.Items.Add(objArea);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objArea = new clsArea();

                objArea.IdArea = Int32.Parse(dt.Rows[i]["IdArea"].ToString());
                objArea.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboArea.Items.Add(objArea);
            }
        }

        private void cargarComboPerfil()
        {
            clsPerfil objPerfil = new clsPerfil();

            DataTable dt = ctrPerfil.seleccionarPerfiles(objPerfil);

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

                objEspecialidad.IdArea = Int32.Parse(dt.Rows[i]["IdEspecialidad"].ToString());
                objEspecialidad.Nombre = dt.Rows[i]["Nombre"].ToString();

                lbxEspecialidades.Items.Add(objEspecialidad);
            }
        }

        private void cargarGrilla()
        {
            dgvDoctores.DataMember = null;

            for (int i = 0; i < dtDoctores.Rows.Count; i++)
            {
                dgvDoctores.Rows.Add(new String[] { dtDoctores.Rows[i]["IdDoctor"].ToString(), 
                                                 dtDoctores.Rows[i]["Paterno"].ToString(),
                                                 dtDoctores.Rows[i]["Materno"].ToString(),
                                                 dtDoctores.Rows[i]["Nombres"].ToString(),
                                                 dtDoctores.Rows[i]["CMP"].ToString(),
                                                 dtDoctores.Rows[i]["Especialidad"].ToString(),
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
                    dgvDoctores.Rows[i].Cells[6].Style.ForeColor = Color.White;
                    dgvDoctores.Rows[i].Cells[6].Style.BackColor = Color.Red;
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
            cboEspecialidadBuscar.SelectedIndex = 0;
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
                //txtNombreDetalle.Text = objEspecialidad.Nombre;

                //int i;
                //for (i = 0; i < cboAreaDetalle.Items.Count; i++)
                //{
                //    if (objEspecialidad.IdArea == ((clsArea)cboAreaDetalle.Items[i]).IdArea)
                //    {
                //        break;
                //    }
                //}
                //cboAreaDetalle.SelectedIndex = i;
                //rtxtDescripcionDetalle.Text = objEspecialidad.Descripcion;
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
                if (txtNombres.Text.CompareTo("") != 0)
                {
                    if (txtCMP.Text.CompareTo("") != 0)
                    {
                        if (txtCMP.Text.Length == 5)
                        {
                            if (lbxEspecialidadesDoctor.Items.Count != 0)
                            {
                                if (cboPerfil.SelectedIndex != 0)
                                {
                                    if (txtCorreoElectronico.Text.CompareTo("") != 0)
                                    {
                                        if (clsComun.validarCorreoElectronico(txtCorreoElectronico.Text))
                                        {
                                            return true;
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
                    MessageBox.Show("Debe ingresar el nombre del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombres.Focus();
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
                objDoctor.Sexo = cboSexo.Text;
                objDoctor.EstadoCivil = cboEstadoCivil.Text;
                objDoctor.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                objDoctor.IdTipoDocumento = ((clsTipoDocumento)cboTipoDocumento.SelectedItem).IdTipoDocumento;
                objDoctor.NumeroDocumento = txtNumeroDocumento.Text;
                objDoctor.Pais = cboPais.Text;
                objDoctor.DepartamentoNacimiento = cboDepartamento.Text;
                objDoctor.ProvinciaNacimiento = cboProvincia.Text;
                objDoctor.DistritoNacimiento = cboDistrito.Text;
                objDoctor.DepartamentoDomicilio = cboDepartamentoDomicilio.Text;
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
                objDoctor.Usuario = "";
                objDoctor.Contrasena = "";

                if (numAccion == clsComun.INSERTAR)
                {
                    if (ctrDoctor.registrarDoctor(objDoctor))
                    {
                        if (MessageBox.Show("El doctor se registró exitosamente\n¿Desea seguir registrando doctores?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            limpiarFormulario();

                            txtPaterno.Focus();
                        }
                        else
                        {
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
                    clsComun.redimensionarTabControl(tbcDoctor, 569, 417);
                    clsComun.redimensionarVentana(this, 573, 443);
                    clsComun.tabAnterior(tbcDoctor, tbpBuscar, tbpDetalle);

                    limpiarFormulario();

                    txtPaternoBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.redimensionarTabControl(tbcDoctor, 569, 417);
            clsComun.redimensionarVentana(this, 573, 443);
            clsComun.tabAnterior(tbcDoctor, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtPaternoBuscar.Focus();
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
            if (cboPais.SelectedItem.ToString().ToUpper().CompareTo("PERU") == 0)
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
    }
}
