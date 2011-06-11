using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsProvincia
    {
        private int numIdProvincia;
        private string strNombre;

        public int NumIdProvincia
        {
            get { return numIdProvincia; }
            set { numIdProvincia = value; }
        }

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
