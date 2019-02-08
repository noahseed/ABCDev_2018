using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_v2_liste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Utilisateur> mesUsers = new List<Utilisateur>();

            mesUsers.Add(new Utilisateur("Delon", "Adelon", "leclandessiciliens", 3, "adelon@gmail.com", "emp"));
            mesUsers.Add(new Utilisateur("Belmondo", "Bbel", "leprofessionnel", 2, "belmondo@gmail.com", "cadre"));
            mesUsers.Add(new Utilisateur("demo", "user", "user", 3, "", "emp"));
            mesUsers.Add(new Utilisateur("Patrascu", "Gabriel", "sourisdent", 1, "patrascu@gmail.com", "cadre"));
            mesUsers.Add(new Utilisateur("Charvet", "Johnny", "taulier", 2, "cjohnny@gmail.com", "cadre"));

            Console.WriteLine("Veuillez saisir votre login svp : ");
            string login = Console.ReadLine();
            Console.WriteLine("Veuillez saisir le mot de passe svp : ");
            string motDePasse = Console.ReadLine();
            bool test = false;
            // List<Utilisateur>user1= mesUsers.FindAll(monUtil => monUtil.niveauAcces == 2);
            //List<Utilisateur> userCadre = mesUsers.FindAll(monCadre => monCadre.Qualification == "cadre");
            List<Utilisateur> userAdmin = mesUsers.FindAll(monAdmin => monAdmin.niveauAcces > 1 && monAdmin.Qualification == "emp" );
            string nomUt = "";
            int nivUt = 0;
            foreach (Utilisateur admin in mesUsers)
            {
                if (admin.Login == login && admin.MotDePasse == motDePasse)
                {
                    test = true;
                    nomUt = admin.Nom;
                    nivUt = admin.niveauAcces;
                    break;
                }

            }
            if (test == true)
            {
                Console.WriteLine("Bravo M(me) " + nomUt + " vous êtes authentifié(e) avec le niveau d'accès : "+nivUt +".");
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas autorisé à vous connecter");
                Console.WriteLine("Contactez votre administrateur système");
            }
            //foreach (Utilisateur item in userAdmin)
            //{
            //    Console.WriteLine(item.Nom + " qualification : " + item.Qualification+ " niveau d'accès " + item.niveauAcces);
            //}

            Console.ReadKey();
        }
    }
}

