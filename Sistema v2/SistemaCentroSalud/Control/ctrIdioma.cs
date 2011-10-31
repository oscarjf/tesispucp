using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Acceso;
using System.Reflection;
using Modelo;

namespace Control
{
    public class ctrIdioma
    {
        public static bool registrarIdioma(clsIdioma objIdioma)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objIdioma);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManIdioma", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarIdioma(clsIdioma objIdioma)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objIdioma);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManIdioma", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool eliminarIdioma(clsIdioma objIdioma)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objIdioma);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManIdioma", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool recuperarIdioma(clsIdioma objIdioma)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objIdioma);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManIdioma", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsIdioma seleccionarIdioma(clsIdioma objIdioma)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objIdioma);

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

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedure2("up_ManIdioma", lstParametrosSQL);

            objIdioma.Nombre = dtResultado.Rows[0]["Nombre"].ToString();
            objIdioma.Descripcion = dtResultado.Rows[0]["Descripcion"].ToString();

            return objIdioma;
        }

        public static DataTable seleccionarIdiomaes(clsIdioma objIdioma)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objIdioma);

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

            return clsGestorBD.ejecutarStoredProcedure2("up_ManIdioma", lstParametrosSQL);
        }

        public static DataTable seleccionarIdiomaesCriterios(clsIdioma objIdioma)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objIdioma);

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

            return clsGestorBD.ejecutarStoredProcedure2("up_ManIdioma", lstParametrosSQL);
        }

        private static List<SqlParameter> crearLista(clsIdioma objIdioma)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objIdioma.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@" + pi.Name;
                    sqlParametro.Value = pi.GetValue(objIdioma, null);
                    sqlParametro.Direction = ParameterDirection.Input;

                    lstParametrosSQL.Add(sqlParametro);
                }
            }

            return lstParametrosSQL;
        }
    }
}
