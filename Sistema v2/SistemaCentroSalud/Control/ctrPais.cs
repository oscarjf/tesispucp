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
    public class ctrPais
    {
        public static bool registrarPais(clsPais objPais)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPais);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManPais", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarPais(clsPais objPais)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPais);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManPais", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool eliminarPais(clsPais objPais)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPais);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManPais", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool recuperarPais(clsPais objPais)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPais);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedure("up_ManPais", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsPais seleccionarPais(clsPais objPais)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPais);

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

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedure2("up_ManPais", lstParametrosSQL);

            objPais.Nombre = dtResultado.Rows[0]["Nombre"].ToString();            

            return objPais;
        }

        public static DataTable seleccionarPaises(clsPais objPais)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPais);

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

            return clsGestorBD.ejecutarStoredProcedure2("up_ManPais", lstParametrosSQL);
        }

        public static DataTable seleccionarPaisesCriterios(clsPais objPais)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPais);

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

            return clsGestorBD.ejecutarStoredProcedure2("up_ManPais", lstParametrosSQL);
        }

        private static List<SqlParameter> crearLista(clsPais objPais)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objPais.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@" + pi.Name;
                    sqlParametro.Value = pi.GetValue(objPais, null);
                    sqlParametro.Direction = ParameterDirection.Input;

                    lstParametrosSQL.Add(sqlParametro);
                }
            }

            return lstParametrosSQL;
        }
    }
}
