using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsPais
    {
        private int numIdPais;

        public int NumIdPais
        {
            get { return numIdPais; }
            set { numIdPais = value; }
        }
        private string strNombre;

        public string StrNombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }

        public override string ToString()
        {
            return strNombre;
        }
    }
}
