using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsDetalleDisponibilidad
    {
        private int numIdDetalleDisponibilidad;

        public int IdDetalleDisponibilidad
        {
            get { return numIdDetalleDisponibilidad; }
            set { numIdDetalleDisponibilidad = value; }
        }
        private int numIdDisponibilidad;

        public int IdDisponibilidad
        {
            get { return numIdDisponibilidad; }
            set { numIdDisponibilidad = value; }
        }
        private DateTime dtFecha;

        public DateTime Fecha
        {
            get { return dtFecha; }
            set { dtFecha = value; }
        }
        private DateTime dtHoraInicio;

        public DateTime HoraInicio
        {
            get { return dtHoraInicio; }
            set { dtHoraInicio = value; }
        }
        private DateTime dtHoraFin;

        public DateTime HoraFin
        {
            get { return dtHoraFin; }
            set { dtHoraFin = value; }
        }
    }
}
