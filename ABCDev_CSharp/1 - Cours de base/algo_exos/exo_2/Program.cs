using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;

            Console.Write("Indiquez la valeur de A : ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Indiquez la valeur de B : ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Indiquez la valeur de C : ");
            C = int.Parse(Console.ReadLine());

            if (A < B && B < C)
            {
                Console.WriteLine("A : {0}, B : {1}, C : {2}", A, B, C);
            }
            else if (A < C && C < B)
            {
                Console.WriteLine("A : {0}, B : {1}, C : {2}", A, C, B);
            }
            else if (B < A && A < C)
            {
                Console.WriteLine("A : {0}, B : {1}, C : {2}", B, A, C);
            }
            else if (B < C && C < A)
            {
                Console.WriteLine("A : {0}, B : {1}, C : {2}", B, C, A);
            }
            else if (C < A && A < B)
            {
                Console.WriteLine("A : {0}, B : {1}, C : {2}", C, A, B);
            }
            else if (C < B && B < A)
            {
                Console.WriteLine("A : {0}, B : {1}, C : {2}", C, B, A);
            }
            else
            {
                Console.WriteLine("Erreur ! valeurs égales");
            }
            Console.ReadKey();
        }
    }
}
