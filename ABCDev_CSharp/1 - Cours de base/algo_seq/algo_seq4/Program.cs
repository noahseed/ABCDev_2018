using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_seq4
{
    class Program
    {
        static void Main(string[] args)
        {
            float r;
            float a;
            double aire;
            Console.Write("Indiquez le rayon du cercle : ");
            r = float.Parse(Console.ReadLine());
            Console.Write("Indiquez l'angle en degrés : ");
            a = float.Parse(Console.ReadLine());
            aire = Math.PI * Math.Pow(r,2) * a / 360;
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("l'aire du secteur circulaire est {0:#.##}",aire);
            Console.ReadKey();
        }
    }
}
