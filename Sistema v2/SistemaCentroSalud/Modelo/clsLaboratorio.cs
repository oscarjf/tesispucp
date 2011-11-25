
namespace Modelo
{
    public class clsLaboratorio
    {
        private int numIdLaboratorio;

        public int IdLaboratorio
        {
            get { return numIdLaboratorio; }
            set { numIdLaboratorio = value; }
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

        public clsLaboratorio()
        {
            IdLaboratorio = 0;
            Codigo = "";
            Nombre = "";
            Descripcion = "";
            Estado = "ACTIVO";
        }
    }
}
