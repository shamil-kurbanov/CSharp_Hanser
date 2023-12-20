using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_und_Polymorphie
{
    internal class Kunde //Basis Klasse
    {
        public string Anrede {  get; set; }
        public string Nachname { get; set; }
        public bool StammKunde {  get; set; }
        public double Guthaben {  get; protected set; }


        //Konstruktor
        public Kunde(string anrede, string name)
        {
            Anrede = anrede;
            Nachname = name;
        }

        //virtuelle (überschreibene) Methode
        public virtual string GetAdresse() //virtuelle Methode
        {
            string s = Anrede + " " + Nachname;
            return s;
        }

        public virtual void AddGuthaben(double betrag) //virtuelle Methode
        {
            if (StammKunde)
            {
                Guthaben += betrag;
            }
        }

        //Normale Methode
        public void Test()
        {
            MessageBox.Show("Hallo Kunde!");
        }

    }
}
