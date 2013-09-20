using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Acceso;
using Modelo;

namespace Control
{
    public class ctrEpisodio
    {
        public static bool registrarEpisodio(clsEpisodio objEpisodio)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objEpisodio);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManEpisodio", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarEpisodio(clsEpisodio objEpisodio)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objEpisodio);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManEpisodio", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsEpisodio seleccionarEpisodio(clsEpisodio objEpisodio)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objEpisodio);

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

            DataSet dsResultado = clsGestorBD.ejecutarStoredProcedureDataSet("up_ManEpisodio", lstParametrosSQL);
            DataTable dtResultado = dsResultado.Tables[0];
            DataTable dtResultado2 = dsResultado.Tables[1];

            objEpisodio.IdEpisodio = Int32.Parse(dtResultado.Rows[0]["IdEpisodio"].ToString());
            objEpisodio.Ectoscopia = dtResultado.Rows[0]["Ectoscopia"].ToString();
            objEpisodio.IdExamenFisico = Int32.Parse(dtResultado.Rows[0]["IdExamenFisico"].ToString());
            objEpisodio.Temperatura = dtResultado.Rows[0]["Temperatura"].ToString();
            objEpisodio.FrecuenciaCardiaca = dtResultado.Rows[0]["FrecuenciaCardiaca"].ToString();
            objEpisodio.FrecuenciaRespiratoria = dtResultado.Rows[0]["FrecuenciaRespiratoria"].ToString();
            objEpisodio.PresionArterial = dtResultado.Rows[0]["PresionArterial"].ToString();
            objEpisodio.Peso = dtResultado.Rows[0]["Peso"].ToString();
            objEpisodio.Talla = dtResultado.Rows[0]["Talla"].ToString();
            objEpisodio.Otros = dtResultado.Rows[0]["Otros"].ToString();
            objEpisodio.IdEnfermedad = Int32.Parse(dtResultado.Rows[0]["IdEnfermedad"].ToString());
            objEpisodio.Tiempo = dtResultado.Rows[0]["Tiempo"].ToString();
            objEpisodio.Inicio = dtResultado.Rows[0]["Inicio"].ToString();
            objEpisodio.Curso = dtResultado.Rows[0]["Curso"].ToString();
            objEpisodio.Sintomas = dtResultado.Rows[0]["Sintomas"].ToString();
            objEpisodio.RelatoCronologico = dtResultado.Rows[0]["RelatoCronologico"].ToString();
            objEpisodio.IdFuncionesBiologicas = Int32.Parse(dtResultado.Rows[0]["IdFuncionesBiologicas"].ToString());
            objEpisodio.Apetito = dtResultado.Rows[0]["Apetito"].ToString();
            objEpisodio.Sed = dtResultado.Rows[0]["Sed"].ToString();
            objEpisodio.Orina = dtResultado.Rows[0]["Orina"].ToString();
            objEpisodio.Deposiciones = dtResultado.Rows[0]["Deposiciones"].ToString();
            objEpisodio.IdModoIngreso = Int32.Parse(dtResultado.Rows[0]["IdModoIngreso"].ToString());
            objEpisodio.IdHistoriaClinica = Int32.Parse(dtResultado.Rows[0]["IdHistoriaClinica"].ToString());
            for (int i = 0; i < dtResultado2.Rows.Count; i++)
            {
                clsDiagnostico objDiagnostico = new clsDiagnostico();
                objDiagnostico.IdDiagnostico = Int32.Parse(dtResultado2.Rows[i]["IdDiagnostico"].ToString());
                objDiagnostico.IdCie10 = Int32.Parse(dtResultado2.Rows[i]["IdCie10"].ToString());
                objDiagnostico.Codigo = dtResultado2.Rows[i]["Codigo"].ToString();
                objDiagnostico.Descripcion = dtResultado2.Rows[i]["Descripcion"].ToString();

                objEpisodio._Diagnosticos.Add(objDiagnostico);
            }

            return objEpisodio;
        }

        private static List<SqlParameter> crearLista(clsEpisodio objEpisodio)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objEpisodio.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    if (pi.Name.Substring(0, 1).CompareTo("_") != 0)
                    {
                        sqlParametro = new SqlParameter();
                        sqlParametro.ParameterName = "@" + pi.Name;
                        sqlParametro.Value = pi.GetValue(objEpisodio, null);
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

        public static int registrarPaciente(clsPaciente objPaciente)
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

            return numResultado;
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

        public static int registrarTriaje(clsTriaje objTriaje)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objTriaje);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManTriaje", lstParametrosSQL);

            return numResultado;
        }

        public static int seleccionarIdAntecedentes(int numIdHistoriaClinica)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdHistoriaClinica";
            sqlParametro.Value = numIdHistoriaClinica;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedureDataTable("up_SelHistoriaClinica", lstParametrosSQL);

            int numIdAntecedentes = Int32.Parse(dtResultado.Rows[0]["IdAntecedentes"].ToString());

            return numIdAntecedentes;
        }

        private static List<SqlParameter> crearLista(clsTriaje objTriaje)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objTriaje.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@" + pi.Name;
                    sqlParametro.Value = pi.GetValue(objTriaje, null);
                    sqlParametro.Direction = ParameterDirection.Input;

                    lstParametrosSQL.Add(sqlParametro);
                }
            }

            return lstParametrosSQL;
        }

        public static string seleccionarEctoscopia(int numIdHistoriaClinica)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            sqlParametro = new SqlParameter();
            sqlParametro.ParameterName = "@IdHistoriaClinica";
            sqlParametro.Value = numIdHistoriaClinica;
            sqlParametro.Direction = ParameterDirection.Input;

            lstParametrosSQL.Add(sqlParametro);

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedureDataTable("up_SelEctoscopia", lstParametrosSQL);
            string strEctoscopias = "";

            DateTime dtFecha;
            for (int i = 0; i < dtResultado.Rows.Count; i++)
            {
                dtFecha = (DateTime)dtResultado.Rows[i]["FechaRegistro"];
                strEctoscopias += dtFecha.ToShortDateString() + "\n";
                if (i == dtResultado.Rows.Count - 1)
                {
                    break;
                }
                strEctoscopias += "==========" + "\n";
            }
            
            return strEctoscopias;
        }
    }
}
