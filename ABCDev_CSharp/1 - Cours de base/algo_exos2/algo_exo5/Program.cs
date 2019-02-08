using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Barnabé fait ses courses
            decimal S, depense;
            int nbMagasins = 0;
            bool test = false;

            do
            {
                Console.Write("Indiquez la somme dont dispose Barnabé : ");
                test = decimal.TryParse(Console.ReadLine(), out S);
            } while (test == false);
            
            do
            {
                depense = (S / 2) + 1;
                S = S - depense;
                nbMagasins++;
                Console.WriteLine("Barnabé a dépensé {0:#,###.##} Francs dans le magasin {1}.", depense, nbMagasins);
            } while (depense > 2);

            Console.WriteLine("Barnabé est entré dans {0} magasin(s).", nbMagasins);
            Console.ReadKey();
        }
    }
}
