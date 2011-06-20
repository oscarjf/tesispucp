using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comun;
using Modelo;
using Logica;
using Control;

namespace SistemaCentroSalud.Ventanas_Personal
{
    public partial class frmDoctor : Form
    {
        DataTable dtDoctores;
        private int numIdDoctor = 0;
        private int numAccion = 0;
        private string strSexo; //M:Masculino, F:Femenino
        private int numIdTipoDocumento = 0;
        private int numIdPerfil = 0;
        private int numIdArea = 0;
        private int numIdEspecialidad = 0;

        public frmDoctor()
        {
            InitializeComponent();

            clsComun.redimensionarVentana(this, 578, 444);
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            inicializarVentana();
        }

        private void inicializarVentana()
        {
            cboSexo.SelectedIndex = 0;
            cboEstadoCivil.SelectedIndex = 0;

            List<clsTipoDocumento> lstTipoDocumentos = clsGestorLogico.up_SelTipoDocumento();
            llenarComboTipoDocumento(lstTipoDocumentos);
            cboTipoDocumento.SelectedIndex = 0;

            List<clsArea> lstAreas = clsGestorLogico.up_SelArea("MÉDICA", "ACTIVO");
            llenarComboArea(lstAreas);
            cboArea.SelectedIndex = 0;

            List<clsEspecialidad> lstEspecialidades = clsGestorLogico.up_SelEspecialidad();
            llenarComboEspecialidad(lstEspecialidades);
            cboEspecialidad.SelectedIndex = 0;

            List<clsPais> lstPaises = clsGestorLogico.up_SelPais();
            llenarComboPais(lstPaises);
            cboPais.SelectedIndex = 0;

            List<clsUbigeo> lstDepartamentos = clsGestorLogico.up_SelDepartamento();
            llenarComboDepartamento(lstDepartamentos);

            List<clsPerfil> lstPerfiles = clsGestorLogico.up_SelPerfil();
            llenarComboPerfil(lstPerfiles);
            cboPerfil.SelectedIndex = 0;
        }

        private void llenarComboPais(List<clsPais> lstPaises)
        {
            clsPais objPais = new clsPais();
            objPais.StrNombre = "SELECCIONAR";

            cboPais.Items.Add(objPais);

            for (int i = 0; i < lstPaises.Count; i++)
            {
                cboPais.Items.Add(lstPaises[i]);
            }
        }

        private void llenarComboEspecialidad(List<clsEspecialidad> lstEspecialidades)
        {
            clsEspecialidad objEspecialidad = new clsEspecialidad();
            objEspecialidad.StrNombre = "SELECCIONAR";

            cboEspecialidad.Items.Add(objEspecialidad);

            for (int i = 0; i < lstEspecialidades.Count; i++)
            {
                cboEspecialidad.Items.Add(lstEspecialidades[i]);
            }
        }

        private void llenarComboArea(List<clsArea> lstAreas)
        {
            clsArea objArea = new clsArea();
            objArea.StrNombre = "SELECCIONAR";

            cboArea.Items.Add(objArea);

            for (int i = 0; i < lstAreas.Count; i++)
            {
                cboArea.Items.Add(lstAreas[i]);
            }
        }

        private void llenarComboDepartamento(List<clsUbigeo> lstDepartamentos)
        {
            clsUbigeo objDepartamento = new clsUbigeo();
            objDepartamento.StrNombre = "SELECCIONAR";

            cboDepartamento.Items.Add(objDepartamento);

            for (int i = 0; i < lstDepartamentos.Count; i++)
            {
                cboDepartamento.Items.Add(lstDepartamentos[i]);
            }

            cboDepartamentoDomicilio.Items.Add(objDepartamento);

            for (int i = 0; i < lstDepartamentos.Count; i++)
            {
                cboDepartamentoDomicilio.Items.Add(lstDepartamentos[i]);
            }

            cboDepartamentoDomicilio.SelectedIndex = 0;
        }

        private void llenarComboProvincia(List<clsUbigeo> lstProvincias)
        {
            cboProvincia.Items.Clear();
            cboDistrito.Items.Clear();

            clsUbigeo objProvincia = new clsUbigeo();
            objProvincia.StrNombre = "SELECCIONAR";

            cboProvincia.Items.Add(objProvincia);

            for (int i = 0; i < lstProvincias.Count; i++)
            {
                cboProvincia.Items.Add(lstProvincias[i]);
            }
        }

        private void llenarComboProvinciaDomicilio(List<clsUbigeo> lstProvincias)
        {
            cboProvinciaDomicilio.Items.Clear();
            cboDistritoDomicilio.Items.Clear();

            clsUbigeo objProvincia = new clsUbigeo();
            objProvincia.StrNombre = "SELECCIONAR";

            cboProvinciaDomicilio.Items.Add(objProvincia);

            for (int i = 0; i < lstProvincias.Count; i++)
            {
                cboProvinciaDomicilio.Items.Add(lstProvincias[i]);
            }
        }

        private void llenarComboDistrito(List<clsUbigeo> lstDistritos)
        {
            cboDistrito.Items.Clear();

            clsUbigeo objDistrito = new clsUbigeo();
            objDistrito.StrNombre = "SELECCIONAR";

            cboDistrito.Items.Add(objDistrito);

            for (int i = 0; i < lstDistritos.Count; i++)
            {
                cboDistrito.Items.Add(lstDistritos[i]);
            }
        }

        private void llenarComboDistritoDomicilio(List<clsUbigeo> lstDistritos)
        {
            cboDistritoDomicilio.Items.Clear();

            clsUbigeo objDistrito = new clsUbigeo();
            objDistrito.StrNombre = "SELECCIONAR";

            cboDistritoDomicilio.Items.Add(objDistrito);

            for (int i = 0; i < lstDistritos.Count; i++)
            {
                cboDistritoDomicilio.Items.Add(lstDistritos[i]);
            }
        }

        private void llenarComboTipoDocumento(List<clsTipoDocumento> lstTipoDocumentos)
        {
            clsTipoDocumento objTipoDocumento = new clsTipoDocumento();
            objTipoDocumento.StrNombre = "SELECCIONAR";

            cboTipoDocumento.Items.Add(objTipoDocumento);

            for (int i = 0; i < lstTipoDocumentos.Count; i++)
            {
                cboTipoDocumento.Items.Add(lstTipoDocumentos[i]);
            }
        }

        private void llenarComboPerfil(List<clsPerfil> lstPerfiles)
        {
            clsPerfil objPerfil = new clsPerfil();
            objPerfil.StrNombre = "SELECCIONAR";

            cboPerfil.Items.Add(objPerfil);

            for (int i = 0; i < lstPerfiles.Count; i++)
            {
                cboPerfil.Items.Add(lstPerfiles[i]);
            }
        }

        private string generarNombreUsuario(string strNombre, string strApellidoPaterno, string strApellidoMaterno)
        {
            int numNumeroOcurrencias;
            string strNombreUsuario = strNombre[0] + strApellidoPaterno + strApellidoMaterno[0];

            numNumeroOcurrencias = clsGestorLogico.numeroOcurrenciasUsuario(strNombreUsuario);

            if (numNumeroOcurrencias != 0)
            {
                strNombreUsuario = strNombreUsuario + numNumeroOcurrencias;
            }

            return strNombreUsuario.ToLower();
        }


        private bool validarFecha(DateTime dtFechaNacimiento)
        {
            if (DateTime.Today.AddYears(-18).CompareTo(dtFechaNacimiento) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarNumeroDocumento(string strNumeroDocumento)
        {
            if (strNumeroDocumento.Length == txtNumeroDocumento.MaxLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarVentana()
        {
            if (txtPaterno.Text.CompareTo("") != 0)
            {
                if (txtMaterno.Text.CompareTo("") != 0)
                {
                    if (txtNombres.Text.CompareTo("") != 0)
                    {
                        if (cboEstadoCivil.Text.CompareTo("SELECCIONAR") != 0)
                        {
                            if (cboSexo.Text.CompareTo("SELECCIONAR") != 0)
                            {
                                if (validarFecha(dtpFechaNacimiento.Value))
                                {
                                    if (cboTipoDocumento.Text.CompareTo("SELECCIONAR") != 0)
                                    {
                                        if (txtNumeroDocumento.Text.CompareTo("") != 0)
                                        {
                                            if (validarNumeroDocumento(txtNumeroDocumento.Text))
                                            {
                                                if (cboArea.Text.CompareTo("SELECCIONAR") != 0)
                                                {
                                                    if (cboEspecialidad.Text.CompareTo("SELECCIONAR") != 0)
                                                    {
                                                        if (txtCMP.Text.CompareTo("") != 0)
                                                        {
                                                            if (txtCMP.Text.Length == 5)
                                                            {
                                                                if (cboPerfil.Text.CompareTo("SELECCIONAR") != 0)
                                                                {
                                                                    if (cboPais.Text.CompareTo("SELECCIONAR") != 0)
                                                                    {
                                                                        if (cboDepartamento.Text.CompareTo("SELECCIONAR") != 0)
                                                                        {
                                                                            if (cboProvincia.Text.CompareTo("SELECCIONAR") != 0)
                                                                            {
                                                                                if (cboDistrito.Text.CompareTo("SELECCIONAR") != 0)
                                                                                {
                                                                                    if (cboDepartamentoDomicilio.Text.CompareTo("SELECCIONAR") != 0)
                                                                                    {
                                                                                        if (cboProvinciaDomicilio.Text.CompareTo("SELECCIONAR") != 0)
                                                                                        {
                                                                                            if (cboDistritoDomicilio.Text.CompareTo("SELECCIONAR") != 0)
                                                                                            {
                                                                                                if (txtDireccion.Text.CompareTo("") != 0)
                                                                                                {
                                                                                                    if (txtCorreoElectronico.Text.CompareTo("") != 0)
                                                                                                    {
                                                                                                        if (clsComun.validarCorreoElectronico(txtCorreoElectronico.Text))
                                                                                                        {
                                                                                                            return true;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            MessageBox.Show("Ingrese un correo electrónico válido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                                                                                                    MessageBox.Show("Debe ingresar la dirección del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                                    txtDireccion.Focus();
                                                                                                    return false;
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                MessageBox.Show("Debe seleccionar el distrito de domicilio del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                                cboDistritoDomicilio.Focus();
                                                                                                return false;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            MessageBox.Show("Debe seleccionar la provincia de domicilio del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                            cboProvinciaDomicilio.Focus();
                                                                                            return false;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        MessageBox.Show("Debe seleccionar el departamento de domicilio del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                        cboDepartamentoDomicilio.Focus();
                                                                                        return false;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    MessageBox.Show("Debe seleccionar el distrito de nacimiento del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                    cboDistrito.Focus();
                                                                                    return false;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                MessageBox.Show("Debe seleccionar la provincia de nacimiento del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                cboProvincia.Focus();
                                                                                return false;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("Debe seleccionar el departamento de nacimiento del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                            cboDepartamento.Focus();
                                                                            return false;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Debe seleccionar el pais de nacimiento del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                        cboPais.Focus();
                                                                        return false;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Debe seleccionar el perfil del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                    cboPerfil.Focus();
                                                                    return false;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("El CMP debe tener 5 dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                txtCMP.Focus();
                                                                return false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Debe ingresar el CMP del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                            txtCMP.Focus();
                                                            return false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Debe seleccionar la especialidad del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                        cboEspecialidad.Focus();
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe seleccionar el área del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    cboArea.Focus();
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("El número de documento debe tener " + txtNumeroDocumento.MaxLength + " dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                txtNumeroDocumento.Focus();
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe ingresar el número de documento del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            txtNumeroDocumento.Focus();
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe seleccionar el tipo de documento del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        cboTipoDocumento.Focus();
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El doctor debe de ser mayor de edad\nVerifique la fecha de nacimiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    dtpFechaNacimiento.Focus();
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe seleccionar el sexo del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                cboSexo.Focus();
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar el estado civil del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cboEstadoCivil.Focus();
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

        private void limpiarCampos()
        {
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtNombres.Clear();
            cboEstadoCivil.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;
            dtpFechaNacimiento.Value = DateTime.Now;
            cboTipoDocumento.SelectedIndex = 0;
            txtNumeroDocumento.Clear();
            cboArea.SelectedIndex = 0;
            cboEspecialidad.SelectedIndex = 0;
            txtCMP.Clear();
            cboPerfil.SelectedIndex = 0;
            cboPais.SelectedIndex = 0;
            cboDepartamento.SelectedIndex = 0;
            cboProvincia.SelectedIndex = 0;
            cboDistrito.SelectedIndex = 0;
            cboDepartamentoDomicilio.SelectedIndex = 0;
            cboProvinciaDomicilio.SelectedIndex = 0;
            cboDistritoDomicilio.SelectedIndex = 0;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreoElectronico.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarVentana())
            {
                if (clsGestorBD.up_ManDoctor(numIdDoctor, txtPaterno.Text, txtMaterno.Text, txtNombres.Text, strSexo, dtpFechaNacimiento.Value,numIdTipoDocumento, txtNumeroDocumento.Text, cboEstadoCivil.Text, cboPais.Text, cboDepartamento.Text, cboProvincia.Text, cboDistrito.Text,cboDepartamentoDomicilio.Text, cboProvinciaDomicilio.Text, cboDistritoDomicilio.Text, txtDireccion.Text, txtTelefono.Text, txtCelular.Text,txtCorreoElectronico.Text, DateTime.Now, "PERSONAL", generarNombreUsuario(txtNombres.Text, txtPaterno.Text, txtMaterno.Text ), clsComun.generarContrasenaAleatoria(10), "DOCTOR", numIdPerfil, txtCMP.Text, "X", numIdArea, numIdEspecialidad, "ACTIVO", numAccion))
                {
                    if (numAccion == clsGestorBD.INSERT)
                    {
                        if (MessageBox.Show("El doctor se registró exitosamente\n¿Desea seguir registrando doctores?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            limpiarCampos();
                        }
                        else
                        {
                            //limpiarCampos();

                            //DataTable dtTemporal = clsGestorBD.up_SelEspecialidad(0, "", "", clsGestorBD.SELECTALL);

                            //llenarGrilla(dtTemporal);

                            clsComun.tabAnterior(tbcDoctor, tbpBuscar, tbpDetalle);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El doctor se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //limpiarCampos();

                        //DataTable dtTemporal = clsGestorBD.up_SelEspecialidad(0, "", "", clsGestorBD.SELECTALL);

                        //llenarGrilla(dtTemporal);

                        clsComun.tabAnterior(tbcDoctor, tbpBuscar, tbpDetalle);
                    }
                }
                else
                {
                    if (numAccion == clsGestorBD.INSERT)
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba registrar el doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba actualizar el doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcDoctor, tbpBuscar, tbpDetalle);

            clsComun.redimensionarTabControl(tbcDoctor, 572, 416);
            clsComun.redimensionarVentana(this, 578, 444);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clsComun.tabSiguiente(tbcDoctor, tbpBuscar, tbpDetalle);

            txtPaterno.Focus();

            clsComun.redimensionarTabControl(tbcDoctor, 784, 416);
            clsComun.redimensionarVentana(this, 791, 444);

            numAccion = clsGestorBD.INSERT;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count > 0)
            {
                clsComun.redimensionarTabControl(tbcDoctor, 784, 416);
                clsComun.redimensionarVentana(this, 791, 444);

                numAccion = clsGestorBD.VER;
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
                clsComun.redimensionarTabControl(tbcDoctor, 784, 416);
                clsComun.redimensionarVentana(this, 791, 444);

                numAccion = clsGestorBD.UPDATE;
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

        private void tbcDoctor_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcDoctor.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtNumeroDocumento.Clear();

                if (cboTipoDocumento.SelectedIndex >= 0 && cboTipoDocumento.Text.CompareTo("SELECCIONAR") != 0)
                {
                    numIdTipoDocumento = ((clsTipoDocumento)(cboTipoDocumento.SelectedItem)).NumIdTipoDocumento;
                    txtNumeroDocumento.MaxLength = ((clsTipoDocumento)cboTipoDocumento.SelectedItem).NumNumeroDigitos;
                    txtNumeroDocumento.Enabled = true;
                }
                else
                {
                    txtNumeroDocumento.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboPais.SelectedIndex >= 0 && cboPais.Text.CompareTo("SELECCIONAR") != 0)
                {
                    if (cboPais.Text.CompareTo("PERU") == 0)
                    {
                        cboDepartamento.Enabled = true;
                        cboProvincia.Enabled = true;
                        cboDistrito.Enabled = true;

                        cboDepartamento.SelectedIndex = 0;
                    }
                    else
                    {
                        cboDepartamento.Enabled = false;
                        cboProvincia.Enabled = false;
                        cboDistrito.Enabled = false;

                        cboDepartamento.SelectedIndex = -1;
                    }
                }
                else
                {
                    cboDepartamento.Enabled = false;
                    cboProvincia.Enabled = false;
                    cboDistrito.Enabled = false;

                    cboDepartamento.SelectedIndex = -1;
                    cboProvincia.SelectedIndex = -1;
                    cboDistrito.SelectedIndex = -1;
                }
            }
            catch
            {
            }
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboDepartamento.SelectedIndex > 0)
                {
                    string strCodigoDepartamento = ((clsUbigeo)cboDepartamento.SelectedItem).StrCodigoDepartamento;

                    List<clsUbigeo> lstProvincias = clsGestorLogico.up_SelProvincia(strCodigoDepartamento);

                    llenarComboProvincia(lstProvincias);

                    cboProvincia.SelectedIndex = 0;
                }
                else
                {
                    cboProvincia.SelectedIndex = -1;
                }
            }
            catch
            {
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboProvincia.SelectedIndex > 0)
                {
                    string strCodigoDepartamento = ((clsUbigeo)cboDepartamento.SelectedItem).StrCodigoDepartamento;
                    string strCodigoProvincia = ((clsUbigeo)cboProvincia.SelectedItem).StrCodigoProvincia;

                    List<clsUbigeo> lstDistritos = clsGestorLogico.up_SelDistrito(strCodigoDepartamento, strCodigoProvincia);

                    llenarComboDistrito(lstDistritos);

                    cboDistrito.SelectedIndex = 0;
                }
                else
                {
                    cboDistrito.SelectedIndex = -1;
                }
            }
            catch
            {
            }
        }

        private void cboDepartamentoDomicilio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboDepartamentoDomicilio.SelectedIndex > 0)
                {
                    string strCodigoDepartamento = ((clsUbigeo)cboDepartamentoDomicilio.SelectedItem).StrCodigoDepartamento;

                    List<clsUbigeo> lstProvincias = clsGestorLogico.up_SelProvincia(strCodigoDepartamento);

                    llenarComboProvinciaDomicilio(lstProvincias);

                    cboProvinciaDomicilio.SelectedIndex = 0;
                }
                else
                {
                    cboProvinciaDomicilio.SelectedIndex = -1;
                }
            }
            catch
            {
            }
        }

        private void cboProvinciaDomicilio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboProvinciaDomicilio.SelectedIndex > 0)
                {
                    string strCodigoDepartamento = ((clsUbigeo)cboDepartamentoDomicilio.SelectedItem).StrCodigoDepartamento;
                    string strCodigoProvincia = ((clsUbigeo)cboProvinciaDomicilio.SelectedItem).StrCodigoProvincia;

                    List<clsUbigeo> lstDistritos = clsGestorLogico.up_SelDistrito(strCodigoDepartamento, strCodigoProvincia);

                    llenarComboDistritoDomicilio(lstDistritos);

                    cboDistritoDomicilio.SelectedIndex = 0;
                }
                else
                {
                    cboDistritoDomicilio.SelectedIndex = -1;
                }
            }
            catch
            {
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            numAccion = clsGestorBD.RECOVER;
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            numAccion = clsGestorBD.DELETE;
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSexo.SelectedIndex == 0)
            {
                strSexo = "M";
            }
            else
            {
                strSexo = "F";
            }
        }

        private void cboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPerfil.SelectedIndex > 0)
            {
                numIdPerfil = ((clsPerfil)cboPerfil.SelectedItem).NumIdPerfil;
            }
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboArea.SelectedIndex > 0)
            {
                numIdArea = ((clsArea)cboArea.SelectedItem).NumIdArea;
            }
        }

        private void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEspecialidad.SelectedIndex > 0)
            {
                numIdEspecialidad = ((clsEspecialidad)cboEspecialidad.SelectedItem).NumIdEspecialidad;
            }
        }
    }
}
