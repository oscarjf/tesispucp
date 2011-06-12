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

namespace SistemaCentroSalud.Ventanas_Personal
{
    public partial class frmEnfermera : Form
    {
        public frmEnfermera()
        {
            InitializeComponent();
        }

        private void frmEnfermera_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            inicializarVentana();
        }

        private void inicializarVentana()
        {
            cboSexo.SelectedIndex = 0;

            List<clsTipoDocumento> lstTipoDocumentos = clsGestorLogico.up_SelTipoDocumento();
            llenarComboTipoDocumento(lstTipoDocumentos);
            cboTipoDocumento.SelectedIndex = 0;

            List<clsArea> lstAreas = clsGestorLogico.up_SelArea("Administrativa","ACTIVO");
            llenarComboArea(lstAreas);
            cboArea.SelectedIndex = 0;

            List<clsPais> lstPaises = clsGestorLogico.up_SelPais();
            llenarComboPais(lstPaises);
            cboPais.SelectedIndex = 0;

            List<clsUbigeo> lstDepartamentos = clsGestorLogico.up_SelDepartamento();
            llenarComboDepartamento(lstDepartamentos);

            cboSexo.SelectedIndex = 0;
            cboEstadoCivil.SelectedIndex = 0;            
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

        /// Perfil

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
                                                    //if (cboEspecialidad.Text.CompareTo("SELECCIONAR") != 0)
                                                    //{
                                                        if (txtNumeroLicenciatura.Text.CompareTo("") != 0)
                                                        {
                                                            if (txtNumeroLicenciatura.Text.Length == 5)
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
                                                                                                        MessageBox.Show("Debe ingresar el correo electrónico de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                                        txtCorreoElectronico.Focus();
                                                                                                        return false;
                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    MessageBox.Show("Debe ingresar la dirección de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                                    txtDireccion.Focus();
                                                                                                    return false;
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                MessageBox.Show("Debe seleccionar el distrito de domicilio de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                                cboDistritoDomicilio.Focus();
                                                                                                return false;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            MessageBox.Show("Debe seleccionar la provincia de domicilio de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                            cboProvinciaDomicilio.Focus();
                                                                                            return false;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        MessageBox.Show("Debe seleccionar el departamento de domicilio de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                        cboDepartamentoDomicilio.Focus();
                                                                                        return false;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    MessageBox.Show("Debe seleccionar el distrito de nacimiento de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                    cboDistrito.Focus();
                                                                                    return false;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                MessageBox.Show("Debe seleccionar la provincia de nacimiento de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                cboProvincia.Focus();
                                                                                return false;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("Debe seleccionar el departamento de nacimiento de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                            cboDepartamento.Focus();
                                                                            return false;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Debe seleccionar el pais de nacimiento de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                        cboPais.Focus();
                                                                        return false;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Debe seleccionar el perfil de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                    cboPerfil.Focus();
                                                                    return false;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("El número de licenciatura debe tener 5 dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                txtNumeroLicenciatura.Focus();
                                                                return false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Debe ingresar el número de licenciatura de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                            txtNumeroLicenciatura.Focus();
                                                            return false;
                                                        }
                                                    //}
                                                    //else
                                                    //{
                                                    //    MessageBox.Show("Debe seleccionar la especialidad del doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    //    cboEspecialidad.Focus();
                                                    //    return false;
                                                    //}
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe seleccionar el área de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                                            MessageBox.Show("Debe ingresar el número de documento de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            txtNumeroDocumento.Focus();
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe seleccionar el tipo de documento de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        cboTipoDocumento.Focus();
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La enfermera debe de ser mayor de edad\nVerifique la fecha de nacimiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    dtpFechaNacimiento.Focus();
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe seleccionar el sexo de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                cboSexo.Focus();
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar el estado civil de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cboEstadoCivil.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar el nombre de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombres.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el apellido materno de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaterno.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el apellido paterno de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPaterno.Focus();
                return false;
            }
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clsComun.tabSiguiente(tbcEnfermera, tbpBuscar, tbpDetalle);

            txtPaterno.Focus();
            clsComun.redimensionarTabControl(tbcEnfermera, 784, 416);
            clsComun.redimensionarVentana(this, 791, 443);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvEnfermeras.SelectedRows.Count > 0)
            {
                clsComun.redimensionarTabControl(tbcEnfermera, 784, 416);
                clsComun.redimensionarVentana(this, 791, 443);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEnfermeras.SelectedRows.Count > 0)
            {
                clsComun.redimensionarTabControl(tbcEnfermera, 784, 416);
                clsComun.redimensionarVentana(this, 791, 443);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcEnfermera, tbpBuscar, tbpDetalle);

            clsComun.redimensionarTabControl(tbcEnfermera, 566, 416);
            clsComun.redimensionarVentana(this, 572, 443);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            validarVentana();
        }

        private void tbcEnfermera_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcEnfermera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcEnfermera.SelectedIndex == 1)
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
    }
}
