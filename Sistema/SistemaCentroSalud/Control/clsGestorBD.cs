using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Comun;

namespace Control
{
    public class clsGestorBD
    {
        public const int INSERT = 0;
        public const int UPDATE = 1;
        public const int DELETE = 2;
        public const int RECOVER = 3;
        public const int SELECT = 4;
        public const int SELECTALL = 5;
        public const int SELECTCUSTOM = 6;
        public const int VER = 7;

        private static string strRuta = AppDomain.CurrentDomain.BaseDirectory;
        private static TextReader tr = new StreamReader(strRuta + "\\Acceso.txt");
        private static string strServidor = tr.ReadLine();
        private static string strCatalogo = tr.ReadLine();
        private static string strUsuario = tr.ReadLine();
        private static string strContrasena = tr.ReadLine();
        
        public static SqlConnection Conectar()
        {
            SqlConnection sqlConexion = new SqlConnection("Data Source=" + strServidor + "; Initial Catalog=" + strCatalogo + ";Integrated Security=SSPI");

            return sqlConexion;
        }

        #region Mantenimientos
            //TIPO DOCUMENTO
            public static DataTable up_SelTipoDocumento()
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelTipoDocumento", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }

            //PAIS
            public static DataTable up_SelPais()
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelPais", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }
        
            //UBIGEO
            public static DataTable up_SelDepartamento()
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelDepartamentos", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }

            public static DataTable up_SelProvincia(string strCodigoDepartamento)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelProvincias", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@CodDepartamento";
                    sqlParametro.Value = strCodigoDepartamento;
                    sqlComando.Parameters.Add(sqlParametro);

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }

            public static DataTable up_SelDistrito(string strCodigoDepartamento, string strCodigoProvincia)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelDistritos", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@CodDepartamento";
                    sqlParametro.Value = strCodigoDepartamento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@CodProvincia";
                    sqlParametro.Value = strCodigoProvincia;
                    sqlComando.Parameters.Add(sqlParametro);

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }

            //AREA
            public static DataTable up_SelArea(int numId, string strNombre, string strTipo, string strEstado, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelArea", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idArea";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombre";
                    sqlParametro.Value = strNombre;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@tipoArea";
                    sqlParametro.Value = strTipo;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estado";
                    sqlParametro.Value = strEstado;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }
            
            public static bool up_ManArea(int numId, string strNombre, string strTipo, string strDescripcion, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_ManArea", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idArea";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombre";
                    sqlParametro.Value = strNombre;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@descripcion";
                    sqlParametro.Value = strDescripcion;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@tipoArea";
                    sqlParametro.Value = strTipo;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);
                    
                    sqlComando.ExecuteNonQuery();

                    sqlConexion.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return false;
                }
            }
            
            //ESPECIALIDAD
            public static DataTable up_SelEspecialidad(int numId, string strNombre, string strEstado, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelEspecialidad", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idEspecialidad";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombre";
                    sqlParametro.Value = strNombre;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estado";
                    sqlParametro.Value = strEstado;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }

            public static bool up_ManEspecialidad(int numId, string strNombre, string strDescripcion, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_ManEspecialidad", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idEspecialidad";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombre";
                    sqlParametro.Value = strNombre;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@descripcion";
                    sqlParametro.Value = strDescripcion;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlComando.ExecuteNonQuery();

                    sqlConexion.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return false;
                }
            }
            
            //PERFIL
            public static DataTable up_SelPerfil(int numId, string strNombre, string strTipoPersonal, string strEstado, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelPerfil", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idPerfil";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombre";
                    sqlParametro.Value = strNombre;
                    sqlComando.Parameters.Add(sqlParametro);
                    
                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@tipoPersonal";
                    sqlParametro.Value = strTipoPersonal;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estado";
                    sqlParametro.Value = strEstado;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }

            //DOCTOR
            public static bool up_ManDoctor(int numId, string strPaterno, string strMaterno, string strNombres, string strSexo, DateTime dtFechaNacimiento, int numIdTipoDocumento, string strNumeroDocumento, string strEstadoCivil, string strPaisNacimiento, string strDepartamentoNacimiento, string strProvinciaNacimiento, string strDistritoNacimiento, string strDepartamentoDomicilio, string strProvinciaDomicilio, string strDistritoDomicilio, string strDireccion, string strTelefono, string strCelular, string strEmail, DateTime dtFechaRegistro, string strTipoPersona, string strUsuario, string strContrasena, string strTipoPersonal, int numIdPerfil, string strCMP, string strIndicadorHC, int numIdArea, int numIdEspecialidad, string strEstado, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_ManDoctor", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idPersona";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@paterno";
                    sqlParametro.Value = strPaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@materno";
                    sqlParametro.Value = strMaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombres";
                    sqlParametro.Value = strNombres;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@sexo";
                    sqlParametro.Value = strSexo;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@fechaNacimiento";
                    sqlParametro.Value = dtFechaNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idTipoDocumento";
                    sqlParametro.Value = numIdTipoDocumento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@numeroDocumento";
                    sqlParametro.Value = strNumeroDocumento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estadoCivil";
                    sqlParametro.Value = strEstadoCivil;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@paisNacimiento";
                    sqlParametro.Value = strPaisNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@departamentoNacimiento";
                    sqlParametro.Value = strDepartamentoNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@provinciaNacimiento";
                    sqlParametro.Value = strProvinciaNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@distritoNacimiento";
                    sqlParametro.Value = strDistritoNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@departamentoDomicilio";
                    sqlParametro.Value = strDepartamentoDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@provinciaDomicilio";
                    sqlParametro.Value = strProvinciaDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@distritoDomicilio";
                    sqlParametro.Value = strDistritoDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@direccionDomicilio";
                    sqlParametro.Value = strDireccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@telefono";
                    sqlParametro.Value = strTelefono;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@celular";
                    sqlParametro.Value = strCelular;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@email";
                    sqlParametro.Value = strEmail;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@fechaRegistro";
                    sqlParametro.Value = dtFechaRegistro;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@tipoPersona";
                    sqlParametro.Value = strTipoPersona;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@usuario";
                    sqlParametro.Value = strUsuario;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@contrasena";
                    sqlParametro.Value = strContrasena;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@tipoPersonal";
                    sqlParametro.Value = strTipoPersonal;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idPerfil";
                    sqlParametro.Value = numIdPerfil;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@cmp";
                    sqlParametro.Value = strCMP;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@indicadorHC";
                    sqlParametro.Value = strIndicadorHC;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idAreaMedica";
                    sqlParametro.Value = numIdArea;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idEspecialidad";
                    sqlParametro.Value = numIdEspecialidad;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estado";
                    sqlParametro.Value = strEstado;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlComando.ExecuteNonQuery();

                    sqlConexion.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return false;
                }
            }
        #endregion

            public static DataTable up_SelDoctor(int numId, string strNombre, string apPaterno, string apMaterno, string cmp, string nomespecialidad, string strEstado, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelDoctor", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idDoctor";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombres";
                    sqlParametro.Value = strNombre;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@ap_paterno";
                    sqlParametro.Value = apPaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@ap_materno";
                    sqlParametro.Value = apMaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@cmp";
                    sqlParametro.Value = cmp;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nomespecialidad";
                    sqlParametro.Value = nomespecialidad;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estado";
                    sqlParametro.Value = strEstado;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }

            //ENFERMERA
            public static bool up_ManEnfermera(int numId, string strPaterno, string strMaterno, string strNombres, string strSexo, DateTime dtFechaNacimiento, int numIdTipoDocumento, string strNumeroDocumento, string strEstadoCivil, string strPaisNacimiento, string strDepartamentoNacimiento, string strProvinciaNacimiento, string strDistritoNacimiento, string strDepartamentoDomicilio, string strProvinciaDomicilio, string strDistritoDomicilio, string strDireccion, string strTelefono, string strCelular, string strEmail, DateTime dtFechaRegistro, string strTipoPersona, string strUsuario, string strContrasena, string strTipoPersonal, int numIdPerfil, string strNumLicenciatura, int numIdArea, string strEstado, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_ManEnfermera", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idPersona";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@paterno";
                    sqlParametro.Value = strPaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@materno";
                    sqlParametro.Value = strMaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombres";
                    sqlParametro.Value = strNombres;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@sexo";
                    sqlParametro.Value = strSexo;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@fechaNacimiento";
                    sqlParametro.Value = dtFechaNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idTipoDocumento";
                    sqlParametro.Value = numIdTipoDocumento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@numeroDocumento";
                    sqlParametro.Value = strNumeroDocumento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estadoCivil";
                    sqlParametro.Value = strEstadoCivil;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@paisNacimiento";
                    sqlParametro.Value = strPaisNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@departamentoNacimiento";
                    sqlParametro.Value = strDepartamentoNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@provinciaNacimiento";
                    sqlParametro.Value = strProvinciaNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@distritoNacimiento";
                    sqlParametro.Value = strDistritoNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@departamentoDomicilio";
                    sqlParametro.Value = strDepartamentoDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@provinciaDomicilio";
                    sqlParametro.Value = strProvinciaDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@distritoDomicilio";
                    sqlParametro.Value = strDistritoDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@direccionDomicilio";
                    sqlParametro.Value = strDireccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@telefono";
                    sqlParametro.Value = strTelefono;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@celular";
                    sqlParametro.Value = strCelular;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@email";
                    sqlParametro.Value = strEmail;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@fechaRegistro";
                    sqlParametro.Value = dtFechaRegistro;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@tipoPersona";
                    sqlParametro.Value = strTipoPersona;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@usuario";
                    sqlParametro.Value = strUsuario;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@contrasena";
                    sqlParametro.Value = strContrasena;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@tipoPersonal";
                    sqlParametro.Value = strTipoPersonal;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idPerfil";
                    sqlParametro.Value = numIdPerfil;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@numerolicenciatura";
                    sqlParametro.Value = strNumLicenciatura;
                    sqlComando.Parameters.Add(sqlParametro);                    

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idAreaMedica";
                    sqlParametro.Value = numIdArea;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estado";
                    sqlParametro.Value = strEstado;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlComando.ExecuteNonQuery();

                    sqlConexion.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return false;
                }
            }

            public static DataTable up_SelEnfermera(int numId, string strNombre, string apPaterno, string apMaterno, string numlicenciatura, string nomarea, string strEstado, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelEnfermera", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idEnfermera";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombres";
                    sqlParametro.Value = strNombre;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@ap_paterno";
                    sqlParametro.Value = apPaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@ap_materno";
                    sqlParametro.Value = apMaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@numlicenciatura";
                    sqlParametro.Value = numlicenciatura;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nomArea";
                    sqlParametro.Value = nomarea;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estado";
                    sqlParametro.Value = strEstado;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }

            //TECNICO
            public static bool up_ManTecnico(int numId, string strPaterno, string strMaterno, string strNombres, string strSexo, DateTime dtFechaNacimiento, int numIdTipoDocumento, string strNumeroDocumento, string strEstadoCivil, string strPaisNacimiento, string strDepartamentoNacimiento, string strProvinciaNacimiento, string strDistritoNacimiento, string strDepartamentoDomicilio, string strProvinciaDomicilio, string strDistritoDomicilio, string strDireccion, string strTelefono, string strCelular, string strEmail, DateTime dtFechaRegistro, string strTipoPersona, string strUsuario, string strContrasena, string strTipoPersonal, int numIdPerfil, int numIdArea, string strEstado, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_ManTecnico", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idPersona";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@paterno";
                    sqlParametro.Value = strPaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@materno";
                    sqlParametro.Value = strMaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombres";
                    sqlParametro.Value = strNombres;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@sexo";
                    sqlParametro.Value = strSexo;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@fechaNacimiento";
                    sqlParametro.Value = dtFechaNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idTipoDocumento";
                    sqlParametro.Value = numIdTipoDocumento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@numeroDocumento";
                    sqlParametro.Value = strNumeroDocumento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estadoCivil";
                    sqlParametro.Value = strEstadoCivil;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@paisNacimiento";
                    sqlParametro.Value = strPaisNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@departamentoNacimiento";
                    sqlParametro.Value = strDepartamentoNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@provinciaNacimiento";
                    sqlParametro.Value = strProvinciaNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@distritoNacimiento";
                    sqlParametro.Value = strDistritoNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@departamentoDomicilio";
                    sqlParametro.Value = strDepartamentoDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@provinciaDomicilio";
                    sqlParametro.Value = strProvinciaDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@distritoDomicilio";
                    sqlParametro.Value = strDistritoDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@direccionDomicilio";
                    sqlParametro.Value = strDireccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@telefono";
                    sqlParametro.Value = strTelefono;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@celular";
                    sqlParametro.Value = strCelular;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@email";
                    sqlParametro.Value = strEmail;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@fechaRegistro";
                    sqlParametro.Value = dtFechaRegistro;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@tipoPersona";
                    sqlParametro.Value = strTipoPersona;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@usuario";
                    sqlParametro.Value = strUsuario;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@contrasena";
                    sqlParametro.Value = strContrasena;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@tipoPersonal";
                    sqlParametro.Value = strTipoPersonal;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idPerfil";
                    sqlParametro.Value = numIdPerfil;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idAreaMedica";
                    sqlParametro.Value = numIdArea;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estado";
                    sqlParametro.Value = strEstado;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlComando.ExecuteNonQuery();

                    sqlConexion.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return false;
                }
            }

            public static DataTable up_SelTecnico(int numId, string strNombre, string apPaterno, string apMaterno, string nomarea, string strEstado, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelTecnico", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idTecnico";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombres";
                    sqlParametro.Value = strNombre;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@ap_paterno";
                    sqlParametro.Value = apPaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@ap_materno";
                    sqlParametro.Value = apMaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nomArea";
                    sqlParametro.Value = nomarea;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estado";
                    sqlParametro.Value = strEstado;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }

            //ADMINISTRATIVO
            public static bool up_ManAdministrativo(int numId, string strPaterno, string strMaterno, string strNombres, string strSexo, DateTime dtFechaNacimiento, int numIdTipoDocumento, string strNumeroDocumento, string strEstadoCivil, string strPaisNacimiento, string strDepartamentoNacimiento, string strProvinciaNacimiento, string strDistritoNacimiento, string strDepartamentoDomicilio, string strProvinciaDomicilio, string strDistritoDomicilio, string strDireccion, string strTelefono, string strCelular, string strEmail, DateTime dtFechaRegistro, string strTipoPersona, string strUsuario, string strContrasena, string strTipoPersonal, int numIdPerfil, int numIdArea, string strEstado, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_ManAdministrativo", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idPersona";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@paterno";
                    sqlParametro.Value = strPaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@materno";
                    sqlParametro.Value = strMaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombres";
                    sqlParametro.Value = strNombres;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@sexo";
                    sqlParametro.Value = strSexo;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@fechaNacimiento";
                    sqlParametro.Value = dtFechaNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idTipoDocumento";
                    sqlParametro.Value = numIdTipoDocumento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@numeroDocumento";
                    sqlParametro.Value = strNumeroDocumento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estadoCivil";
                    sqlParametro.Value = strEstadoCivil;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@paisNacimiento";
                    sqlParametro.Value = strPaisNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@departamentoNacimiento";
                    sqlParametro.Value = strDepartamentoNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@provinciaNacimiento";
                    sqlParametro.Value = strProvinciaNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@distritoNacimiento";
                    sqlParametro.Value = strDistritoNacimiento;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@departamentoDomicilio";
                    sqlParametro.Value = strDepartamentoDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@provinciaDomicilio";
                    sqlParametro.Value = strProvinciaDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@distritoDomicilio";
                    sqlParametro.Value = strDistritoDomicilio;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@direccionDomicilio";
                    sqlParametro.Value = strDireccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@telefono";
                    sqlParametro.Value = strTelefono;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@celular";
                    sqlParametro.Value = strCelular;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@email";
                    sqlParametro.Value = strEmail;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@fechaRegistro";
                    sqlParametro.Value = dtFechaRegistro;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@tipoPersona";
                    sqlParametro.Value = strTipoPersona;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@usuario";
                    sqlParametro.Value = strUsuario;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@contrasena";
                    sqlParametro.Value = strContrasena;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@tipoPersonal";
                    sqlParametro.Value = strTipoPersonal;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idPerfil";
                    sqlParametro.Value = numIdPerfil;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idAreaAdministrativa";
                    sqlParametro.Value = numIdArea;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estado";
                    sqlParametro.Value = strEstado;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlComando.ExecuteNonQuery();

                    sqlConexion.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return false;
                }
            }

            public static DataTable up_SelAdministrativo(int numId, string strNombre, string apPaterno, string apMaterno, string nomarea, string strEstado, int numAccion)
            {
                try
                {
                    SqlConnection sqlConexion = Conectar();
                    sqlConexion.Open();

                    SqlCommand sqlComando = new SqlCommand("up_SelAdministrativo", sqlConexion);
                    sqlComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParametro;

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@idAdministrativo";
                    sqlParametro.Value = numId;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nombres";
                    sqlParametro.Value = strNombre;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@ap_paterno";
                    sqlParametro.Value = apPaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@ap_materno";
                    sqlParametro.Value = apMaterno;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@nomArea";
                    sqlParametro.Value = nomarea;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@estado";
                    sqlParametro.Value = strEstado;
                    sqlComando.Parameters.Add(sqlParametro);

                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@accion";
                    sqlParametro.Value = numAccion;
                    sqlComando.Parameters.Add(sqlParametro);

                    SqlDataAdapter sqlAdaptador = new SqlDataAdapter(sqlComando);
                    DataTable dtTabla = new DataTable();
                    sqlAdaptador.Fill(dtTabla);

                    sqlConexion.Close();

                    return dtTabla;
                }
                catch (Exception ex)
                {
                    clsComun.registrarErrorLog(ex.ToString());
                    return null;
                }
            }

        public static DataTable consultarSentencia(String strSentenciaSQL)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection sqlConexion = Conectar();
                SqlCommand sqlComando = new SqlCommand(strSentenciaSQL, sqlConexion);
                sqlConexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(sqlComando);
                da.Fill(dt);

                sqlConexion.Close();

                return dt;
            }
            catch (Exception ex)
            {
                clsComun.registrarErrorLog(ex.ToString());
                return null;
            }
        }

        public static bool ejecutarSentencia(String strSentenciaSQL)
        {
            try
            {
                SqlConnection sqlConexion = Conectar();
                SqlCommand sqlComando = new SqlCommand(strSentenciaSQL, sqlConexion);
                sqlConexion.Open();

                sqlComando.ExecuteNonQuery();
                sqlConexion.Close();

                return true;
            }
            catch (Exception ex)
            {
                clsComun.registrarErrorLog(ex.ToString());
                return false;
            }
        }
    }
}
