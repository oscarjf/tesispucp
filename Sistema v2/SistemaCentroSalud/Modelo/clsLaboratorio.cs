using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        private String strCodigo;

        public String Codigo
        {
            get { return strCodigo; }
            set { strCodigo = value; }
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
