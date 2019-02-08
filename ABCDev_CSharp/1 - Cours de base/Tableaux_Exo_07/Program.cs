using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux_Exo_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string prenom;
            int borneSup = 6;
            int borneInf = 0;
            int milieu;
            int compare;

            string[] tableau = new string[7] { "agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie" };

            Console.WriteLine("Veuillez choisir un prenom dans la liste.");
            prenom = Console.ReadLine();
            milieu = (borneInf + tableau.Length - 1) / 2;

            do
            {
                compare = prenom.CompareTo(tableau[milieu]);
                if (compare == -1)
                {
                    borneSup = milieu;
                    milieu = (borneInf + borneSup) / 2;
                }
                else if (compare == 1)
                {
                    borneInf = milieu;
                    milieu = ((borneInf + borneSup) / 2) + 1;
                }
            } while (compare != 0);

            Console.WriteLine("le nom a été trouvé à l'index {0}", milieu);
            Console.ReadKey();
        }
    }
}