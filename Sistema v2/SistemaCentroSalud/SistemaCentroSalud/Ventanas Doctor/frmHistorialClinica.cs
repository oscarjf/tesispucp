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

namespace SistemaCentroSalud.Ventanas_Doctor
{
    public partial class frmHistorialClinica : Form
    {
        private frmPrincipal ventanaPrincipal;
        private DataTable dtPacientes;
        private DataTable dtEpisodios;
        private int numAccion;
        private int numIdPaciente;
        private int numIdEmpleado;
        private int numIdHistoriaClinica;
        private string strGrupoSanguineo;
        private string strFactorSanguineo;

        public frmHistorialClinica(bool blnHistoriaClinicaCompleta, int idUsuario, frmPrincipal ventanaPrincipal)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventanaPrincipal;
            numIdEmpleado = ventanaPrincipal.getIdEmpleado();
        }

        private void frmHistorialClinica_Load(object sender, EventArgs e)
        {
            //cargarComboModoIngreso();
            cargarComboTipoDocumento();
            cargarComboEtnia();
            cargarComboReligion();
            cargarComboOcupacion();
            cargarComboIdioma();

            cargarComboPais();
            cargarCombosDepartamento();

            cboTipoDocumentoBuscar.SelectedIndex = 0;
            cboEtnia.SelectedIndex = 0;
            cboReligion.SelectedIndex = 0;
            cboOcupacion.SelectedIndex = 0;
            cboIdioma.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;
            cboEstadoCivil.SelectedIndex = 0;
            cboGrupoSanguineo.SelectedIndex = 0;
            cboFactorSanguineo.SelectedIndex = 0;

            cboPais.SelectedIndex = 0;
            cboDepartamentoDomicilio.SelectedIndex = 0;
        }

        private void cargarComboEtnia()
        {
            clsEtnia objEtnia = new clsEtnia();

            DataTable dt = ctrEtnia.seleccionarEtniasCriterios(objEtnia);

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

            DataTable dt = ctrReligion.seleccionarReligionesCriterios(objReligion);

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

            DataTable dt = ctrOcupacion.seleccionarOcupacionesCriterios(objOcupacion);

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

            DataTable dt = ctrIdioma.seleccionarIdiomasCriterios(objIdioma);

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
                objTipoDocumento.NumeroDigitos = dt.Rows[i]["NUMERODIGITOS"].ToString();

                cboTipoDocumentoBuscar.Items.Add(objTipoDocumento);
            }
        }

        private void cargarComboPais()
        {
            clsPais objPais = new clsPais();

            DataTable dt = ctrPais.seleccionarPaisesCriterios(objPais);

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

            dgvHistoriasClinicas.DataMember = null;

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

                    dgvHistoriasClinicas.Rows.Add(new String[] { dtPacientes.Rows[i]["IdHistoriaClinica"].ToString(),
                                                                 dtPacientes.Rows[i]["NumeroHistoriaClinica"].ToString(), 
                                                                 dtPacientes.Rows[i]["Paterno"].ToString(),
                                                                 dtPacientes.Rows[i]["Materno"].ToString(),
                                                                 dtPacientes.Rows[i]["Nombres"].ToString(),
                                                                 strTipoDocumento,
                                                                 dtPacientes.Rows[i]["NumeroDocumento"].ToString(),
                                                                 strGrupoSanguineo,
                                                                 strFactorSanguineo,
                                                                 dtPacientes.Rows[i]["IdPersona"].ToString() });
                }
            }

            dgvHistoriasClinicas.ClearSelection();
        }

        private void cargarGrillaEpisodios()
        {
            dgvEpisodios.DataMember = null;

            for (int i = 0; i < dtEpisodios.Rows.Count; i++)
            {
                string strTitulo = dtEpisodios.Rows[i]["TipoEmpleado"].ToString();

                if (strTitulo.CompareTo("DOCTOR") == 0)
                {
                    strTitulo = "DR. ";
                }
                else if (strTitulo.CompareTo("ENFERMERO") == 0)
                {
                    strTitulo = "ENF. ";
                }
                else if (strTitulo.CompareTo("TÉCNICO") == 0)
                {
                    strTitulo = "TEC. ";
                }
                else
                {
                    strTitulo = "";
                }

                dgvEpisodios.Rows.Add(new String[] { dtEpisodios.Rows[i]["IdEpisodio"].ToString(),
                                                     ((DateTime)dtEpisodios.Rows[i]["FechaRegistro"]).ToShortDateString(),
                                                     ((DateTime)dtEpisodios.Rows[i]["FechaRegistro"]).ToShortTimeString(),
                                                     strTitulo + dtEpisodios.Rows[i]["Responsable"].ToString() });
            }

            dgvEpisodios.ClearSelection();
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

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = clsComun.calcularEdad(dtpFechaNacimiento.Value).ToString();
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

        private void dgvHistoriasClinicas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistoriasClinicas.SelectedRows.Count > 0)
            {
                dtEpisodios = ctrHistoriaClinica.seleccionarEpisodios(Int32.Parse(dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[9].Value.ToString()));

                cargarGrillaEpisodios();
            }
        }
    }
}
