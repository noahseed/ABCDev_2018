using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_exo3a
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, limite, compteur;
            bool test = false;
            limite = 0;
            compteur = 0;
            do
            {
                limite++;
                do
                {
                    Console.Write("Veuillez entrer l'âge de la personne " + limite + " : ");
                    test = int.TryParse(Console.ReadLine(), out age);
                } while (test == false);

                if (age < 20)
                {
                    compteur++;
                }
            } while (limite < 20);
            Console.WriteLine("-----------------------------");
            if (compteur == 20)
            {
                Console.WriteLine("Toutes les personnes ont moins de vingt ans.");
            }
            else if (compteur == 0)
            {
                Console.WriteLine("Toutes les personnes ont plus de 20 ans.");
            }
            else
            {
                int reste = 20 - compteur;
                Console.WriteLine("Il y a {0} personnes agées de moins de 20 ans\net {1} personnes agées de plus de 20 ans.", compteur, reste);
            }
            Console.ReadKey();
        }
    }
}
