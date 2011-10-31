using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsCPT
    {
        private int numIdCPT;

        public int IdCPT
        {
            get { return numIdCPT; }
            set { numIdCPT = value; }
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
        private string strEstado;

        public string Estado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }
    }
}
