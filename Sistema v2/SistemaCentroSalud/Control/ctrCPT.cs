using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using Acceso;
using Modelo;

namespace Control
{
    public class ctrCPT
    {
        public static bool registrarCPT(clsCPT objCPT)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objCPT);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManCPT", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarCPT(clsCPT objCPT)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objCPT);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Accion";
            sqlParametro.Value = 1;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdGenerado";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManCPT", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool eliminarCPT(clsCPT objCPT)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objCPT);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Accion";
            sqlParametro.Value = 2;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdGenerado";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManCPT", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool recuperarCPT(clsCPT objCPT)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objCPT);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Accion";
            sqlParametro.Value = 3;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdGenerado";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManCPT", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsCPT seleccionarCPT(clsCPT objCPT)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objCPT);

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

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedure2("up_ManCPT", lstParametrosSQL);

            objCPT.Descripcion = dtResultado.Rows[0]["Descripcion"].ToString();

            return objCPT;
        }

        public static DataTable seleccionarCPTes(clsCPT objCPT)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objCPT);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Accion";
            sqlParametro.Value = 5;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdGenerado";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            return clsGestorBD.ejecutarStoredProcedure2("up_ManCPT", lstParametrosSQL);
        }

        public static DataTable seleccionarCPTesCriterios(clsCPT objCPT)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objCPT);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Accion";
            sqlParametro.Value = 6;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdGenerado";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            return clsGestorBD.ejecutarStoredProcedure2("up_ManCPT", lstParametrosSQL);
        }

        private static List<SqlParameter> crearLista(clsCPT objCPT)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objCPT.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@" + pi.Name;
                    sqlParametro.Value = pi.GetValue(objCPT, null);
                    sqlParametro.Direction = ParameterDirection.Input;

                    lstParametrosSQL.Add(sqlParametro);
                }
            }

            return lstParametrosSQL;
        }
    }
}
