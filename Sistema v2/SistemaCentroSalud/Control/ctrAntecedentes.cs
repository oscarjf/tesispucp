using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Acceso;
using Modelo;

namespace Control
{
    public class ctrAntecedentes
    {
        public static bool registrarAntecedentes(clsAntecedentes objAntecedentes)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objAntecedentes);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManAntecedentes", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool modificarAntecedentes(clsAntecedentes objAntecedentes)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objAntecedentes);

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

            int numResultado = clsGestorBD.ejecutarStoredProcedureInt("up_ManAntecedentes", lstParametrosSQL);

            if (numResultado != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static clsAntecedentes seleccionarAntecedentes(clsAntecedentes objAntecedentes)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            lstParametrosSQL = crearLista(objAntecedentes);

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

            DataTable dtResultado = clsGestorBD.ejecutarStoredProcedureDataTable("up_ManAntecedentes", lstParametrosSQL);

            objAntecedentes.IndTabaco = dtResultado.Rows[0]["IndTabaco"].ToString();
            objAntecedentes.IndAlcohol = dtResultado.Rows[0]["IndAlcohol"].ToString();
            objAntecedentes.IndCafe = dtResultado.Rows[0]["IndCafe"].ToString();
            objAntecedentes.IndTe = dtResultado.Rows[0]["IndTe"].ToString();
            objAntecedentes.IndDrogas = dtResultado.Rows[0]["IndDrogas"].ToString();
            objAntecedentes.IndDiabetes = dtResultado.Rows[0]["IndDiabetes"].ToString();
            objAntecedentes.DescDiabetes = dtResultado.Rows[0]["DescripcionDiabetes"].ToString();
            objAntecedentes.IndHipertension = dtResultado.Rows[0]["IndHipertension"].ToString();
            objAntecedentes.DescHipertension = dtResultado.Rows[0]["DescripcionHipertension"].ToString();
            objAntecedentes.IndCoronariopatia = dtResultado.Rows[0]["IndCoronariopatia"].ToString();
            objAntecedentes.DescCoronariopatia = dtResultado.Rows[0]["DescripcionCoronariopatia"].ToString();
            objAntecedentes.IndDislipidemia = dtResultado.Rows[0]["IndDislipidemia"].ToString();
            objAntecedentes.DescDislipidemia = dtResultado.Rows[0]["DescripcionDislipidemia"].ToString();
            objAntecedentes.IndAsma = dtResultado.Rows[0]["IndAsma"].ToString();
            objAntecedentes.DescAsma = dtResultado.Rows[0]["DescripcionAsma"].ToString();
            objAntecedentes.IndPsicopatia = dtResultado.Rows[0]["IndPsicopatia"].ToString();
            objAntecedentes.DescPsicopatia = dtResultado.Rows[0]["DescripcionPsicopatia"].ToString();
            objAntecedentes.IndAlergias = dtResultado.Rows[0]["IndAlergias"].ToString();
            objAntecedentes.DescAlergias = dtResultado.Rows[0]["DescripcionAlergias"].ToString();
            objAntecedentes.IndTuberculosis = dtResultado.Rows[0]["IndTuberculosis"].ToString();
            objAntecedentes.DescTuberculosis = dtResultado.Rows[0]["DescripcionTuberculosis"].ToString();
            objAntecedentes.IndAtipia = dtResultado.Rows[0]["IndAtipia"].ToString();
            objAntecedentes.DescAtipia = dtResultado.Rows[0]["DescripcionAtipia"].ToString();
            objAntecedentes.IndGota = dtResultado.Rows[0]["IndGota"].ToString();
            objAntecedentes.DescGota = dtResultado.Rows[0]["DescripcionGota"].ToString();
            objAntecedentes.IndAfeccionBroncopulmonar = dtResultado.Rows[0]["IndAfeccionBroncopulmonar"].ToString();
            objAntecedentes.DescAfeccionBroncopulmonar = dtResultado.Rows[0]["DescripcionAfeccionBroncopulmonar"].ToString();
            objAntecedentes.IndEndocrinopatia = dtResultado.Rows[0]["IndEndocrinopatia"].ToString();
            objAntecedentes.DescEndocrinopatia = dtResultado.Rows[0]["DescripcionEndocrinopatia"].ToString();
            objAntecedentes.IndNefropatia = dtResultado.Rows[0]["IndNefropatia"].ToString();
            objAntecedentes.DescNefropatia = dtResultado.Rows[0]["DescripcionNefropatia"].ToString();
            objAntecedentes.IndUropatia = dtResultado.Rows[0]["IndUropatia"].ToString();
            objAntecedentes.DescUropatia = dtResultado.Rows[0]["DescripcionUropatia"].ToString();
            objAntecedentes.IndHemopatia = dtResultado.Rows[0]["IndHemopatia"].ToString();
            objAntecedentes.DescHemopatia = dtResultado.Rows[0]["DescripcionHemopatia"].ToString();
            objAntecedentes.IndETS = dtResultado.Rows[0]["IndETS"].ToString();
            objAntecedentes.DescETS = dtResultado.Rows[0]["DescripcionETS"].ToString();
            objAntecedentes.IndUlcera = dtResultado.Rows[0]["IndUlcera"].ToString();
            objAntecedentes.DescUlcera = dtResultado.Rows[0]["DescripcionUlcera"].ToString();
            objAntecedentes.IndColecistopatia = dtResultado.Rows[0]["IndColecistopatia"].ToString();
            objAntecedentes.DescColecistopatia = dtResultado.Rows[0]["DescripcionColecistopatia"].ToString();
            objAntecedentes.IndHepatitis = dtResultado.Rows[0]["IndHepatitis"].ToString();
            objAntecedentes.DescHepatitis = dtResultado.Rows[0]["DescripcionHepatitis"].ToString();
            objAntecedentes.IndEnfermedadesNeurologicas = dtResultado.Rows[0]["IndEnfermedadesNeurologicas"].ToString();
            objAntecedentes.DescEnfermedadesNeurologicas = dtResultado.Rows[0]["DescripcionEnfermedadesNeurologicas"].ToString();
            objAntecedentes.IndFiebresProlongadas = dtResultado.Rows[0]["IndFiebresProlongadas"].ToString();
            objAntecedentes.DescFiebresProlongadas = dtResultado.Rows[0]["DescripcionFiebresProlongadas"].ToString();
            objAntecedentes.IndColagenopatia = dtResultado.Rows[0]["IndColagenopatia"].ToString();
            objAntecedentes.DescColagenopatia = dtResultado.Rows[0]["DescripcionColagenopatia"].ToString();
            objAntecedentes.Otros = dtResultado.Rows[0]["Otros"].ToString();

            return objAntecedentes;
        }

        private static List<SqlParameter> crearLista(clsAntecedentes objAntecedentes)
        {
            List<SqlParameter> lstParametrosSQL = new List<SqlParameter>();
            SqlParameter sqlParametro;

            foreach (PropertyInfo pi in objAntecedentes.GetType().GetProperties())
            {
                if (pi.CanRead)
                {
                    sqlParametro = new SqlParameter();
                    sqlParametro.ParameterName = "@" + pi.Name;
                    sqlParametro.Value = pi.GetValue(objAntecedentes, null);
                    sqlParametro.Direction = ParameterDirection.Input;

                    lstParametrosSQL.Add(sqlParametro);
                }
            }

            return lstParametrosSQL;
        }
    }
}
