using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Acceso;
using Modelo;
using Comun;

namespace Control
{
    public class ctrEnfermero
    {
        public static bool registrarEnfermero(clsEnfermero objEnfermero)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objEnfermero);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManEnfermero", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarEnfermero(clsEnfermero objEnfermero)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objEnfermero);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManEnfermero", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool eliminarEnfermero(clsEnfermero objEnfermero)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objEnfermero);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManEnfermero", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool recuperarEnfermero(clsEnfermero objEnfermero)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objEnfermero);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManEnfermero", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsEnfermero seleccionarEnfermero(clsEnfermero objEnfermero)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objEnfermero);

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

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedureDataTable("up_ManEnfermero", lstParametrosSQL);
            
            objEnfermero.IdEnfermero = Int32.Parse(dtResultado.Rows[0]["IdPersona"].ToString());
            objEnfermero.Paterno = dtResultado.Rows[0]["Paterno"].ToString();
            objEnfermero.Materno = dtResultado.Rows[0]["Materno"].ToString();
            objEnfermero.Nombres = dtResultado.Rows[0]["Nombres"].ToString();
            objEnfermero.FechaNacimiento = DateTime.Parse(dtResultado.Rows[0]["FechaNacimiento"].ToString());
            objEnfermero.Sexo = dtResultado.Rows[0]["Sexo"].ToString();
            objEnfermero.IdTipoDocumento = Int32.Parse(dtResultado.Rows[0]["IdTipoDocumento"].ToString());
            objEnfermero._TipoDocumento = dtResultado.Rows[0]["TipoDocumento"].ToString();
            objEnfermero.NumeroDocumento = dtResultado.Rows[0]["NumeroDocumento"].ToString();
            objEnfermero.EstadoCivil = dtResultado.Rows[0]["EstadoCivil"].ToString();
            objEnfermero._IdLugarNacimiento = Int32.Parse(dtResultado.Rows[0]["IdLugarNacimiento"].ToString());
            objEnfermero.Pais = dtResultado.Rows[0]["Pais"].ToString();
            objEnfermero.DepartamentoNacimiento = dtResultado.Rows[0]["Departamento"].ToString();
            objEnfermero.ProvinciaNacimiento = dtResultado.Rows[0]["Provincia"].ToString();
            objEnfermero.DistritoNacimiento = dtResultado.Rows[0]["Distrito"].ToString();
            objEnfermero._IdDomicilio = Int32.Parse(dtResultado.Rows[0]["IdDomicilio"].ToString());
            objEnfermero.DepartamentoDomicilio = dtResultado.Rows[0]["DepartamentoDomicilio"].ToString();
            objEnfermero.ProvinciaDomicilio = dtResultado.Rows[0]["ProvinciaDomicilio"].ToString();
            objEnfermero.DistritoDomicilio = dtResultado.Rows[0]["DistritoDomicilio"].ToString();
            objEnfermero.Direccion = dtResultado.Rows[0]["Direccion"].ToString();
            objEnfermero.Telefono = dtResultado.Rows[0]["Telefono"].ToString();
            objEnfermero.Celular = dtResultado.Rows[0]["Celular"].ToString();
            objEnfermero.CorreoElectronico = dtResultado.Rows[0]["CorreoElectronico"].ToString();
            objEnfermero.Usuario = dtResultado.Rows[0]["Usuario"].ToString();
            objEnfermero.Contrasena = dtResultado.Rows[0]["Contrasena"].ToString();
            objEnfermero.IdArea = Int32.Parse(dtResultado.Rows[0]["IdArea"].ToString());
            objEnfermero._Area = dtResultado.Rows[0]["Area"].ToString();
            objEnfermero.Foto = dtResultado.Rows[0]["Foto"].ToString();
            objEnfermero.IdPerfil = Int32.Parse(dtResultado.Rows[0]["IdPerfil"].ToString());
            objEnfermero._Perfil = dtResultado.Rows[0]["Perfil"].ToString();
            objEnfermero.Estado = dtResultado.Rows[0]["Estado"].ToString();
            objEnfermero.NumeroLicencia = dtResultado.Rows[0]["NumeroLicencia"].ToString();
            objEnfermero.Usuario = dtResultado.Rows[0]["Usuario"].ToString();
            objEnfermero.Contrasena = dtResultado.Rows[0]["Contrasena"].ToString();

            return objEnfermero;
        }

        public static DataTable seleccionarEnfermeros(clsEnfermero objEnfermero)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objEnfermero);

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

            return clsGestorBD.ejecutarStoredProcedureDataTable("up_ManEnfermero", lstParametrosSQL);
        }

        public static DataTable seleccionarEnfermerosCriterios(clsEnfermero objEnfermero)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objEnfermero);

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

            return clsGestorBD.ejecutarStoredProcedureDataTable("up_ManEnfermero", lstParametrosSQL);
        }

        public static bool validarNumeroLicencia(int numIdEnfermero, string strNumeroLicencia)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdEnfermero";
            sqlParametro.Value = numIdEnfermero;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@NumeroLicencia";
            sqlParametro.Value = strNumeroLicencia;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Contador";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ValidarNumeroLicencia", lstParametrosSQL);

            if (numResultado == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static List<SqlParameter> crearLista(clsEnfermero objEnfermero)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objEnfermero.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    if (pi.Name.Substring(0, 1).CompareTo("_") != 0)
                    {
                        sqlParametro = new SqlParameter();
                        sqlParametro.ParameterName = "@" + pi.Name;
                        sqlParametro.Value = pi.GetValue(objEnfermero, null);
                        sqlParametro.Direction = ParameterDirection.Input;

                        lstParametrosSQL.Add(sqlParametro);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return lstParametrosSQL;
        }
    }
}
