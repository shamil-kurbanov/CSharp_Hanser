﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphes_Verhalten
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
            return base.GetAdresse() + LF + WohnOrt;
        }

        //Die Methode AddGuthaben() wird komplett neu überschrieben. Ohne Rücksicht auf die Zugehörigkeit zur Stammkundschaft
        //werden jedem Privatkunden 5% vom Rechnungsbetrag als Bonusguthaben angerechnet

        public override void AddGuthaben(double betrag)
        {
            //Zugriff auf protected-Property in Basisklasse
            Guthaben += 0.05 * betrag;
        }

        //Normale Methode Test() aus Basisklasse
        public new void Test()
        {
            MessageBox.Show("Hello Privatkunde!");
        }
    }

   
}
