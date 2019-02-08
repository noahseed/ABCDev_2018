using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_mdp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration
            string[,] tabLogins = new string[3, 2];
            string login;
            string motDePasse;
            int i;
            bool motDePasseEstValide;

            // Définition des logins valides
            tabLogins[0, 0] = "user";
            tabLogins[0, 1] = "";
            tabLogins[1, 0] = "adelon";
            tabLogins[1, 1] = "leclandessiciliens";
            tabLogins[2, 0] = "jbelmondo";
            tabLogins[2, 1] = "leprofessionnel";

            // Demande à l'utilisateur d'entrer un login et mot de passe
            Console.Write("Entrez votre login svp : ");
            login = Console.ReadLine();
            Console.Write("Entrez votre mot de passe svp : ");
            motDePasse = Console.ReadLine();

            // Vérification du couple login et mot de passe
            motDePasseEstValide = false;
            for (i = 0; i < tabLogins.GetLength(0); i++)
            {
                if ((tabLogins[i, 0] == login) && (tabLogins[i, 1] == motDePasse))
                {
                    motDePasseEstValide = true;
                }
            }

            // Informer l'utilisateur sur l'état de la connexion
            if (motDePasseEstValide)
            {
                Console.WriteLine("La connexion est réussie.");
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas autorisé à vous connecter.");
                Console.WriteLine("Contactez votre administrateur système.");
            }
            Console.ReadKey();
        }
    }
}
