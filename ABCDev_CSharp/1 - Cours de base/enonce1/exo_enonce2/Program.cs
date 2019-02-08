using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_enonce2
{
    class Program
    {
        static void Main(string[] args)
        {
            string temps;
            string etat;
            string repa;
            string biblio1;
            string biblio2;

            Console.WriteLine("Fait-il beau temps ? o/n");
            temps = Console.ReadLine();
            if (temps == "o")           //S'il fait beau temps
            {
                Console.WriteLine("Il fait beau temps");
                Console.WriteLine("La bicyclette est-elle en état de fonctionnement ? o/n");
                etat = Console.ReadLine();
                if (etat == "o")
                {
                    Console.WriteLine("Je vais faire une balade à bicyclette.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Je vais chez le garagiste.");
                    Console.WriteLine("Les réparations de la bicyclette sont-elles immédiates ? o/n");
                    repa = Console.ReadLine();
                    if (repa == "o")
                    {
                        Console.WriteLine("Je vais faire une balade à bicyclette.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("je vais à pied jusqu'à l'étang pour cueillir les joncs");
                        Console.ReadKey();
                    }
                }
            }
            else                        // S'il fait mauvais temps
            {
                Console.WriteLine("Il fait mauvais temps");
                Console.WriteLine("Est-ce que le livre Madame Bovary se trouve dans la bibliothèque du salon ? o/n");
                biblio1 = Console.ReadLine();
                if (biblio1 == "o")
                {
                    Console.WriteLine("je m'installe confortablement dans un fauteuil et je me plonge dans la lecture du livre Madame Bovary.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Est-ce que le livre Madame Bovary se trouve à la bibliothèque municipale ? o/n");
                    biblio2 = Console.ReadLine();
                    if (biblio2 == "o")
                    {
                        Console.WriteLine("J'emprunte le livre Madame Bovary.");
                        Console.WriteLine("Je rentre ensuite à la maison, je m'installe confortablement dans un fauteuil et je me plonge dans la lecture du livre Madame Bovary.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("J'emprunte un bouquin policier.");
                        Console.WriteLine("Je rentre ensuite à la maison, je m'installe confortablement dans un fauteuil et je me plonge dans la lecture.");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
