
namespace Modelo
{
    public class clsPerfil
    {
        private int numIdPerfil;

        public int IdPerfil
        {
            get { return numIdPerfil; }
            set { numIdPerfil = value; }
        }
        private string strNombre;

        public string Nombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }
        private string strTipoEmpleado;

        public string TipoEmpleado
        {
            get { return strTipoEmpleado; }
            set { strTipoEmpleado = value; }
        }
        private string strEstado;

        public string Estado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }
        private string strListaMenus;

        public string ListaMenus
        {
            get { return strListaMenus; }
            set { strListaMenus = value; }
        }

        public override string ToString()
        {
            return Nombre;
        }

        public clsPerfil()
        {
            IdPerfil = 0;
            Nombre = "";
            TipoEmpleado = "";
            Estado = "ACTIVO";
            ListaMenus = "";
        }
    }
}
