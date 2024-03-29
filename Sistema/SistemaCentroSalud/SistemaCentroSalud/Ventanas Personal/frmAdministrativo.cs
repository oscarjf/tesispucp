﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comun;
using Control;
using Logica;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Personal
{
    public partial class frmAdministrativo : Form
    {
        DataTable dtAdministrativo;
        private int numIdAdministrativo = 0;
        private int numAccion = 0;
        private string strSexo; //M:Masculino, F:Femenino
        private int numIdTipoDocumento = 0;
        private int numIdPerfil = 0;
        private int numIdArea = 0;
        
        public frmAdministrativo()
        {
            InitializeComponent();
            clsComun.redimensionarVentana(this, 480, 444);            
        }

        private void frmAdministrativo_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            inicializarVentana();
            dtAdministrativo = clsGestorBD.up_SelAdministrativo(0, "", "", "", "", "", clsGestorBD.SELECTALL);
            llenarGrilla(dtAdministrativo);
        }

        private void llenarGrilla(DataTable dtTabla)
        {
            dgvAdministrativos.DataMember = null;
            //dgvDoctores.Rows.Clear();

            for (int i = 0; i < dtTabla.Rows.Count; i++)
            {
                string strIdAdministrativo = dtTabla.Rows[i][0].ToString();
                string strPaterno = dtTabla.Rows[i][1].ToString();
                string strMaterno = dtTabla.Rows[i][2].ToString();
                string strNombres = dtTabla.Rows[i][3].ToString();
                string strArea = dtTabla.Rows[i][4].ToString();
                string strEstadoAdministrativo = dtTabla.Rows[i][5].ToString();

                string[] strFila = { strIdAdministrativo, strPaterno, strMaterno, strNombres, strArea, strEstadoAdministrativo };

                dgvAdministrativos.Rows.Add(strFila);

                if (strEstadoAdministrativo.CompareTo("INACTIVO") == 0)
                {
                    dgvAdministrativos.Rows[i].Cells[0].Style.ForeColor = Color.White;
                    dgvAdministrativos.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    dgvAdministrativos.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvAdministrativos.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvAdministrativos.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvAdministrativos.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvAdministrativos.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvAdministrativos.Rows[i].Cells[3].Style.BackColor = Color.Red;
                    dgvAdministrativos.Rows[i].Cells[4].Style.ForeColor = Color.White;
                    dgvAdministrativos.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    dgvAdministrativos.Rows[i].Cells[5].Style.ForeColor = Color.White;
                    dgvAdministrativos.Rows[i].Cells[5].Style.BackColor = Color.Red;
                }
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
            cboPerfil.SelectedIndex = 0;
            cboPais.SelectedIndex = 0;
            cboDepartamento.SelectedIndex = 0;
            if (cboProvincia.Items.Count != 0) cboProvincia.SelectedIndex = -1;
            if (cboDistrito.Items.Count != 0) cboDistrito.SelectedIndex = -1;

            cboDepartamentoDomicilio.SelectedIndex = 0;
            if (cboProvinciaDomicilio.Items.Count != 0) cboProvinciaDomicilio.SelectedIndex = -1;
            if (cboDistritoDomicilio.Items.Count != 0) cboDistritoDomicilio.SelectedIndex = -1;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreoElectronico.Clear();
        }

        private void mostrarDatos(int numAccion, DataTable dtEnfermera)
        {
            txtPaterno.Text = dtEnfermera.Rows[0][1].ToString();
            txtMaterno.Text = dtEnfermera.Rows[0][2].ToString();
            txtNombres.Text = dtEnfermera.Rows[0][3].ToString();
            cboEstadoCivil.Text = dtEnfermera.Rows[0][4].ToString();
            if (dtEnfermera.Rows[0][5].ToString().CompareTo("M") == 0)
            {
                cboSexo.SelectedIndex = 1;
            }
            else
            {
                cboSexo.SelectedIndex = 2;
            }
            dtpFechaNacimiento.Text = dtEnfermera.Rows[0][6].ToString();
            cboTipoDocumento.Text = dtEnfermera.Rows[0][7].ToString();
            txtNumeroDocumento.Text = dtEnfermera.Rows[0][8].ToString();
            cboArea.Text = dtEnfermera.Rows[0][9].ToString();
            cboPerfil.Text = dtEnfermera.Rows[0][10].ToString();
            txtTelefono.Text = dtEnfermera.Rows[0][11].ToString();
            txtCelular.Text = dtEnfermera.Rows[0][12].ToString();
            txtCorreoElectronico.Text = dtEnfermera.Rows[0][13].ToString();
            cboDepartamentoDomicilio.Text = dtEnfermera.Rows[0][14].ToString();
            cboProvinciaDomicilio.Text = dtEnfermera.Rows[0][15].ToString();
            cboDistritoDomicilio.Text = dtEnfermera.Rows[0][16].ToString();
            txtDireccion.Text = dtEnfermera.Rows[0][17].ToString();
            cboPais.Text = dtEnfermera.Rows[0][18].ToString();
            cboDepartamento.Text = dtEnfermera.Rows[0][19].ToString();
            cboProvincia.Text = dtEnfermera.Rows[0][20].ToString();
            cboDistrito.Text = dtEnfermera.Rows[0][21].ToString();

            if (numAccion == clsGestorBD.VER)
            {
                txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboEstadoCivil.Enabled = false;
                cboSexo.Enabled = false;
                dtpFechaNacimiento.Enabled = false;
                cboTipoDocumento.Enabled = false;
                txtNumeroDocumento.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboArea.Enabled = false;
                cboPerfil.Enabled = false;
                txtTelefono.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtCelular.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtCorreoElectronico.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboDepartamentoDomicilio.Enabled = false;
                cboProvinciaDomicilio.Enabled = false;
                cboDistritoDomicilio.Enabled = false;
                txtDireccion.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboPais.Enabled = false;
                cboDepartamento.Enabled = false;
                cboProvincia.Enabled = false;
                cboDistrito.Enabled = false;
            }
            else
            {
                txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboEstadoCivil.Enabled = true;
                cboSexo.Enabled = true;
                dtpFechaNacimiento.Enabled = true;
                cboTipoDocumento.Enabled = true;
                txtNumeroDocumento.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboArea.Enabled = true;
                cboPerfil.Enabled = true;
                txtTelefono.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtCelular.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtCorreoElectronico.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboDepartamentoDomicilio.Enabled = true;
                cboProvinciaDomicilio.Enabled = true;
                cboDistritoDomicilio.Enabled = true;
                txtDireccion.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboPais.Enabled = true;
                cboDepartamento.Enabled = true;
                cboProvincia.Enabled = true;
                cboDistrito.Enabled = true;
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
                                            //if (validarNumeroDocumento(txtNumeroDocumento.Text))
                                            //{
                                            if (cboArea.Text.CompareTo("SELECCIONAR") != 0)
                                            {
                                                //if (cboEspecialidad.Text.CompareTo("SELECCIONAR") != 0)
                                                //{
                                                //if (txtNumeroLicenciatura.Text.CompareTo("") != 0)
                                                //{
                                                //if (txtNumeroLicenciatura.Text.Length == 5)
                                                //{
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
                                                                                        MessageBox.Show("Debe ingresar el correo electrónico del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                        txtCorreoElectronico.Focus();
                                                                                        return false;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    MessageBox.Show("Debe ingresar la dirección del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                    txtDireccion.Focus();
                                                                                    return false;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                MessageBox.Show("Debe seleccionar el distrito de domicilio del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                                cboDistritoDomicilio.Focus();
                                                                                return false;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("Debe seleccionar la provincia de domicilio del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                            cboProvinciaDomicilio.Focus();
                                                                            return false;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Debe seleccionar el departamento de domicilio del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                        cboDepartamentoDomicilio.Focus();
                                                                        return false;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Debe seleccionar el distrito de nacimiento del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                    cboDistrito.Focus();
                                                                    return false;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Debe seleccionar la provincia de nacimiento del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                cboProvincia.Focus();
                                                                return false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Debe seleccionar el departamento de nacimiento del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                            cboDepartamento.Focus();
                                                            return false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Debe seleccionar el pais de nacimiento del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                        cboPais.Focus();
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Debe seleccionar el perfil del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    cboPerfil.Focus();
                                                    return false;
                                                }
                                                //}
                                                //else
                                                //{
                                                //    MessageBox.Show("El número de licenciatura debe tener 5 dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                //    txtNumeroLicenciatura.Focus();
                                                //    return false;
                                                //}
                                                //}
                                                //else
                                                //{
                                                //    MessageBox.Show("Debe ingresar el número de licenciatura de la enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                //    txtNumeroLicenciatura.Focus();
                                                //    return false;
                                                //}
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
                                                MessageBox.Show("Debe seleccionar el área del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                cboArea.Focus();
                                                return false;
                                            }
                                            //}
                                            //else
                                            //{
                                            //    MessageBox.Show("El número de documento debe tener " + txtNumeroDocumento.MaxLength + " dígitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            //    txtNumeroDocumento.Focus();
                                            //    return false;
                                            //}
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe ingresar el número de documento del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            txtNumeroDocumento.Focus();
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe seleccionar el tipo de documento del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        cboTipoDocumento.Focus();
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El administrativo debe de ser mayor de edad\nVerifique la fecha de nacimiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    dtpFechaNacimiento.Focus();
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe seleccionar el sexo del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                cboSexo.Focus();
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar el estado civil del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cboEstadoCivil.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar el nombre del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNombres.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el apellido materno del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaterno.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el apellido paterno del administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPaterno.Focus();
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

        private void inicializarVentana()
        {
            cboSexo.SelectedIndex = 0;
            cboEstadoCivil.SelectedIndex = 0;

            List<clsTipoDocumento> lstTipoDocumentos = clsGestorLogico.up_SelTipoDocumento();
            llenarComboTipoDocumento(lstTipoDocumentos);
            cboTipoDocumento.SelectedIndex = 0;

            List<clsArea> lstAreas = clsGestorLogico.up_SelArea("ADMINISTRATIVA", "ACTIVO");
            llenarComboArea(lstAreas);
            cboArea.SelectedIndex = 0;

            List<clsPais> lstPaises = clsGestorLogico.up_SelPais();
            llenarComboPais(lstPaises);
            cboPais.SelectedIndex = 0;

            List<clsUbigeo> lstDepartamentos = clsGestorLogico.up_SelDepartamento();
            llenarComboDepartamento(lstDepartamentos);

            List<clsPerfil> lstPerfiles = clsGestorLogico.up_SelPerfilEnfermera();
            llenarComboPerfil(lstPerfiles);
            cboPerfil.SelectedIndex = 0;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clsComun.tabSiguiente(tbcAdministrativo, tbpBuscar, tbpDetalle);

            txtPaterno.Focus();
            clsComun.redimensionarTabControl(tbcAdministrativo, 784, 416);
            clsComun.redimensionarVentana(this, 791, 443);
            numAccion = clsGestorBD.INSERT;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvAdministrativos.SelectedRows.Count > 0)
            {
                try
                {
                    clsComun.redimensionarTabControl(tbcAdministrativo, 784, 416);
                    clsComun.redimensionarVentana(this, 791, 444);

                    numAccion = clsGestorBD.VER;

                    numIdAdministrativo = Int32.Parse(dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[0].Value.ToString());

                    DataTable dtAdministrativo = clsGestorBD.up_SelAdministrativo(numIdAdministrativo, "", "", "", "", "", clsGestorBD.SELECT);

                    mostrarDatos(numAccion, dtAdministrativo);

                    clsComun.tabSiguiente(tbcAdministrativo, tbpBuscar, tbpDetalle);
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un técnico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAdministrativos.SelectedRows.Count > 0)
            {
                try
                {
                    clsComun.redimensionarTabControl(tbcAdministrativo, 784, 416);
                    clsComun.redimensionarVentana(this, 791, 444);

                    numAccion = clsGestorBD.UPDATE;

                    numIdAdministrativo = Int32.Parse(dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[0].Value.ToString());

                    DataTable dtAdministrativo = clsGestorBD.up_SelAdministrativo(numIdAdministrativo, "", "", "", "", "", clsGestorBD.SELECT);

                    mostrarDatos(numAccion, dtAdministrativo);

                    clsComun.tabSiguiente(tbcAdministrativo, tbpBuscar, tbpDetalle);
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un técnico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            DataTable dtTemporal = clsGestorBD.up_SelAdministrativo(0, "", "", "", "", "", clsGestorBD.SELECTALL);
            llenarGrilla(dtTemporal);

            clsComun.tabAnterior(tbcAdministrativo, tbpBuscar, tbpDetalle);
            clsComun.redimensionarTabControl(tbcAdministrativo, 572, 416);
            clsComun.redimensionarVentana(this, 572, 443);
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

        private void tbcAdministrativo_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcAdministrativo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcAdministrativo.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarVentana())
            {
                if (clsGestorBD.up_ManAdministrativo(numIdAdministrativo, txtPaterno.Text, txtMaterno.Text, txtNombres.Text, strSexo, dtpFechaNacimiento.Value, numIdTipoDocumento, txtNumeroDocumento.Text, cboEstadoCivil.Text, cboPais.Text, cboDepartamento.Text, cboProvincia.Text, cboDistrito.Text, cboDepartamentoDomicilio.Text, cboProvinciaDomicilio.Text, cboDistritoDomicilio.Text, txtDireccion.Text, txtTelefono.Text, txtCelular.Text, txtCorreoElectronico.Text, DateTime.Now, "PERSONAL", generarNombreUsuario(txtNombres.Text, txtPaterno.Text, txtMaterno.Text), clsComun.generarContrasenaAleatoria(10), "TECNICO", numIdPerfil, numIdArea, "ACTIVO", numAccion))
                {
                    if (numAccion == clsGestorBD.INSERT)
                    {
                        if (MessageBox.Show("El Administrativo se registró exitosamente\n¿Desea seguir registrando administrativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            limpiarCampos();
                        }
                        else
                        {
                            limpiarCampos();

                            DataTable dtTemporal = clsGestorBD.up_SelAdministrativo(0, "", "", "", "", "", clsGestorBD.SELECTALL);

                            llenarGrilla(dtTemporal);

                            clsComun.tabAnterior(tbcAdministrativo, tbpBuscar, tbpDetalle);
                            clsComun.redimensionarTabControl(tbcAdministrativo, 572, 416);
                            clsComun.redimensionarVentana(this, 578, 444);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Administrativo se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCampos();

                        DataTable dtTemporal = clsGestorBD.up_SelAdministrativo(0, "", "", "", "", "", clsGestorBD.SELECTALL);

                        llenarGrilla(dtTemporal);

                        clsComun.tabAnterior(tbcAdministrativo, tbpBuscar, tbpDetalle);
                        clsComun.redimensionarTabControl(tbcAdministrativo, 572, 416);
                        clsComun.redimensionarVentana(this, 578, 444);
                    }
                }
                else
                {
                    if (numAccion == clsGestorBD.INSERT)
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba registrar al Administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba actualizar al Administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSexo.SelectedIndex == 1)
            {
                strSexo = "M";
            }
            if (cboSexo.SelectedIndex == 2)
            //else
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

        private void dgvAdministrativos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[5].Value.ToString().CompareTo("ACTIVO") == 0)
            {
                btnInactivar.Visible = true;
                btnActivar.Visible = false;
            }
            else
            {
                btnInactivar.Visible = false;
                btnActivar.Visible = true;
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvAdministrativos.RowCount > 0)
            {
                try
                {
                    numIdAdministrativo = Int32.Parse(dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[0].Value.ToString());
                    if (clsGestorBD.up_ManAdministrativo(numIdAdministrativo, "", "", "", "", dtpFechaNacimiento.Value, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", DateTime.Now, "", "", "", "", 0, 0, "", clsGestorBD.RECOVER))
                    {
                        MessageBox.Show("El Administrativo se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCampos();

                        DataTable dtTemporal = clsGestorBD.up_SelAdministrativo(0, "", "", "", "", "", clsGestorBD.SELECTALL);
                        llenarGrilla(dtTemporal);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba activar al administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            if (dgvAdministrativos.RowCount > 0)
            {
                try
                {
                    numIdAdministrativo = Int32.Parse(dgvAdministrativos.Rows[dgvAdministrativos.CurrentRow.Index].Cells[0].Value.ToString());
                    if (clsGestorBD.up_ManAdministrativo(numIdAdministrativo, "", "", "", "", dtpFechaNacimiento.Value, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", DateTime.Now, "", "", "", "", 0, 0, "", clsGestorBD.DELETE))
                    {
                        MessageBox.Show("El Administrativo se inactivó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarCampos();

                        DataTable dtTemporal = clsGestorBD.up_SelAdministrativo(0, "", "", "", "", "", clsGestorBD.SELECTALL);
                        llenarGrilla(dtTemporal);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba inactivar al administrativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                }
            }
        }
    }
}
