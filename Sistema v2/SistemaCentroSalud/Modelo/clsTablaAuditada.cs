using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsTablaAuditada
    {
        private int numIdTablaAuditada;

        public int _IdTablaAuditada
        {
            get { return numIdTablaAuditada; }
            set { numIdTablaAuditada = value; }
        }
        private string strTabla;

        public string Tabla
        {
            get { return strTabla; }
            set { strTabla = value; }
        }
        private string strIndAuditoria;

        public string IndAuditoria
        {
            get { return strIndAuditoria; }
            set { strIndAuditoria = value; }
        }
        private string strIndInsertar;

        public string IndInsertar
        {
            get { return strIndInsertar; }
            set { strIndInsertar = value; }
        }
        private string strIndActualizar;

        public string IndActualizar
        {
            get { return strIndActualizar; }
            set { strIndActualizar = value; }
        }
        private string strIndEliminar;

        public string IndEliminar
        {
            get { return strIndEliminar; }
            set { strIndEliminar = value; }
        }

        public clsTablaAuditada()
        {
            _IdTablaAuditada = 0;
            Tabla = "";
            IndAuditoria = "";
            IndInsertar = "";
            IndActualizar = "";
            IndEliminar = "";
        }
    }
}
