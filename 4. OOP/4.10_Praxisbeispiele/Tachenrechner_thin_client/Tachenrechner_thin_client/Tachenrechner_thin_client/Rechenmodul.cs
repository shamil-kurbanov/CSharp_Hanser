using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tachenrechner_thin_client
{
    internal class Rechenmodul
    {
        private int state = 1; //Startmodus (Zustandsvariable)
        private char op;       // aktueller Operator
        private Register reg1;
        private Register reg2; //zwei Rechenregister

        //Im Konstruktor werden zwei Register-Objekte erzeugt
        public Rechenmodul()
        {
            reg1 = new Register();
            reg2 = new Register();
        }


    }
}
