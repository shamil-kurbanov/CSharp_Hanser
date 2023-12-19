using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Einfache_Klasse
{
	internal class Kunde
	{
		public delegate void GuthabenLeer(object sender, string e); //den Ereignistyp definieren
		public event GuthabenLeer? WenigGuthaben; //eine Ereignisinstanz WenigGuthaben deklarieren

		//Ereignis verwenden
		//1.Auf Klassenebene referenzieren wir zunächst die übliche Objektvariable
		private Kunde kunde1; //Objekt referenzieren

        private const char LF = (char)10; //private Konstante (Zeilenumbruch)

		private string? anrede; // privates Feld
		private string? name; // privates Feld
        private int plz; // privates Feld
        private string? ort; // privates Feld
        private bool stammkunde; //privates Feld
        private double guthaben; // privates Feld 

        public string? Anrede // öffentliche Feld
        {
			get { return anrede; }
			set
			{
				if (value == "Herr" || value == "Frau")
				{
					anrede = value;
				}
				else
				{
					MessageBox.Show("Die Anrede '" + value + "' ist nicht zulässig!");
				}
			}

		}

        public string? Name { get; set; } // öffentliche Feld
        public int PLZ { get; set; } // öffentliche Feld
        public string? Ort { get; set; } // öffentliche Feld
        public bool Stammkunde { get; set; } // öffentliche Feld
        public double Guthaben { get; private set; } // öffentliche Feld


        //Konstruktor


        // öffentliche Methode
        public string Adresse()
		{
			string s = Anrede + " " + Name + LF + PLZ.ToString() + " " + Ort;
			return s;
		}
		// öffentliche Methode
		public void AddGuthaben(double betrag) //erste Überladung
		{
			if (Stammkunde)
			{
				Guthaben += betrag;
				/*
				if (Guthaben <= 10)
				{
					//Das Ergebnis feuert nur, wenn ...
					if(WenigGuthaben != null) //eine Alternative: WenigGuthaben?.Invoke(this, meldung)
					{
						// ... mindestens ein Eventhandler angemeldet ist
						string meldung = "Das Guthaben beträgt " + Guthaben.ToString("C") + "!";
						WenigGuthaben(this, meldung);
					}
				}
				*/
			}
		}

		public void AddGuthaben(double brutto, double mwst) //zweite Überladung
		{
			Guthaben += brutto / (1 + mwst);
		}

		/*
		//2. Wir schreiben nun eine Ereignisbehandlung (Eventhandler) für das Ereignis
		private void GuthabenKontrolle(object obj, string s)
		{
			Kunde k = obj as Kunde;
			label2.Text = k.Name + ": " + s; //Ausgabe einer Warnung

			//Um das Ereignis mit dem Eventhandler zu verbinden, ist eine Anmeldung erforderlich,
			//die wir in den Konstruktorcode von Form1 einfügen können #§#
		}
		*/
	}
}
