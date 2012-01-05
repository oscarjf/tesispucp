
namespace Modelo
{
    public class clsTriaje
    {
        private int numIdEmpleado;

        public int IdEmpleado
        {
            get { return numIdEmpleado; }
            set { numIdEmpleado = value; }
        }
        private int numIdPaciente;

        public int IdPaciente
        {
            get { return numIdPaciente; }
            set { numIdPaciente = value; }
        }
        private int numIdHistoriaClinica;

        public int IdHistoriaClinica
        {
            get { return numIdHistoriaClinica; }
            set { numIdHistoriaClinica = value; }
        }
        private string strGrupoSanguineo;

        public string GrupoSanguineo
        {
            get { return strGrupoSanguineo; }
            set { strGrupoSanguineo = value; }
        }
        private string strFactorSanguineo;

        public string FactorSanguineo
        {
            get { return strFactorSanguineo; }
            set { strFactorSanguineo = value; }
        }
        private int numIdModoIngreso;

        public int IdModoIngreso
        {
            get { return numIdModoIngreso; }
            set { numIdModoIngreso = value; }
        }
        private string strTemperatura;

        public string Temperatura
        {
            get { return strTemperatura; }
            set { strTemperatura = value; }
        }
        private string strFrecuenciaCardiaca;

        public string FrecuenciaCardiaca
        {
            get { return strFrecuenciaCardiaca; }
            set { strFrecuenciaCardiaca = value; }
        }
        private string strFrecuenciaRespiratoria;

        public string FrecuenciaRespiratoria
        {
            get { return strFrecuenciaRespiratoria; }
            set { strFrecuenciaRespiratoria = value; }
        }
        private string strPresionArterial;

        public string PresionArterial
        {
            get { return strPresionArterial; }
            set { strPresionArterial = value; }
        }
        private string strPeso;

        public string Peso
        {
            get { return strPeso; }
            set { strPeso = value; }
        }
        private string strTalla;

        public string Talla
        {
            get { return strTalla; }
            set { strTalla = value; }
        }
        private string strObservaciones;

        public string Observaciones
        {
            get { return strObservaciones; }
            set { strObservaciones = value; }
        }
        private int numIdExamenFisico;

        public int IdExamenFisico
        {
            get { return numIdExamenFisico; }
            set { numIdExamenFisico = value; }
        }
        private int numIdEpisodio;

        public int IdEpisodio
        {
            get { return numIdEpisodio; }
            set { numIdEpisodio = value; }
        }

        public clsTriaje()
        {
            IdEmpleado = 0;
            IdPaciente = 0;
            IdHistoriaClinica = 0;
            GrupoSanguineo = "";
            FactorSanguineo = "";
            IdModoIngreso = 0;
            Temperatura = "";
            FrecuenciaCardiaca = "";
            FrecuenciaRespiratoria = "";
            PresionArterial = "";
            Peso = "";
            Talla = "";
            Observaciones = "";
            IdExamenFisico = 0;
            IdEpisodio = 0;
        }
    }
}
