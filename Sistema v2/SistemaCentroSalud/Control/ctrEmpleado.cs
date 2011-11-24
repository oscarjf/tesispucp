using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Acceso;

namespace Control
{
    public class ctrEmpleado
    {
        public static bool validarIngreso(string strUsuario, string strContrasena)
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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ValidarAcceso", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
    }
}
