using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tachenrechner_thin_client
{
    public class Register
    {
        //Die globale Variable "registerContents" speichert den Registerinhalt als Zeichenkette
        private string registerContents = string.Empty;

        //Zugriff auf den numerischen Wert von "registerContents"
        public double Wert
        {
            get
            {
                try
                {
                    return Convert.ToDouble(registerContents);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                registerContents = value.ToString();
            }
        }

        //Hinzufügen einer einzelnen Ziffer und Rückgabe des Anzeigestrings
        public string NeueZiffer(char z)
        {
            if(char.IsDigit(z) || (z.ToString() == ","))
            {
                registerContents += z;
                return registerContents;
            }
            else
            {
                return "";
            }
        }

        //Letzte Ziffer löschen und Anzeigestring zurückgeben
        public string LoeschZiffer()
        {
            if (registerContents.Length > 0)
            {
                registerContents = registerContents.Remove(registerContents.Length - 1, 1);
            }
            return registerContents;
        }

        //Gesamtes Register löschen
        public void LoeschAlles()
        {
            registerContents = string.Empty;
        }
    }
}
