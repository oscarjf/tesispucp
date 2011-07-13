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
using System.Data.SqlClient;
using Control;

namespace SistemaCentroSalud.Ventanas_Doctor
{
    public partial class frmHistorialClinica : Form
    {
        private clsHistoriaClinica objHistoriaClinica = new clsHistoriaClinica();
        private clsPaciente objPaciente = new clsPaciente();
        private clsEpisodio objEpisodio = new clsEpisodio();
        private int numIdPaciente = 0;
        private int numIdHC;
        private int numIdUsuario;
        private bool blnTieneHC;

        public frmHistorialClinica(bool blnHistoriaClinicaCompleta, int idUsuario)
        {
            InitializeComponent();

            if (!blnHistoriaClinicaCompleta)
            {
                tbcHistoriaClinicaPartes.TabPages.Remove(tbpAnamnesis);
                tbcHistoriaClinicaPartes.TabPages.Remove(tbpExamenFisico);
            }
            this.numIdUsuario = idUsuario;
        }

        private void frmHistorialClinica_Load(object sender, EventArgs e)
        {
            cargarCIE10();
            inicializarVentana();
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            String strSentenciaSQL;
            SqlCommand cmdComandoSQL;
            SqlDataReader sqlLector;
            SqlConnection con = clsGestorBD.Conectar();

            con.Open();

            strSentenciaSQL = "SELECT P.Id_Persona, P.Paterno, P.Materno, P.Nombres ";
            strSentenciaSQL += "FROM Persona P ";
            strSentenciaSQL += "WHERE P.TipoPersona = 'PACIENTE'";

            cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

            cmdComandoSQL.Prepare();
            sqlLector = cmdComandoSQL.ExecuteReader();

            while (sqlLector.Read())
            {
                dgvHistoriasClinicas.Rows.Add(new String[] { sqlLector.GetInt32(0).ToString(), sqlLector.GetString(1), sqlLector.GetString(2), sqlLector.GetString(3) });
            }

            sqlLector.Close();
            con.Close();
        }

        private bool tieneHistoriaClinica(int numIdPaciente)
        {
            String strSentenciaSQL;
            SqlCommand cmdComandoSQL;
            SqlDataReader sqlLector;
            SqlConnection con = clsGestorBD.Conectar();
            bool blnTiene = false;
            con.Open();

            strSentenciaSQL = "SELECT H.Id_HistoriaClinica, H.Numero, P.Id_Persona, P.Paterno, P.Materno, P.Nombres ";
            strSentenciaSQL += "FROM HistoriaClinica H, Persona P ";
            strSentenciaSQL += "WHERE H.Id_Paciente = " + numIdPaciente;

            cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

            cmdComandoSQL.Prepare();
            sqlLector = cmdComandoSQL.ExecuteReader();

            while (sqlLector.Read())
            {
                numIdHC = sqlLector.GetInt32(0);
                blnTiene = true;
                break;
            }

            sqlLector.Close();
            con.Close();

            return blnTiene;
        }

        private void guardarHistoriaClinica(clsPaciente objPaciente, clsEpisodio objEpisodio, clsHistoriaClinica objHistoriaClinica)
        {
            try
            {
                String strSentenciaSQL;
                SqlCommand cmdComandoSQL;
                SqlDataReader sqlLector;
                SqlConnection con = clsGestorBD.Conectar();

                con.Open();

                //ENFERMEDAD ACTUAL
                strSentenciaSQL = "INSERT INTO EnfermedadActual ";
                strSentenciaSQL += "(TiempoEnfermedad, InicioEnfermedad, CursoEnfermedad, SintomasPrincipales, RelatoCronologico) ";
                strSentenciaSQL += "VALUES ('" + objEpisodio.StrTiempoEnfermedad + "','" + objEpisodio.StrInicioEnfermedad + "','" + objEpisodio.StrCursoEnfermedad + "','" + objEpisodio.StrSintomasPrincipales + "','" + objEpisodio.StrRelatoCronológico + "')";
                cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                cmdComandoSQL.Prepare();
                cmdComandoSQL.ExecuteNonQuery();

                int numIdEnfermedadActual = 0;

                strSentenciaSQL = "SELECT MAX(Id_EnfermedadActual) FROM EnfermedadActual ";

                cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                cmdComandoSQL.Prepare();
                sqlLector = cmdComandoSQL.ExecuteReader();

                while (sqlLector.Read())
                {
                    numIdEnfermedadActual = sqlLector.GetInt32(0);
                    break;
                }

                sqlLector.Close();

                //EXAMEN FISICO
                strSentenciaSQL = "INSERT INTO ExamenFisico ";
                strSentenciaSQL += "(Temperatura, FrecuenciaCardiaca, Pulso, FrecuenciaRespiratoria, PresionArterial, Peso, Talla, OtrosExamenes) ";
                strSentenciaSQL += "VALUES ('" + objEpisodio.StrTemperatura + "','" + objEpisodio.StrFrecuenciaCardiaca + "','" + objEpisodio.StrPulso + "','" + objEpisodio.StrFrecuenciaRespiratoria + "','" +  objEpisodio.StrPresionArteria + "','" + objEpisodio.StrPeso + "','" + objEpisodio.StrTalla + "','" + objEpisodio.StrOtrosExamenes + "')";
                cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                cmdComandoSQL.Prepare();
                cmdComandoSQL.ExecuteNonQuery();

                int numIdExamenFisico = 0;

                strSentenciaSQL = "SELECT MAX(Id_ExamenFisico) FROM ExamenFisico ";

                cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                cmdComandoSQL.Prepare();
                sqlLector = cmdComandoSQL.ExecuteReader();

                while (sqlLector.Read())
                {
                    numIdExamenFisico = sqlLector.GetInt32(0);
                    break;
                }

                sqlLector.Close();
                
                //DIAGNOSTICO
                strSentenciaSQL = "INSERT INTO Diagnostico ";
                strSentenciaSQL += "(Id_Cie10, Descripcion, FechaRegistro) ";
                strSentenciaSQL += "VALUES ('" + objEpisodio.NumCie10 + "','" + objEpisodio.StrDescripcionCIE10 + "',GETDATE())";
                cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                cmdComandoSQL.Prepare();
                cmdComandoSQL.ExecuteNonQuery();

                int numIdDiagnostico = 0;

                strSentenciaSQL = "SELECT MAX(Id_Diagnostico) FROM Diagnostico ";

                cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                cmdComandoSQL.Prepare();
                sqlLector = cmdComandoSQL.ExecuteReader();

                while (sqlLector.Read())
                {
                    numIdDiagnostico = sqlLector.GetInt32(0);
                    break;
                }

                sqlLector.Close();

                //EPISODIO
                strSentenciaSQL = "INSERT INTO Episodio";
                strSentenciaSQL += "(Ectoscopia, Id_ExamenFisico, Id_EnfermedadActual, Id_Diagnostico, FechaRegistro, DoctorRegistro) ";
                strSentenciaSQL += "VALUES ('" + objEpisodio.StrEctoscopia + "'," + numIdExamenFisico + "," + numIdEnfermedadActual + "," + numIdDiagnostico + ",GETDATE()," + numIdUsuario + ")";
                cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                cmdComandoSQL.Prepare();
                cmdComandoSQL.ExecuteNonQuery();

                int numIdEpisodio = 0;

                strSentenciaSQL = "SELECT MAX(Id_Episodio) FROM Episodio ";

                cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                cmdComandoSQL.Prepare();
                sqlLector = cmdComandoSQL.ExecuteReader();

                while (sqlLector.Read())
                {
                    numIdEpisodio = sqlLector.GetInt32(0);
                    break;
                }

                sqlLector.Close();

                if (blnTieneHC == false)
                {
                    //ANTECEDENTES
                    strSentenciaSQL = "INSERT INTO Antecedentes ";
                    strSentenciaSQL += "(IndTabaco, IndAlcohol, IndCafe, IndTe, IndDrogas, IndDiabetes, DescripcionDiabetes, IndHipertension, DescripcionHipertension, IndCoronariopatia, DescripcionCoronariopatia, IndDislipidemia, DescripcionDislipidemia, IndAsma, DescripcionAsma, IndPsicopatia, DescripcionPsicopatia, IndAlergias, DescripcionAlergias, IndTuberculosis, DescripcionTuberculosis, IndAtipia, DescripcionAtipia, IndGota, DescripcionGota, IndEndocrinopatia, DescripcionEndocrinopatia, IndNefropatia, DescripcionNefropatia, IndUropatia, DescripcionUropatia, IndHemopatia, DescripcionHemopatia, IndETS, DescripcionETS, IndUlcera, DescripcionUlcera, IndColecistopatia, DescripcionColecistopatia, IndHepatitis, DescripcionHepatitis, IndEnfermedadesNeurologicas, DescripcionEnfermedadesNeurologicas, IndFiebresProlongadas, DescripcionFiebresProlongadas, IndColagenopatia, DescripcionColagenopatia, Otros) ";
                    strSentenciaSQL += "VALUES ('" + objHistoriaClinica.StrIndTabaco + "','" + objHistoriaClinica.StrIndAlcohol + "','" + objHistoriaClinica.StrIndCafe + "','" + objHistoriaClinica.StrIndTe + "','" + objHistoriaClinica.StrIndDrogas + "','" + objHistoriaClinica.StrIndDiabetes + "','" + objHistoriaClinica.StrDescripcionDiabetes + "','" + objHistoriaClinica.StrIndHipertension + "','" + objHistoriaClinica.StrDescripcionHipertension + "','" + objHistoriaClinica.StrIndCoronariopatia + "','" + objHistoriaClinica.StrDescripcionCoronariopatia + "','" + objHistoriaClinica.StrIndDislipidemia + "','" + objHistoriaClinica.StrDescripcionDislipidemia + "','" + objHistoriaClinica.StrIndAsma + "','" + objHistoriaClinica.StrDescripcionAsma + "','" + objHistoriaClinica.StrIndPsicopatia + "','" + objHistoriaClinica.StrDescripcionPsicopatia + "','" + objHistoriaClinica.StrIndAlergias + "','" + objHistoriaClinica.StrDescripcionAlergias + "','" + objHistoriaClinica.StrIndTuberculosis + "','" + objHistoriaClinica.StrDescripcionTuberculosis + "','" + objHistoriaClinica.StrIndAtipia + "','" + objHistoriaClinica.StrDescripcionAtipia + "','" + objHistoriaClinica.StrIndGota + "','" + objHistoriaClinica.StrDescripcionGota + "','" + objHistoriaClinica.StrIndEndocrinopatia + "','" + objHistoriaClinica.StrDescripcionEndocrinopatia + "','" + objHistoriaClinica.StrIndNefropatia + "','" + objHistoriaClinica.StrDescripcionNefropatia + "','" + objHistoriaClinica.StrIndUropatia + "','" + objHistoriaClinica.StrDescripcionUropatia + "','" + objHistoriaClinica.StrIndHemopatia + "','" + objHistoriaClinica.StrDescripcionHemopatia + "','" + objHistoriaClinica.StrIndETS + "','" + objHistoriaClinica.StrDescripcionETS + "','" + objHistoriaClinica.StrIndUlcera + "','" + objHistoriaClinica.StrDescripcionUlcera + "','" + objHistoriaClinica.StrIndColecistopatia + "','" + objHistoriaClinica.StrDescripcionColecistopatia + "','" + objHistoriaClinica.StrIndHepatitis + "','" + objHistoriaClinica.StrDescripcionHepatitis + "','" + objHistoriaClinica.StrIndEnfermedadesNeurologicas + "','" + objHistoriaClinica.StrDescripcionEnfermedadesNeurologicas + "','" + objHistoriaClinica.StrIndFiebresProlongadas + "','" + objHistoriaClinica.StrDescripcionFiebresProlongadas + "','" + objHistoriaClinica.StrIndColagenopatia + "','" + objHistoriaClinica.StrDescripcionColagenopatia + "','" + objHistoriaClinica.StrOtrosAntecedentes + "')";
                    cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                    cmdComandoSQL.Prepare();
                    cmdComandoSQL.ExecuteNonQuery();

                    int numIdAntecednetes = 0;

                    strSentenciaSQL = "SELECT MAX(Id_Antecedentes) FROM Antecedentes ";

                    cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                    cmdComandoSQL.Prepare();
                    sqlLector = cmdComandoSQL.ExecuteReader();

                    while (sqlLector.Read())
                    {
                        numIdAntecednetes = sqlLector.GetInt32(0);
                        break;
                    }

                    sqlLector.Close();

                    //HISTORIA CLINICA
                    strSentenciaSQL = "INSERT INTO HistoriaClinica";
                    strSentenciaSQL += "(Numero, Id_Paciente, Id_Antecedentes, FechaRegistro, UsuarioCreacion) ";
                    strSentenciaSQL += "VALUES ('1234'," + numIdPaciente + "," + numIdAntecednetes + ",GETDATE()," + numIdUsuario + ")";
                    cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                    cmdComandoSQL.Prepare();
                    cmdComandoSQL.ExecuteNonQuery();

                    //int numIdHistoriaClinica = 0;

                    strSentenciaSQL = "SELECT MAX(Id_HistoriaClinica) FROM HistoriaClinica ";

                    cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                    cmdComandoSQL.Prepare();
                    sqlLector = cmdComandoSQL.ExecuteReader();

                    while (sqlLector.Read())
                    {
                        numIdHC = sqlLector.GetInt32(0);
                        break;
                    }

                    sqlLector.Close();
                }
                else
                {
                    int numIdAntecedente = 0;

                    strSentenciaSQL = "SELECT Id_Antecedentes FROM HistoriaClinica WHERE Id_HistoriaClinica = " + numIdHC;

                    cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                    cmdComandoSQL.Prepare();
                    sqlLector = cmdComandoSQL.ExecuteReader();

                    while (sqlLector.Read())
                    {
                        numIdAntecedente = sqlLector.GetInt32(0);
                        break;
                    }

                    sqlLector.Close();

                    //ANTECEDENTES
                    strSentenciaSQL = "UPDATE Antecedentes ";
                    strSentenciaSQL += "SET IndTabaco = '" + objHistoriaClinica.StrIndTabaco + "', IndAlcohol = '" + objHistoriaClinica.StrIndAlcohol + "', IndCafe = '" + objHistoriaClinica.StrIndCafe + "', " + 
                                            "IndTe = '" + objHistoriaClinica.StrIndTe + "', IndDrogas = '" + objHistoriaClinica.StrIndDrogas + "', IndDiabetes = '" + objHistoriaClinica.StrIndDiabetes + "', DescripcionDiabetes = '" + objHistoriaClinica.StrDescripcionDiabetes + "', " +
                                            "IndHipertension = '" + objHistoriaClinica.StrIndHipertension + "', DescripcionHipertension = '" + objHistoriaClinica.StrDescripcionHipertension + "', IndCoronariopatia = '" + objHistoriaClinica.StrIndCoronariopatia + "', " + 
                                            "DescripcionCoronariopatia = '" + objHistoriaClinica.StrDescripcionCoronariopatia + "', IndDislipidemia = '" + objHistoriaClinica.StrIndDislipidemia + "', DescripcionDislipidemia = '" + objHistoriaClinica.StrDescripcionDislipidemia + "', " + 
                                            "IndAsma = '" + objHistoriaClinica.StrIndAsma + "', DescripcionAsma = '" + objHistoriaClinica.StrDescripcionAsma + "', IndPsicopatia = '" + objHistoriaClinica.StrIndPsicopatia + "', DescripcionPsicopatia = '" + objHistoriaClinica.StrDescripcionPsicopatia + "', " + 
                                            "IndAlergias = '" + objHistoriaClinica.StrIndAlergias + "', DescripcionAlergias = '" + objHistoriaClinica.StrDescripcionAlergias + "', IndTuberculosis = '" + objHistoriaClinica.StrIndTuberculosis + "', DescripcionTuberculosis = '" + objHistoriaClinica.StrDescripcionTuberculosis + "', " + 
                                            "IndAtipia = '" + objHistoriaClinica.StrIndAtipia + "', DescripcionAtipia = '" + objHistoriaClinica.StrDescripcionAtipia + "', IndGota = '" + objHistoriaClinica.StrIndGota + "', DescripcionGota = '" + objHistoriaClinica.StrDescripcionGota + "', IndEndocrinopatia = '" + objHistoriaClinica.StrIndEndocrinopatia + "', " + 
                                            "DescripcionEndocrinopatia = '" + objHistoriaClinica.StrDescripcionEndocrinopatia + "', IndNefropatia = '" + objHistoriaClinica.StrIndNefropatia + "', DescripcionNefropatia = '" + objHistoriaClinica.StrDescripcionNefropatia + "', " + 
                                            "IndUropatia = '" + objHistoriaClinica.StrIndUropatia + "', DescripcionUropatia = '" +  objHistoriaClinica.StrDescripcionUropatia + "', IndHemopatia = '" + objHistoriaClinica.StrIndHemopatia + "', DescripcionHemopatia = '" + objHistoriaClinica.StrDescripcionHemopatia + "', " + 
                                            "IndETS = '" + objHistoriaClinica.StrIndETS + "', DescripcionETS = '" + objHistoriaClinica.StrDescripcionETS + "', IndUlcera = '" + objHistoriaClinica.StrIndUlcera + "', DescripcionUlcera = '" + objHistoriaClinica.StrDescripcionUlcera + "', " + 
                                            "IndColecistopatia = '" + objHistoriaClinica.StrIndColecistopatia + "', DescripcionColecistopatia = '" + objHistoriaClinica.StrDescripcionColecistopatia + "', IndHepatitis = '" + objHistoriaClinica.StrIndHepatitis + "', DescripcionHepatitis = '" + objHistoriaClinica.StrDescripcionHepatitis + "', " + 
                                            "IndEnfermedadesNeurologicas = '" + objHistoriaClinica.StrIndEnfermedadesNeurologicas + "', DescripcionEnfermedadesNeurologicas = '" + objHistoriaClinica.StrDescripcionEnfermedadesNeurologicas + "', IndFiebresProlongadas = '" + objHistoriaClinica.StrIndFiebresProlongadas + "', DescripcionFiebresProlongadas = '" + objHistoriaClinica.StrDescripcionFiebresProlongadas + "', " +
                                            "IndColagenopatia = '" + objHistoriaClinica.StrIndColagenopatia + "', DescripcionColagenopatia = '" + objHistoriaClinica.StrDescripcionColagenopatia + "', Otros = '" + objHistoriaClinica.StrOtrosAntecedentes + "' WHERE Id_Antecedentes = " + numIdAntecedente;
                    cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                    cmdComandoSQL.Prepare();
                    cmdComandoSQL.ExecuteNonQuery();
                }

                //AGREGAR EPISODIO A HISTORIA CLINICA
                strSentenciaSQL = "INSERT INTO EpisodiosxHistoriaClinica";
                strSentenciaSQL += "(Id_HistoriaClinica, Id_Episodio) ";
                strSentenciaSQL += "VALUES (" + numIdHC + "," + numIdEpisodio + ")";
                cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

                cmdComandoSQL.Prepare();
                cmdComandoSQL.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void cargarCIE10()
        {
            SqlConnection sqlConexion = clsGestorBD.Conectar();
            SqlCommand sqlComando = new SqlCommand("SELECT Descripcion FROM Cie10", sqlConexion);
            sqlConexion.Open();
            SqlDataReader sqlLector = sqlComando.ExecuteReader();

            while (sqlLector.Read())
            {
                txtDiagnostico.AutoCompleteCustomSource.Add(sqlLector[0].ToString());
            }

            sqlLector.Close();
            sqlConexion.Close();
        }

        private int obtenerIdCie10(string strDescripcion)
        {
            int numId = 0;
            SqlConnection sqlConexion = clsGestorBD.Conectar();
            SqlCommand sqlComando = new SqlCommand("SELECT Id_Cie10 FROM Cie10 WHERE Descripcion = '" + strDescripcion + "'", sqlConexion);
            sqlConexion.Open();
            SqlDataReader sqlLector = sqlComando.ExecuteReader();

            while (sqlLector.Read())
            {
                numId = Int32.Parse(sqlLector[0].ToString());
            }

            sqlLector.Close();
            sqlConexion.Close();

            return numId;
        }

        private void inicializarVentana()
        {
            cboSexo.SelectedIndex = 0;
            cboRaza.SelectedIndex = 0;
            cboReligion.SelectedIndex = 0;
            cboOcupacion.SelectedIndex = 0;
            cboEstadoCivil.SelectedIndex = 0;
            cboGrupoSanguineo.SelectedIndex = 0;
            cboFactorSanguineo.SelectedIndex = 0;
            int numAnos = calcularEdad();
            txtEdad.Text = numAnos + "";

            List<clsPais> lstPaises = clsGestorLogico.up_SelPais();
            llenarComboPais(lstPaises);
            cboPais.SelectedIndex = 0;

            List<clsUbigeo> lstDepartamentos = clsGestorLogico.up_SelDepartamento();
            llenarComboDepartamento(lstDepartamentos);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //PACIENTE:
                objPaciente.StrApellidoPaterno = txtPaterno.Text;
                objPaciente.StrApellidoMaterno = txtMaterno.Text;
                objPaciente.StrNombres = txtNombres.Text;
                objPaciente.StrSexo = cboSexo.SelectedItem.ToString();
                objPaciente.StrRaza = cboRaza.SelectedItem.ToString();
                objPaciente.StrReligion = cboReligion.SelectedItem.ToString();
                objPaciente.StrOcupacion = cboOcupacion.SelectedItem.ToString();
                objPaciente.DtFechaNacimiento = dtpFechaNacimiento.Value;
                objPaciente.StrGrupoSanguineo = cboGrupoSanguineo.SelectedItem.ToString();
                objPaciente.StrFactorSanguineo = cboFactorSanguineo.SelectedItem.ToString();
                objPaciente.StrPais = cboPais.SelectedItem.ToString();
                objPaciente.StrDepartamentoNacimiento = cboDepartamento.SelectedItem.ToString();
                objPaciente.StrProvinciaNacimiento = cboProvincia.SelectedItem.ToString();
                objPaciente.StrDistritoNacimiento = cboDistrito.SelectedItem.ToString();
                objPaciente.StrDepartamentoDomicilio = cboDepartamentoDomicilio.SelectedItem.ToString();
                objPaciente.StrProvinciaDomicilio = cboProvinciaDomicilio.SelectedItem.ToString();
                objPaciente.StrDistritoDomicilio = cboDistritoDomicilio.SelectedItem.ToString();
                objPaciente.StrDireccionDomicilio = txtDireccion.Text;
            }
            catch
            {
            }
            //EPISODIO:
            objEpisodio.StrEctoscopia = rtxtEctoscopiaActual.Text;
            objEpisodio.StrTiempoEnfermedad = txtTiempoEnfermedad.Text;
            objEpisodio.StrInicioEnfermedad = txtInicioEnfermedad.Text;
            objEpisodio.StrCursoEnfermedad = txtCursoEnfermedad.Text;
            objEpisodio.StrSintomasPrincipales = rtxtSintomasEnfermedad.Text;
            objEpisodio.StrRelatoCronológico = rtxtRelatoCronologico.Text;

            //EX. FISICO:
            objEpisodio.StrTemperatura = txtTemperatura.Text;
            objEpisodio.StrFrecuenciaCardiaca = txtFrecuenciaCardiaca.Text;
            objEpisodio.StrPulso = txtPulso.Text;
            objEpisodio.StrFrecuenciaRespiratoria = txtFrecuenciaRespiratoria.Text;
            objEpisodio.StrPresionArteria = txtPresionArterial.Text;
            objEpisodio.StrPeso = txtPeso.Text;
            objEpisodio.StrTalla = txtTalla.Text;
            objEpisodio.StrOtrosExamenes = rtxtOtrosExamenes.Text;

            //ANTECEDENTES
            objHistoriaClinica.StrOtrosAntecedentes = rtxtOtrosAntecedentes.Text;
            objHistoriaClinica.StrDescripcionDiabetes = txtDiabetes.Text;
            objHistoriaClinica.StrDescripcionHipertension = txtHipertensionArterial.Text;
            objHistoriaClinica.StrDescripcionCoronariopatia = txtCoronariopatia.Text;
            objHistoriaClinica.StrDescripcionDislipidemia = txtDislipidemia.Text;
            objHistoriaClinica.StrDescripcionAsma = txtAsma.Text;
            objHistoriaClinica.StrDescripcionPsicopatia = txtPsicopatia.Text;
            objHistoriaClinica.StrDescripcionAlergias = txtAlergias.Text;
            objHistoriaClinica.StrDescripcionTuberculosis = txtTuberculosis.Text;
            objHistoriaClinica.StrDescripcionAtipia = txtAtipia.Text;
            objHistoriaClinica.StrDescripcionGota= txtGota.Text;
            objHistoriaClinica.StrDescripcionEndocrinopatia = txtEndocrinopatia.Text;
            objHistoriaClinica.StrDescripcionNefropatia = txtNefropatia.Text;
            objHistoriaClinica.StrDescripcionUropatia = txtUropatia.Text;
            objHistoriaClinica.StrDescripcionHemopatia = txtHemopatia.Text;
            objHistoriaClinica.StrDescripcionETS = txtETS.Text;
            objHistoriaClinica.StrDescripcionUlcera = txtUlcera.Text;
            objHistoriaClinica.StrDescripcionColecistopatia = txtColecistopatia.Text;
            objHistoriaClinica.StrDescripcionHepatitis = txtHepatitis.Text;
            objHistoriaClinica.StrDescripcionEnfermedadesNeurologicas = txtEnfermedadesNeurologicas.Text;
            objHistoriaClinica.StrDescripcionFiebresProlongadas = txtFiebresProlongadas.Text;
            objHistoriaClinica.StrDescripcionColagenopatia = txtColagenopatia.Text;

            //DIAGNOSTICO
            objEpisodio.NumCie10 = obtenerIdCie10(txtDiagnostico.Text);
            objEpisodio.StrDescripcionCIE10 = rtxtDiagnosticoActual.Text;

            guardarHistoriaClinica(objPaciente, objEpisodio, objHistoriaClinica);

            MessageBox.Show("La Historia Clínica se guardó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cargarEctoscopias(int numIdHC)
        {
            String strSentenciaSQL;
            SqlCommand cmdComandoSQL;
            SqlDataReader sqlLector;
            SqlConnection con = clsGestorBD.Conectar();

            con.Open();

            //ENFERMEDAD ACTUAL
            strSentenciaSQL = "SELECT E.FechaRegistro, E.Ectoscopia FROM Episodio E, HistoriaClinica H, EpisodiosxHistoriaClinica X WHERE X.Id_Episodio = E.Id_Episodio AND H.Id_HistoriaClinica = " + numIdHC + " ORDER BY FechaRegistro DESC";
            cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

            cmdComandoSQL.Prepare();
            sqlLector = cmdComandoSQL.ExecuteReader();

            string strEctoscopia = "";

            while (sqlLector.Read())
            {
                strEctoscopia += sqlLector.GetString(0) + ":\n";
                strEctoscopia += "================\n";
                strEctoscopia += sqlLector.GetString(1);
                strEctoscopia += "\n\n";
            }

            rtxtEctoscopiaAnterior.Text = strEctoscopia;

            sqlLector.Close();
            con.Close();
        }

        private void cargarAntecedentes(int numIdPaciente)
        {
            String strSentenciaSQL;
            SqlCommand cmdComandoSQL;
            SqlDataReader sqlLector;
            SqlConnection con = clsGestorBD.Conectar();

            con.Open();

            //ENFERMEDAD ACTUAL
            strSentenciaSQL = "SELECT * FROM Antecedentes, HistoriaClinica WHERE HistoriaClinica.Id_Antecedentes = Antecedentes.Id_Antecedentes and HistoriaClinica.Id_Paciente = " + numIdPaciente;
            cmdComandoSQL = new SqlCommand(strSentenciaSQL, con);

            cmdComandoSQL.Prepare();
            sqlLector = cmdComandoSQL.ExecuteReader();

            while (sqlLector.Read())
            {
                if (sqlLector.GetString(1).CompareTo("X") == 0)
                {
                    cbxTabaco.Checked = true;
                }
                if (sqlLector.GetString(2).CompareTo("X") == 0)
                {
                    cbxAlcohol.Checked = true;
                }
                if (sqlLector.GetString(3).CompareTo("X") == 0)
                {
                    cbxCafe.Checked = true;
                }
                if (sqlLector.GetString(4).CompareTo("X") == 0)
                {
                    cbxTe.Checked = true;
                }
                if (sqlLector.GetString(5).CompareTo("X") == 0)
                {
                    cbxDrogas.Checked = true;
                }
                if (sqlLector.GetString(6).CompareTo("X") == 0)
                {
                    cbxDiabetes.Checked = true;
                    txtDiabetes.Text = sqlLector.GetString(7);
                }
                if (sqlLector.GetString(8).CompareTo("X") == 0)
                {
                    cbxHipertensionArterial.Checked = true;
                    txtHipertensionArterial.Text = sqlLector.GetString(9);
                }
                if (sqlLector.GetString(10).CompareTo("X") == 0)
                {
                    cbxCoronariopatia.Checked = true;
                    txtCoronariopatia.Text = sqlLector.GetString(11);
                }
                if (sqlLector.GetString(12).CompareTo("X") == 0)
                {
                    cbxDislipidemia.Checked = true;
                    txtDislipidemia.Text = sqlLector.GetString(13);
                }
                if (sqlLector.GetString(14).CompareTo("X") == 0)
                {
                    cbxAsma.Checked = true;
                    txtAsma.Text = sqlLector.GetString(15);
                }
                if (sqlLector.GetString(16).CompareTo("X") == 0)
                {
                    cbxPsicopatia.Checked = true;
                    txtPsicopatia.Text = sqlLector.GetString(17);
                }
                if (sqlLector.GetString(18).CompareTo("X") == 0)
                {
                    cbxAlergias.Checked = true;
                    txtAlergias.Text = sqlLector.GetString(19);
                }
                if (sqlLector.GetString(20).CompareTo("X") == 0)
                {
                    cbxTuberculosis.Checked = true;
                    txtTuberculosis.Text = sqlLector.GetString(21);
                }
                if (sqlLector.GetString(22).CompareTo("X") == 0)
                {
                    cbxAtipia.Checked = true;
                    txtAtipia.Text = sqlLector.GetString(23);
                }
                if (sqlLector.GetString(24).CompareTo("X") == 0)
                {
                    cbxGota.Checked = true;
                    txtGota.Text = sqlLector.GetString(25);
                }
                if (sqlLector.GetString(26).CompareTo("X") == 0)
                {
                    cbxEndocrinopatia.Checked = true;
                    txtEndocrinopatia.Text = sqlLector.GetString(27);
                }
                if (sqlLector.GetString(28).CompareTo("X") == 0)
                {
                    cbxNefropatia.Checked = true;
                    txtNefropatia.Text = sqlLector.GetString(29);
                }
                if (sqlLector.GetString(30).CompareTo("X") == 0)
                {
                    cbxUropatia.Checked = true;
                    txtUropatia.Text = sqlLector.GetString(31);
                }
                if (sqlLector.GetString(32).CompareTo("X") == 0)
                {
                    cbxHemopatia.Checked = true;
                    txtHemopatia.Text = sqlLector.GetString(33);
                }
                if (sqlLector.GetString(34).CompareTo("X") == 0)
                {
                    cbxETS.Checked = true;
                    txtETS.Text = sqlLector.GetString(35);
                }
                if (sqlLector.GetString(36).CompareTo("X") == 0)
                {
                    cbxUlcera.Checked = true;
                    txtUlcera.Text = sqlLector.GetString(37);
                }
                if (sqlLector.GetString(38).CompareTo("X") == 0)
                {
                    cbxColecistopatia.Checked = true;
                    txtColecistopatia.Text = sqlLector.GetString(39);
                }
                if (sqlLector.GetString(40).CompareTo("X") == 0)
                {
                    cbxHepatitis.Checked = true;
                    txtHepatitis.Text = sqlLector.GetString(41);
                }
                if (sqlLector.GetString(42).CompareTo("X") == 0)
                {
                    cbxEnfermedadesNeurologicas.Checked = true;
                    txtEnfermedadesNeurologicas.Text = sqlLector.GetString(43);
                }
                if (sqlLector.GetString(44).CompareTo("X") == 0)
                {
                    cbxFiebresProlongadas.Checked = true;
                    txtFiebresProlongadas.Text = sqlLector.GetString(45);
                }
                if (sqlLector.GetString(46).CompareTo("X") == 0)
                {
                    cbxColagenopatia.Checked = true;
                    txtColagenopatia.Text = sqlLector.GetString(47);
                }
                
                rtxtOtrosAntecedentes.Text = sqlLector.GetString(48);
                
                break;
            }

            sqlLector.Close();
            con.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (dgvHistoriasClinicas.RowCount > 0)
            {
                numIdPaciente = Int32.Parse(dgvHistoriasClinicas.Rows[dgvHistoriasClinicas.CurrentRow.Index].Cells[0].Value.ToString());

                if (tieneHistoriaClinica(numIdPaciente))
                {
                    blnTieneHC = true;

                    cargarAntecedentes(numIdPaciente);
                    cargarEctoscopias(numIdHC);
                }
                else
                {
                    blnTieneHC = false;
                }

                clsComun.tabSiguiente(tbcHistoriaClinica, tbpBuscar, tbpDetalle);

                tbcHistoriaClinicaPartes.SelectedTab = tbpEctoscopia;

                rtxtEctoscopiaActual.Focus();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvHistoriasClinicas.SelectedRows.Count > 0)
            {
            }
            else
            {
                MessageBox.Show("Debe seleccionar una historia clínica", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvHistoriasClinicas.SelectedRows.Count > 0)
            {
            }
            else
            {
                MessageBox.Show("Debe seleccionar una historia clínica", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbcHistoriaClinica_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcHistoriaClinica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcHistoriaClinica.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcHistoriaClinica, tbpBuscar, tbpDetalle);
        }

        private void cbxDiabetes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDiabetes.Checked)
            {
                txtDiabetes.Enabled = true;
                objHistoriaClinica.StrIndDiabetes = "X";
            }
            else
            {
                txtDiabetes.Clear();
                txtDiabetes.Enabled = false;
                objHistoriaClinica.StrIndDiabetes = "";
            }
        }

        private void cbxHipertensionArterial_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHipertensionArterial.Checked)
            {
                txtHipertensionArterial.Enabled = true;
                objHistoriaClinica.StrIndHipertension = "X";
            }
            else
            {
                txtHipertensionArterial.Clear();
                txtHipertensionArterial.Enabled = false;
                objHistoriaClinica.StrIndHipertension = "";
            }
        }

        private void cbxCoronariopatia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCoronariopatia.Checked)
            {
                txtCoronariopatia.Enabled = true;
                objHistoriaClinica.StrIndCoronariopatia = "X";
            }
            else
            {
                txtCoronariopatia.Clear();
                txtCoronariopatia.Enabled = false;
                objHistoriaClinica.StrIndCoronariopatia = "";
            }
        }

        private void cbxDislipidemia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDislipidemia.Checked)
            {
                txtDislipidemia.Enabled = true;
                objHistoriaClinica.StrIndDislipidemia = "X";
            }
            else
            {
                txtDislipidemia.Clear();
                txtDislipidemia.Enabled = false;
                objHistoriaClinica.StrIndDislipidemia = "";
            }
        }

        private void cbxAsma_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAsma.Checked)
            {
                txtAsma.Enabled = true;
                objHistoriaClinica.StrIndAsma = "X";
            }
            else
            {
                txtAsma.Clear();
                txtAsma.Enabled = false;
                objHistoriaClinica.StrIndAsma = "";
            }
        }

        private void cbxPsicopatia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPsicopatia.Checked)
            {
                txtPsicopatia.Enabled = true;
                objHistoriaClinica.StrIndPsicopatia = "X";                
            }
            else
            {
                txtPsicopatia.Clear();
                txtPsicopatia.Enabled = false;
                objHistoriaClinica.StrIndPsicopatia = "";
            }
        }

        private void cbxAlergias_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAlergias.Checked)
            {
                txtAlergias.Enabled = true;
                objHistoriaClinica.StrIndAlergias = "X";
            }
            else
            {
                txtAlergias.Clear();
                txtAlergias.Enabled = false;
                objHistoriaClinica.StrIndAlergias = "";
            }
        }

        private void cbxTuberculosis_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTuberculosis.Checked)
            {
                txtTuberculosis.Enabled = true;
                objHistoriaClinica.StrIndTuberculosis = "X";
            }
            else
            {
                txtTuberculosis.Clear();
                txtTuberculosis.Enabled = false;
                objHistoriaClinica.StrIndTuberculosis = "";
            }
        }

        private void cbxAtipia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAtipia.Checked)
            {
                txtAtipia.Enabled = true;
                objHistoriaClinica.StrIndAtipia = "X";
            }
            else
            {
                txtAtipia.Clear();
                txtAtipia.Enabled = false;
                objHistoriaClinica.StrIndAtipia = "";
            }
        }

        private void cbxGota_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxGota.Checked)
            {
                txtGota.Enabled = true;
                objHistoriaClinica.StrIndGota = "X";
            }
            else
            {
                txtGota.Clear();
                txtGota.Enabled = false;
                objHistoriaClinica.StrIndGota = "";
            }
        }

        private void cbxEndocrinopatia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEndocrinopatia.Checked)
            {
                txtEndocrinopatia.Enabled = true;
                objHistoriaClinica.StrIndEndocrinopatia = "X";
            }
            else
            {
                txtEndocrinopatia.Clear();
                txtEndocrinopatia.Enabled = false;
                objHistoriaClinica.StrIndEndocrinopatia = "";
            }
        }

        private void cbxNefropatia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNefropatia.Checked)
            {
                txtNefropatia.Enabled = true;
                objHistoriaClinica.StrIndNefropatia = "X";
            }
            else
            {
                txtNefropatia.Clear();
                txtNefropatia.Enabled = false;
                objHistoriaClinica.StrIndNefropatia = "";
            }
        }

        private void cbxUropatia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxUropatia.Checked)
            {
                txtUropatia.Enabled = true;
                objHistoriaClinica.StrIndUropatia = "X";
            }
            else
            {
                txtUropatia.Clear();
                txtUropatia.Enabled = false;
                objHistoriaClinica.StrIndUropatia = "";
            }
        }

        private void cbxHemopatia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHemopatia.Checked)
            {
                txtHemopatia.Enabled = true;
                objHistoriaClinica.StrIndHemopatia = "X";
            }
            else
            {
                txtHemopatia.Clear();
                txtHemopatia.Enabled = false;
                objHistoriaClinica.StrIndHemopatia = "";
            }
        }

        private void cbxETS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxETS.Checked)
            {
                txtETS.Enabled = true;
                objHistoriaClinica.StrIndETS = "X";
            }
            else
            {
                txtETS.Clear();
                txtETS.Enabled = false;
                objHistoriaClinica.StrIndETS = "";
            }
        }

        private void cbxUlcera_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxUlcera.Checked)
            {
                txtUlcera.Enabled = true;
                objHistoriaClinica.StrIndUlcera = "X";
            }
            else
            {
                txtUlcera.Clear();
                txtUlcera.Enabled = false;
                objHistoriaClinica.StrIndUlcera = "";
            }
        }

        private void cbxColecistopatia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxColecistopatia.Checked)
            {
                txtColecistopatia.Enabled = true;
                objHistoriaClinica.StrIndColecistopatia = "X";
            }
            else
            {
                txtColecistopatia.Clear();
                txtColecistopatia.Enabled = false;
                objHistoriaClinica.StrIndColecistopatia = "";
            }
        }

        private void cbxHepatitis_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHepatitis.Checked)
            {
                txtHepatitis.Enabled = true;
                objHistoriaClinica.StrIndHepatitis = "X";
            }
            else
            {
                txtHepatitis.Clear();
                txtHepatitis.Enabled = false;
                objHistoriaClinica.StrIndHepatitis = "";
            }
        }

        private void cbxEnfermedadesNeurologicas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEnfermedadesNeurologicas.Checked)
            {
                txtEnfermedadesNeurologicas.Enabled = true;
                objHistoriaClinica.StrIndEnfermedadesNeurologicas = "X";
            }
            else
            {
                txtEnfermedadesNeurologicas.Clear();
                txtEnfermedadesNeurologicas.Enabled = false;
                objHistoriaClinica.StrIndEnfermedadesNeurologicas = "";
            }
        }

        private void cbxFiebresProlongadas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFiebresProlongadas.Checked)
            {
                txtFiebresProlongadas.Enabled = true;
                objHistoriaClinica.StrIndFiebresProlongadas = "X";
            }
            else
            {
                txtFiebresProlongadas.Clear();
                txtFiebresProlongadas.Enabled = false;
                objHistoriaClinica.StrIndFiebresProlongadas = "";
            }
        }

        private void cbxColagenopatia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxColagenopatia.Checked)
            {
                txtColagenopatia.Enabled = true;
                objHistoriaClinica.StrIndColagenopatia = "X";
            }
            else
            {
                txtColagenopatia.Clear();
                txtColagenopatia.Enabled = false;
                objHistoriaClinica.StrIndColagenopatia = "";
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

        private int calcularEdad()
        {
            int numAnos = DateTime.Now.Year - dtpFechaNacimiento.Value.Year;
            
            if (DateTime.Now.Subtract(dtpFechaNacimiento.Value.AddYears(numAnos)).TotalDays < 0)
            {
                numAnos = numAnos - 1;
            }

            return numAnos;
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                dtpFechaNacimiento.Value = DateTime.Now;
            }
            else
            {
                int numAnos = calcularEdad();
                txtEdad.Text = numAnos + "";
            }
            
        }

        private void txtDiagnostico_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxTabaco_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTabaco.Checked)
            {
                objHistoriaClinica.StrIndTabaco = "X";
            }
            else
            {
                objHistoriaClinica.StrIndTabaco = "";
            }
        }

        private void cbxAlcohol_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAlcohol.Checked)
            {
                objHistoriaClinica.StrIndAlcohol = "X";
            }
            else
            {
                objHistoriaClinica.StrIndAlcohol = "";
            }
        }

        private void cbxCafe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCafe.Checked)
            {
                objHistoriaClinica.StrIndCafe = "X";
            }
            else
            {
                objHistoriaClinica.StrIndCafe = "";
            }
        }

        private void cbxTe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTe.Checked)
            {
                objHistoriaClinica.StrIndTe = "X";
            }
            else
            {
                objHistoriaClinica.StrIndTe = "";
            }
        }

        private void cbxDrogas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDrogas.Checked)
            {
                objHistoriaClinica.StrIndDrogas = "X";
            }
            else
            {
                objHistoriaClinica.StrIndDrogas = "";
            }
        }
    }
}
