using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Reflection;
using System.Data;
using Acceso;
using Modelo;

namespace Control
{
    public class ctrReligion
    {
        public static bool registrarReligion(clsReligion objReligion)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objReligion);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManReligion", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarReligion(clsReligion objReligion)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objReligion);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManReligion", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool eliminarReligion(clsReligion objReligion)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objReligion);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManReligion", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool recuperarReligion(clsReligion objReligion)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objReligion);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManReligion", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsReligion seleccionarReligion(clsReligion objReligion)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objReligion);

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

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedure2("up_ManReligion", lstParametrosSQL);

            objReligion.Nombre = dtResultado.Rows[0]["Nombre"].ToString();
            objReligion.Descripcion = dtResultado.Rows[0]["Descripcion"].ToString();

            return objReligion;
        }

        public static DataTable seleccionarReligiones(clsReligion objReligion)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objReligion);

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

            return clsGestorBD.ejecutarStoredProcedure2("up_ManReligion", lstParametrosSQL);
        }

        public static DataTable seleccionarReligionesCriterios(clsReligion objReligion)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objReligion);

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

            return clsGestorBD.ejecutarStoredProcedure2("up_ManReligion", lstParametrosSQL);
        }

        private static List<SqlParameter> crearLista(clsReligion objReligion)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objReligion.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@" + pi.Name;
                    sqlParametro.Value = pi.GetValue(objReligion, null);
                    sqlParametro.Direction = ParameterDirection.Input;

                    lstParametrosSQL.Add(sqlParametro);
                }
            }

            return lstParametrosSQL;
        }
    }
}
