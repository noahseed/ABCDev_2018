using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_seq2
{
    class Program
    {
        static void Main(string[] args)
        {
            double rayon;
            double aire;
            double volume;
            Console.Write("Indiquez le rayon de la sphère : ");
            rayon = double.Parse(Console.ReadLine());
            aire = 4 * Math.PI * Math.Pow(rayon,2);
            //Console.WriteLine("L'aire de la sphère est : " + aire.ToString("##,###.00"));
            volume = (double)4/3 * Math.PI * Math.Pow(rayon,3);
            //Console.WriteLine("Le volume de la sphère est : " + volume.ToString("##,###.00"));
            Console.WriteLine("L'aire de la sphère est {0:##,###.00} et son volume est {1:##,###.00}",aire,volume);
            Console.ReadKey();
        }
    }
}
