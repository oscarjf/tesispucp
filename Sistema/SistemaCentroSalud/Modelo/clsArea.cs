using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsArea
    {
        private int numIdArea;

        public int NumIdArea
        {
            get { return numIdArea; }
            set { numIdArea = value; }
        }
        private string strNombre;

        public string StrNombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }
        private string strDescripcion;

        public string StrDescripcion
        {
            get { return strDescripcion; }
            set { strDescripcion = value; }
        }
        private string strTipoArea;

        public string StrTipoArea
        {
            get { return strTipoArea; }
            set { strTipoArea = value; }
        }
        private string strEstado;

        public string StrEstado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }

        public override string ToString()
        {
            return strNombre;
        }
    }
}
