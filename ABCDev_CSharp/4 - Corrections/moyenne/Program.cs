using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float moyenne;

            Console.Write("Veuillez saisir un nombre positif décimal ou non pour A : ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Veuillez saisir un nombre positif décimal ou non pour B : ");
            b = float.Parse(Console.ReadLine());
            moyenne = (a + b) / 2;
            Console.WriteLine("La moyenne des deux nombres est : {0:##.00}",moyenne);
            Console.ReadLine();
        }
    }
}
