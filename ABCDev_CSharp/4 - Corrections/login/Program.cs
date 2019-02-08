using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {

            string login;
            string motDePasse;
            bool motDePasseEstValide = false;
            int niveau = 0;
            string[,] tabLogin = new string[3, 3] { { "user", "", "2" }, { "Adelon", "leclandessiciliens", "1" }, { "jbelmondo", "leprofessionnel", "1" } };
            
            Console.WriteLine("Veuillez saisir votre login svp : ");
            login = Console.ReadLine();
            Console.WriteLine("Veuillez saisir le mot de passe svp : ");
            motDePasse = Console.ReadLine();

            for (int i = 0; i < tabLogin.GetLength(0) && !motDePasseEstValide; i++)
            {
                if ((tabLogin[i, 0] == login) && (tabLogin[i, 1] == motDePasse))
                {

                    niveau = int.Parse(tabLogin[i, 2]);

                    motDePasseEstValide = true;

                }
            }
            login = login.ToUpper();
            if (motDePasseEstValide && niveau != 0)
            {
                Console.WriteLine("La connexion est réussie !");
                Console.WriteLine("Bienvenue " + login + " sur votre interface de gestion, \nVous êtes l'administrateur de niveau : " + niveau + " !");
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas autorisé à vous connecter");
                Console.WriteLine("Contactez votre administrateur système");
            }
            Console.ReadKey();
        }
    }
}
