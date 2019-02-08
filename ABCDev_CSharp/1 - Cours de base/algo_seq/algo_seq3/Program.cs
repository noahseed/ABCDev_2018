using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_seq3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double p;
            double aire;
            Console.Write("Indiquez la longueur du côté A : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Indiquez la longueur du côté B : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Indiquez la longueur du côté C : ");
            c = double.Parse(Console.ReadLine());
            p = a + b + c;
            aire = Math.Sqrt((p / 2 * (p /2 - a) * (p / 2 - b) * (p / 2 - c)));
            Console.WriteLine("Le périmètre du triangle est {0:0.00} cm", p);
            Console.WriteLine("L'aire du triangle est {0:0.00} cm²", aire);
            Console.ReadKey();
        }
    }
}
