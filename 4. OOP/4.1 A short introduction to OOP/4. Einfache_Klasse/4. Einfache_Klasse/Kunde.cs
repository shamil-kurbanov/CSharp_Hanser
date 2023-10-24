using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Einfache_Klasse
{
	internal class Kunde
	{
		private string anrede; // Feld
		private string name; // Feld

		//Konstruktor
		public Kunde(string anrede, string name)
		{
			this.anrede = anrede;
			this.name = name;
		}

		//Eigenschaft
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		//Methode
		public string Adresse()
		{
			string s = anrede + " " + Name;
			return s;
		}
	}
}
