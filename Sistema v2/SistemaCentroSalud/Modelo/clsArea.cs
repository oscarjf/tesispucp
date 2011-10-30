
namespace Modelo
{
    public class clsArea
    {
        private int numIdArea;

        public int IdArea
        {
            get { return numIdArea; }
            set { numIdArea = value; }
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
        private string strTipoArea;

        public string TipoArea
        {
            get { return strTipoArea; }
            set { strTipoArea = value; }
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

        public clsArea()
        {
            IdArea = 0;
            Nombre = "";
            Descripcion = "";
            TipoArea = "";
            Estado = "ACTIVO";
        }
    }
}
