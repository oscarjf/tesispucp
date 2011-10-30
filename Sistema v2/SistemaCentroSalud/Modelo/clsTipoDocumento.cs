
namespace Modelo
{
    public class clsTipoDocumento
    {
        private int numIdTipoDocumento;

        public int IdTipoDocumento
        {
            get { return numIdTipoDocumento; }
            set { numIdTipoDocumento = value; }
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
        private string strNumeroDigitos;

        public string NumeroDigitos
        {
            get { return strNumeroDigitos; }
            set { strNumeroDigitos = value; }
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

        public clsTipoDocumento()
        {
            IdTipoDocumento = 0;
            Nombre = "";
            Descripcion = "";
            NumeroDigitos = "0";
            Estado = "ACTIVO";
        }
    }
}
