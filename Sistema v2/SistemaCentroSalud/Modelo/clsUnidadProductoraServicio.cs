
namespace Modelo
{
    public class clsUnidadProductoraServicio
    {
        private int numIdUnidadProductoraServicio;

        public int IdUnidadProductoraServicio
        {
            get { return numIdUnidadProductoraServicio; }
            set { numIdUnidadProductoraServicio = value; }
        }
        private string strCodigo;

        public string Codigo
        {
            get { return strCodigo; }
            set { strCodigo = value; }
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
            return Codigo + " - " + Descripcion;
        }

        public clsUnidadProductoraServicio()
        {
            IdUnidadProductoraServicio = 0;
            Codigo = "";
            Nombre = "";
            Descripcion = "";
            Estado = "ACTIVO";
        }
    }
}
