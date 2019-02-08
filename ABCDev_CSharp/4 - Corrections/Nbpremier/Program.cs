using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbpremier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lire un nombre entier et déterminer s'il est premier.
            int a, n=2,reste;
            bool diviseur = false; bool test = false;

            do
            {
                Console.WriteLine("Valeur a");
            test = int.TryParse(Console.ReadLine(),out a);
                
            } while (test==false);
            if (a>1)
            {
                         do
                {//recherche du diviseur
                    reste = a % n;    //A reste n
                    if (reste==0)
                    {
                        diviseur = true;
                        break;
                    }
                    n++;
                
                } while (diviseur==false && n<a);
                 if (diviseur== true)
                 {
                     Console.WriteLine("Le nombre n'est pas premier,il a pour diviseur {0:##,###}", n);        
                 }
                 else
                 {
                     Console.WriteLine("C'est un nombre premier!");
                 }
            }
            else
            {
                Console.WriteLine("Le nombre 1 n'est pas premier par définition");
            }
            Console.ReadKey();

            













        }
    }
}
