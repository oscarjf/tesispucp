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
	    //ANTECEDENTES:
        private int numIdAntecedentes;

        public int IdAntecedentes
        {
            get { return numIdAntecedentes; }
            set { numIdAntecedentes = value; }
        }
        private string strIndTabaco;

        public string IndTabaco
        {
            get { return strIndTabaco; }
            set { strIndTabaco = value; }
        }
        private string strIndAlcohol;

        public string IndAlcohol
        {
            get { return strIndAlcohol; }
            set { strIndAlcohol = value; }
        }
        private string strIndCafe;

        public string IndCafe
        {
            get { return strIndCafe; }
            set { strIndCafe = value; }
        }
        private string strIndTe;

        public string IndTe
        {
            get { return strIndTe; }
            set { strIndTe = value; }
        }
        private string strIndDrogas;

        public string IndDrogas
        {
            get { return strIndDrogas; }
            set { strIndDrogas = value; }
        }
        private string strIndDiabetes;

        public string IndDiabetes
        {
            get { return strIndDiabetes; }
            set { strIndDiabetes = value; }
        }
        private string strDescDiabetes;

        public string DescDiabetes
        {
            get { return strDescDiabetes; }
            set { strDescDiabetes = value; }
        }
        private string strIndHipertension;

        public string IndHipertension
        {
            get { return strIndHipertension; }
            set { strIndHipertension = value; }
        }
        private string strDescHipertension;

        public string DescHipertension
        {
            get { return strDescHipertension; }
            set { strDescHipertension = value; }
        }
        private string strIndCoronariopatia;

        public string IndCoronariopatia
        {
            get { return strIndCoronariopatia; }
            set { strIndCoronariopatia = value; }
        }
        private string strDescCoronariopatia;

        public string DescCoronariopatia
        {
            get { return strDescCoronariopatia; }
            set { strDescCoronariopatia = value; }
        }
        private string strIndDislipidemia;

        public string IndDislipidemia
        {
            get { return strIndDislipidemia; }
            set { strIndDislipidemia = value; }
        }
        private string strDescDislipidemia;

        public string DescDislipidemia
        {
            get { return strDescDislipidemia; }
            set { strDescDislipidemia = value; }
        }
        private string strIndAsma;

        public string IndAsma
        {
            get { return strIndAsma; }
            set { strIndAsma = value; }
        }
        private string strDescAsma;

        public string DescAsma
        {
            get { return strDescAsma; }
            set { strDescAsma = value; }
        }
        private string strIndPsicopatia;

        public string IndPsicopatia
        {
            get { return strIndPsicopatia; }
            set { strIndPsicopatia = value; }
        }
        private string strDescPsicopatia;

        public string DescPsicopatia
        {
            get { return strDescPsicopatia; }
            set { strDescPsicopatia = value; }
        }
        private string strIndAlergias;

        public string IndAlergias
        {
            get { return strIndAlergias; }
            set { strIndAlergias = value; }
        }
        private string strDescAlergias;

        public string DescAlergias
        {
            get { return strDescAlergias; }
            set { strDescAlergias = value; }
        }
        private string strIndTuberculosis;

        public string IndTuberculosis
        {
            get { return strIndTuberculosis; }
            set { strIndTuberculosis = value; }
        }
        private string strDescTuberculosis;

        public string DescTuberculosis
        {
            get { return strDescTuberculosis; }
            set { strDescTuberculosis = value; }
        }
        private string strIndAtipia;

        public string IndAtipia
        {
            get { return strIndAtipia; }
            set { strIndAtipia = value; }
        }
        private string strDescAtipia;

        public string DescAtipia
        {
            get { return strDescAtipia; }
            set { strDescAtipia = value; }
        }
        private string strIndGota;

        public string IndGota
        {
            get { return strIndGota; }
            set { strIndGota = value; }
        }
        private string strDescGota;

        public string DescGota
        {
            get { return strDescGota; }
            set { strDescGota = value; }
        }
        private string strIndAfeccionBroncopulmonar;

        public string IndAfeccionBroncopulmonar
        {
            get { return strIndAfeccionBroncopulmonar; }
            set { strIndAfeccionBroncopulmonar = value; }
        }
        private string strDescAfeccionBroncopulmonar;

        public string DescAfeccionBroncopulmonar
        {
            get { return strDescAfeccionBroncopulmonar; }
            set { strDescAfeccionBroncopulmonar = value; }
        }
        private string strIndEndocrinopatia;

        public string IndEndocrinopatia
        {
            get { return strIndEndocrinopatia; }
            set { strIndEndocrinopatia = value; }
        }
        private string strDescEndocrinopatia;

        public string DescEndocrinopatia
        {
            get { return strDescEndocrinopatia; }
            set { strDescEndocrinopatia = value; }
        }
        private string strIndNefropatia;

        public string IndNefropatia
        {
            get { return strIndNefropatia; }
            set { strIndNefropatia = value; }
        }
        private string strDescNefropatia;

        public string DescNefropatia
        {
            get { return strDescNefropatia; }
            set { strDescNefropatia = value; }
        }
        private string strIndUropatia;

        public string IndUropatia
        {
            get { return strIndUropatia; }
            set { strIndUropatia = value; }
        }
        private string strDescUropatia;

        public string DescUropatia
        {
            get { return strDescUropatia; }
            set { strDescUropatia = value; }
        }
        private string strIndHemopatia;

        public string IndHemopatia
        {
            get { return strIndHemopatia; }
            set { strIndHemopatia = value; }
        }
        private string strDescHemopatia;

        public string DescHemopatia
        {
            get { return strDescHemopatia; }
            set { strDescHemopatia = value; }
        }
        private string strIndETS;

        public string IndETS
        {
            get { return strIndETS; }
            set { strIndETS = value; }
        }
        private string strDescETS;

        public string DescETS
        {
            get { return strDescETS; }
            set { strDescETS = value; }
        }
        private string strIndUlcera;

        public string IndUlcera
        {
            get { return strIndUlcera; }
            set { strIndUlcera = value; }
        }
        private string strDescUlcera;

        public string DescUlcera
        {
            get { return strDescUlcera; }
            set { strDescUlcera = value; }
        }
        private string strIndColecistopatia;

        public string IndColecistopatia
        {
            get { return strIndColecistopatia; }
            set { strIndColecistopatia = value; }
        }
        private string strDescColecistopatia;

        public string DescColecistopatia
        {
            get { return strDescColecistopatia; }
            set { strDescColecistopatia = value; }
        }
        private string strIndHepatitis;

        public string IndHepatitis
        {
            get { return strIndHepatitis; }
            set { strIndHepatitis = value; }
        }
        private string strDescHepatitis;

        public string DescHepatitis
        {
            get { return strDescHepatitis; }
            set { strDescHepatitis = value; }
        }
        private string strIndEnfermedadesNeurologicas;

        public string IndEnfermedadesNeurologicas
        {
            get { return strIndEnfermedadesNeurologicas; }
            set { strIndEnfermedadesNeurologicas = value; }
        }
        private string strDescEnfermedadesNeurologicas;

        public string DescEnfermedadesNeurologicas
        {
            get { return strDescEnfermedadesNeurologicas; }
            set { strDescEnfermedadesNeurologicas = value; }
        }
        private string strIndFiebresProlongadas;

        public string IndFiebresProlongadas
        {
            get { return strIndFiebresProlongadas; }
            set { strIndFiebresProlongadas = value; }
        }
        private string strDescFiebresProlongadas;

        public string DescFiebresProlongadas
        {
            get { return strDescFiebresProlongadas; }
            set { strDescFiebresProlongadas = value; }
        }
        private string strIndColagenopatia;

        public string IndColagenopatia
        {
            get { return strIndColagenopatia; }
            set { strIndColagenopatia = value; }
        }
        private string strDescColagenopatia;

        public string DescColagenopatia
        {
            get { return strDescColagenopatia; }
            set { strDescColagenopatia = value; }
        }
        private string strOtrosAntecedentes;

        public string OtrosAntecedentes
        {
            get { return strOtrosAntecedentes; }
            set { strOtrosAntecedentes = value; }
        }
        //
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
            IdAntecedentes=0;
            IndTabaco="";
            IndAlcohol="";
            IndCafe="";
            IndTe="";
            IndDrogas="";
            IndDiabetes="";
            DescDiabetes="";
            IndHipertension="";
            DescHipertension="";
            IndCoronariopatia="";
            DescCoronariopatia="";
            IndDislipidemia="";
            DescDislipidemia="";
            IndAsma="";
            DescAsma="";
            IndPsicopatia="";
            DescPsicopatia="";
            IndAlergias="";
            DescAlergias="";
            IndTuberculosis="";
            DescTuberculosis="";
            IndAtipia="";
            DescAtipia="";
            IndGota="";
            DescGota="";
            IndAfeccionBroncopulmonar="";
            DescAfeccionBroncopulmonar="";
            IndEndocrinopatia="";
            DescEndocrinopatia="";
            IndNefropatia="";
            DescNefropatia="";
            IndUropatia="";
            DescUropatia="";
            IndHemopatia="";
            DescHemopatia="";
            IndETS="";
            DescETS="";
            IndUlcera="";
            DescUlcera="";
            IndColecistopatia="";
            DescColecistopatia="";
            IndHepatitis="";
            DescHepatitis="";
            IndEnfermedadesNeurologicas="";
            DescEnfermedadesNeurologicas="";
            IndFiebresProlongadas="";
            DescFiebresProlongadas="";
            IndColagenopatia="";
            DescColagenopatia="";
            OtrosAntecedentes="";
            Ectoscopia="";
            IdEmpleado=0;
        }
    }
}
