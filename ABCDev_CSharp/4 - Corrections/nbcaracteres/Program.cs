using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nbcaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Caractère ASCII 'a' =97
            //Caractère ASCII 'z'=122
            // Dénombrer les lettres de l'alphabet dans un tableau: Lire un texte d'au moins 120 caractères (à contrôler).
            // Compter et afficher le nombre d'occurrences (d'apparitions) de chacune des lettres de l'alphabet.
            string phrase;
            int nbCarac;
            int[] nblettre = new int[26];
            char laLettre;
            do
            {
                Console.WriteLine("Donnez moi un texte d'au moins 20 caractères.");
                phrase = Console.ReadLine();
                nbCarac = phrase.Length;

            } while (nbCarac < 20);

            phrase = phrase.ToLower();
            phrase = phrase.Replace('é', 'e');
            phrase = phrase.Replace('à', 'a');
            phrase = phrase.Replace('è', 'e');
            phrase = phrase.Replace('ê', 'e');

            for (int i = 0; i < nblettre.Length; i++)
            {
                nblettre[i] = 0;
            }
            for (int i = 0; i < nblettre.Length; i++)
            {
                for (int j = 0; j < phrase.Length; j++)
                {
                    if ((97 + i) == phrase[j])
                    {
                        nblettre[i]++;
                    }
                }
            }
            for (int i = 0; i < nblettre.Length; i++)
            {
                if (nblettre[i] > 0)
                {
                    laLettre = Convert.ToChar(97 + i);
                    Console.WriteLine("La lettre : {0} est présente {1} fois ", laLettre, nblettre[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
