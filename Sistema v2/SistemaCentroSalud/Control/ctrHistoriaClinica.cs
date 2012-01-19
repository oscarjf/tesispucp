﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Acceso;

namespace Control
{
    public class ctrHistoriaClinica
    {
        public static DataTable seleccionarEpisodios(int numIdPaciente)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
             
            SqlParameter sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdPaciente";
            sqlParametro.Value = numIdPaciente;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            return clsGestorBD.ejecutarStoredProcedureDataTable("up_SelEpisodios", lstParametrosSQL);
        }
    }
}