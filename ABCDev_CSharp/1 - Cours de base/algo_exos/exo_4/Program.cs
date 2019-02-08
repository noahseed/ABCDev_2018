using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double Nb;
            double Abs;
            bool Test;
            Console.Write("Veuillez entrer un nombre pour connaître sa valeur absolue : ");

            Test = double.TryParse(Console.ReadLine(), out Nb);
            Abs = Math.Abs(Nb);

            if (Test == true)
            {
                Console.WriteLine("La valeur absolue du nombre {0} est {1}.", Nb, Abs);
            }
            else
            {
                Console.WriteLine("Veuillez entrer un nombre valide !");
            }
            Console.ReadKey();
        }
    }
}
