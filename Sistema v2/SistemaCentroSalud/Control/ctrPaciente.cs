using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Modelo;
using System.Data;
using Acceso;
using System.Reflection;

namespace Control
{
    public class ctrPaciente
    {
        public static bool registrarPaciente(clsPaciente objPaciente)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPaciente);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManPaciente", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarPaciente(clsPaciente objPaciente)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPaciente);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManPaciente", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool eliminarPaciente(clsPaciente objPaciente)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPaciente);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManPaciente", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool recuperarPaciente(clsPaciente objPaciente)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPaciente);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManPaciente", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsPaciente seleccionarPaciente(clsPaciente objPaciente)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPaciente);

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

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedureDataTable("up_ManPaciente", lstParametrosSQL);

            objPaciente.IdPaciente = Int32.Parse(dtResultado.Rows[0]["IdPersona"].ToString());
            objPaciente.Paterno = dtResultado.Rows[0]["Paterno"].ToString();
            objPaciente.Materno = dtResultado.Rows[0]["Materno"].ToString();
            objPaciente.Nombres = dtResultado.Rows[0]["Nombres"].ToString();
            objPaciente.FechaNacimiento = DateTime.Parse(dtResultado.Rows[0]["FechaNacimiento"].ToString());
            objPaciente.Sexo = dtResultado.Rows[0]["Sexo"].ToString();
            objPaciente.IdTipoDocumento = Int32.Parse(dtResultado.Rows[0]["IdTipoDocumento"].ToString());
            objPaciente._TipoDocumento = dtResultado.Rows[0]["TipoDocumento"].ToString();
            objPaciente.NumeroDocumento = dtResultado.Rows[0]["NumeroDocumento"].ToString();
            objPaciente.EstadoCivil = dtResultado.Rows[0]["EstadoCivil"].ToString();
            objPaciente._IdLugarNacimiento = Int32.Parse(dtResultado.Rows[0]["IdLugarNacimiento"].ToString());
            objPaciente.Pais = dtResultado.Rows[0]["Pais"].ToString();
            objPaciente.DepartamentoNacimiento = dtResultado.Rows[0]["Departamento"].ToString();
            objPaciente.ProvinciaNacimiento = dtResultado.Rows[0]["Provincia"].ToString();
            objPaciente.DistritoNacimiento = dtResultado.Rows[0]["Distrito"].ToString();
            objPaciente._IdDomicilio = Int32.Parse(dtResultado.Rows[0]["IdDomicilio"].ToString());
            objPaciente.DepartamentoDomicilio = dtResultado.Rows[0]["DepartamentoDomicilio"].ToString();
            objPaciente.ProvinciaDomicilio = dtResultado.Rows[0]["ProvinciaDomicilio"].ToString();
            objPaciente.DistritoDomicilio = dtResultado.Rows[0]["DistritoDomicilio"].ToString();
            objPaciente.Direccion = dtResultado.Rows[0]["Direccion"].ToString();
            objPaciente.Telefono = dtResultado.Rows[0]["Telefono"].ToString();
            objPaciente.Celular = dtResultado.Rows[0]["Celular"].ToString();
            objPaciente.CorreoElectronico = dtResultado.Rows[0]["CorreoElectronico"].ToString();
            objPaciente.IdEtnia = Int32.Parse(dtResultado.Rows[0]["IdEtnia"].ToString());
            objPaciente._Etnia = dtResultado.Rows[0]["Etnia"].ToString();
            objPaciente.IdIdioma = Int32.Parse(dtResultado.Rows[0]["IdIdioma"].ToString());
            objPaciente._Idioma = dtResultado.Rows[0]["Idioma"].ToString();
            objPaciente.IdOcupacion = Int32.Parse(dtResultado.Rows[0]["IdOcupacion"].ToString());
            objPaciente._Ocupacion = dtResultado.Rows[0]["Ocupacion"].ToString();
            objPaciente.IdReligion = Int32.Parse(dtResultado.Rows[0]["IdReligion"].ToString());
            objPaciente._Religion = dtResultado.Rows[0]["Religion"].ToString();
            objPaciente.GrupoSanguineo = dtResultado.Rows[0]["GrupoSanguineo"].ToString();
            objPaciente.FactorSanguineo = dtResultado.Rows[0]["FactorSanguineo"].ToString();

            return objPaciente;
        }

        public static DataTable seleccionarPacientes(clsPaciente objPaciente)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPaciente);

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

            return clsGestorBD.ejecutarStoredProcedureDataTable("up_ManPaciente", lstParametrosSQL);
        }

        public static DataTable seleccionarPacientesCriterios(clsPaciente objPaciente)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objPaciente);

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

            return clsGestorBD.ejecutarStoredProcedureDataTable("up_ManPaciente", lstParametrosSQL);
        }

        public static bool validarNumeroHistoriaClinica(int numIdPaciente, string strNumeroHistoriaClinica)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdPaciente";
            sqlParametro.Value = numIdPaciente;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@NumeroHistoriaClinica";
            sqlParametro.Value = strNumeroHistoriaClinica;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@Contador";
            sqlParametro.Value = 0;
            sqlParametro.Direction = ParameterDirection.Output;

            lstParametrosSQL.Add(sqlParametro);

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ValidarNumeroHistoriaClinica", lstParametrosSQL);

            if (numResultado == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static List<SqlParameter> crearLista(clsPaciente objPaciente)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objPaciente.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    if (pi.Name.Substring(0, 1).CompareTo("_") != 0)
                    {
                        sqlParametro = new SqlParameter();
                        sqlParametro.ParameterName = "@" + pi.Name;
                        sqlParametro.Value = pi.GetValue(objPaciente, null);
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
