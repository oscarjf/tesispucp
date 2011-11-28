﻿using System;

namespace Modelo
{
    public class clsPaciente
    {
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
        private string strSexo;

        public string Sexo
        {
            get { return strSexo; }
            set { strSexo = value; }
        }
        private DateTime dtFechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return dtFechaNacimiento; }
            set { dtFechaNacimiento = value; }
        }
        private int numIdTipoDocumento;

        public int IdTipoDocumento
        {
            get { return numIdTipoDocumento; }
            set { numIdTipoDocumento = value; }
        }
        private string strTipoDocumento;

        public string _TipoDocumento
        {
            get { return strTipoDocumento; }
            set { strTipoDocumento = value; }
        }
        private string strNumeroDocumento;

        public string NumeroDocumento
        {
            get { return strNumeroDocumento; }
            set { strNumeroDocumento = value; }
        }
        private string strEstadoCivil;

        public string EstadoCivil
        {
            get { return strEstadoCivil; }
            set { strEstadoCivil = value; }
        }
        private string strPais;

        public string Pais
        {
            get { return strPais; }
            set { strPais = value; }
        }
        private int numIdLugarNacimiento;

        public int _IdLugarNacimiento
        {
            get { return numIdLugarNacimiento; }
            set { numIdLugarNacimiento = value; }
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
        private int numIdDomicilio;

        public int _IdDomicilio
        {
            get { return numIdDomicilio; }
            set { numIdDomicilio = value; }
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
        private string strTelefono;

        public string Telefono
        {
            get { return strTelefono; }
            set { strTelefono = value; }
        }
        private string strCelular;

        public string Celular
        {
            get { return strCelular; }
            set { strCelular = value; }
        }
        private string strCorreoElectronico;

        public string CorreoElectronico
        {
            get { return strCorreoElectronico; }
            set { strCorreoElectronico = value; }
        }
        private string strTipoPersona;

        public string TipoPersona
        {
            get { return strTipoPersona; }
            set { strTipoPersona = value; }
        }
        private int numIdOcupacion;

        public int IdOcupacion
        {
            get { return numIdOcupacion; }
            set { numIdOcupacion = value; }
        }
        private string strOcupacion;

        public string _Ocupacion
        {
            get { return strOcupacion; }
            set { strOcupacion = value; }
        }
        private int numIdEtnia;

        public int IdEtnia
        {
            get { return numIdEtnia; }
            set { numIdEtnia = value; }
        }
        private string strEtnia;

        public string _Etnia
        {
            get { return strEtnia; }
            set { strEtnia= value; }
        }
        private int numIdIdioma;

        public int IdIdioma
        {
            get { return numIdIdioma; }
            set { numIdIdioma = value; }
        }
        private string strIdioma;

        public string _Idioma
        {
            get { return strIdioma; }
            set { strIdioma = value; }
        }
        private int numIdReligion;

        public int IdReligion
        {
            get { return numIdReligion; }
            set { numIdReligion = value; }
        }
        private string strReligion;

        public string _Religion
        {
            get { return strReligion; }
            set { strReligion = value; }
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
        private string strNumeroHistoriaClinica;

        public string NumeroHistoriaClinica
        {
            get { return strNumeroHistoriaClinica; }
            set { strNumeroHistoriaClinica = value; }
        }
        private int numIdEmpleado;

        public int IdEmpleado
        {
            get { return numIdEmpleado; }
            set { numIdEmpleado = value; }
        }
        
        public override string ToString()
        {
            return Paterno + " " + Materno + " " + Nombres;
        }

        public clsPaciente()
        {
            IdPaciente = 0;
            Paterno = "";
            Materno = "";
            Nombres = "";
            Sexo = "";
            FechaNacimiento = DateTime.Now;
            IdTipoDocumento = 0;
            NumeroDocumento = "";
            EstadoCivil = "";
            Pais = "";
            DepartamentoNacimiento = "";
            ProvinciaNacimiento = "";
            DistritoNacimiento = "";
            DepartamentoDomicilio = "";
            ProvinciaDomicilio = "";
            DistritoDomicilio = "";
            Direccion = "";
            Telefono = "";
            Celular = "";
            CorreoElectronico = "";
            TipoPersona = "PACIENTE";
            IdOcupacion = 0;
            IdEtnia = 0;
            IdIdioma = 0;
            IdReligion = 0;
            GrupoSanguineo = "";
            FactorSanguineo = "";
            NumeroHistoriaClinica = "";
            IdEmpleado = 0;
        }
    }
}
