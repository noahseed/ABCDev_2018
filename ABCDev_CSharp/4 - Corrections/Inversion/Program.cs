using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversion
{
    class Program
    {


        static void Main(string[] args)
        {
            bool testA=false;
            bool testB = false;
            double a;
            double b;
            double temp;

            do
            {
                Console.Write("Entrer la valeur de A:");
                testA = double.TryParse(Console.ReadLine(),out a);
            } while (testA == false);
            do
            {
                Console.Write("Entrer la valeur de B:");
                testB = double.TryParse(Console.ReadLine(), out b);
            } while (testB== false);
            Console.WriteLine("La valeur de A avant inversion est:{0:n}", a);
            Console.WriteLine("La valeur de B avant inversion est:{0:n}", b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("La valeur de A après inversion est:{0:n}", a);
            Console.WriteLine("La valeur de B après inversion est:{0:n}", b);
            Console.ReadKey();

        }
    }
}
