using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;

            Console.Write("Indiquez la valeur de A : ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Indiquez la valeur de B : ");
            B = int.Parse(Console.ReadLine());
            if (A < B)
            {
                Console.WriteLine("A : {0} et B : {1}", A, B);
            }
            else if(A == B)
            {
                //Console.WriteLine("A : " + A + " et B : " + B);
                Console.WriteLine("A : {0} et B : {1}", A, B);
            }
            else
            {
                int C = A;
                A = B;
                B = C;
                Console.WriteLine("A : {0} et B : {1}", A, B);
            }
            Console.ReadKey();
        }
    }
}
