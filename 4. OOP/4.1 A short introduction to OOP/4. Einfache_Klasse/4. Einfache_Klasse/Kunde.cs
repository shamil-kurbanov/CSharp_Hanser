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

		public string? Anrede; // öffentliche Feld
		public string? Name; // öffentliche Feld
		public int PLZ; // öffentliche Feld
		public string? Ort; // öffentliche Feld
		public bool Stammkunde; // öffentliche Feld
		public double Guthaben; // öffentliche Feld


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
