using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsPaciente : clsPersona
    {
        private string strOcupacion;

        public string StrOcupacion
        {
            get { return strOcupacion; }
            set { strOcupacion = value; }
        }
        private string strRaza;

        public string StrRaza
        {
            get { return strRaza; }
            set { strRaza = value; }
        }
        private string strIdioma;

        public string StrIdioma
        {
            get { return strIdioma; }
            set { strIdioma = value; }
        }
        private string strReligion;

        public string StrReligion
        {
            get { return strReligion; }
            set { strReligion = value; }
        }
        private string strGrupoSanguineo;

        public string StrGrupoSanguineo
        {
            get { return strGrupoSanguineo; }
            set { strGrupoSanguineo = value; }
        }
        private string strFactorSanguineo;

        public string StrFactorSanguineo
        {
            get { return strFactorSanguineo; }
            set { strFactorSanguineo = value; }
        }
    }
}
