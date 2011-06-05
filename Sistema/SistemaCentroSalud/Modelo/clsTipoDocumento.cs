using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsTipoDocumento
    {
        private int numIdTipoDocumento;

        public int NumIdTipoDocumento
        {
            get { return numIdTipoDocumento; }
            set { numIdTipoDocumento = value; }
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
        private int numNumeroDigitos;

        public int NumNumeroDigitos
        {
            get { return numNumeroDigitos; }
            set { numNumeroDigitos = value; }
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
