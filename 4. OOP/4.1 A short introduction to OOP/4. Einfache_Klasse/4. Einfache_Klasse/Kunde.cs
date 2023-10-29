using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Einfache_Klasse
{
	internal class Kunde
	{
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
		public void AddGuthaben(double betrag)
		{
			if (Stammkunde)
			{
				Guthaben += betrag;
			}
		}

	}
}
