using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsAuditoria
    {
        private string strNombreTabla;

        public string NombreTabla
        {
            get { return strNombreTabla; }
            set { strNombreTabla = value; }
        }
        private int numIdEmpleado;

        public int IdEmpleado
        {
            get { return numIdEmpleado; }
            set { numIdEmpleado = value; }
        }
        private string strNombreEmpleado;

        public string NombreEmpleado
        {
            get { return strNombreEmpleado; }
            set { strNombreEmpleado = value; }
        }
        private string strIndFechaInicio;

        public string IndFechaInicio
        {
            get { return strIndFechaInicio; }
            set { strIndFechaInicio = value; }
        }
        private DateTime dtFechaInicio;

        public DateTime FechaInicio
        {
            get { return dtFechaInicio; }
            set { dtFechaInicio = value; }
        }
        private string strIndFechaFin;

        public string IndFechaFin
        {
            get { return strIndFechaFin; }
            set { strIndFechaFin = value; }
        }
        private DateTime dtFechaFin;

        public DateTime FechaFin
        {
            get { return dtFechaFin; }
            set { dtFechaFin = value; }
        }
        private string strTipo;

        public string Tipo
        {
            get { return strTipo; }
            set { strTipo = value; }
        }

        public clsAuditoria()
        {
            NombreTabla = "";
            numIdEmpleado = 0;
            NombreEmpleado = "";
            IndFechaInicio = "";
            FechaInicio = DateTime.Today;
            IndFechaFin = "";
            FechaFin = DateTime.Today;
            Tipo = "TODAS";
        }
    }
}
