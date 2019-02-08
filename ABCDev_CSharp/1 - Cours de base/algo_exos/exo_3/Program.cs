using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            bool Test;

            Console.Write("Entrez une année : ");
            Test = int.TryParse(Console.ReadLine(), out A);

            if (Test == true)
            {
                if (A % 4 == 0 && A % 100 != 0 || A % 400 == 0)
                {
                    Console.WriteLine(A + " est une année bissextile !");
                }
                else
                {
                    Console.WriteLine(A + " n'est pas une année bissextile !");
                }
            }
            else
            {
                Console.WriteLine("Vous devez entrer une année valide !");
            }
            Console.ReadKey();
        }
    }
}
