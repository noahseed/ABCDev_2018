using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_enonce3
{
    class Program
    {
        static void Main(string[] args)
        {
            string scol;
            string annee;
            string type;
            string poche;
            string lu;
            string roman;
            string etat;
            Console.WriteLine("Sagit-il d'un livre scolaire ? o/n");
            scol = Console.ReadLine();
            if (scol == "o")
            {
                Console.WriteLine("Quel est le genre ? (1)littérature, (2)philosophie, (3)langues étrangères, (4)autres.");
                type = Console.ReadLine();
                if (type == "1" || type == "2" || type == "3")
                {
                    Console.WriteLine("Ce livre est-il paru après 1995? o/n");
                    annee = Console.ReadLine();
                    if (annee == "o")   // Livres scolaires postérieurs à 1995
                    {
                        Console.WriteLine("Ce livre est à ranger dans la bibliothèque.");
                        Console.ReadKey();
                    }
                    else        // Livres scolaires antérieurs à 1995
                    {
                        Console.WriteLine("Ce livre est à ranger dans le carton étiqueté BOITESCOL.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Ce livre est à ranger dans le carton étiqueté BOITESCOL.");
                    Console.ReadKey();
                }
            }
            else        // Livres NON scolaires
            {
                Console.WriteLine("Ce livre est-il un livre de poche ? o/n");
                poche = Console.ReadLine();
                if (poche == "o")
                {
                    Console.WriteLine("Avez-vous déjà lu ce livre ? o/n");
                    lu = Console.ReadLine();
                    if (lu == "o")
                    {
                        Console.WriteLine("Est-ce que ce livre est un roman ? o/n");
                        roman = Console.ReadLine();
                        if (roman == "o")
                        {
                            Console.WriteLine("Ce livre est à ranger dans le carton étiqueté BOITEROM.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ce livre est à ranger dans le carton étiqueté BOITEDIV.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ce livre est à ranger dans la bibliothèque.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Est-ce que ce livre est déterioré ? o/n");
                    etat = Console.ReadLine();
                    if (etat == "o")
                    {
                        Console.WriteLine("Est-ce que ce livre est un roman ? o/n");
                        roman = Console.ReadLine();
                        if (roman == "o")
                        {
                            Console.WriteLine("Ce livre est à ranger dans le carton étiqueté BOITEROM.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ce livre est à ranger dans le carton étiqueté BOITEDIV.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ce livre est à ranger dans la bibliothèque.");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
