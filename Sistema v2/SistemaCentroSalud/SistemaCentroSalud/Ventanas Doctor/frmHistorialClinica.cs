using System;
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
        private int numAccion;
        private int numIdPaciente;
        private int numIdEmpleado;
        private int numIdHistoriaClinica;
        private int numIdEpisodio = 0;
        private bool blnExiste = false;

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
                                                                 dtPacientes.Rows[i]["IdPersona"].ToString() });
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

        private void mostrarInformacion(clsPaciente objPaciente, int numAccion)
        {
            txtPaterno.Text = objPaciente.Paterno;
            txtMaterno.Text = objPaciente.Materno;
            txtNombres.Text = objPaciente.Nombres;
            //Modo de ingreso
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

            if (numAccion != clsComun.INSERTAR)
            {
                
            }

            if (numAccion == clsComun.VER)
            {
                
                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
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
            else
            {
                dgvEpisodios.DataMember = null;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (dgvHistoriasClinicas.SelectedRows.Count > 0)
            {
                numAccion = clsComun.INSERTAR;

                numIdPaciente = Int32.Parse(dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[9].Value.ToString());

                clsPaciente objPaciente = new clsPaciente();
                objPaciente.IdPaciente = numIdPaciente;

                objPaciente = ctrPaciente.seleccionarPaciente(objPaciente);

                numIdHistoriaClinica = objPaciente._IdHistoriaClinica;

                limpiarFormulario();

                mostrarInformacion(objPaciente, numAccion);

                txtPaterno.Focus();

                if (blnExiste)
                {
                    
                }
                else
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

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
                dgvDiagnosticos.Rows.Add(new String[] { "",
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
    }
}
