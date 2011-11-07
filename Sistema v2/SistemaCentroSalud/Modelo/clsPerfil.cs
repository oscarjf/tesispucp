
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
        private string strTipoPersonal;

        public string TipoPersonal
        {
            get { return strTipoPersonal; }
            set { strTipoPersonal = value; }
        }
        private string strEstado;

        public string Estado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }
        private string strListaIdVentanas;

        public string ListaIdVentanas
        {
            get { return strListaIdVentanas; }
            set { strListaIdVentanas = value; }
        }

        public override string ToString()
        {
            return Nombre;
        }

        public clsPerfil()
        {
            IdPerfil = 0;
            Nombre = "";
            TipoPersonal = "";
            Estado = "ACTIVO";
            ListaIdVentanas = "";
        }
    }
}
