using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechercheDiviseur
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 2, res;
            bool test = false, premier = true;

            do
            {
                Console.WriteLine("Choisissez un nombre!");
                //  string chaine=Console.ReadLine();
                test = int.TryParse((Console.ReadLine()), out n);
                if (n < 2)
                {
                    test = false;
                }

            } while (test == false);

            while (i < n)
            {
                res = n % i;
                if (res == 0)
                {
                    Console.WriteLine("Le nombre saisi - {0:###,###} a pour diviseur - {1}", n, i);
                    premier = false;
                }

                i++;
            }
            if (premier)
            {
                Console.Write("Le nombre premier n'a pas de diviseur autre que 1 et lui-même...");
            }
            Console.ReadKey();


            //2.Recherche des diviseurs d’un nombre
            //Lire un nombre entier et déterminer tous ses diviseurs autres que 1 et lui-même. 

        }
    }
}
