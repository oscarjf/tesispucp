using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Acceso;
using Modelo;

namespace Control
{
    public class ctrTecnico
    {
        public static bool registrarTecnico(clsTecnico objTecnico)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objTecnico);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManTecnico", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarTecnico(clsTecnico objTecnico)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objTecnico);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManTecnico", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool eliminarTecnico(clsTecnico objTecnico)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objTecnico);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManTecnico", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool recuperarTecnico(clsTecnico objTecnico)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objTecnico);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManTecnico", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsTecnico seleccionarTecnico(clsTecnico objTecnico)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objTecnico);

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

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedureDataTable("up_ManTecnico", lstParametrosSQL);

            objTecnico.IdTecnico = Int32.Parse(dtResultado.Rows[0]["IdPersona"].ToString());
            objTecnico.Paterno = dtResultado.Rows[0]["Paterno"].ToString();
            objTecnico.Materno = dtResultado.Rows[0]["Materno"].ToString();
            objTecnico.Nombres = dtResultado.Rows[0]["Nombres"].ToString();
            objTecnico.FechaNacimiento = DateTime.Parse(dtResultado.Rows[0]["FechaNacimiento"].ToString());
            objTecnico.Sexo = dtResultado.Rows[0]["Sexo"].ToString();
            objTecnico.IdTipoDocumento = Int32.Parse(dtResultado.Rows[0]["IdTipoDocumento"].ToString());
            objTecnico._TipoDocumento = dtResultado.Rows[0]["TipoDocumento"].ToString();
            objTecnico.NumeroDocumento = dtResultado.Rows[0]["NumeroDocumento"].ToString();
            objTecnico.EstadoCivil = dtResultado.Rows[0]["EstadoCivil"].ToString();
            objTecnico._IdLugarNacimiento = Int32.Parse(dtResultado.Rows[0]["IdLugarNacimiento"].ToString());
            objTecnico.Pais = dtResultado.Rows[0]["Pais"].ToString();
            objTecnico.DepartamentoNacimiento = dtResultado.Rows[0]["Departamento"].ToString();
            objTecnico.ProvinciaNacimiento = dtResultado.Rows[0]["Provincia"].ToString();
            objTecnico.DistritoNacimiento = dtResultado.Rows[0]["Distrito"].ToString();
            objTecnico._IdDomicilio = Int32.Parse(dtResultado.Rows[0]["IdDomicilio"].ToString());
            objTecnico.DepartamentoDomicilio = dtResultado.Rows[0]["DepartamentoDomicilio"].ToString();
            objTecnico.ProvinciaDomicilio = dtResultado.Rows[0]["ProvinciaDomicilio"].ToString();
            objTecnico.DistritoDomicilio = dtResultado.Rows[0]["DistritoDomicilio"].ToString();
            objTecnico.Direccion = dtResultado.Rows[0]["Direccion"].ToString();
            objTecnico.Telefono = dtResultado.Rows[0]["Telefono"].ToString();
            objTecnico.Celular = dtResultado.Rows[0]["Celular"].ToString();
            objTecnico.CorreoElectronico = dtResultado.Rows[0]["CorreoElectronico"].ToString();
            objTecnico.Usuario = dtResultado.Rows[0]["Usuario"].ToString();
            objTecnico.Contrasena = dtResultado.Rows[0]["Contrasena"].ToString();
            objTecnico.IdArea = Int32.Parse(dtResultado.Rows[0]["IdArea"].ToString());
            objTecnico._Area = dtResultado.Rows[0]["Area"].ToString();
            objTecnico.Foto = dtResultado.Rows[0]["Foto"].ToString();
            objTecnico.IdPerfil = Int32.Parse(dtResultado.Rows[0]["IdPerfil"].ToString());
            objTecnico._Perfil = dtResultado.Rows[0]["Perfil"].ToString();
            objTecnico.Estado = dtResultado.Rows[0]["Estado"].ToString();
            
            return objTecnico;
        }

        public static DataTable seleccionarTecnicos(clsTecnico objTecnico)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objTecnico);

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

            return clsGestorBD.ejecutarStoredProcedureDataTable("up_ManTecnico", lstParametrosSQL);
        }

        public static DataTable seleccionarTecnicosCriterios(clsTecnico objTecnico)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objTecnico);

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

            return clsGestorBD.ejecutarStoredProcedureDataTable("up_ManTecnico", lstParametrosSQL);
        }

        private static List<SqlParameter> crearLista(clsTecnico objTecnico)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objTecnico.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    if (pi.Name.Substring(0, 1).CompareTo("_") != 0)
                    {
                        sqlParametro = new SqlParameter();
                        sqlParametro.ParameterName = "@" + pi.Name;
                        sqlParametro.Value = pi.GetValue(objTecnico, null);
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
