using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(12, 7);
            Fraction f1 = new Fraction(9);
            Fraction f2 = new Fraction();
            Ecran.Affiche(f);
            Ecran.Affiche(f1);
            Ecran.Affiche(f2);

            f.Superieur(f1);
            Ecran.Affiche(f);

            Console.ReadKey();
        }
    }
}
