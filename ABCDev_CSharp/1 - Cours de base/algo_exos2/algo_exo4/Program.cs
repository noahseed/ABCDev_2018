using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jeu de la fourchette

            Random rnd = new Random();
            int nbRandom = rnd.Next(0, 101);
            int nbSaisi;
            int nbMin = 0, nbMax = 100;
            int compteur = 1;
            bool test = false;
            
            //Console.WriteLine(nbRandom);
            do
            {
                Console.Write("Essayez de deviner le nombre que j'ai choisi (0 à 100) : ");
                test = int.TryParse(Console.ReadLine(), out nbSaisi);
            } while (test == false);
            
            while (nbSaisi != nbRandom)
            {
                while (nbSaisi < nbRandom)
                {
                    if (nbSaisi > nbMin)
                    {
                        nbMin = nbSaisi;
                        Console.WriteLine("Le nombre que j'ai choisi est compris entre {0} et {1}", nbMin, nbMax);
                    }
                    else
                    {
                        Console.WriteLine("Hé ! Je t'ai dit que le chiffre est compris entre {0} et {1} !!!!", nbMin, nbMax);
                    }
                    
                    compteur++;
                    Console.Write("Retente ta chance : ");
                    nbSaisi = int.Parse(Console.ReadLine());
                }
                while (nbSaisi > nbRandom)
                {
                    if (nbSaisi < nbMax)
                    {
                        nbMax = nbSaisi;
                        Console.WriteLine("Le nombre que j'ai choisi est compris entre {0} et {1}", nbMin, nbMax);
                    }
                    else
                    {
                        Console.WriteLine("Hé ho ! Je t'ai dit que le chiffre est compris entre {0} et {1} !!!!", nbMin, nbMax);
                    }

                    compteur++;
                    Console.Write("Retente ta chance : ");
                    nbSaisi = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("*********************************");
            if (compteur == 1)
	        {
		        Console.WriteLine("Wouah !!!! T'es trop fort ! T'as trouvé du premier coup ! xD");
	        }
            else
	        {
                Console.WriteLine("Bien joué ! Vous avez trouvé au bout de {0} essais ! ^^", compteur);
	        }
            Console.ReadKey();
        }
    }
}
