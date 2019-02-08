using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableaux3
{
    class Program
    {
        static void Main(string[] args)
        {
            string texte = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.";
            char[] lettres = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] compteur = new int[26];

            for (int i = 0; i < texte.Length; i++)
            {
                for (int j = 0; j < lettres.Length; j++)
                {
                    if (texte[i] == lettres[j])
                    {
                        compteur[j]++;
                    }
                }
            }

            for (int k = 0; k < lettres.Length; k++)
            {
                Console.WriteLine("La lettre " + lettres[k] + " apparait " + compteur[k] + " fois.");
            }

            Console.ReadKey();
        }
    }
}
