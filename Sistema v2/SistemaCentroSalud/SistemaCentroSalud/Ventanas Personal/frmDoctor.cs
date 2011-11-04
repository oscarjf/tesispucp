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
            //cargarComboPais();
            //cargarCombosDepartamento();
            //cargarComboArea();
            //cargarComboPerfil();

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

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objUbigeo = new clsUbigeo();

                objUbigeo.IdUbigeo = Int32.Parse(dt.Rows[i]["IdUbigeo"].ToString());
                objUbigeo.CodDepartamento = dt.Rows[i]["CodDepartamento"].ToString();
                objUbigeo.Descripcion = dt.Rows[i]["Descripcion"].ToString();

                cboDepartamento.Items.Add(objUbigeo);
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

        //private void cargarGrilla()
        //{
        //    dgvEspecialidades.DataMember = null;

        //    for (int i = 0; i < dtEspecialidades.Rows.Count; i++)
        //    {
        //        dgvEspecialidades.Rows.Add(new String[] { dtEspecialidades.Rows[i]["IdEspecialidad"].ToString(), 
        //                                         dtEspecialidades.Rows[i]["Nombre"].ToString(),
        //                                         dtEspecialidades.Rows[i]["Area"].ToString(), 
        //                                         dtEspecialidades.Rows[i]["Estado"].ToString() });

        //        if (dtEspecialidades.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
        //        {
        //            dgvEspecialidades.Rows[i].Cells[1].Style.ForeColor = Color.White;
        //            dgvEspecialidades.Rows[i].Cells[1].Style.BackColor = Color.Red;
        //            dgvEspecialidades.Rows[i].Cells[2].Style.ForeColor = Color.White;
        //            dgvEspecialidades.Rows[i].Cells[2].Style.BackColor = Color.Red;
        //            dgvEspecialidades.Rows[i].Cells[3].Style.ForeColor = Color.White;
        //            dgvEspecialidades.Rows[i].Cells[3].Style.BackColor = Color.Red;
        //        }
        //    }

        //    dgvEspecialidades.ClearSelection();
        //}

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

        //private void mostrarInformacion(clsEspecialidad objEspecialidad, int numAccion)
        //{
        //    if (numAccion != clsComun.INSERTAR)
        //    {
        //        txtNombreDetalle.Text = objEspecialidad.Nombre;

        //        int i;
        //        for (i = 0; i < cboAreaDetalle.Items.Count; i++)
        //        {
        //            if (objEspecialidad.IdArea == ((clsArea)cboAreaDetalle.Items[i]).IdArea)
        //            {
        //                break;
        //            }
        //        }
        //        cboAreaDetalle.SelectedIndex = i;
        //        rtxtDescripcionDetalle.Text = objEspecialidad.Descripcion;
        //    }

        //    if (numAccion == clsComun.VER)
        //    {
        //        txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
        //        cboAreaDetalle.Enabled = false;
        //        rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;

        //        btnCancelar.Visible = false;
        //        btnGuardar.Text = "Volver";
        //    }
        //    else
        //    {
        //        txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
        //        cboAreaDetalle.Enabled = true;
        //        rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;

        //        btnCancelar.Visible = true;
        //        btnGuardar.Text = "Guardar";
        //    }

        //    clsComun.tabSiguiente(tbcEspecialidad, tbpBuscar, tbpDetalle);
        //}

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
    }
}
