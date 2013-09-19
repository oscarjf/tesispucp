using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsDetalleDiagnostico
    {
        private int numIdDiagnostico;

        public int IdDiagnostico
        {
            get { return numIdDiagnostico; }
            set { numIdDiagnostico = value; }
        }
        private int numIdCie10;

        public int IdCie10
        {
            get { return numIdCie10; }
            set { numIdCie10 = value; }
        }
        private string strDescripcion;

        public string Descripcion
        {
            get { return strDescripcion; }
            set { strDescripcion = value; }
        }

        public clsDetalleDiagnostico()
        {
            Descripcion = "";
        }
    }
}
