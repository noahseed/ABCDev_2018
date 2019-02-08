using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableaux6
{
    class Program
    {
        static void Main(string[] args)
        {
            string motATrouver;
            char lettre;
            int essai = 0;
            int compteur = 2;
            bool testSaisie = false;
            bool gagner = false;

            Console.WriteLine("\"JEU DU PENDU\"\n");
            Console.Write("Veuillez entrer un mot à l'abri du regard de l'autre joueur : ");
            motATrouver = Console.ReadLine();
            motATrouver = motATrouver.ToLower();
            Console.Clear();

            int tailleMot = motATrouver.Length;

            char[] lettretrouve = new char[tailleMot];

            for (int i = 0; i < tailleMot; i++)
            {
                lettretrouve[i] = '-';
            }

            lettretrouve[0] = motATrouver[0];
            lettretrouve[tailleMot - 1] = motATrouver[tailleMot - 1];

            Console.WriteLine(lettretrouve);

            do
            {
                Console.Write("Proposer une et une seule lettre (essai {0}/6) : ", essai);
                testSaisie = char.TryParse(Console.ReadLine(), out lettre);
            } while (!testSaisie);

            while (essai < 6 && gagner == false)
            {
                for (int i = 0; i < tailleMot; i++)
                {
                    if (motATrouver[i] == lettre)
                    {
                        lettretrouve[i] = lettre;
                        compteur++;

                        if (compteur >= tailleMot)
                        {
                            gagner = true;
                            Console.WriteLine("Bravo ! Vous avez trouvé le mot !");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                }
                essai++;
                Console.WriteLine(lettretrouve);

                do
                {
                    Console.Write("Proposer une et une seule lettre (essai {0}/6) : ", essai);
                    testSaisie = char.TryParse(Console.ReadLine(), out lettre);
                } while (!testSaisie);
            }
            Console.ReadKey();
        }
    }
}
