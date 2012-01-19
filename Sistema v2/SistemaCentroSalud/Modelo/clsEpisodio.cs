using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsEpisodio
    {
        private int numIdPaciente;

        public int NumIdPaciente
        {
            get { return numIdPaciente; }
            set { numIdPaciente = value; }
        }
        private int numIdEpisodio;

        public int NumIdEpisodio
        {
            get { return numIdEpisodio; }
            set { numIdEpisodio = value; }
        }
        private DateTime dtFechaRegistro;

        public DateTime DtFechaRegistro
        {
            get { return dtFechaRegistro; }
            set { dtFechaRegistro = value; }
        }
        private string strTipoEmpleado;

        public string StrTipoEmpleado
        {
            get { return strTipoEmpleado; }
            set { strTipoEmpleado = value; }
        }
        private string strResponsable;

        public string StrResponsable
        {
            get { return strResponsable; }
            set { strResponsable = value; }
        }
    }
}
