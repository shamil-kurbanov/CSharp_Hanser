using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_und_Polymorphie
{
    internal class PrivatKunde: Kunde //erbt von der Basisklasse Kunde!
    {
        public string WohnOrt {  get; set; }

        public PrivatKunde(string anrede, string name, string wohnOrt): base(anrede, name)
        {
            WohnOrt = wohnOrt; //klassenspezifische Ergänzung
        }

        //Die Methode GetAdresse() wird so überschrieben, dass zusätzlich zu Anrede und Name (von der Basisklasse geerbt)
        //noch der Wohnort des PrivatKunden angezeigt wird

        public override string GetAdresse()
        {
            const char LF = (char)10; //Zeilenvorschub
            return base.GetAdresse();
        }

        //Die Methode AddGuthaben() wird komplett neu überschrieben. Ohne Rücksicht auf die Zugehörigkeit zur Stammkundschaft
        //werden jedem Privatkunden 5% vom Rechnungsbetrag als Bonusguthaben angerechnet

        public override void AddGuthaben(double betrag)
        {
            //Zugriff auf protected-Property in Basisklasse
            Guthaben += 0.05 * betrag;
        }

    }

   
}
