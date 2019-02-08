using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            double Aire;
            double P;


            Console.WriteLine("veuillez saisir la valeur du côté A");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("veuillez saisir la valeur du côté B");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("veuillez saisir la valeur du côté C");
            C = double.Parse(Console.ReadLine());

            P = A + B + C;
            Aire = Math.Sqrt((P / 2 * (P / 2 - A) * (P / 2 - B) * (P / 2 - C)));
            //aire = (p/2(p/2-a)(p/2-b)(p/2-c))1/2 

            Console.WriteLine("le perimetre du triangle est de : {0:##0.00} cm ", P);
            Console.WriteLine("l'aire du triangle est de : {0:##0.00} cm²", Aire);
            Console.ReadKey();

        }
    }
}
