using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terre
{
    class Program
    {
        static void Main(string[] args)
        {
            double R;//Rayon 0
            Console.WriteLine("Quelle est le rayon de la sphère ?");
            R = double.Parse(Console.ReadLine());
            double A = 4 * Math.PI * Math.Pow(R, 2);
            double V = (double)4/3 * Math.PI * Math.Pow(R, 3);

            Console.WriteLine("L'aire de la sphère de rayon R : {0:###.###}Km est {1:##,###.00}Km2 et son volume est {2:#,###.###} Km3 ",R,A,V);
            Console.ReadKey();
        }
    }
}
