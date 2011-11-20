using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Acceso;
using Modelo;

namespace Control
{
    public class ctrAdministrativo
    {
        public static bool registrarAdministrativo(clsAdministrativo objAdministrativo)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objAdministrativo);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManAdministrativo", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarAdministrativo(clsAdministrativo objAdministrativo)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objAdministrativo);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManAdministrativo", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool eliminarAdministrativo(clsAdministrativo objAdministrativo)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objAdministrativo);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManAdministrativo", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool recuperarAdministrativo(clsAdministrativo objAdministrativo)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objAdministrativo);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManAdministrativo", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsAdministrativo seleccionarAdministrativo(clsAdministrativo objAdministrativo)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objAdministrativo);

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

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedureDataTable("up_ManAdministrativo", lstParametrosSQL);

            objAdministrativo.IdAdministrativo = Int32.Parse(dtResultado.Rows[0]["IdPersona"].ToString());
            objAdministrativo.Paterno = dtResultado.Rows[0]["Paterno"].ToString();
            objAdministrativo.Materno = dtResultado.Rows[0]["Materno"].ToString();
            objAdministrativo.Nombres = dtResultado.Rows[0]["Nombres"].ToString();
            objAdministrativo.FechaNacimiento = DateTime.Parse(dtResultado.Rows[0]["FechaNacimiento"].ToString());
            objAdministrativo.Sexo = dtResultado.Rows[0]["Sexo"].ToString();
            objAdministrativo.IdTipoDocumento = Int32.Parse(dtResultado.Rows[0]["IdTipoDocumento"].ToString());
            objAdministrativo._TipoDocumento = dtResultado.Rows[0]["TipoDocumento"].ToString();
            objAdministrativo.NumeroDocumento = dtResultado.Rows[0]["NumeroDocumento"].ToString();
            objAdministrativo.EstadoCivil = dtResultado.Rows[0]["EstadoCivil"].ToString();
            objAdministrativo._IdLugarNacimiento = Int32.Parse(dtResultado.Rows[0]["IdLugarNacimiento"].ToString());
            objAdministrativo.Pais = dtResultado.Rows[0]["Pais"].ToString();
            objAdministrativo.DepartamentoNacimiento = dtResultado.Rows[0]["Departamento"].ToString();
            objAdministrativo.ProvinciaNacimiento = dtResultado.Rows[0]["Provincia"].ToString();
            objAdministrativo.DistritoNacimiento = dtResultado.Rows[0]["Distrito"].ToString();
            objAdministrativo._IdDomicilio = Int32.Parse(dtResultado.Rows[0]["IdDomicilio"].ToString());
            objAdministrativo.DepartamentoDomicilio = dtResultado.Rows[0]["DepartamentoDomicilio"].ToString();
            objAdministrativo.ProvinciaDomicilio = dtResultado.Rows[0]["ProvinciaDomicilio"].ToString();
            objAdministrativo.DistritoDomicilio = dtResultado.Rows[0]["DistritoDomicilio"].ToString();
            objAdministrativo.Direccion = dtResultado.Rows[0]["Direccion"].ToString();
            objAdministrativo.Telefono = dtResultado.Rows[0]["Telefono"].ToString();
            objAdministrativo.Celular = dtResultado.Rows[0]["Celular"].ToString();
            objAdministrativo.CorreoElectronico = dtResultado.Rows[0]["CorreoElectronico"].ToString();
            objAdministrativo.Usuario = dtResultado.Rows[0]["Usuario"].ToString();
            objAdministrativo.Contrasena = dtResultado.Rows[0]["Contrasena"].ToString();
            objAdministrativo.IdArea = Int32.Parse(dtResultado.Rows[0]["IdArea"].ToString());
            objAdministrativo._Area = dtResultado.Rows[0]["Area"].ToString();
            objAdministrativo.Foto = dtResultado.Rows[0]["Foto"].ToString();
            objAdministrativo.IdPerfil = Int32.Parse(dtResultado.Rows[0]["IdPerfil"].ToString());
            objAdministrativo._Perfil = dtResultado.Rows[0]["Perfil"].ToString();
            objAdministrativo.Estado = dtResultado.Rows[0]["Estado"].ToString();

            return objAdministrativo;
        }

        public static DataTable seleccionarAdministrativos(clsAdministrativo objAdministrativo)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objAdministrativo);

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

            return clsGestorBD.ejecutarStoredProcedureDataTable("up_ManAdministrativo", lstParametrosSQL);
        }

        public static DataTable seleccionarAdministrativosCriterios(clsAdministrativo objAdministrativo)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objAdministrativo);

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

            return clsGestorBD.ejecutarStoredProcedureDataTable("up_ManAdministrativo", lstParametrosSQL);
        }

        private static List<SqlParameter> crearLista(clsAdministrativo objAdministrativo)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objAdministrativo.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    if (pi.Name.Substring(0, 1).CompareTo("_") != 0)
                    {
                        sqlParametro = new SqlParameter();
                        sqlParametro.ParameterName = "@" + pi.Name;
                        sqlParametro.Value = pi.GetValue(objAdministrativo, null);
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
