using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_seq5
{
    class Program
    {
        static void Main(string[] args)
        {
            double S;
            double i;
            int n;
            double valeur1;
            double valeur2;
            Console.Write("Indiquez la somme initiale placée sur le compte : ");
            S = double.Parse(Console.ReadLine());
            Console.Write("Indiquez le taux d'intérêt : ");
            i = (double.Parse(Console.ReadLine())) / 100;
            Console.Write("Indiquez le nombre d'années du placement : ");
            n = int.Parse(Console.ReadLine());
            valeur1 = S * (1 + n * i);
            valeur2 = S * Math.Pow(1 + i,n);
            Console.WriteLine("Valeur acquise avec intérêt simple : {0:##,###.00}", valeur1);
            Console.WriteLine("Valeur avec intérêt composé : {0:##,###.00}", valeur2);
            Console.ReadKey();
        }
    }
}
