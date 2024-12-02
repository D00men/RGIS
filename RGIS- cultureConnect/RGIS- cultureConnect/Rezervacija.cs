using System;
using System.Collections.Generic; 

namespace RGIS__cultureConnect
{
    public class Rezervacija
    {
        private int iDRezervacije;
        private int iDDogodka;
        private int iDUporabnika;
        private DateTime datumRezervacije;
        private int steviloOseb;
        private string statusRezervacije;

        public bool NovaRezervacija(int iDDogodka, int iD_uporabnika, int steviloMest)
        {
            throw new System.NotImplementedException("Not implemented");
        }

        public List<Rezervacija> PridobiRezervacije(int iD_uporabnika)
        {
            throw new System.NotImplementedException("Not implemented");
        }

        private UpravljanjeRezervacije upravljanjeRezervacije; 

        private RezervacijaUI rezervacijaUI; 
    }
}
