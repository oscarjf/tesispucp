
namespace Modelo
{
    public class clsUbigeo
    {
        private int numIdUbigeo;

        public int IdUbigeo
        {
            get { return numIdUbigeo; }
            set { numIdUbigeo = value; }
        }
        private string strCodDepartamento;

        public string CodDepartamento
        {
            get { return strCodDepartamento; }
            set { strCodDepartamento = value; }
        }
        private string strCodProvincia;

        public string CodProvincia
        {
            get { return strCodProvincia; }
            set { strCodProvincia = value; }
        }
        private string strCodDistrito;

        public string CodDistrito
        {
            get { return strCodDistrito; }
            set { strCodDistrito = value; }
        }
        private string strDescripcion;

        public string Descripcion
        {
            get { return strDescripcion; }
            set { strDescripcion = value; }
        }

        public clsUbigeo()
        {
            IdUbigeo = 0;
            CodDepartamento = "";
            CodProvincia = "";
            CodDistrito = "";
            Descripcion = "";
        }
    }
}
