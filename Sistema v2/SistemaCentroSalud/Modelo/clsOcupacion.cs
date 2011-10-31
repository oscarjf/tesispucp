
namespace Modelo
{
    public class clsOcupacion
    {
        private int numIdOcupacion;

        public int IdOcupacion
        {
            get { return numIdOcupacion; }
            set { numIdOcupacion = value; }
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

        public clsOcupacion()
        {
            IdOcupacion = 0;
            Nombre = "";
            Descripcion = "";
            Estado = "ACTIVO";
        }
    }
}
