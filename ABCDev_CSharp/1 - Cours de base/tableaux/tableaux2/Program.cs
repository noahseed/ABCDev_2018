using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableaux2
{
    class Program
    {
        static void Main(string[] args)
        {
            string texte;
            int compteur = 0;
            char lettre;
            int posi = 0;
            bool test = false;

            do
            {
                Console.Write("Veuillez entrer une phrase, en terminant par un point : ");
                texte = Console.ReadLine();
            } while (!texte.EndsWith("."));

            if (texte == ".")
            {
                Console.WriteLine("LA CHAINE EST VIDE.");
            }

            do
            {
                Console.Write("Merci de renseigner le caractère que vous souhaitez rechercher dans la chaine : ");
                test = char.TryParse(Console.ReadLine(), out lettre);
            } while (test == false);

            for (int i = 0; i < texte.Length; i++)
            {
                if (texte[i] == lettre)
                {
                    posi = texte.IndexOf(lettre, posi) + 1;

                    Console.WriteLine("Le caratère {0} a été trouvé à la position {1}", lettre, posi);
                    compteur++;
                }
            }

            if (compteur == 0)
            {
                Console.WriteLine("La phrase ne contient pas le caractère recherché.");
            }
            else
            {
                Console.WriteLine("Le caractère {0} apparait {1} fois", lettre, compteur);
            }
            Console.ReadLine();
        }
    }
}
