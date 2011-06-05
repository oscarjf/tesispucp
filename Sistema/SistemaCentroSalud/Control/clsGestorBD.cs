using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Comun;
using System.Data.SqlClient;
using System.IO;

namespace Control
{
    public class clsGestorBD
    {
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
            
            //DOCTOR
            public static bool up_ManArea(int numId, string strPaterno, string strMaterno, string strNombres, int numSexo, DateTime dtFechaNacimiento, int numTipoDocumento, string strNumeroDocumento, string strEstadoCivil, int numLugarNacimiento, int numDomicilio, string strTelefono, string strCelular, string strEmail, DateTime dtFechaRegistro, string strTipoPersona)
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

        public static DataTable consultarSentencia(String strSentenciaSQL)
        {
            DataTable dt = new DataTable();

            return dt;
        }

        public static void ejecutarSentencia(String strSentenciaSQL)
        {

        }
    }
}
