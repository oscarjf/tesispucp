using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsEtnia
    {
        private int numIdEtnia;

        public int IdEtnia
        {
            get { return numIdEtnia; }
            set { numIdEtnia = value; }
        }

        private String strCodigo;

        public String Codigo
        {
            get { return strCodigo; }
            set { strCodigo = value; }
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
