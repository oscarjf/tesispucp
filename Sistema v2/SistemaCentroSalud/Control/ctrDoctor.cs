using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Acceso;
using Comun;
using Modelo;

namespace Control
{
    public class ctrDoctor
    {
        public static bool registrarDoctor(clsDoctor objDoctor)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objDoctor);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManDoctor", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarDoctor(clsDoctor objDoctor)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objDoctor);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManDoctor", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool eliminarDoctor(clsDoctor objDoctor)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objDoctor);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManDoctor", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool recuperarDoctor(clsDoctor objDoctor)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objDoctor);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManDoctor", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsDoctor seleccionarDoctor(clsDoctor objDoctor)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objDoctor);

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

            DataSet dsResultado = clsGestorBD.ejecutarStoredProcedureDataSet("up_ManDoctor", lstParametrosSQL);
            DataTable dtResultado = dsResultado.Tables[0];
            DataTable dtResultado2 = dsResultado.Tables[1];

            objDoctor.IdDoctor = Int32.Parse(dtResultado.Rows[0]["IdPersona"].ToString());
            objDoctor.Paterno = dtResultado.Rows[0]["Paterno"].ToString();
            objDoctor.Materno = dtResultado.Rows[0]["Materno"].ToString();
            objDoctor.Nombres = dtResultado.Rows[0]["Nombres"].ToString();
            objDoctor.FechaNacimiento = DateTime.Parse(dtResultado.Rows[0]["FechaNacimiento"].ToString());
            objDoctor.Sexo = dtResultado.Rows[0]["Sexo"].ToString();
            objDoctor.IdTipoDocumento = Int32.Parse(dtResultado.Rows[0]["IdTipoDocumento"].ToString());
            objDoctor._TipoDocumento = dtResultado.Rows[0]["TipoDocumento"].ToString();
            objDoctor.NumeroDocumento = dtResultado.Rows[0]["NumeroDocumento"].ToString();
            objDoctor.EstadoCivil = dtResultado.Rows[0]["EstadoCivil"].ToString();
            objDoctor._IdLugarNacimiento = Int32.Parse(dtResultado.Rows[0]["IdLugarNacimiento"].ToString());
            objDoctor.Pais = dtResultado.Rows[0]["Pais"].ToString();
            objDoctor.DepartamentoNacimiento = dtResultado.Rows[0]["Departamento"].ToString();
            objDoctor.ProvinciaNacimiento = dtResultado.Rows[0]["Provincia"].ToString();
            objDoctor.DistritoNacimiento = dtResultado.Rows[0]["Distrito"].ToString();
            objDoctor._IdDomicilio = Int32.Parse(dtResultado.Rows[0]["IdDomicilio"].ToString());
            objDoctor.DepartamentoDomicilio = dtResultado.Rows[0]["DepartamentoDomicilio"].ToString();
            objDoctor.ProvinciaDomicilio = dtResultado.Rows[0]["ProvinciaDomicilio"].ToString();
            objDoctor.DistritoDomicilio = dtResultado.Rows[0]["DistritoDomicilio"].ToString();
            objDoctor.Direccion = dtResultado.Rows[0]["Direccion"].ToString();
            objDoctor.Telefono = dtResultado.Rows[0]["Telefono"].ToString();
            objDoctor.Celular = dtResultado.Rows[0]["Celular"].ToString();
            objDoctor.CorreoElectronico = dtResultado.Rows[0]["CorreoElectronico"].ToString();
            objDoctor.Usuario = dtResultado.Rows[0]["Usuario"].ToString();
            objDoctor.Contrasena = dtResultado.Rows[0]["Contrasena"].ToString();
            objDoctor.IdArea = Int32.Parse(dtResultado.Rows[0]["IdArea"].ToString());
            objDoctor._Area = dtResultado.Rows[0]["Area"].ToString();
            objDoctor.Foto = dtResultado.Rows[0]["Foto"].ToString();
            objDoctor.IdPerfil = Int32.Parse(dtResultado.Rows[0]["IdPerfil"].ToString());
            objDoctor._Perfil = dtResultado.Rows[0]["Perfil"].ToString();
            objDoctor.Estado = dtResultado.Rows[0]["Estado"].ToString();
            objDoctor.CMP = dtResultado.Rows[0]["CMP"].ToString();
            objDoctor.IndicadorHC = dtResultado.Rows[0]["IndicadorHC"].ToString();
            objDoctor._IdHorario = Int32.Parse(dtResultado.Rows[0]["IdHorario"].ToString());
            objDoctor._IdDisponibilidad = Int32.Parse(dtResultado.Rows[0]["IdDisponibilidad"].ToString());
            objDoctor._Especialidades = new List<clsEspecialidad>();
            for (int i = 0; i < dtResultado2.Rows.Count; i++)
            {
                clsEspecialidad objEspecialidad = new clsEspecialidad();
                objEspecialidad.IdEspecialidad = Int32.Parse(dtResultado2.Rows[i]["IdEspecialidad"].ToString());
                objEspecialidad.Nombre = dtResultado2.Rows[i]["Nombre"].ToString();
                objEspecialidad.IdArea = Int32.Parse(dtResultado2.Rows[i]["IdArea"].ToString());

                objDoctor._Especialidades.Add(objEspecialidad);
            }
            objDoctor.Usuario = dtResultado.Rows[0]["Usuario"].ToString();
            objDoctor.Contrasena = dtResultado.Rows[0]["Contrasena"].ToString();

            return objDoctor;
        }

        public static DataTable seleccionarDoctores(clsDoctor objDoctor)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objDoctor);

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

            return clsGestorBD.ejecutarStoredProcedureDataTable("up_ManDoctor", lstParametrosSQL);
        }

        public static DataTable seleccionarDoctoresCriterios(clsDoctor objDoctor)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objDoctor);

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

            return clsGestorBD.ejecutarStoredProcedureDataTable("up_ManDoctor", lstParametrosSQL);
        }

        public static bool validarCMP(int numIdDoctor,string strCMP)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdDoctor";
            sqlParametro.Value = numIdDoctor;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@CMP";
            sqlParametro.Value = strCMP;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Contador";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ValidarCMP", lstParametrosSQL);

            if (numResultado == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static List<SqlParameter> crearLista(clsDoctor objDoctor)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objDoctor.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    if (pi.Name.Substring(0, 1).CompareTo("_") != 0)
                    {
                        sqlParametro = new SqlParameter();
                        sqlParametro.ParameterName = "@" + pi.Name;
                        sqlParametro.Value = pi.GetValue(objDoctor, null);
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
