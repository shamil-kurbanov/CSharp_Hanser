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

        //Ziffereingabe in aktuelles Register
        public string NeueZiffer(string ziffer)
        {
            char z = ziffer[0];
            if (state == 1) //zum ersten Register hinzufügen
            {
                return reg1.NeueZiffer(z);
            }
            else //zum zweiten Register hinzufügen
            {
                return reg1.Wert.ToString() + " " + op + " " + reg2.NeueZiffer(z);
            }
        }

        //Letzte Ziffer des aktuellen Registers löschen und resultierenden Registerinhalt zurückgeben:
        public string LoescheZiffer()
        {
            if (state == 1)
            {
                return reg1.LoeschZiffer();
            }
            else 
            { 
                return reg2.LoeschZiffer();
            }
        }

        ////.......

    }
}
