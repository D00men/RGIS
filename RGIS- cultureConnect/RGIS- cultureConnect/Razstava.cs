using System;

namespace RGIS__cultureConnect
{
	public class Razstava {
		private int iD;
		private string lokacija;
		private string opis;
		private DateTime datumZacetka;
		private String attribute;
		private DateTime datumKonca;

		public string PridobiPodrobnosti() {
			throw new System.NotImplementedException("Not implemented");
		}
		public bool JeAktivna(ref DateTime datum) {
			throw new System.NotImplementedException("Not implemented");
		}

		private UpravljanjeRazstav upravljanjeRazstav;

	}

}
