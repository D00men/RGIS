using System;

namespace RGIS__cultureConnect
{
    public class Dogodek
    {
        private int iDDogodka;
        private string ime;
        private string opis;
        private string lokacija;
        private DateTime cas;
        private double cena;

        public bool UstvariDogodek()
        {
            throw new System.NotImplementedException("Not implemented");
        }

        public bool PosodobiDogodek(string ime, string opis, string lokacija, DateTime cas, double cena)
        {
            this.ime = ime;
            this.opis = opis;
            this.lokacija = lokacija;
            this.cas = cas;
            this.cena = cena;

            throw new System.NotImplementedException("Not implemented");
        }

        
        private UpravljanjeDogodkov upravljanjeDogodkov; 
    }
}




