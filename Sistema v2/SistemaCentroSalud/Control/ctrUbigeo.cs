using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Acceso;

namespace Control
{
    public class ctrUbigeo
    {
        public static DataTable seleccionarDepartamentos()
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            
            return clsGestorBD.ejecutarStoredProcedure2("up_SelDepartamento", lstParametrosSQL);
        }

        public static DataTable seleccionarProvincias(string strCodDepartamento)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@CodDepartamento";
            sqlParametro.Value = strCodDepartamento;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            return clsGestorBD.ejecutarStoredProcedure2("up_SelProvincia", lstParametrosSQL);
        }

        public static DataTable seleccionarDistritos(string strCodDepartamento, string strCodProvincia)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@CodDepartamento";
            sqlParametro.Value = strCodDepartamento;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@CodProvincia";
            sqlParametro.Value = strCodProvincia;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            return clsGestorBD.ejecutarStoredProcedure2("up_SelDistrito", lstParametrosSQL);
        }
    }
}
