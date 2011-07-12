using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsHIS
    {
        private DateTime fecharegistro;

        public DateTime Fecharegistro
        {
            get { return fecharegistro; }
            set { fecharegistro = value; }
        }
        
        private int numeroHC;

        public int NumeroHC
        {
            get { return numeroHC; }
            set { numeroHC = value; }
        }
        
        private String codDistritoProcedencia;

        public String CodDistritoProcedencia
        {
            get { return codDistritoProcedencia; }
            set { codDistritoProcedencia = value; }
        }
        
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        
        private String sexo;

        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        
        private int idcie10;

        public int Idcie10
        {
            get { return idcie10; }
            set { idcie10 = value; }
        }

        private String tipodiagnostico;

        public String Tipodiagnostico
        {
            get { return tipodiagnostico; }
            set { tipodiagnostico = value; }
        }

        private String establecimiento;

        public String Establecimiento
        {
            get { return establecimiento; }
            set { establecimiento = value; }
        }

        private String servicio;

        public String Servicio
        {
            get { return servicio; }
            set { servicio = value; }
        }
    }
}
