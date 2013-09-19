
namespace Modelo
{
    public class clsDiagnostico
    {
        private int numIdDiagnostico;

        public int IdDiagnostico
        {
            get { return numIdDiagnostico; }
            set { numIdDiagnostico = value; }
        }
        private int numIdCie10;

        public int IdCie10
        {
            get { return numIdCie10; }
            set { numIdCie10 = value; }
        }
        private string strCodigo;

        public string Codigo
        {
            get { return strCodigo; }
            set { strCodigo = value; }
        }
        private string strDescripcion;

        public string Descripcion
        {
            get { return strDescripcion; }
            set { strDescripcion = value; }
        }

        public clsDiagnostico()
        {
            IdDiagnostico = 0;
            IdCie10 = 0;
            Codigo = "";
            Descripcion = "";
        }
    }
}
