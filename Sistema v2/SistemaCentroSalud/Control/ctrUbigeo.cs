using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Acceso;
using System.Data;

namespace Control
{
    public class ctrUbigeo
    {
        public static DataTable seleccionarDepartamentos()
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            
            return clsGestorBD.ejecutarStoredProcedure2("up_SelDepartamento", lstParametrosSQL);
        }
    }
}
