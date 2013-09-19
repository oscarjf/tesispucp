using System;

namespace Modelo
{
    public class clsHistoriaClinica
    {
        private int numIdHistoriaClinica;

        public int IdHistoriaClinica
        {
            get { return numIdHistoriaClinica; }
            set { numIdHistoriaClinica = value; }
        }
        private int numIdEpisodio;

        public int IdEpisodio
        {
            get { return numIdEpisodio; }
            set { numIdEpisodio = value; }
        }
        //PACIENTE:
        private int numIdPaciente;

        public int IdPaciente
        {
            get { return numIdPaciente; }
            set { numIdPaciente = value; }
        }
        private string strPaterno;

        public string Paterno
        {
            get { return strPaterno; }
            set { strPaterno = value; }
        }
        private string strMaterno;

        public string Materno
        {
            get { return strMaterno; }
            set { strMaterno = value; }
        }
        private string strNombres;

        public string Nombres
        {
            get { return strNombres; }
            set { strNombres = value; }
        }
        private int numIdModoIngreso;

        public int IdModoIngreso
        {
            get { return numIdModoIngreso; }
            set { numIdModoIngreso = value; }
        }
        private string strSexo;

        public string Sexo
        {
            get { return strSexo; }
            set { strSexo = value; }
        }
        private int numIdEtnia;

        public int IdEtnia
        {
            get { return numIdEtnia; }
            set { numIdEtnia = value; }
        }
        private int numIdReligion;

        public int IdReligion
        {
            get { return numIdReligion; }
            set { numIdReligion = value; }
        }
        private int numIdOcupacion;

        public int IdOcupacion
        {
            get { return numIdOcupacion; }
            set { numIdOcupacion = value; }
        }
        private int numIdIdioma;

        public int IdIdioma
        {
            get { return numIdIdioma; }
            set { numIdIdioma = value; }
        }
        private string strEstadoCivil;

        public string EstadoCivil
        {
            get { return strEstadoCivil; }
            set { strEstadoCivil = value; }
        }
        private DateTime dtpFechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return dtpFechaNacimiento; }
            set { dtpFechaNacimiento = value; }
        }
        private string strGrupoSanguineo;

        public string GrupoSanguineo
        {
            get { return strGrupoSanguineo; }
            set { strGrupoSanguineo = value; }
        }
        private string strFactorSanguineo;

        public string FactorSanguineo
        {
            get { return strFactorSanguineo; }
            set { strFactorSanguineo = value; }
        }
        private string strPais;

        public string Pais
        {
            get { return strPais; }
            set { strPais = value; }
        }
        private string strDepartamentoNacimiento;

        public string DepartamentoNacimiento
        {
            get { return strDepartamentoNacimiento; }
            set { strDepartamentoNacimiento = value; }
        }
        private string strProvinciaNacimiento;

        public string ProvinciaNacimiento
        {
            get { return strProvinciaNacimiento; }
            set { strProvinciaNacimiento = value; }
        }
        private string strDistritoNacimiento;

        public string DistritoNacimiento
        {
            get { return strDistritoNacimiento; }
            set { strDistritoNacimiento = value; }
        }
        private string strDepartamentoDomicilio;

        public string DepartamentoDomicilio
        {
            get { return strDepartamentoDomicilio; }
            set { strDepartamentoDomicilio = value; }
        }
        private string strProvinciaDomicilio;

        public string ProvinciaDomicilio
        {
            get { return strProvinciaDomicilio; }
            set { strProvinciaDomicilio = value; }
        }
        private string strDistritoDomicilio;

        public string DistritoDomicilio
        {
            get { return strDistritoDomicilio; }
            set { strDistritoDomicilio = value; }
        }
        private string strDireccion;

        public string Direccion
        {
            get { return strDireccion; }
            set { strDireccion = value; }
        }
        //EXAMEN FISICO:
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
        private string strOtrosExamenes;

        public string OtrosExamenes
        {
            get { return strOtrosExamenes; }
            set { strOtrosExamenes = value; }
        }
	    //FUNCIONES BIOLOGICAS:
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
	    //ENFERMEDAD:
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
	    //DIAGNOSTICOSXEPISODIO:
        private string strListaIdDiagnosticos;

        public string ListaIdDiagnosticos
        {
            get { return strListaIdDiagnosticos; }
            set { strListaIdDiagnosticos = value; }
        }
        //ECTOSCOPIA
        private string strEctoscopia;

        public string Ectoscopia
        {
            get { return strEctoscopia; }
            set { strEctoscopia = value; }
        }
        private int numIdEmpleado;

        public int IdEmpleado
        {
            get { return numIdEmpleado; }
            set { numIdEmpleado = value; }
        }

        public clsHistoriaClinica()
        {
            IdHistoriaClinica=0;
            IdEpisodio=0;
            IdPaciente=0;
            Paterno="";
            Materno="";
            Nombres="";
            IdModoIngreso=0;
            Sexo="";
            IdEtnia=0;
            IdReligion=0;
            IdOcupacion=0;
            IdIdioma=0;
            EstadoCivil="";
            FechaNacimiento=DateTime.Now;
            GrupoSanguineo="";
            FactorSanguineo="";
            Pais="";
            DepartamentoNacimiento="";
            ProvinciaNacimiento="";
            DistritoNacimiento="";
            DepartamentoDomicilio="";
            ProvinciaDomicilio="";
            DistritoDomicilio="";
            Direccion="";
            IdExamenFisico=0;
            Temperatura="";
            FrecuenciaCardiaca="";
            FrecuenciaRespiratoria="";
            PresionArterial="";
            Peso="";
            Talla="";
            OtrosExamenes="";
            IdFuncionesBiologicas=0;
            Apetito="";
            Sed="";
            Orina="";
            Deposiciones="";
            IdEnfermedad=0;
            Tiempo="";
            Inicio="";
            Curso="";
            Sintomas="";
            RelatoCronologico="";
            ListaIdDiagnosticos = "";
            Ectoscopia="";
            IdEmpleado=0;
        }
    }
}
