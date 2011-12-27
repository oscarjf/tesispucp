using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comun
{
    public static class clsVentanas
    {
        private static bool blnVentanaHorario = false;

        public static bool VentanaHorarioActiva
        {
            get { return blnVentanaHorario; }
            set { blnVentanaHorario = value; }
        }
    }
}
