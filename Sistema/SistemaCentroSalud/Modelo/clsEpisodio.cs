using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsEpisodio
    {
        private int numIdEpisodio;

        public int NumIdEpisodio
        {
            get { return numIdEpisodio; }
            set { numIdEpisodio = value; }
        }
        private string strEctoscopia;

        public string StrEctoscopia
        {
            get { return strEctoscopia; }
            set { strEctoscopia = value; }
        }
        //Enfermedad Actual
        private string strTiempoEnfermedad;

        public string StrTiempoEnfermedad
        {
            get { return strTiempoEnfermedad; }
            set { strTiempoEnfermedad = value; }
        }
        private string strInicioEnfermedad;

        public string StrInicioEnfermedad
        {
            get { return strInicioEnfermedad; }
            set { strInicioEnfermedad = value; }
        }
        private string strCursoEnfermedad;

        public string StrCursoEnfermedad
        {
            get { return strCursoEnfermedad; }
            set { strCursoEnfermedad = value; }
        }
        private string strSintomasPrincipales;

        public string StrSintomasPrincipales
        {
            get { return strSintomasPrincipales; }
            set { strSintomasPrincipales = value; }
        }
        private string strRelatoCronológico;

        public string StrRelatoCronológico
        {
            get { return strRelatoCronológico; }
            set { strRelatoCronológico = value; }
        }
        //Examen Fisico
        private string strTemperatura;

        public string StrTemperatura
        {
            get { return strTemperatura; }
            set { strTemperatura = value; }
        }
        private string strFrecuenciaCardiaca;

        public string StrFrecuenciaCardiaca
        {
            get { return strFrecuenciaCardiaca; }
            set { strFrecuenciaCardiaca = value; }
        }
        private string strPulso;

        public string StrPulso
        {
            get { return strPulso; }
            set { strPulso = value; }
        }
        private string strFrecuenciaRespiratoria;

        public string StrFrecuenciaRespiratoria
        {
            get { return strFrecuenciaRespiratoria; }
            set { strFrecuenciaRespiratoria = value; }
        }
        private string strPresionArteria;

        public string StrPresionArteria
        {
            get { return strPresionArteria; }
            set { strPresionArteria = value; }
        }
        private string strPeso;

        public string StrPeso
        {
            get { return strPeso; }
            set { strPeso = value; }
        }
        private string strTalla;

        public string StrTalla
        {
            get { return strTalla; }
            set { strTalla = value; }
        }
        private string strOtrosExamenes;

        public string StrOtrosExamenes
        {
            get { return strOtrosExamenes; }
            set { strOtrosExamenes = value; }
        }
        private int numCie10;

        public int NumCie10
        {
            get { return numCie10; }
            set { numCie10 = value; }
        }
        private string strCodigoCIE10;

        public string StrCodigoCIE10
        {
            get { return strCodigoCIE10; }
            set { strCodigoCIE10 = value; }
        }
        private string strDescripcionCIE10;

        public string StrDescripcionCIE10
        {
            get { return strDescripcionCIE10; }
            set { strDescripcionCIE10 = value; }
        }
        private string strFechaRegistro;

        public string StrFechaRegistro
        {
            get { return strFechaRegistro; }
            set { strFechaRegistro = value; }
        }
    }
}
