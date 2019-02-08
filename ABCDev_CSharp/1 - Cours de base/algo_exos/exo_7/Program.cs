using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int jour, mois, annee, bis, resultat4, valeurMois, reste7;
            string jourSem;
            bool TestJ, TestM, TestA;

            do
            {
                Console.Write("Entrez le numéro du jour : ");
                TestJ = int.TryParse(Console.ReadLine(), out jour);
                if (TestJ == false || jour < 1 || jour > 31)
                {
                    Console.WriteLine("Erreur ! Vous devez entrer un NUMERO de 1 à 31 !");
                }
            }
            while (jour < 1 || jour > 31);
            
            do
            {
                Console.Write("Entrez le numéro du mois : ");
                TestM = int.TryParse(Console.ReadLine(), out mois);
                if (TestM == false || mois < 1 || mois > 12)
                {
                    Console.WriteLine("Erreur ! Vous devez entrer un NUMERO de 1 à 12 !");
                }
            }
            while (mois < 1 || mois > 12);

            do
            {
                Console.Write("Entrez les deux derniers chiffres de l'année : ");
                TestA = int.TryParse(Console.ReadLine(), out annee);
                if (TestA == false || annee < 0 || annee > 99)
                {
                    Console.WriteLine("Erreur ! Vous devez entrer un NUMERO de 0 à 99 !");
                }
            }
            while (annee < 0 || annee > 99);

            bis = annee % 4;
            resultat4 = annee / 4;

            switch (mois)
            {
                case 1: // Janvier
                    if (bis == 0)
                    {
                        // Année bissextile
                        valeurMois = 0;
                    }
                    else
                    {
                        // Année NON bissextile
                        valeurMois = 1;
                    }
                    break;
                case 2: // Février
                    if (bis == 0)
                    {
                        // Année bissextile
                        valeurMois = 3;
                    }
                    else
                    {
                        // Année NON bissextile
                        valeurMois = 4;
                    }
                    break;
                case 3: // Mars
                    valeurMois = 4;
                    break;
                case 4: // Avril
                    valeurMois = 0;
                    break;
                case 5: // Mai
                    valeurMois = 2;
                    break;
                case 6: // Juin
                    valeurMois = 5;
                    break;
                case 7: // Juillet
                    valeurMois = 0;
                    break;
                case 8: // Août
                    valeurMois = 3;
                    break;
                case 9: // Septembre
                    valeurMois = 6;
                    break;
                case 10: // Octobre
                    valeurMois = 1;
                    break;
                case 11: // Novembre
                    valeurMois = 4;
                    break;
                case 12: // Décembre
                    valeurMois = 6;
                    break;
                default:
                    Console.WriteLine("Il y a une erreur quelque part !");
                    valeurMois = 999;
                    break;
            }

            reste7 = (annee + resultat4 + valeurMois + jour) % 7;

            switch (reste7)
            {
                case 0:
                    jourSem = "Samedi";
                    break;
                case 1:
                    jourSem = "Dimanche";
                    break;
                case 2:
                    jourSem = "Lundi";
                    break;
                case 3:
                    jourSem = "Mardi";
                    break;
                case 4:
                    jourSem = "Mercredi";
                    break;
                case 5:
                    jourSem = "Jeudi";
                    break;
                case 6:
                    jourSem = "Vendredi";
                    break;
                default:
                    jourSem = "Indéfini";
                    break;
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Le {0}/{1}/19{2:00} était un {3}", jour, mois, annee, jourSem);
            Console.ReadKey();
        }
    }
}
