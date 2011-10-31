using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsReligion
    {
        private int numIdReligion;

        public int IdReligion
        {
            get { return numIdReligion; }
            set { numIdReligion = value; }
        }
        private String strNombre;

        public String Nombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }
        private String strDescripcion;

        public String Descripcion
        {
            get { return strDescripcion; }
            set { strDescripcion = value; }
        }
        private String strEstado;

        public String Estado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }
    }
}
