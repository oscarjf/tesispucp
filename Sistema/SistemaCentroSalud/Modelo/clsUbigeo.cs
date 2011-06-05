using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsUbigeo
    {
        private string strCodigoDepartamento;

        public string StrCodigoDepartamento
        {
            get { return strCodigoDepartamento; }
            set { strCodigoDepartamento = value; }
        }
        private string strCodigoProvincia;

        public string StrCodigoProvincia
        {
            get { return strCodigoProvincia; }
            set { strCodigoProvincia = value; }
        }
        private string strCodigoDistrito;

        public string StrCodigoDistrito
        {
            get { return strCodigoDistrito; }
            set { strCodigoDistrito = value; }
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
