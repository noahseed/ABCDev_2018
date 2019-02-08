using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double x;

            int[] montableau = new int[10];
            for (int i = 0; i < montableau.Length; i++)
            {
                montableau[i] = i + 1;
            }
            string chaine = "";
            for (int i = 0; i < montableau.Length; i++)
            {
               chaine+= montableau[i] + ",";
            }
            
            chaine = chaine.Substring(0, chaine.Length - 1);
            Console.Write(chaine);

            Console.WriteLine(" Introduisez la valeur de A : ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine(" Introduisez la valeur de B : ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine(" Nous allons rechercher la valeur de x solution de l'équation ax+b=0, appuyez sur une touche");
            x= resolution_equation(a, b);
            Console.WriteLine(" La valeur de x est :{0:##,##0.00}", x);
            Console.ReadKey();

        }
        static public double resolution_equation(double _a, double _b)     
        {
            double x;
            
            if (_a == 0 && _b == 0)
            {
                Console.WriteLine(" L’ équation est indéterminée ! ");
                x = double.NaN ;
            }
            else if (_a == 0 && _b != 0)
            {
                Console.WriteLine(" L’ équation est impossible ! ");
                x = double.NaN ;
            }
            else
            {
                x = -_b / _a;
            }
            return x;

        }
    }
}
