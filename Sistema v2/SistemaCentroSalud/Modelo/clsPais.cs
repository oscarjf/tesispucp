
namespace Modelo
{
    public class clsPais
    {
        private int numIdPais;

        public int IdPais
        {
            get { return numIdPais; }
            set { numIdPais = value; }
        }
        private string strNombre;

        public string Nombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }
        private string strDescripcion;

        public string Descripcion
        {
            get { return strDescripcion; }
            set { strDescripcion = value; }
        }
        private string strEstado;

        public string Estado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }

        public override string ToString()
        {
            return Nombre;
        }

        public clsPais()
        {
            IdPais = 0;
            Nombre = "";
            Descripcion = "";
            Estado = "ACTIVO";
        }
    }
}
