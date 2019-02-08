using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_exo6b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jeu du 0-1-2
            Random rnd = new Random();

            int nbHuman;
            int scoreComputer = 0;
            int scoreHuman = 0;
            bool test = false;

            do
            {
                do
                {
                    Console.Write("Choisissez un nombre de 0 à 2 : ");
                    test = int.TryParse(Console.ReadLine(), out nbHuman);
                } while (test == false || nbHuman > 2);

                int nbComputer = rnd.Next(0, 3);
                Console.WriteLine("L'ordinateur a choisi " + nbComputer);

                if (nbHuman == nbComputer)
                {
                    Console.WriteLine("Ex aequo, personne ne marque.");
                }
                else if (nbHuman + 1 == nbComputer || nbHuman == nbComputer + 2)
                {
                    Console.WriteLine("Le joueur humain gagne la manche.");
                    scoreHuman++;
                    Console.WriteLine("Joueur humain {0}, ordinateur {1}.", scoreHuman, scoreComputer);
                }
                else if (nbHuman < 0)
                {
                    scoreHuman = 20;
                }
                else
                {
                    Console.WriteLine("L'ordinateur gagne la manche.");
                    scoreComputer++;
                    Console.WriteLine("Humain {0} - Ordinateur {1}.", scoreHuman, scoreComputer);
                }
            } while (scoreComputer < 10 && scoreHuman < 10);

            Console.WriteLine("-------------------------------------");
            if (scoreHuman >= 10 && scoreHuman < 20)
            {
                Console.WriteLine("Le joueur humain remporte la partie !");
            }
            else if (scoreHuman == 20)
            {
                Console.WriteLine("Le joueur humain abandonne la partie !");
            }
            else
            {
                Console.WriteLine("L'ordinateur remporte la partie !");
            }
            Console.ReadKey();
        }
    }
}
