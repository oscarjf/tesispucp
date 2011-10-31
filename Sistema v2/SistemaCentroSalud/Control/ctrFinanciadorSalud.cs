using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Acceso;
using System.Reflection;
using System.Data;
using Modelo;

namespace Control
{
    public class ctrFinanciadorSalud
    {
        public static bool registrarFinanciadorSalud(clsFinanciadorSalud objFinanciadorSalud)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objFinanciadorSalud);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManFinanciadorSalud", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarFinanciadorSalud(clsFinanciadorSalud objFinanciadorSalud)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objFinanciadorSalud);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManFinanciadorSalud", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool eliminarFinanciadorSalud(clsFinanciadorSalud objFinanciadorSalud)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objFinanciadorSalud);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManFinanciadorSalud", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool recuperarFinanciadorSalud(clsFinanciadorSalud objFinanciadorSalud)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objFinanciadorSalud);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManFinanciadorSalud", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsFinanciadorSalud seleccionarFinanciadorSalud(clsFinanciadorSalud objFinanciadorSalud)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objFinanciadorSalud);

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

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedure2("up_ManFinanciadorSalud", lstParametrosSQL);

            objFinanciadorSalud.Nombre = dtResultado.Rows[0]["Nombre"].ToString();
            
            return objFinanciadorSalud;
        }

        public static DataTable seleccionarFinanciadorSaludes(clsFinanciadorSalud objFinanciadorSalud)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objFinanciadorSalud);

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

            return clsGestorBD.ejecutarStoredProcedure2("up_ManFinanciadorSalud", lstParametrosSQL);
        }

        public static DataTable seleccionarFinanciadorSaludesCriterios(clsFinanciadorSalud objFinanciadorSalud)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objFinanciadorSalud);

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

            return clsGestorBD.ejecutarStoredProcedure2("up_ManFinanciadorSalud", lstParametrosSQL);
        }

        private static List<SqlParameter> crearLista(clsFinanciadorSalud objFinanciadorSalud)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objFinanciadorSalud.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@" + pi.Name;
                    sqlParametro.Value = pi.GetValue(objFinanciadorSalud, null);
                    sqlParametro.Direction = ParameterDirection.Input;

                    lstParametrosSQL.Add(sqlParametro);
                }
            }

            return lstParametrosSQL;
        }
    }
}
