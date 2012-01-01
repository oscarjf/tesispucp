using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsDetalleDisponibilidad
    {
        private int numIdDetalleDisponibilidad;

        public int _IdDetalleDisponibilidad
        {
            get { return numIdDetalleDisponibilidad; }
            set { numIdDetalleDisponibilidad = value; }
        }
        private int numIdDisponibilidad;

        public int _IdDisponibilidad
        {
            get { return numIdDisponibilidad; }
            set { numIdDisponibilidad = value; }
        }
        private DateTime dtFecha;

        public DateTime _Fecha
        {
            get { return dtFecha; }
            set { dtFecha = value; }
        }
        private DateTime dtHoraInicio;

        public DateTime _HoraInicio
        {
            get { return dtHoraInicio; }
            set { dtHoraInicio = value; }
        }
        private DateTime dtHoraFin;

        public DateTime _HoraFin
        {
            get { return dtHoraFin; }
            set { dtHoraFin = value; }
        }
        private int numIdDisponibilidadDoctor;

        public int IdDisponibilidadDoctor
        {
            get { return numIdDisponibilidadDoctor; }
            set { numIdDisponibilidadDoctor = value; }
        }
        private DateTime dtFechaElegida;

        public DateTime FechaElegida
        {
            get { return dtFechaElegida; }
            set { dtFechaElegida = value; }
        }
        private string strDetalleXML;

        public string DetalleXML
        {
            get { return strDetalleXML; }
            set { strDetalleXML = value; }
        }
        private string strListaEliminados;

        public string ListaEliminados
        {
            get { return strListaEliminados; }
            set { strListaEliminados = value; }
        }

        public clsDetalleDisponibilidad()
        {
            IdDisponibilidadDoctor = 0;
            FechaElegida = DateTime.Now;
            DetalleXML = "";
            ListaEliminados = "";
        }
    }
}
