using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableaux4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tableau = new char[26] { 'a', 'z', 'x', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'c', 'y', 'b' };
            char tempo;
            char min;

            for (int i = 0; i < tableau.Length; i++)
            {
                min = tableau[i];

                for (int j = i; j < tableau.Length; j++)
                {
                    if (min > tableau[j])
                    {
                        tempo = tableau[i];
                        tableau[i] = tableau[j];
                        tableau[j] = tempo;
                        min = tableau[i];
                    }
                }
            }

            foreach (char lettre in tableau)
            {
                Console.WriteLine(lettre);
            }

            Console.ReadKey();
        }
    }
}
