using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsPerfil
    {
        private int numIdPerfil;

        public int NumIdPerfil
        {
            get { return numIdPerfil; }
            set { numIdPerfil = value; }
        }
        private string strNombre;

        public string StrNombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }
        private string strTipoPersonal;

        public string StrTipoPersonal
        {
            get { return strTipoPersonal; }
            set { strTipoPersonal = value; }
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
