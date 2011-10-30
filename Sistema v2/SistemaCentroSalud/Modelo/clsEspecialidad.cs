
namespace Modelo
{
    public class clsEspecialidad
    {
        private int numIdEspecialidad;

        public int IdEspecialidad
        {
            get { return numIdEspecialidad; }
            set { numIdEspecialidad = value; }
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
        private int numIdArea;

        public int IdArea
        {
            get { return numIdArea; }
            set { numIdArea = value; }
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

        public clsEspecialidad()
        {
            IdEspecialidad = 0;
            Nombre = "";
            Descripcion = "";
            IdArea = 0;
            Estado = "ACTIVO";
        }
    }
}
