using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsDetalleHorario
    {
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
        private int numIdConsultorio;

        public int IdConsultorio
        {
            get { return numIdConsultorio; }
            set { numIdConsultorio = value; }
        }
        private string strConsultorio;

        public string _Consultorio
        {
            get { return strConsultorio; }
            set { strConsultorio = value; }
        }
        private int numIdEspecialidad;

        public int IdEspecialidad
        {
            get { return numIdEspecialidad; }
            set { numIdEspecialidad = value; }
        }
        private string strEspecialidad;

        public string _Especialidad
        {
            get { return strEspecialidad; }
            set { strEspecialidad = value; }
        }
    }
}
