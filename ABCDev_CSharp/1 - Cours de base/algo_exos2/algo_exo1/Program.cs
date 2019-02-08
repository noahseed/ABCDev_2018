using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89 et 97

            int n, i;
            double r, f;
            bool test = false;

            do
            {
                Console.Write("Veuillez entrer un nombre entier : ");
                test = int.TryParse(Console.ReadLine(), out n);
            } while (test == false);

            r = Math.Sqrt(n);
            i = 2;

            do
            {
                f = n % i;
                i++;
            } while (i <= r && f != 0);

            if (f != 0 || n == 2)
            {
                Console.Write(n + " est un nombre premier.");
                Console.ReadKey();
            }
            else
        	{
                Console.Write(n + " n'est pas un nombre premier.");
                Console.ReadKey();
	        }
        }
    }
}
