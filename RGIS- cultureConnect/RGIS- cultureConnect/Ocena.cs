using System;

namespace RGIS__cultureConnect
{
    public class Ocena
    {
        public int ID { get; set; }
        public int IDDogodka { get; set; }
        public int IDUporabnika { get; set; }
        public int OcenaVrednost { get; set; }
        public string Komentar { get; set; }
        public DateTime DatumOcene { get; set; }

 
        public Ocena(int idDogodka, int idUporabnika, int ocenaVrednost, string komentar)
        {
            IDDogodka = idDogodka;
            IDUporabnika = idUporabnika;
            OcenaVrednost = ocenaVrednost;
            Komentar = komentar;
            DatumOcene = DateTime.Now; 
        }

        public void PosodobiKomentar(string novKomentar)
        {
            throw new System.NotImplementedException("Not implemented");
        }

        public void PosodobiOceno(int novaOcena)
        {
            throw new System.NotImplementedException("Not implemented");
        }
    }
}
