using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeux_pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            //L'algorithme lit un mot proposé par un premier joueur. 
            //Ce mot a une longueur minimum de 5 caractères (à contrôler).
            //L'algorithme affiche ensuite le mot où toutes les lettres sauf la première 
            //et la dernière sont remplacées par un tiret. Un deuxième joueur propose des lettres 
            //une à une. Chaque fois que la lettre se trouve dans le mot, l'algorithme remplace 
            //les tirets qui remplaçaient cette lettre et réaffiche le mot. Le second joueur
            //    a droit à un maximum de 6 essais infructueux (lettre ne se trouvant pas dans le mot).

            string mot, motTemp, lettre;
            string[] tabMot = new string[30];
            int nbEssais = 6;
            bool trouve = false;
            bool trouveLettre = false;

            do
            {
                Console.Write(" Veuillez saisir le mot à deviner d'au moins 5 lettres :");
                mot = Console.ReadLine();
            } while (mot.Length < 5);

            tabMot[0] = mot.Substring(0, 1);
            tabMot[mot.Length - 1] = Convert.ToString(mot[mot.Length - 1]);
            for (int i = 1; i < mot.Length - 1; i++)
            {
                tabMot[i] = "-";
            }

            Console.Clear();
            motTemp = "";
            foreach (string chaine in tabMot)
            {
                motTemp += chaine;
            }
            Console.WriteLine(motTemp);

            do
            {
                trouveLettre = false;
                Console.WriteLine(" Veuillez choisir une lettre non accentuée :");
                lettre = Console.ReadLine();

                for (int i = 1; i < mot.Length - 1; i++)
                {
                    if (mot[i].CompareTo(Convert.ToChar(lettre)) == 0)
                    {
                        tabMot[i] = lettre;
                        trouveLettre = true;
                    }
                }
                if (trouveLettre == false)
                {
                    nbEssais--;
                    Console.WriteLine("Il ne vous reste que {0} essais infructueux possibles ", nbEssais);
                }
                else
                {
                    motTemp = "";
                    foreach (string chaine in tabMot)
                    {
                        motTemp += chaine;
                    }
                    Console.WriteLine(motTemp);
                    if (motTemp == mot)
                    {
                        trouve = true;
                    }
                }
            } while (nbEssais > 0 && !trouve);

            if (nbEssais == 0)
            {
                Console.WriteLine(" Vous avez perdu ! Le mot était : " + mot);
            }
            else
            {
                Console.WriteLine(" Vous avez trouvé le mot : {1} avec seulement {0} erreurs ", 6 - nbEssais, motTemp);
            }
            Console.ReadKey();
        }
    }
}
