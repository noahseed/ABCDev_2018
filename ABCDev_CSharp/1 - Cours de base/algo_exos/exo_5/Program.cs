using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez indiquer la valeur de a : ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Veuillez indiquer la valeur de b : ");
            float b = float.Parse(Console.ReadLine());
            
            if (a == 0 && b == 0)
            {
                Console.Write("L'équation est indéterminée !");
            }
            else if (a == 0 && b != 0)
            {
                Console.Write("L'équation est impossible !");
            }
            else
            {
                float x = -b / a;
                Console.Write("La solution de l'équation est : x = {0:0.00}", x);
            }
            Console.ReadKey();
        }
    }
}
