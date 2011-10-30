
namespace Modelo
{
    public class clsPabellon
    {
        private int numIdPabellon;

        public int IdPabellon
        {
            get { return numIdPabellon; }
            set { numIdPabellon = value; }
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

        public clsPabellon()
        {
            IdPabellon = 0;
            Nombre = "";
            Descripcion = "";
            Estado = "ACTIVO";
        }
    }
}
