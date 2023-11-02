using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphes_Verhalten
{
    internal class FirmenKunde : Kunde
    {
        private const double mwst = 0.19;
        public FirmenKunde(string anrede, string name, string firma) : base(anrede, name)
        {
            Firma = firma;
        }

        public string Firma { get; set; }

        //Methode
        public override string GetAdresse()
        {
            const char LF = (char)10; //Zeilenvorschub
            return base.GetAdresse() + LF + Firma;
        }

        public override void AddGuthaben(double brutto)
        {
            double netto = brutto / (1 + mwst);
            base.AddGuthaben(netto * 0.01); //Aufruf der Methode der Basisklasse
        }

        public double GetMwst()
        {
            return mwst;
        }
    }
}
