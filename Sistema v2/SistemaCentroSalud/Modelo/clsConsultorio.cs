
namespace Modelo
{
    public class clsConsultorio
    {
        private int numIdConsultorio;

        public int IdConsultorio
        {
            get { return numIdConsultorio; }
            set { numIdConsultorio = value; }
        }
        private string strPiso;

        public string Piso
        {
            get { return strPiso; }
            set { strPiso = value; }
        }
        private string strNumero;

        public string Numero
        {
            get { return strNumero; }
            set { strNumero = value; }
        }
        private int numIdPabellon;

        public int IdPabellon
        {
            get { return numIdPabellon; }
            set { numIdPabellon = value; }
        }
        private string strEstado;

        public string Estado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }

        public override string ToString()
        {
            return Numero;
        }

        public clsConsultorio()
        {
            IdConsultorio = 0;
            Piso = "";
            Numero = "";
            IdPabellon = 0;
            Estado = "ACTIVO";
        }
    }
}
