using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_seq1
{
    class Program
    {
        static void Main(string[] args)
        {
            float chiffreA;
            float chiffreB;
            float moyenne;
            Console.Write("Veuillez entrer la valeur de A : ");
            chiffreA = float.Parse(Console.ReadLine());
            Console.Write("Veuillez entrer la valeur de B : ");
            chiffreB = float.Parse(Console.ReadLine());
            moyenne = (chiffreA + chiffreB) / 2;
            Console.WriteLine("La moyenne est {0:##.00}",moyenne);
            Console.ReadKey();
        }
    }
}
