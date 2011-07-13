using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsHistoriaClinica
    {
        private int numIdHistoriaClinica;

        public int NumIdHistoriaClinica
        {
            get { return numIdHistoriaClinica; }
            set { numIdHistoriaClinica = value; }
        }
        private int numNumeroHC;

        public int NumNumeroHC
        {
            get { return numNumeroHC; }
            set { numNumeroHC = value; }
        }
        private List<clsEpisodio> lstEpisodios;

        public List<clsEpisodio> LstEpisodios
        {
            get { return lstEpisodios; }
            set { lstEpisodios = value; }
        }
        //Antecedentes
        private string strIndTabaco;

        public string StrIndTabaco
        {
            get { return strIndTabaco; }
            set { strIndTabaco = value; }
        }
        private string strIndAlcohol;

        public string StrIndAlcohol
        {
            get { return strIndAlcohol; }
            set { strIndAlcohol = value; }
        }
        private string strIndCafe;

        public string StrIndCafe
        {
            get { return strIndCafe; }
            set { strIndCafe = value; }
        }
        private string strIndTe;

        public string StrIndTe
        {
            get { return strIndTe; }
            set { strIndTe = value; }
        }
        private string strIndDrogas;

        public string StrIndDrogas
        {
            get { return strIndDrogas; }
            set { strIndDrogas = value; }
        }
        private string strIndDiabetes;

        public string StrIndDiabetes
        {
            get { return strIndDiabetes; }
            set { strIndDiabetes = value; }
        }
        private string strDescripcionDiabetes;

        public string StrDescripcionDiabetes
        {
            get { return strDescripcionDiabetes; }
            set { strDescripcionDiabetes = value; }
        }
        private string strIndHipertension;

        public string StrIndHipertension
        {
            get { return strIndHipertension; }
            set { strIndHipertension = value; }
        }
        private string strDescripcionHipertension;

        public string StrDescripcionHipertension
        {
            get { return strDescripcionHipertension; }
            set { strDescripcionHipertension = value; }
        }
        private string strIndCoronariopatia;

        public string StrIndCoronariopatia
        {
            get { return strIndCoronariopatia; }
            set { strIndCoronariopatia = value; }
        }
        private string strDescripcionCoronariopatia;

        public string StrDescripcionCoronariopatia
        {
            get { return strDescripcionCoronariopatia; }
            set { strDescripcionCoronariopatia = value; }
        }
        private string strIndDislipidemia;

        public string StrIndDislipidemia
        {
            get { return strIndDislipidemia; }
            set { strIndDislipidemia = value; }
        }
        private string strDescripcionDislipidemia;

        public string StrDescripcionDislipidemia
        {
            get { return strDescripcionDislipidemia; }
            set { strDescripcionDislipidemia = value; }
        }
        private string strIndAsma;

        public string StrIndAsma
        {
            get { return strIndAsma; }
            set { strIndAsma = value; }
        }
        private string strDescripcionAsma;

        public string StrDescripcionAsma
        {
            get { return strDescripcionAsma; }
            set { strDescripcionAsma = value; }
        }
        private string strIndPsicopatia;

        public string StrIndPsicopatia
        {
            get { return strIndPsicopatia; }
            set { strIndPsicopatia = value; }
        }
        private string strDescripcionPsicopatia;

        public string StrDescripcionPsicopatia
        {
            get { return strDescripcionPsicopatia; }
            set { strDescripcionPsicopatia = value; }
        }
        private string strIndAlergias;

        public string StrIndAlergias
        {
            get { return strIndAlergias; }
            set { strIndAlergias = value; }
        }
        private string strDescripcionAlergias;

        public string StrDescripcionAlergias
        {
            get { return strDescripcionAlergias; }
            set { strDescripcionAlergias = value; }
        }
        private string strIndTuberculosis;

        public string StrIndTuberculosis
        {
            get { return strIndTuberculosis; }
            set { strIndTuberculosis = value; }
        }
        private string strDescripcionTuberculosis;

        public string StrDescripcionTuberculosis
        {
            get { return strDescripcionTuberculosis; }
            set { strDescripcionTuberculosis = value; }
        }
        private string strIndAtipia;

        public string StrIndAtipia
        {
            get { return strIndAtipia; }
            set { strIndAtipia = value; }
        }
        private string strDescripcionAtipia;

        public string StrDescripcionAtipia
        {
            get { return strDescripcionAtipia; }
            set { strDescripcionAtipia = value; }
        }
        private string strIndGota;

        public string StrIndGota
        {
            get { return strIndGota; }
            set { strIndGota = value; }
        }
        private string strDescripcionGota;

        public string StrDescripcionGota
        {
            get { return strDescripcionGota; }
            set { strDescripcionGota = value; }
        }
        private string strIndEndocrinopatia;

        public string StrIndEndocrinopatia
        {
            get { return strIndEndocrinopatia; }
            set { strIndEndocrinopatia = value; }
        }
        private string strDescripcionEndocrinopatia;

        public string StrDescripcionEndocrinopatia
        {
            get { return strDescripcionEndocrinopatia; }
            set { strDescripcionEndocrinopatia = value; }
        }
        private string strIndNefropatia;

        public string StrIndNefropatia
        {
            get { return strIndNefropatia; }
            set { strIndNefropatia = value; }
        }
        private string strDescripcionNefropatia;

        public string StrDescripcionNefropatia
        {
            get { return strDescripcionNefropatia; }
            set { strDescripcionNefropatia = value; }
        }
        private string strIndUropatia;

        public string StrIndUropatia
        {
            get { return strIndUropatia; }
            set { strIndUropatia = value; }
        }
        private string strDescripcionUropatia;

        public string StrDescripcionUropatia
        {
            get { return strDescripcionUropatia; }
            set { strDescripcionUropatia = value; }
        }
        private string strIndHemopatia;

        public string StrIndHemopatia
        {
            get { return strIndHemopatia; }
            set { strIndHemopatia = value; }
        }
        private string strDescripcionHemopatia;

        public string StrDescripcionHemopatia
        {
            get { return strDescripcionHemopatia; }
            set { strDescripcionHemopatia = value; }
        }
        private string strIndETS;

        public string StrIndETS
        {
            get { return strIndETS; }
            set { strIndETS = value; }
        }
        private string strDescripcionETS;

        public string StrDescripcionETS
        {
            get { return strDescripcionETS; }
            set { strDescripcionETS = value; }
        }
        private string strIndUlcera;

        public string StrIndUlcera
        {
            get { return strIndUlcera; }
            set { strIndUlcera = value; }
        }
        private string strDescripcionUlcera;

        public string StrDescripcionUlcera
        {
            get { return strDescripcionUlcera; }
            set { strDescripcionUlcera = value; }
        }
        private string strIndHepatitis;

        public string StrIndHepatitis
        {
            get { return strIndHepatitis; }
            set { strIndHepatitis = value; }
        }
        private string strDescripcionHepatitis;

        public string StrDescripcionHepatitis
        {
            get { return strDescripcionHepatitis; }
            set { strDescripcionHepatitis = value; }
        }
        private string strIndColecistopatia;

        public string StrIndColecistopatia
        {
            get { return strIndColecistopatia; }
            set { strIndColecistopatia = value; }
        }
        private string strDescripcionColecistopatia;

        public string StrDescripcionColecistopatia
        {
            get { return strDescripcionColecistopatia; }
            set { strDescripcionColecistopatia = value; }
        }
        private string strIndEnfermedadesNeurologicas;

        public string StrIndEnfermedadesNeurologicas
        {
            get { return strIndEnfermedadesNeurologicas; }
            set { strIndEnfermedadesNeurologicas = value; }
        }
        private string strDescripcionEnfermedadesNeurologicas;

        public string StrDescripcionEnfermedadesNeurologicas
        {
            get { return strDescripcionEnfermedadesNeurologicas; }
            set { strDescripcionEnfermedadesNeurologicas = value; }
        }
        private string strIndFiebresProlongadas;

        public string StrIndFiebresProlongadas
        {
            get { return strIndFiebresProlongadas; }
            set { strIndFiebresProlongadas = value; }
        }
        private string strDescripcionFiebresProlongadas;

        public string StrDescripcionFiebresProlongadas
        {
            get { return strDescripcionFiebresProlongadas; }
            set { strDescripcionFiebresProlongadas = value; }
        }
        private string strIndColagenopatia;

        public string StrIndColagenopatia
        {
            get { return strIndColagenopatia; }
            set { strIndColagenopatia = value; }
        }
        private string strDescripcionColagenopatia;

        public string StrDescripcionColagenopatia
        {
            get { return strDescripcionColagenopatia; }
            set { strDescripcionColagenopatia = value; }
        }
        private string strOtrosAntecedentes;

        public string StrOtrosAntecedentes
        {
            get { return strOtrosAntecedentes; }
            set { strOtrosAntecedentes = value; }
        }
    }
}
