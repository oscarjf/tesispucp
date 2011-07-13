using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsPersona
    {
        private int numIdUsuario;

        public int NumIdUsuario
        {
            get { return numIdUsuario; }
            set { numIdUsuario = value; }
        }
        private string strApellidoPaterno;

        public string StrApellidoPaterno
        {
            get { return strApellidoPaterno; }
            set { strApellidoPaterno = value; }
        }
        private string strApellidoMaterno;

        public string StrApellidoMaterno
        {
            get { return strApellidoMaterno; }
            set { strApellidoMaterno = value; }
        }
        private string strNombres;

        public string StrNombres
        {
            get { return strNombres; }
            set { strNombres = value; }
        }
        private string strSexo;

        public string StrSexo
        {
            get { return strSexo; }
            set { strSexo = value; }
        }

        private int numTipoDocumento;

        public int NumTipoDocumento
        {
            get { return numTipoDocumento; }
            set { numTipoDocumento = value; }
        }
        private string strTipoDocumento;

        public string StrTipoDocumento
        {
            get { return strTipoDocumento; }
            set { strTipoDocumento = value; }
        }

        private string strEstadoCivil;

        public string StrEstadoCivil
        {
            get { return strEstadoCivil; }
            set { strEstadoCivil = value; }
        }

        private int numIdLugarNacimiento;

        public int NumIdLugarNacimiento
        {
            get { return numIdLugarNacimiento; }
            set { numIdLugarNacimiento = value; }
        }
        private string strPais;

        public string StrPais
        {
            get { return strPais; }
            set { strPais = value; }
        }
        private string strDepartamentoNacimiento;

        public string StrDepartamentoNacimiento
        {
            get { return strDepartamentoNacimiento; }
            set { strDepartamentoNacimiento = value; }
        }
        private string strProvinciaNacimiento;

        public string StrProvinciaNacimiento
        {
            get { return strProvinciaNacimiento; }
            set { strProvinciaNacimiento = value; }
        }
        private string strDistritoNacimiento;

        public string StrDistritoNacimiento
        {
            get { return strDistritoNacimiento; }
            set { strDistritoNacimiento = value; }
        }

        private int numIdDomicilio;

        public int NumIdDomicilio
        {
            get { return numIdDomicilio; }
            set { numIdDomicilio = value; }
        }
        private string strDepartamentoDomicilio;

        public string StrDepartamentoDomicilio
        {
            get { return strDepartamentoDomicilio; }
            set { strDepartamentoDomicilio = value; }
        }
        private string strProvinciaDomicilio;

        public string StrProvinciaDomicilio
        {
            get { return strProvinciaDomicilio; }
            set { strProvinciaDomicilio = value; }
        }
        private string strDistritoDomicilio;

        public string StrDistritoDomicilio
        {
            get { return strDistritoDomicilio; }
            set { strDistritoDomicilio = value; }
        }
        private string strDireccionDomicilio;

        public string StrDireccionDomicilio
        {
            get { return strDireccionDomicilio; }
            set { strDireccionDomicilio = value; }
        }

        private string strTelefono;

        public string StrTelefono
        {
            get { return strTelefono; }
            set { strTelefono = value; }
        }
        private string strCelular;

        public string StrCelular
        {
            get { return strCelular; }
            set { strCelular = value; }
        }
        private string strEmail;

        public string StrEmail
        {
            get { return strEmail; }
            set { strEmail = value; }
        }
        private DateTime dtFechaNacimiento;

        public DateTime DtFechaNacimiento
        {
            get { return dtFechaNacimiento; }
            set { dtFechaNacimiento = value; }
        }
    }
}
