using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Acceso;

namespace Control
{
    public class ctrEmpleado
    {
        public static string generarNombreUsuario(int numIdEmpleado, string strPaterno, string strMaterno, string strNombres)
        {
            int contador = -1;
            string strParte1 = "", strParte2 = "", strParte3 = "", strNombreUsuario = "";

            if (strNombres.CompareTo("") != 0)
            {
                strParte1 = strNombres.Substring(0, 1);
            }

            if (strPaterno.CompareTo("") != 0)
            {
                strParte2 = strPaterno;
            }

            if (strMaterno.CompareTo("") != 0)
            {
                strParte3 = strMaterno.Substring(0, 1);
            }

            strNombreUsuario = strParte1 + strParte2 + strParte3;

            while (contador != 0)
            {
                List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
                SqlParameter sqlParametro;

                sqlParametro = new SqlParameter();
                sqlParametro.ParameterName = "@IdEmpleado";
                sqlParametro.Value = numIdEmpleado;
                sqlParametro.Direction = ParameterDirection.Input;

                lstParametrosSQL.Add(sqlParametro);

                sqlParametro = new SqlParameter();
                sqlParametro.ParameterName = "@Usuario";
                sqlParametro.Value = strNombreUsuario;
                sqlParametro.Direction = ParameterDirection.Input;

                lstParametrosSQL.Add(sqlParametro);

                sqlParametro = new SqlParameter();
                sqlParametro.ParameterName = "@Contador";
                sqlParametro.Value = 0;
                sqlParametro.Direction = ParameterDirection.Output;

                lstParametrosSQL.Add(sqlParametro);

                contador = clsGestorBD.ejecutarStoredProcedureInt("up_ValidarNombreUsuario", lstParametrosSQL);

                if (contador != 0)
                {
                    strNombreUsuario = strNombreUsuario + (contador + 1).ToString();
                }
            }

            return strNombreUsuario.ToLower();
        }

        public static int validarIngreso(string strUsuario, string strContrasena)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Usuario";
            sqlParametro.Value = strUsuario;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Contrasena";
            sqlParametro.Value = strContrasena;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Acceso";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            int numIdEmpleado = clsGestorBD.ejecutarStoredProcedureInt("up_ValidarAcceso", lstParametrosSQL);

            return numIdEmpleado;
        }

        public static bool validarCorreoElectronico(int numIdPersona, string strCorreoElectronico)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdPersona";
            sqlParametro.Value = numIdPersona;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@CorreoElectronico";
            sqlParametro.Value = strCorreoElectronico;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Contador";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ValidarCorreoElectronico", lstParametrosSQL);

            if (numResultado == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable obtenerDatosCuenta(string strCorreoElectronico)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@CorreoElectronico";
            sqlParametro.Value = strCorreoElectronico;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedureDataTable("up_SelDatosCuenta", lstParametrosSQL);

            if (dtResultado.Rows.Count != 0)
            {
                return dtResultado;
            }
            else
            {
                return null;
            }
        }

        public static DataTable obtenerMenusPerfil(int numIdEmpleado)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdEmpleado";
            sqlParametro.Value = numIdEmpleado;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedureDataTable("up_ObtenerMenus", lstParametrosSQL);

            if (dtResultado.Rows.Count != 0)
            {
                return dtResultado;
            }
            else
            {
                return null;
            }
        }

        public static string obtenerTipoEmpleado(int numIdEmpleado)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdEmpleado";
            sqlParametro.Value = numIdEmpleado;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedureDataTable("up_ObtenerTipoEmpleado", lstParametrosSQL);

            if (dtResultado.Rows.Count != 0)
            {
                return dtResultado.Rows[0]["TipoEmpleado"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static bool validarCambioCuenta(int numIdEmpleado, string strNombreUsuario, string strContrasena)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdEmpleado";
            sqlParametro.Value = numIdEmpleado;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Usuario";
            sqlParametro.Value = strNombreUsuario;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Contrasena";
            sqlParametro.Value = strContrasena;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Exito";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            int exito = clsGestorBD.ejecutarStoredProcedureInt("up_ValidarCambioCuenta", lstParametrosSQL);

            if (exito != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
