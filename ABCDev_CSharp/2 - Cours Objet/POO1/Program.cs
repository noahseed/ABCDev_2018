using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);

            if (c1.Superieur(c2))
            {
                Console.WriteLine("superieur");
            }
            else
            {
                Console.WriteLine("inferieur");
            }
            Console.ReadKey();
        }
    }
}
