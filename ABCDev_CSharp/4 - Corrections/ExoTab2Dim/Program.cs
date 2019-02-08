using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoTab2Dim
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool formatage = false;


            do
            {
                Console.WriteLine("Veuillez choisir le nombre de formations");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    formatage = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Votre saisie est erronée, veuillez recommencer.\n" + ex.Message);
                }
            } while (!formatage);


            string[,] tabF = new string[n, 2];

            SaisieFormation(ref tabF);
            Console.Clear();

            Afficher(ref tabF);
            Trier(ref tabF);
            Console.WriteLine("Le tableau des formations trié par ordre croissant est :" + Environment.NewLine);
            Afficher(ref tabF);

            Console.ReadKey();

        }

        private static void Afficher(ref string[,] _tabF)
        {           
            for (int i = 0; i <_tabF.GetLength(0) ; i++)
            {
                Console.WriteLine("formation : " + _tabF[i, 0] + " Nombre de stagiaires : " + _tabF[i, 1] + "\n");
            }
        }

        private static void Trier(ref string[,] _tabF)
        {
            string tmp;
            bool test = false;
            do
            {
                test = false;
                for (int i = 0; i < _tabF.GetLength(0)-1; i++)
                {
                    if (Convert.ToInt32(_tabF[i,1])>Convert.ToInt32(_tabF[i+1,1]))
                    {
                        tmp = _tabF[i, 1];
                        _tabF[i, 1] = _tabF[i + 1, 1];
                        _tabF[i + 1, 1] = tmp;
                        tmp = _tabF[i, 0];
                        _tabF[i, 0] = _tabF[i + 1, 0];
                        _tabF[i + 1, 0] = tmp;
                        test = true;
                    }
                }
            } while (test);
        }

        private static void SaisieFormation(ref string[,] _tabF)
        {
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.Write("Veuillez saisir le nom de la formation numéro {0} : ", i + 1);
                _tabF[i, 0] = Console.ReadLine();
            }
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.Write("Veuillez saisir le nombre de stagiaires pour la formation : {0} -", _tabF[i, 0]);
                _tabF[i, 1] = Console.ReadLine();
            }
        }
    }
}

//Réaliser la mise en oeuvre du programme:(Le codage) à partir du pseudo-code suivant :

////* prog principal
// * 
//         * tableau tabF[n,2] de chaine  
//         *
//         * 
//         * // saisir les formations
//         * SaisieFormation(tabF)  // procédure de saisie
//         * // saisir le nombre de stagiaire par formation
//         * SaisieNbreStag(tabF)
//         * // trier les formations par ordre croissant de nombre de stagiaires
//         * Trier(tabF)
//         * // afficher les formations triées par nombre
// *         Afficher(tabF)
// * fin prog principal 

//Avec la création des 3 procedures ou fonctions dont vous avez besoins.
//décrire ces 3 procedures en pseudo-code avant de les implementer.

//Vous utiliserez un tableau à 2 dimensions.
//Vous utiliserez une procedure "try" "catch" pour la gestion des erreurs de saisie.
