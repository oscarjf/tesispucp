using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Doctor
{
    public partial class frmHistorialClinica : Form
    {
        private frmPrincipal ventanaPrincipal;
        private DataTable dtPacientes;
        private DataTable dtEpisodios;
        private DataTable dtCie10;
        private string strNumeroHistoriaClinica;
        private int numAccion;
        private int numIdPaciente;
        private int numIdEmpleado;
        private int numIdHistoriaClinica;
        private int numIdAntecedentes;
        private int numIdEpisodio;
        private int numIdEnfermedad;
        private bool blnExiste = false;
        private clsEpisodio objEpisodio;

        public frmHistorialClinica(bool blnHistoriaClinicaCompleta, int idUsuario, frmPrincipal ventanaPrincipal)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventanaPrincipal;
            numIdEmpleado = ventanaPrincipal.getIdEmpleado();
        }

        private void frmHistorialClinica_Load(object sender, EventArgs e)
        {
            cargarCie10();

            cargarComboModoIngreso();
            cargarComboTipoDocumento();
            cargarComboEtnia();
            cargarComboReligion();
            cargarComboOcupacion();
            cargarComboIdioma();

            cargarComboPais();
            cargarCombosDepartamento();

            cboModoIngreso.SelectedIndex = 0;
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

            cboDiagnostico.SelectedIndex = -1;

            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
        }

        private void cargarComboModoIngreso()
        {
            clsModoIngreso objModoIngreso = new clsModoIngreso();

            DataTable dt = ctrModoIngreso.seleccionarModosIngresoCriterios(objModoIngreso);

            objModoIngreso.Nombre = "SELECCIONAR";

            cboModoIngreso.Items.Add(objModoIngreso);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objModoIngreso = new clsModoIngreso();

                objModoIngreso.IdModoIngreso = Int32.Parse(dt.Rows[i]["IdModoIngreso"].ToString());
                objModoIngreso.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboModoIngreso.Items.Add(objModoIngreso);
            }
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

        private void cargarCie10()
        {
            dtCie10 = ctrHistoriaClinica.seleccionarCie10();

            cboDiagnostico.DataSource = dtCie10;
            cboDiagnostico.DisplayMember = "Descripcion";
            cboDiagnostico.ValueMember = "IdCie10";

            for (int i = 0; i < dtCie10.Rows.Count; i++)
            {
                cboDiagnostico.AutoCompleteCustomSource.Add(dtCie10.Rows[i]["Descripcion"].ToString());
            }

            cboDiagnostico.Text = "";
        }

        private void cargarGrilla()
        {
            dgvHistoriasClinicas.DataMember = null;

            for (int i = 0; i < dtPacientes.Rows.Count; i++)
            {
                dgvHistoriasClinicas.Rows.Add(new String[] { dtPacientes.Rows[i]["IdHistoriaClinica"].ToString(),
                                                                 dtPacientes.Rows[i]["NumeroHistoriaClinica"].ToString(), 
                                                                 dtPacientes.Rows[i]["Paterno"].ToString(),
                                                                 dtPacientes.Rows[i]["Materno"].ToString(),
                                                                 dtPacientes.Rows[i]["Nombres"].ToString(),
                                                                 dtPacientes.Rows[i]["TipoDocumento"].ToString(),
                                                                 dtPacientes.Rows[i]["NumeroDocumento"].ToString(),
                                                                 dtPacientes.Rows[i]["GrupoSanguineo"].ToString(),
                                                                 dtPacientes.Rows[i]["FactorSanguineo"].ToString(),
                                                                 dtPacientes.Rows[i]["IdPersona"].ToString(),
                                                                 dtPacientes.Rows[i]["IdAntecedentes"].ToString()});
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
                                                     strTitulo + dtEpisodios.Rows[i]["Responsable"].ToString(),
                                                     dtEpisodios.Rows[i]["IdEnfermedad"].ToString()});
            }

            if (dtEpisodios.Rows.Count > 0)
            {
                if (DateTime.Now.ToShortDateString().CompareTo(((DateTime)dtEpisodios.Rows[0]["FechaRegistro"]).ToShortDateString()) == 0)
                {
                    blnExiste = true;
                    numIdEpisodio = Int32.Parse(dgvEpisodios.Rows[dgvEpisodios.CurrentRow.Index].Cells[0].Value.ToString());
                }
                else
                {
                    blnExiste = false;
                    numIdEpisodio = 0;
                }
            }

            dgvEpisodios.ClearSelection();
        }

        private void limpiarFormulario()
        {
            //FILIACION
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtNombres.Clear();
            cboSexo.SelectedIndex = 0;
            cboEtnia.SelectedIndex = 0;
            cboReligion.SelectedIndex = 0;
            cboOcupacion.SelectedIndex = 0;
            cboIdioma.SelectedIndex = 0;
            cboEstadoCivil.SelectedIndex = 0;
            dtpFechaNacimiento.Value = DateTime.Now;
            txtEdad.Text = "0";
            cboModoIngreso.SelectedIndex = 0;
            cboGrupoSanguineo.SelectedIndex = 0;
            cboFactorSanguineo.SelectedIndex = 0;
            cboPais.SelectedIndex = 0;
            cboDepartamentoDomicilio.SelectedIndex = 0;
            txtDireccion.Text = "";
            //ENFERMEDAD ACTUAL
            txtTiempoEnfermedad.Text = "";
            txtInicioEnfermedad.Text = "";
            txtCursoEnfermedad.Text = "";
            rtxtSintomasEnfermedad.Text = "";
            rtxtRelatoCronologico.Text = "";
            //ANTECEDENTES
            cbxTabaco.Checked = false;
            cbxAlcohol.Checked = false;
            cbxCafe.Checked = false;
            cbxTe.Checked = false;
            cbxDrogas.Checked = false;
            cbxDiabetes.Checked = false;
            txtDiabetes.Text = "";
            cbxHipertensionArterial.Checked = false;
            txtHipertensionArterial.Text = "";
            cbxCoronariopatia.Checked = false;
            txtCoronariopatia.Text = "";
            cbxDislipidemia.Checked = false;
            txtDislipidemia.Text = "";
            cbxAsma.Checked = false;
            txtAsma.Text = "";
            cbxPsicopatia.Checked = false;
            txtPsicopatia.Text = "";
            cbxAlergias.Checked = false;
            txtAlergias.Text = "";
            cbxTuberculosis.Checked = false;
            txtTuberculosis.Text = "";
            cbxAtipia.Checked = false;
            txtAtipia.Text = "";
            cbxGota.Checked = false;
            txtGota.Text = "";
            cbxEndocrinopatia.Checked = false;
            txtEndocrinopatia.Text = "";
            cbxNefropatia.Checked = false;
            txtNefropatia.Text = "";
            cbxUropatia.Checked = false;
            txtUropatia.Text = "";
            cbxHemopatia.Checked = false;
            txtHemopatia.Text = "";
            cbxETS.Checked = false;
            txtETS.Text = "";
            cbxUlcera.Checked = false;
            txtUlcera.Text = "";
            cbxColecistopatia.Checked = false;
            txtColecistopatia.Text = "";
            cbxHepatitis.Checked = false;
            txtHepatitis.Text = "";
            cbxEnfermedadesNeurologicas.Checked = false;
            txtEnfermedadesNeurologicas.Text = "";
            cbxFiebresProlongadas.Checked = false;
            txtFiebresProlongadas.Text = "";
            cbxColagenopatia.Checked = false;
            txtColagenopatia.Text = "";
            rtxtOtrosAntecedentes.Text = "";
            //ECTOSCOPIA
            rtxtEctoscopiaAnterior.Text = "";
            rtxtEctoscopiaActual.Text = "";
            //EXAMEN FISICO
            txtTemperatura.Text = "";
            txtFrecuenciaCardiaca.Text = "";
            txtFrecuenciaRespiratoria.Text = "";
            txtPresionArterial.Text = "";
            txtPeso.Text = "";
            txtTalla.Text = "";
            rtxtOtrosExamenes.Text = "";
            //DIAGNOSTICO
            cboDiagnostico.SelectedItem = -1;
            rtxtDiagnosticoActual.Text = "";
            dgvDiagnosticos.DataMember = null;
        }

        private bool validarPaciente()
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
                    MessageBox.Show("Debe ingresar el número de historia clínica", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumeroHistoriaClinica.Focus();
                    return false;
                }
            }
        }

        private bool validarFormulario()
        {
            return true;
        }

        private bool validarDiagnostico()
        {
            if (cboDiagnostico.Text.CompareTo("") != 0)
            {
                if (dtCie10.Select("Descripcion = '" + cboDiagnostico.Text + "'").Length > 0)
                {
                    if (rtxtDiagnosticoActual.Text.CompareTo("") != 0)
                    {
                        if (dgvDiagnosticos.RowCount > 0)
                        {
                            for (int i = 0; i < dgvDiagnosticos.RowCount; i++)
                            {
                                if (dtCie10.Rows[cboDiagnostico.SelectedIndex]["Codigo"].ToString().CompareTo(dgvDiagnosticos["colCodigo", i].Value.ToString()) == 0)
                                {
                                    MessageBox.Show("El diagnóstico ya fue ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                            }
                        }

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar la descripción del diagnóstico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Diagnóstico ingresado no se encuentra en el CIE10", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un diagnóstico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void mostrarInformacion(clsPaciente objPaciente, clsAntecedentes objAntecedentes, clsEpisodio objEpisodio, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNumeroHistoriaClinica.Text = strNumeroHistoriaClinica;

                int numIdModoIngreso = 0;

                if (objPaciente != null)
                {
                    txtPaterno.Text = objPaciente.Paterno;
                    txtMaterno.Text = objPaciente.Materno;
                    txtNombres.Text = objPaciente.Nombres;
                    if (blnExiste)
                    {
                        numIdModoIngreso = ctrModoIngreso.seleccionarModoIngreso(numIdEpisodio).IdModoIngreso;

                        for (int i = 0; i < cboModoIngreso.Items.Count; i++)
                        {
                            if (numIdModoIngreso == ((clsModoIngreso)cboModoIngreso.Items[i]).IdModoIngreso)
                            {
                                cboModoIngreso.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                    cboSexo.Text = objPaciente.Sexo;
                    dtpFechaNacimiento.Value = objPaciente.FechaNacimiento;
                    cboEtnia.Text = objPaciente._Etnia;
                    cboReligion.Text = objPaciente._Religion;
                    cboOcupacion.Text = objPaciente._Ocupacion;
                    cboIdioma.Text = objPaciente._Idioma;
                    cboEstadoCivil.Text = objPaciente.EstadoCivil;
                    dtpFechaNacimiento.Value = objPaciente.FechaNacimiento;
                    txtEdad.Text = objPaciente._NumEdad.ToString();
                    cboGrupoSanguineo.Text = objPaciente.GrupoSanguineo;
                    cboFactorSanguineo.Text = objPaciente.FactorSanguineo;
                    cboPais.Text = objPaciente.Pais;
                    cboDepartamento.Text = objPaciente.DepartamentoNacimiento;
                    cboProvincia.Text = objPaciente.ProvinciaNacimiento;
                    cboDistrito.Text = objPaciente.DistritoNacimiento;
                    cboDepartamentoDomicilio.Text = objPaciente.DepartamentoDomicilio;
                    cboProvinciaDomicilio.Text = objPaciente.ProvinciaDomicilio;
                    cboDistritoDomicilio.Text = objPaciente.DistritoDomicilio;
                    txtDireccion.Text = objPaciente.Direccion;
                }

                if (objAntecedentes != null)
                {
                    if (objAntecedentes.IndTabaco.CompareTo("X") == 0)
                    {
                        cbxTabaco.Checked = true;
                    }
                    if (objAntecedentes.IndAlcohol.CompareTo("X") == 0)
                    {
                        cbxAlcohol.Checked = true;
                    }
                    if (objAntecedentes.IndCafe.CompareTo("X") == 0)
                    {
                        cbxCafe.Checked = true;
                    }
                    if (objAntecedentes.IndTe.CompareTo("X") == 0)
                    {
                        cbxTe.Checked = true;
                    }
                    if (objAntecedentes.IndDrogas.CompareTo("X") == 0)
                    {
                        cbxDrogas.Checked = true;
                    }
                    if (objAntecedentes.IndDiabetes.CompareTo("X") == 0)
                    {
                        cbxDiabetes.Checked = true;
                    }
                    txtDiabetes.Text = objAntecedentes.DescDiabetes;
                    if (objAntecedentes.IndHipertension.CompareTo("X") == 0)
                    {
                        cbxHipertensionArterial.Checked = true;
                    }
                    txtHipertensionArterial.Text = objAntecedentes.DescHipertension;
                    if (objAntecedentes.IndCoronariopatia.CompareTo("X") == 0)
                    {
                        cbxCoronariopatia.Checked = true;
                    }
                    txtCoronariopatia.Text = objAntecedentes.DescCoronariopatia;
                    if (objAntecedentes.IndDislipidemia.CompareTo("X") == 0)
                    {
                        cbxDislipidemia.Checked = true;
                    }
                    txtDislipidemia.Text = objAntecedentes.DescDislipidemia;
                    if (objAntecedentes.IndAsma.CompareTo("X") == 0)
                    {
                        cbxAsma.Checked = true;
                    }
                    txtAsma.Text = objAntecedentes.DescAsma;
                    if (objAntecedentes.IndPsicopatia.CompareTo("X") == 0)
                    {
                        cbxPsicopatia.Checked = true;
                    }
                    txtPsicopatia.Text = objAntecedentes.DescPsicopatia;
                    if (objAntecedentes.IndAlergias.CompareTo("X") == 0)
                    {
                        cbxAlergias.Checked = true;
                    }
                    txtAlergias.Text = objAntecedentes.DescAlergias;
                    if (objAntecedentes.IndTuberculosis.CompareTo("X") == 0)
                    {
                        cbxTuberculosis.Checked = true;
                    }
                    txtTuberculosis.Text = objAntecedentes.DescTuberculosis;
                    if (objAntecedentes.IndAtipia.CompareTo("X") == 0)
                    {
                        cbxAtipia.Checked = true;
                    }
                    txtAtipia.Text = objAntecedentes.DescAtipia;
                    if (objAntecedentes.IndGota.CompareTo("X") == 0)
                    {
                        cbxGota.Checked = true;
                    }
                    txtGota.Text = objAntecedentes.DescGota;
                    //if (objAntecedentes.IndAfeccionBroncopulmonar.CompareTo("X") == 0)
                    //{

                    //}
                    //objAntecedentes.DescAfeccionBroncopulmonar = "";
                    if (objAntecedentes.IndEndocrinopatia.CompareTo("X") == 0)
                    {
                        cbxEndocrinopatia.Checked = true;
                    }
                    txtEndocrinopatia.Text = objAntecedentes.DescEndocrinopatia;
                    if (objAntecedentes.IndNefropatia.CompareTo("X") == 0)
                    {
                        cbxNefropatia.Checked = true;
                    }
                    txtNefropatia.Text = objAntecedentes.DescNefropatia;
                    if (objAntecedentes.IndUropatia.CompareTo("X") == 0)
                    {
                        cbxUropatia.Checked = true;
                    }
                    txtUropatia.Text = objAntecedentes.DescUropatia;
                    if (objAntecedentes.IndHemopatia.CompareTo("X") == 0)
                    {
                        cbxHemopatia.Checked = true;
                    }
                    txtHemopatia.Text = objAntecedentes.DescHemopatia;
                    if (objAntecedentes.IndETS.CompareTo("X") == 0)
                    {
                        cbxETS.Checked = true;
                    }
                    txtETS.Text = objAntecedentes.DescETS;
                    if (objAntecedentes.IndUlcera.CompareTo("X") == 0)
                    {
                        cbxUlcera.Checked = true;
                    }
                    txtUlcera.Text = objAntecedentes.DescUlcera;
                    if (objAntecedentes.IndColecistopatia.CompareTo("X") == 0)
                    {
                        cbxColecistopatia.Checked = true;
                    }
                    txtColecistopatia.Text = objAntecedentes.DescColecistopatia;
                    if (objAntecedentes.IndHepatitis.CompareTo("X") == 0)
                    {
                        cbxHepatitis.Checked = true;
                    }
                    txtHepatitis.Text = objAntecedentes.DescHepatitis;
                    if (objAntecedentes.IndEnfermedadesNeurologicas.CompareTo("X") == 0)
                    {
                        cbxEnfermedadesNeurologicas.Checked = true;
                    }
                    txtEnfermedadesNeurologicas.Text = objAntecedentes.DescEnfermedadesNeurologicas;
                    if (objAntecedentes.IndFiebresProlongadas.CompareTo("X") == 0)
                    {
                        cbxFiebresProlongadas.Checked = true;
                    }
                    txtFiebresProlongadas.Text = objAntecedentes.DescFiebresProlongadas;
                    if (objAntecedentes.IndColagenopatia.CompareTo("X") == 0)
                    {
                        cbxColagenopatia.Checked = true;
                    }
                    txtColagenopatia.Text = objAntecedentes.DescColagenopatia;
                    rtxtOtrosAntecedentes.Text = objAntecedentes.Otros;
                }

                if (objEpisodio != null)
                {
                    txtTiempoEnfermedad.Text = objEpisodio.Tiempo;
                    txtInicioEnfermedad.Text = objEpisodio.Inicio;
                    txtCursoEnfermedad.Text = objEpisodio.Curso;
                    rtxtSintomasEnfermedad.Text = objEpisodio.Sintomas;
                    rtxtRelatoCronologico.Text = objEpisodio.RelatoCronologico;

                    rtxtEctoscopiaAnterior.Text = ctrEpisodio.seleccionarEctoscopia(objPaciente._IdHistoriaClinica);
                    rtxtEctoscopiaActual.Text = objEpisodio.Ectoscopia;

                    txtTemperatura.Text = objEpisodio.Temperatura;
                    txtFrecuenciaCardiaca.Text = objEpisodio.FrecuenciaCardiaca;
                    txtFrecuenciaRespiratoria.Text = objEpisodio.FrecuenciaRespiratoria;
                    txtPresionArterial.Text = objEpisodio.PresionArterial;
                    txtPeso.Text = objEpisodio.Peso;
                    txtTalla.Text = objEpisodio.Talla;
                    rtxtOtrosExamenes.Text = objEpisodio.Otros;

                    rtxtApetito.Text = objEpisodio.Apetito;
                    rtxtSed.Text = objEpisodio.Sed;
                    rtxtOrina.Text = objEpisodio.Orina;
                    rtxtDeposiciones.Text = objEpisodio.Deposiciones;

                    for (int i = 0; i < objEpisodio._Diagnosticos.Count; i++)
                    {
                        dgvDiagnosticos.Rows.Add(new String[] { objEpisodio._Diagnosticos[i].IdCie10.ToString(),
                                                            objEpisodio._Diagnosticos[i].Codigo,
                                                            objEpisodio._Diagnosticos[i].Descripcion });

                        dgvDiagnosticos.ClearSelection();
                    }
                }                
            }

            if (numAccion == clsComun.VER)
            {
                txtNumeroHistoriaClinica.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboModoIngreso.Enabled = false;
                cboSexo.Enabled = false;
                cboEtnia.Enabled = false;
                cboReligion.Enabled = false;
                cboOcupacion.Enabled = false;
                cboIdioma.Enabled = false;
                cboEstadoCivil.Enabled = false;
                dtpFechaNacimiento.Enabled = false;
                cboGrupoSanguineo.Enabled = false;
                cboFactorSanguineo.Enabled = false;
                cboPais.Enabled = false;
                cboDepartamento.Enabled = false;
                cboProvincia.Enabled = false;
                cboDistrito.Enabled = false;
                cboDepartamentoDomicilio.Enabled = false;
                cboProvinciaDomicilio.Enabled = false;
                cboDistritoDomicilio.Enabled = false;
                txtDireccion.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                btnGuardarFiliacion.Visible = false;
                btnCancelarFiliacion.Visible = false;
                cboModoIngreso.Visible = true;

                cbxTabaco.Enabled = false;
                cbxAlcohol.Enabled = false;
                cbxCafe.Enabled = false;
                cbxTe.Enabled = false;
                cbxDrogas.Enabled = false;
                cbxDiabetes.Enabled = false;
                txtDiabetes.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxHipertensionArterial.Enabled = false;
                txtHipertensionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxCoronariopatia.Enabled = false;
                txtCoronariopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxDislipidemia.Enabled = false;
                txtDislipidemia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxAsma.Enabled = false;
                txtAsma.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxPsicopatia.Enabled = false;
                txtPsicopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxAlergias.Enabled = false;
                txtAlergias.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxTuberculosis.Enabled = false;
                txtTuberculosis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxAtipia.Enabled = false;
                txtAtipia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxGota.Enabled = false;
                txtGota.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxEndocrinopatia.Enabled = false;
                txtEndocrinopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxNefropatia.Enabled = false;
                txtNefropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxUropatia.Enabled = false;
                txtUropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxHemopatia.Enabled = false;
                txtHemopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxETS.Enabled = false;
                txtETS.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxUlcera.Enabled = false;
                txtUlcera.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxColecistopatia.Enabled = false;
                txtColecistopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxHepatitis.Enabled = false;
                txtHepatitis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxEnfermedadesNeurologicas.Enabled = false;
                txtEnfermedadesNeurologicas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxFiebresProlongadas.Enabled = false;
                txtFiebresProlongadas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cbxColagenopatia.Enabled = false;
                txtColagenopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                rtxtOtrosAntecedentes.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
                btnGuardarAntecedentes.Visible = false;

                rtxtEctoscopiaActual.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;

                txtTiempoEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtInicioEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtCursoEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                rtxtSintomasEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
                rtxtRelatoCronologico.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;

                txtTemperatura.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtFrecuenciaRespiratoria.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtFrecuenciaCardiaca.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtPresionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtPeso.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                txtTalla.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                rtxtApetito.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
                rtxtSed.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
                rtxtOrina.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
                rtxtDeposiciones.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
                rtxtOtrosExamenes.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;

                cboDiagnostico.Enabled = false;
                rtxtDiagnosticoActual.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
                btnBuscar.Visible = false;
                btnAgregar.Visible = false;
                btnQuitar.Visible = false;
                
                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtNumeroHistoriaClinica.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboModoIngreso.Enabled = true;
                cboSexo.Enabled = true;
                cboEtnia.Enabled = true;
                cboReligion.Enabled = true;
                cboOcupacion.Enabled = true;
                cboIdioma.Enabled = true;
                cboEstadoCivil.Enabled = true;
                dtpFechaNacimiento.Enabled = true;
                cboGrupoSanguineo.Enabled = true;
                cboFactorSanguineo.Enabled = true;
                cboPais.Enabled = true;
                cboDepartamento.Enabled = true;
                cboProvincia.Enabled = true;
                cboDistrito.Enabled = true;
                cboDepartamentoDomicilio.Enabled = true;
                cboProvinciaDomicilio.Enabled = true;
                cboDistritoDomicilio.Enabled = true;
                txtDireccion.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                btnGuardarFiliacion.Visible = true;

                if (numAccion == clsComun.INSERTAR)
                {
                    lblModoIngreso.Visible = false;
                    cboModoIngreso.Visible = false;
                    btnCancelarFiliacion.Visible = true;
                    tbpFiliacion.Enabled = true;
                    tbpAntecedentes.Enabled = false;
                    tbpEnfermedadActual.Enabled = false;
                    tbpEctoscopia.Enabled = false;
                    tbpExamenFisico.Enabled = false;
                    tbpDiagnostico.Enabled = false;
                    tbcAnamnesisPartes.SelectedTab = tbpFiliacion;
                }
                else
                {
                    lblModoIngreso.Visible = true;
                    cboModoIngreso.Visible = true;
                    btnCancelarFiliacion.Visible = false;
                    tbpFiliacion.Enabled = true;
                    tbpAntecedentes.Enabled = true;
                    tbpEnfermedadActual.Enabled = true;
                    tbpEctoscopia.Enabled = true;
                    tbpExamenFisico.Enabled = true;
                    tbpDiagnostico.Enabled = true;
                }
                
                cbxTabaco.Enabled = true;
                cbxAlcohol.Enabled = true;
                cbxCafe.Enabled = true;
                cbxTe.Enabled = true;
                cbxDrogas.Enabled = true;
                cbxDiabetes.Enabled = true;
                txtDiabetes.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxHipertensionArterial.Enabled = true;
                txtHipertensionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxCoronariopatia.Enabled = true;
                txtCoronariopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxDislipidemia.Enabled = true;
                txtDislipidemia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxAsma.Enabled = true;
                txtAsma.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxPsicopatia.Enabled = true;
                txtPsicopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxAlergias.Enabled = true;
                txtAlergias.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxTuberculosis.Enabled = true;
                txtTuberculosis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxAtipia.Enabled = true;
                txtAtipia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxGota.Enabled = true;
                txtGota.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxEndocrinopatia.Enabled = true;
                txtEndocrinopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxNefropatia.Enabled = true;
                txtNefropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxUropatia.Enabled = true;
                txtUropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxHemopatia.Enabled = true;
                txtHemopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxETS.Enabled = true;
                txtETS.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxUlcera.Enabled = true;
                txtUlcera.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxColecistopatia.Enabled = true;
                txtColecistopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxHepatitis.Enabled = true;
                txtHepatitis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxEnfermedadesNeurologicas.Enabled = true;
                txtEnfermedadesNeurologicas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxFiebresProlongadas.Enabled = true;
                txtFiebresProlongadas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cbxColagenopatia.Enabled = true;
                txtColagenopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                rtxtOtrosAntecedentes.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
                btnGuardarAntecedentes.Visible = true;

                rtxtEctoscopiaActual.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;

                txtTiempoEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtInicioEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtCursoEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                rtxtSintomasEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
                rtxtRelatoCronologico.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;

                txtTemperatura.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtFrecuenciaRespiratoria.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtFrecuenciaCardiaca.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtPresionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtPeso.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                txtTalla.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                rtxtApetito.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
                rtxtSed.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
                rtxtOrina.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
                rtxtDeposiciones.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
                rtxtOtrosExamenes.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;

                cboDiagnostico.Enabled = true;
                rtxtDiagnosticoActual.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
                btnBuscar.Visible = true;
                btnAgregar.Visible = true;
                btnQuitar.Visible = true;

                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.tabSiguiente(tbcHistoriaClinica, tbpBuscar, tbpDetalle);
            tbcAnamnesisPartes.SelectedTab = tbpFiliacion;
            tbcHistoriaClinicaPartes.SelectedTab = tbpAnamnesis;
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

        private void dgvHistoriasClinicas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistoriasClinicas.SelectedRows.Count > 0)
            {
                dtEpisodios = ctrHistoriaClinica.seleccionarEpisodios(Int32.Parse(dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[9].Value.ToString()));

                cargarGrillaEpisodios();
            }
            else
            {
                dgvEpisodios.DataMember = null;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            mostrarInformacion(null, null, null, numAccion);

            txtNumeroHistoriaClinica.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvHistoriasClinicas.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdHistoriaClinica = Int32.Parse(dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[0].Value.ToString());

                strNumeroHistoriaClinica = dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[1].Value.ToString();

                numIdPaciente = Int32.Parse(dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[9].Value.ToString());

                numIdAntecedentes = Int32.Parse(dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[10].Value.ToString());

                numIdEpisodio = Int32.Parse(dgvEpisodios.Rows[dgvEpisodios.CurrentRow.Index].Cells[0].Value.ToString());

                clsPaciente objPaciente = new clsPaciente();
                objPaciente.IdPaciente = numIdPaciente;

                objPaciente = ctrPaciente.seleccionarPaciente(objPaciente);

                clsAntecedentes objAntecedentes = new clsAntecedentes();
                objAntecedentes.IdAntecedentes = numIdAntecedentes;

                objAntecedentes = ctrAntecedentes.seleccionarAntecedentes(objAntecedentes);

                objEpisodio = new clsEpisodio();
                objEpisodio.IdEpisodio = numIdEpisodio;

                objEpisodio = ctrEpisodio.seleccionarEpisodio(objEpisodio);

                mostrarInformacion(objPaciente, objAntecedentes, objEpisodio, numAccion);

                txtPaterno.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (blnExiste)
            {
                numAccion = clsComun.MODIFICAR;

                numIdHistoriaClinica = Int32.Parse(dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[0].Value.ToString());

                strNumeroHistoriaClinica = dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[1].Value.ToString();

                numIdPaciente = Int32.Parse(dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[9].Value.ToString());

                numIdAntecedentes = Int32.Parse(dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[10].Value.ToString());

                numIdEpisodio = Int32.Parse(dgvEpisodios.Rows[dgvEpisodios.CurrentRow.Index].Cells[0].Value.ToString());

                numIdEnfermedad = Int32.Parse(dgvEpisodios.Rows[dgvEpisodios.CurrentRow.Index].Cells[4].Value.ToString());

                clsPaciente objPaciente = new clsPaciente();
                objPaciente.IdPaciente = numIdPaciente;

                objPaciente = ctrPaciente.seleccionarPaciente(objPaciente);

                clsAntecedentes objAntecedentes = new clsAntecedentes();
                objAntecedentes.IdAntecedentes = numIdAntecedentes;

                objAntecedentes = ctrAntecedentes.seleccionarAntecedentes(objAntecedentes);

                objEpisodio = new clsEpisodio();
                objEpisodio.IdEpisodio = numIdEpisodio;

                objEpisodio = ctrEpisodio.seleccionarEpisodio(objEpisodio);

                mostrarInformacion(objPaciente, objAntecedentes, objEpisodio, numAccion);

                txtPaterno.Focus();
            }
            else
            {
                MessageBox.Show("No hay episodios para continuar el día de hoy", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarDiagnostico())
            {
                dgvDiagnosticos.Rows.Add(new String[] { dtCie10.Rows[cboDiagnostico.SelectedIndex]["IdCie10"].ToString(),
                                                        dtCie10.Rows[cboDiagnostico.SelectedIndex]["Codigo"].ToString(),
                                                        rtxtDiagnosticoActual.Text });

                dgvDiagnosticos.ClearSelection();
                cboDiagnostico.Text = "";
                rtxtDiagnosticoActual.Clear();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDiagnosticos.Rows.Count > 0)
            {
                dgvDiagnosticos.Rows.RemoveAt(dgvDiagnosticos.CurrentRow.Index);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcHistoriaClinica, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtPaternoBuscar.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.tabAnterior(tbcHistoriaClinica, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                txtPaternoBuscar.Focus();

                dgvEpisodios.ClearSelection();
                dgvHistoriasClinicas.ClearSelection();
            }
            else
            {
                if (validarFormulario())
                {
                    List<clsDetalleDiagnostico> lstDiagnosticos = new List<clsDetalleDiagnostico>();
                    objEpisodio.Ectoscopia = rtxtEctoscopiaActual.Text;
                    objEpisodio.Temperatura = txtTemperatura.Text;
                    objEpisodio.FrecuenciaCardiaca = txtFrecuenciaCardiaca.Text;
                    objEpisodio.FrecuenciaRespiratoria = txtFrecuenciaRespiratoria.Text;
                    objEpisodio.PresionArterial = txtPresionArterial.Text;
                    objEpisodio.Peso = txtPeso.Text;
                    objEpisodio.Talla = txtTalla.Text;
                    objEpisodio.Otros = rtxtOtrosExamenes.Text;
                    objEpisodio.Tiempo = txtTiempoEnfermedad.Text;
                    objEpisodio.Inicio = txtInicioEnfermedad.Text;
                    objEpisodio.Curso = txtCursoEnfermedad.Text;
                    objEpisodio.Sintomas = rtxtSintomasEnfermedad.Text;
                    objEpisodio.RelatoCronologico = rtxtRelatoCronologico.Text;
                    objEpisodio.Apetito = rtxtApetito.Text;
                    objEpisodio.Sed = rtxtSed.Text;
                    objEpisodio.Orina = rtxtOrina.Text;
                    objEpisodio.Deposiciones = rtxtDeposiciones.Text;
                    objEpisodio.IdEmpleado = numIdEmpleado;
                    for (int i = 0; i < dgvDiagnosticos.RowCount; i++)
                    {
                        clsDetalleDiagnostico objDetalleDiagnostico = new clsDetalleDiagnostico();
                        objDetalleDiagnostico.IdCie10 = Int32.Parse(dgvDiagnosticos.Rows[i].Cells[0].Value.ToString());
                        objDetalleDiagnostico.Descripcion = dgvDiagnosticos.Rows[i].Cells[2].Value.ToString();

                        lstDiagnosticos.Add(objDetalleDiagnostico);
                    }
                    
                    objEpisodio.DetalleXML = clsComun.Serializar(lstDiagnosticos);

                    if (numAccion == clsComun.INSERTAR)
                    {
                        //No hace nada
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        if (ctrEpisodio.modificarEpisodio(objEpisodio))
                        {
                            MessageBox.Show("El episodio se registró exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.tabAnterior(tbcHistoriaClinica, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtPaternoBuscar.Focus();

                            dgvEpisodios.ClearSelection();
                            dgvHistoriasClinicas.ClearSelection();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el episodio", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                }
            }
        }

        private void cbxDiabetes_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxDiabetes.Checked)
            {
                txtDiabetes.Clear();
                txtDiabetes.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtDiabetes.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxHipertensionArterial_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxHipertensionArterial.Checked)
            {
                txtHipertensionArterial.Clear();
                txtHipertensionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtHipertensionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxCoronariopatia_TextChanged(object sender, EventArgs e)
        {
            if (!cbxCoronariopatia.Checked)
            {
                txtCoronariopatia.Clear();
                txtCoronariopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtCoronariopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxDislipidemia_TextChanged(object sender, EventArgs e)
        {
            if (!cbxDislipidemia.Checked)
            {
                txtDislipidemia.Clear();
                txtDislipidemia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtDislipidemia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxAsma_TextChanged(object sender, EventArgs e)
        {
            if (!cbxAsma.Checked)
            {
                txtAsma.Clear();
                txtAsma.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtAsma.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxPsicopatia_TextChanged(object sender, EventArgs e)
        {
            if (!cbxPsicopatia.Checked)
            {
                txtPsicopatia.Clear();
                txtPsicopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtPsicopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxAlergias_TextChanged(object sender, EventArgs e)
        {
            if (!cbxAlergias.Checked)
            {
                txtAlergias.Clear();
                txtAlergias.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtAlergias.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxTuberculosis_TextChanged(object sender, EventArgs e)
        {
            if (!cbxTuberculosis.Checked)
            {
                txtTuberculosis.Clear();
                txtTuberculosis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtTuberculosis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxAtipia_TextChanged(object sender, EventArgs e)
        {
            if (!cbxAtipia.Checked)
            {
                txtAtipia.Clear();
                txtAtipia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtAtipia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxGota_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxGota.Checked)
            {
                txtGota.Clear();
                txtGota.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtGota.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxEndocrinopatia_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxEndocrinopatia.Checked)
            {
                txtEndocrinopatia.Clear();
                txtEndocrinopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtEndocrinopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxNefropatia_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxNefropatia.Checked)
            {
                txtNefropatia.Clear();
                txtNefropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtNefropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxUropatia_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxUropatia.Checked)
            {
                txtUropatia.Clear();
                txtUropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtUropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxHemopatia_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxHemopatia.Checked)
            {
                txtHemopatia.Clear();
                txtHemopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtHemopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxETS_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxETS.Checked)
            {
                txtETS.Clear();
                txtETS.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtETS.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxUlcera_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxUlcera.Checked)
            {
                txtUlcera.Clear();
                txtUlcera.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtUlcera.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxColecistopatia_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxColecistopatia.Checked)
            {
                txtColecistopatia.Clear();
                txtColecistopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtColecistopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxHepatitis_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxHepatitis.Checked)
            {
                txtHepatitis.Clear();
                txtHepatitis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtHepatitis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxEnfermedadesNeurologicas_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxEnfermedadesNeurologicas.Checked)
            {
                txtEnfermedadesNeurologicas.Clear();
                txtEnfermedadesNeurologicas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtEnfermedadesNeurologicas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxFiebresProlongadas_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxFiebresProlongadas.Checked)
            {
                txtFiebresProlongadas.Clear();
                txtFiebresProlongadas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtFiebresProlongadas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void cbxColagenopatia_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxColagenopatia.Checked)
            {
                txtColagenopatia.Clear();
                txtColagenopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            }
            else
            {
                txtColagenopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            }
        }

        private void btnGuardarAntecedentes_Click(object sender, EventArgs e)
        {
            clsAntecedentes objAntecedentes = new clsAntecedentes();

            objAntecedentes.IdAntecedentes = numIdAntecedentes;
            if (cbxTabaco.Checked)
            {
                objAntecedentes.IndTabaco = "X";
            }
            if (cbxAlcohol.Checked)
            {
                objAntecedentes.IndAlcohol = "X";
            }
            if (cbxCafe.Checked)
            {
                objAntecedentes.IndCafe = "X";
            }
            if (cbxTe.Checked)
            {
                objAntecedentes.IndTe = "X";
            }
            if (cbxDrogas.Checked)
            {
                objAntecedentes.IndDrogas = "";
            }
            if (cbxDiabetes.Checked)
            {
                objAntecedentes.IndDiabetes = "X";
            }
            objAntecedentes.DescDiabetes = txtDiabetes.Text;
            if (cbxHipertensionArterial.Checked)
            {
                objAntecedentes.IndHipertension = "X";
            }
            objAntecedentes.DescHipertension = txtHipertensionArterial.Text;
            if (cbxCoronariopatia.Checked)
            {
                objAntecedentes.IndCoronariopatia = "X";
            }
            objAntecedentes.DescCoronariopatia = txtCoronariopatia.Text;
            if (cbxDislipidemia.Checked)
            {
                objAntecedentes.IndDislipidemia = "X";
            }
            objAntecedentes.DescDislipidemia = txtDislipidemia.Text;
            if (cbxAsma.Checked)
            {
                objAntecedentes.IndAsma = "X";
            }
            objAntecedentes.DescAsma = txtAsma.Text;
            if (cbxPsicopatia.Checked)
            {
                objAntecedentes.IndPsicopatia = "X";
            }
            objAntecedentes.DescPsicopatia = txtPsicopatia.Text;
            if (cbxAlergias.Checked)
            {
                objAntecedentes.IndAlergias = "X";
            }
            objAntecedentes.DescAlergias = txtAlergias.Text;
            if (cbxTuberculosis.Checked)
            {
                objAntecedentes.IndTuberculosis = "X";
            }
            objAntecedentes.DescTuberculosis = txtTuberculosis.Text;
            if (cbxAtipia.Checked)
            {
                objAntecedentes.IndAtipia = "X";
            }
            objAntecedentes.DescAtipia = txtAtipia.Text;
            if (cbxGota.Checked)
            {
                objAntecedentes.IndGota = "X";
            }
            objAntecedentes.DescGota = txtGota.Text;
            //objAntecedentes.IndAfeccionBroncopulmonar = "";
            //objAntecedentes.DescAfeccionBroncopulmonar = "";
            if (cbxEndocrinopatia.Checked)
            {
                objAntecedentes.IndEndocrinopatia = "X";
            }
            objAntecedentes.DescEndocrinopatia = txtEndocrinopatia.Text;
            if (cbxNefropatia.Checked)
            {
                objAntecedentes.IndNefropatia = "X";
            }
            objAntecedentes.DescNefropatia = txtNefropatia.Text;
            if (cbxUropatia.Checked)
            {
                objAntecedentes.IndUropatia = "X";
            }
            objAntecedentes.DescUropatia = txtUropatia.Text;
            if (cbxHemopatia.Checked)
            {
                objAntecedentes.IndHemopatia = "X";
            }
            objAntecedentes.DescHemopatia = txtHemopatia.Text;
            if (cbxETS.Checked)
            {
                objAntecedentes.IndETS = "X";
            }
            objAntecedentes.DescETS = txtETS.Text;
            if (cbxUlcera.Checked)
            {
                objAntecedentes.IndUlcera = "X";
            }
            objAntecedentes.DescUlcera = txtUlcera.Text;
            if (cbxColecistopatia.Checked)
            {
                objAntecedentes.IndColecistopatia = "X";
            }
            objAntecedentes.DescColecistopatia = txtColecistopatia.Text;
            if (cbxHepatitis.Checked)
            {
                objAntecedentes.IndHepatitis = "X";
            }
            objAntecedentes.DescHepatitis = txtHepatitis.Text;
            if (cbxEnfermedadesNeurologicas.Checked)
            {
                objAntecedentes.IndEnfermedadesNeurologicas = "X";
            }
            objAntecedentes.DescEnfermedadesNeurologicas = txtEnfermedadesNeurologicas.Text;
            if (cbxFiebresProlongadas.Checked)
            {
                objAntecedentes.IndFiebresProlongadas = "X";
            }
            objAntecedentes.DescFiebresProlongadas = txtFiebresProlongadas.Text;
            if (cbxColagenopatia.Checked)
            {
                objAntecedentes.IndColagenopatia = "X";
            }
            objAntecedentes.DescColagenopatia = txtColagenopatia.Text;
            objAntecedentes.Otros = rtxtOtrosAntecedentes.Text;

            if (ctrAntecedentes.modificarAntecedentes(objAntecedentes))
            {
                MessageBox.Show("Los Antecedentes se guardaron exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Ocurrió un error mientras se intentaba guardar los antecedentes", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                {
                    btnGuardarAntecedentes_Click(sender, e);
                }
            }
        }

        private void tbcHistoriaClinica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcHistoriaClinica.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcHistoriaClinica_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcHistoriaClinicaPartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numAccion == clsComun.INSERTAR)
            {
                if (tbcHistoriaClinicaPartes.SelectedIndex == 1)
                {
                    tbpBuscar.Enabled = false;
                }
            }
        }

        private void tbcHistoriaClinicaPartes_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (numAccion == clsComun.INSERTAR)
            {
                if (e.TabPage.Enabled == false)
                {
                    e.Cancel = true;
                }
            }
        }

        private void tbcAnamnesisPartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numAccion == clsComun.INSERTAR)
            {
                if (tbcAnamnesisPartes.SelectedIndex == 1)
                {
                    tbpBuscar.Enabled = false;
                }
            }
        }

        private void tbcAnamnesisPartes_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (numAccion == clsComun.INSERTAR)
            {
                if (e.TabPage.Enabled == false)
                {
                    e.Cancel = true;
                }
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

        private void btnGuardarFiliacion_Click(object sender, EventArgs e)
        {
            if (validarPaciente())
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
                objPaciente.Pais = clsComun.seleccionarToVacio(cboPais.Text);
                objPaciente.DepartamentoNacimiento = cboDepartamento.Text;
                objPaciente.ProvinciaNacimiento = cboProvincia.Text;
                objPaciente.DistritoNacimiento = cboDistrito.Text;
                objPaciente.DepartamentoDomicilio = clsComun.seleccionarToVacio(cboDepartamentoDomicilio.Text);
                objPaciente.ProvinciaDomicilio = cboProvinciaDomicilio.Text;
                objPaciente.DistritoDomicilio = cboDistritoDomicilio.Text;
                objPaciente.Direccion = txtDireccion.Text;
                objPaciente.NumeroHistoriaClinica = txtNumeroHistoriaClinica.Text;
                objPaciente.IdEmpleado = numIdEmpleado;
                if (cboGrupoSanguineo.SelectedIndex > 0)
                {
                    objPaciente.GrupoSanguineo = cboGrupoSanguineo.Text;
                }
                if (cboFactorSanguineo.SelectedIndex > 0)
                {
                    objPaciente.FactorSanguineo = cboFactorSanguineo.Text;
                }
                
                if (numAccion == clsComun.INSERTAR)
                {
                    objPaciente.IdEpisodio = 0;
                    objPaciente.IdModoIngreso = 0;

                    numIdPaciente = ctrEpisodio.registrarPaciente(objPaciente);

                    if (numIdPaciente > 0)
                    {
                        objPaciente = new clsPaciente();
                        objPaciente.IdPaciente = numIdPaciente;
                        
                        MessageBox.Show("El paciente se registró exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el paciente", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardarFiliacion_Click(sender, e);
                        }
                    }

                    objPaciente = ctrPaciente.seleccionarPaciente(objPaciente);

                    clsTriaje objTriaje = new clsTriaje();
                    objTriaje.IdEmpleado = numIdEmpleado;
                    objTriaje.IdPaciente = objPaciente.IdPaciente;
                    objTriaje.IdHistoriaClinica = objPaciente._IdHistoriaClinica;
                    objTriaje.GrupoSanguineo = objPaciente.GrupoSanguineo;
                    objTriaje.FactorSanguineo = objPaciente.FactorSanguineo;
                    objTriaje.IdModoIngreso = objPaciente.IdModoIngreso;

                    numIdEpisodio = ctrEpisodio.registrarTriaje(objTriaje);

                    numIdHistoriaClinica = objPaciente._IdHistoriaClinica;

                    strNumeroHistoriaClinica = objPaciente.NumeroHistoriaClinica;

                    numIdAntecedentes = ctrEpisodio.seleccionarIdAntecedentes(numIdHistoriaClinica);

                    clsAntecedentes objAntecedentes = new clsAntecedentes();
                    objAntecedentes.IdAntecedentes = numIdAntecedentes;

                    objAntecedentes = ctrAntecedentes.seleccionarAntecedentes(objAntecedentes);

                    objEpisodio = new clsEpisodio();
                    objEpisodio.IdEpisodio = numIdEpisodio;

                    objEpisodio = ctrEpisodio.seleccionarEpisodio(objEpisodio);

                    numAccion = clsComun.MODIFICAR;

                    mostrarInformacion(objPaciente, objAntecedentes, objEpisodio, numAccion);

                    txtPaterno.Focus();
                }
                else if (numAccion == clsComun.MODIFICAR)
                {
                    objPaciente.IdEpisodio = numIdEpisodio;
                    if (cboModoIngreso.SelectedIndex > 0)
                    {
                        objPaciente.IdModoIngreso = ((clsModoIngreso)cboModoIngreso.SelectedItem).IdModoIngreso;
                    }

                    if (ctrPaciente.modificarPaciente(objPaciente))
                    {
                        MessageBox.Show("El paciente se registró exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el paciente", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardarFiliacion_Click(sender, e);
                        }
                    }
                }
            }
        }
    }
}
