using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Acceso;
using Modelo;

namespace Control
{
    public class ctrTriaje
    {
        public static bool registrarTriaje(clsTriaje objTriaje)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objTriaje);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Accion";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdGenerado";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManTriaje", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarTriaje(clsTriaje objTriaje)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objTriaje);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Accion";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdGenerado";
            sqlParametro.Value = 1;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManTriaje", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsTriaje seleccionarTriaje(clsTriaje objTriaje)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objTriaje);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Accion";
            sqlParametro.Value = 4;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdGenerado";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedureDataTable("up_ManTriaje", lstParametrosSQL);

            if (dtResultado.Rows.Count > 0)
            {
                objTriaje.IdPaciente = Int32.Parse(dtResultado.Rows[0]["IdPaciente"].ToString());
                objTriaje.IdHistoriaClinica = Int32.Parse(dtResultado.Rows[0]["IdHistoriaClinica"].ToString());
                objTriaje.GrupoSanguineo = dtResultado.Rows[0]["GrupoSanguineo"].ToString();
                objTriaje.FactorSanguineo = dtResultado.Rows[0]["FactorSanguineo"].ToString();
                try
                {
                    objTriaje.IdModoIngreso = Int32.Parse(dtResultado.Rows[0]["IdModoIngreso"].ToString());
                }
                catch
                {
                    objTriaje.IdModoIngreso = 0;
                }
                objTriaje.Temperatura = dtResultado.Rows[0]["Temperatura"].ToString();
                objTriaje.FrecuenciaCardiaca = dtResultado.Rows[0]["FrecuenciaCardiaca"].ToString();
                objTriaje.FrecuenciaRespiratoria = dtResultado.Rows[0]["FrecuenciaRespiratoria"].ToString();
                objTriaje.PresionArterial = dtResultado.Rows[0]["PresionArterial"].ToString();
                objTriaje.Peso = dtResultado.Rows[0]["Peso"].ToString();
                objTriaje.Talla = dtResultado.Rows[0]["Talla"].ToString();
                objTriaje.Observaciones = dtResultado.Rows[0]["Observaciones"].ToString();
                objTriaje.IdExamenFisico = Int32.Parse(dtResultado.Rows[0]["IdExamenFisico"].ToString());
                objTriaje.IdEpisodio = Int32.Parse(dtResultado.Rows[0]["IdEpisodio"].ToString());
            }
            else
            {
                objTriaje = null;
            }

            return objTriaje;
        }

        private static List<SqlParameter> crearLista(clsTriaje objTriaje)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objTriaje.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@" + pi.Name;
                    sqlParametro.Value = pi.GetValue(objTriaje, null);
                    sqlParametro.Direction = ParameterDirection.Input;

                    lstParametrosSQL.Add(sqlParametro);
                }
            }

            return lstParametrosSQL;
        }
    }
}
