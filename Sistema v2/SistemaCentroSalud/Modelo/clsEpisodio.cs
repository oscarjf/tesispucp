using System;
using System.Collections.Generic;

namespace Modelo
{
    public class clsEpisodio
    {
        private int numIdEpisodio;

        public int IdEpisodio
        {
            get { return numIdEpisodio; }
            set { numIdEpisodio = value; }
        }
        private string strEctoscopia;

        public string Ectoscopia
        {
            get { return strEctoscopia; }
            set { strEctoscopia = value; }
        }
        private int numIdExamenFisico;

        public int IdExamenFisico
        {
            get { return numIdExamenFisico; }
            set { numIdExamenFisico = value; }
        }
        private string strTemperatura;

        public string Temperatura
        {
            get { return strTemperatura; }
            set { strTemperatura = value; }
        }
        private string strFrecuenciaCardiaca;

        public string FrecuenciaCardiaca
        {
            get { return strFrecuenciaCardiaca; }
            set { strFrecuenciaCardiaca = value; }
        }
        private string strFrecuenciaRespiratoria;

        public string FrecuenciaRespiratoria
        {
            get { return strFrecuenciaRespiratoria; }
            set { strFrecuenciaRespiratoria = value; }
        }
        private string strPresionArterial;

        public string PresionArterial
        {
            get { return strPresionArterial; }
            set { strPresionArterial = value; }
        }
        private string strPeso;

        public string Peso
        {
            get { return strPeso; }
            set { strPeso = value; }
        }
        private string strTalla;

        public string Talla
        {
            get { return strTalla; }
            set { strTalla = value; }
        }
        private string strOtros;

        public string Otros
        {
            get { return strOtros; }
            set { strOtros = value; }
        }
        private int numIdEnfermedad;

        public int IdEnfermedad
        {
            get { return numIdEnfermedad; }
            set { numIdEnfermedad = value; }
        }
        private string strTiempo;

        public string Tiempo
        {
            get { return strTiempo; }
            set { strTiempo = value; }
        }
        private string strInicio;

        public string Inicio
        {
            get { return strInicio; }
            set { strInicio = value; }
        }
        private string strCurso;

        public string Curso
        {
            get { return strCurso; }
            set { strCurso = value; }
        }
        private string strSintomas;

        public string Sintomas
        {
            get { return strSintomas; }
            set { strSintomas = value; }
        }
        private string strRelatoCronologico;

        public string RelatoCronologico
        {
            get { return strRelatoCronologico; }
            set { strRelatoCronologico = value; }
        }
        private int numIdFuncionesBiologicas;

        public int IdFuncionesBiologicas
        {
            get { return numIdFuncionesBiologicas; }
            set { numIdFuncionesBiologicas = value; }
        }
        private string strApetito;

        public string Apetito
        {
            get { return strApetito; }
            set { strApetito = value; }
        }
        private string strSed;

        public string Sed
        {
            get { return strSed; }
            set { strSed = value; }
        }
        private string strOrina;

        public string Orina
        {
            get { return strOrina; }
            set { strOrina = value; }
        }
        private string strDeposiciones;

        public string Deposiciones
        {
            get { return strDeposiciones; }
            set { strDeposiciones = value; }
        }
        private int numIdModoIngreso;

        public int IdModoIngreso
        {
            get { return numIdModoIngreso; }
            set { numIdModoIngreso = value; }
        }
        private int numIdHistoriaClinica;

        public int IdHistoriaClinica
        {
            get { return numIdHistoriaClinica; }
            set { numIdHistoriaClinica = value; }
        }
        private int numIdEmpleado;

        public int IdEmpleado
        {
            get { return numIdEmpleado; }
            set { numIdEmpleado = value; }
        }
        private string strDetalleXML;

        public string DetalleXML
        {
            get { return strDetalleXML; }
            set { strDetalleXML = value; }
        } 
        private List<clsDiagnostico> lstDiagnosticos;

        public List<clsDiagnostico> _Diagnosticos
        {
            get { return lstDiagnosticos; }
            set { lstDiagnosticos = value; }
        }

        public clsEpisodio()
        {
            IdEpisodio = 0;
            Ectoscopia = "";
            IdExamenFisico = 0;
            Temperatura = "";
            FrecuenciaCardiaca = "";
            FrecuenciaRespiratoria = "";
            PresionArterial = "";
            Peso = "";
            Talla = "";
            Otros = "";
            IdEnfermedad = 0;
            Tiempo = "";
            Inicio = "";
            Curso = "";
            Sintomas = "";
            RelatoCronologico = "";
            IdFuncionesBiologicas = 0;
            Apetito = "";
            Sed = "";
            Orina = "";
            Deposiciones = "";
            IdModoIngreso = 0;
            IdHistoriaClinica = 0;
            IdEmpleado = 0;
            DetalleXML = "";
            _Diagnosticos = new List<clsDiagnostico>();
        }
    }
}
