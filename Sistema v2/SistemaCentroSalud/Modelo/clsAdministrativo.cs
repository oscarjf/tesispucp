using System;

namespace Modelo
{
    public class clsAdministrativo
    {
        private int numIdAdministrativo;

        public int IdAdministrativo
        {
            get { return numIdAdministrativo; }
            set { numIdAdministrativo = value; }
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
        private string strFoto;

        public string Foto
        {
            get { return strFoto; }
            set { strFoto = value; }
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
        private string strArea;

        public string _Area
        {
            get { return strArea; }
            set { strArea = value; }
        }
        private int numIdPerfil;

        public int IdPerfil
        {
            get { return numIdPerfil; }
            set { numIdPerfil = value; }
        }
        private string strPerfil;

        public string _Perfil
        {
            get { return strPerfil; }
            set { strPerfil = value; }
        }
        private string strEstado;

        public string Estado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }

        public override string ToString()
        {
            return Paterno + " " + Materno + " " + Nombres;
        }

        public clsAdministrativo()
        {
            IdAdministrativo = 0;
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
            TipoPersona = "EMPLEADO";
            Foto = "";
            Usuario = "";
            Contrasena = "";
            TipoEmpleado = "ADMINISTRATIVO";
            IdArea = 0;
            IdPerfil = 0;
            Estado = "ACTIVO";
        }
    }
}
