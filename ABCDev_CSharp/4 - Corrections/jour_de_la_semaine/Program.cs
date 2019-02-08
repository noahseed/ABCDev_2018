using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jour_de_la_semaine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int jour;
            int mois;
            int resultat4;
            bool estNombre = false;
            int annee;
            int reste7;
            int valeurMois;
            string jourSemaine;

            Console.WriteLine(" Introduisez un jour entre 1 et 31");
            jour = int.Parse(Console.ReadLine());
            Console.WriteLine(" Introduisez un mois entre 1 et 12");
            mois = int.Parse(Console.ReadLine());
            
            do
            {
                
                Console.WriteLine(" Introduisez le deux derniers chiffres de l'année de entre 1900 et 2000 ");
                estNombre = int.TryParse(Console.ReadLine(), out annee);

            } while (annee < 0 || annee > 99 || estNombre ==false);

            resultat4 = annee / 4;
            switch (mois)
            {
                case 1:
                    if (annee %4 ==0)
                    {
                        valeurMois = 0;
                    }
                    else
                    {
                        valeurMois = 1;
                    }
                    break;
                case 2:
                    if (annee % 4 == 0)
                    {
                        valeurMois = 3;
                    }
                    else
                    {
                        valeurMois = 4;
                    }
                    break;
                case 3:
                    valeurMois = 4;
                    break;
                case 4:
                    valeurMois = 0;
                    break;
                case 5:
                    valeurMois = 2;
                    break;
                case 6:
                    valeurMois = 5;
                    break;
                case 7:
                    valeurMois = 0;
                    break;
                case 8:
                    valeurMois = 3;
                    break;
                case 9:
                    valeurMois = 6;
                    break;
                case 10:
                    valeurMois = 1;
                    break;
                case 11:
                    valeurMois = 4;
                    break;
                case 12:
                    valeurMois = 6;
                    break;
                default:
                    valeurMois = -1;
                    break;

            }
            reste7 = (annee + resultat4 + valeurMois + jour) % 7;
            switch (reste7)
            {
                case 0:
                    jourSemaine = " samedi ";
                    break;
                case 1:
                    jourSemaine = " dimanche ";
                    break;
                case 2:
                    jourSemaine = " lundi ";
                    break;
                case 3:
                    jourSemaine = " mardi ";
                    break;
                case 4:
                    jourSemaine = " mercredi ";
                    break;
                case 5:
                    jourSemaine = " jeudi ";
                    break;
                case 6:
                    jourSemaine = " vendredi ";
                    break;
                default:
                    jourSemaine = " non défini ";
                    break;
            }

            Console.WriteLine(" Le jour est : " + jourSemaine);
 
            Console.ReadKey();
        }
    }
}
