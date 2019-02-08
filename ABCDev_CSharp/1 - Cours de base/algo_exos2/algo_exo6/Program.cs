using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_exo6
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
                } while (test == false || nbHuman < 0 || nbHuman > 2);

                int nbComputer = rnd.Next(0, 3);
                Console.WriteLine("L'ordinateur a choisi " + nbComputer);

                if (nbHuman < nbComputer)
                {
                    if (nbHuman - nbComputer == 0)
                    {
                        Console.WriteLine("Ex aequo, personne ne marque.");
                    }
                    else if (nbComputer - nbHuman == 1)
                    {
                        if (nbHuman < nbComputer)
                        {
                            Console.WriteLine("Le joueur humain gagne la manche.");
                            scoreHuman++;
                            Console.WriteLine("Joueur humain {0}, ordinateur {1}.", scoreHuman, scoreComputer);
                        }
                        else
                        {
                            Console.WriteLine("L'ordinateur gagne la manche.");
                            scoreComputer++;
                            Console.WriteLine("Joueur humain {0}, ordinateur {1}.", scoreHuman, scoreComputer);
                        }
                    }
                    else
                    {
                        if (nbHuman < nbComputer)
                        {
                            Console.WriteLine("L'ordinateur gagne la manche.");
                            scoreComputer++;
                            Console.WriteLine("Humain {0} - Ordinateur {1}.", scoreHuman, scoreComputer);
                        }
                        else
                        {
                            Console.WriteLine("Le joueur humain gagne la manche.");
                            scoreHuman++;
                            Console.WriteLine("Humain {0} - Ordinateur {1}.", scoreHuman, scoreComputer);
                        }
                    }
                }
                else
                {
                    if (nbComputer - nbHuman == 0)
                    {
                        Console.WriteLine("Ex aequo, personne ne marque.");
                    }
                    else if (nbComputer - nbHuman == 1)
                    {
                        if (nbComputer < nbHuman)
                        {
                            Console.WriteLine("Le joueur humain gagne la manche.");
                            scoreHuman++;
                            Console.WriteLine("Joueur humain {0}, ordinateur {1}.", scoreHuman, scoreComputer);
                        }
                        else
                        {
                            Console.WriteLine("L'ordinateur gagne la manche.");
                            scoreComputer++;
                            Console.WriteLine("Joueur humain {0}, ordinateur {1}.", scoreHuman, scoreComputer);
                        }
                    }
                    else
                    {
                        if (nbComputer > nbHuman)
                        {
                            Console.WriteLine("L'ordinateur gagne la manche.");
                            scoreComputer++;
                            Console.WriteLine("Humain {0} - Ordinateur {1}.", scoreHuman, scoreComputer);
                        }
                        else
                        {
                            Console.WriteLine("Le joueur humain gagne la manche.");
                            scoreHuman++;
                            Console.WriteLine("Humain {0} - Ordinateur {1}.", scoreHuman, scoreComputer);
                        }
                    }
                }
                
            } while (scoreComputer < 10 && scoreHuman < 10);

            Console.WriteLine("-------------------------------------");
            if (scoreHuman >= 10)
            {
                Console.Write("Le joueur humain remporte la partie !");
            }
            else
            {
                Console.Write("L'ordinateur remporte la partie !");
            }
            Console.ReadKey();
        }
    }
}
