using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_seq6
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            string B;
            string tmp;
            Console.Write("Indiquez la valeur de A : ");
            A = Console.ReadLine();
            Console.Write("Indiquez la valeur de B : ");
            B = Console.ReadLine();
            Console.WriteLine("Valeur de A : " + A);
            Console.WriteLine("Valeur de B : " + B);
            Console.WriteLine("--------- ECHANGE DES VALEURS ---------");
            tmp = A;
            A = B;
            B = tmp;
            Console.WriteLine("Nouvelle valeur de A : {0}", A);
            Console.WriteLine("Nouvelle valeur de B : {0}", B);
            Console.ReadKey();
        }
    }
}
