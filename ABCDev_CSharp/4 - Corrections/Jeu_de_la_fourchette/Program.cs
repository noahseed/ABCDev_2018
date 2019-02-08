using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_la_fourchette
{
    class Program
    {
        static void Main(string[] args)
        {
            int choixOrdi;
            int choixJoueur;
            int borneSup = 100;
            int borneInf = 0;
            int compteur = 1;
            bool trouve = false;

            Random aleas = new Random();

            choixOrdi = aleas.Next(0, 101);

            Console.WriteLine(" le numero à rechercher est : " + choixOrdi);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(" On recherche un nombre entre 0 et 100");
            do
            {
                Console.WriteLine("Veuillez saisir un nombre entre {0:0.#} et {1:0.#}", borneInf, borneSup);
                choixJoueur = int.Parse(Console.ReadLine());

                if (choixJoueur == choixOrdi)
                {
                    trouve = true;
                }
                else if (choixJoueur < choixOrdi)
                {
                    borneInf = choixJoueur;
                }
                else
                {
                    borneSup = choixJoueur;
                }
                compteur++;
            }
            while (!trouve);
                 Console.WriteLine(" Felicitation vous avez trouvé le nombre : " + choixJoueur + " En " + compteur + "fois");
                 Console.ReadKey();
        }
    }
}
