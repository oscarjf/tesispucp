using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsDoctor
    {
        private int numIdDoctor;

        public int IdDoctor
        {
            get { return numIdDoctor; }
            set { numIdDoctor = value; }
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
        private Byte[] byFoto;

        public Byte[] Foto
        {
            get { return byFoto; }
            set { byFoto = value; }
        }
        private string strUsuario;

        public string Usuario
        {
            get { return strUsuario; }
            set { strUsuario = value; }
        }
        private string strContrasena;

        public string Contrasena
        {
            get { return strContrasena; }
            set { strContrasena = value; }
        }
        private string strTipoEmpleado;

        public string TipoEmpleado
        {
            get { return strTipoEmpleado; }
            set { strTipoEmpleado = value; }
        }
        private int numIdArea;

        public int IdArea
        {
            get { return numIdArea; }
            set { numIdArea = value; }
        }
        private string strCMP;

        public string CMP
        {
            get { return strCMP; }
            set { strCMP = value; }
        }
        private string strIndicadorHC;

        public string IndicadorHC
        {
            get { return strIndicadorHC; }
            set { strIndicadorHC = value; }
        }
        private string strListaIdEspecialidades;

        public string ListaIdEspecialidades
        {
            get { return strListaIdEspecialidades; }
            set { strListaIdEspecialidades = value; }
        }

        public override string ToString()
        {
            return Paterno + " " + Materno + " " + Nombres;
        }

        public clsDoctor()
        {
            IdDoctor = 0;
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
            TipoPersona = "";
            //Foto
            Usuario = "";
            Contrasena = "";
            TipoEmpleado = "";
            IdArea = 0;
            CMP = "";
            IndicadorHC = "";
            ListaIdEspecialidades = "";
        }
    }
}
