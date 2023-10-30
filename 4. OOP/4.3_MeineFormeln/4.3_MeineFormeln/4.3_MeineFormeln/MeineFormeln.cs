using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_MeineFormeln
{
    internal class MeineFormeln
    {
        public static double KreisUmfang(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double KugelVolumen(double radius)
        {
            return 4 / 3.0 * Math.PI * Math.Pow(radius, 3);
        }

        public static double Netto(double brutto, double mwst)
        {
            return brutto / (1 + mwst);
        }
    }
}
