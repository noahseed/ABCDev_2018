using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filiere_Informatique
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisieF, saisieN;
            int n;
            bool test= false;
            do
            {
                Console.WriteLine("Bonjour, combien de filière voulez vous saisir? : ");
                test = int.TryParse(Console.ReadLine(), out n );
            } while (!test);
            
            string[,] formation = new string[n, 2];

            for (int i = 0; i < formation.GetLength(0); i++)
            {
                Console.Write("Veuillez saisir le nom de la formation numéro: {0:0}-",i + 1);
                saisieF = Console.ReadLine();
                formation[i, 0] = saisieF;
                Console.Write("Veuillez saisir l'effectif de la formation" + saisieF + " : ");
                saisieN = Console.ReadLine();
                formation[i, 1] = saisieN;
            }
            Console.Clear();
            for (int i = 0; i < formation.GetLength(0); i++)
            {
                Console.WriteLine("Formation : " + formation[i, 0] + "; Nombre de stagiaires inscrits : " + formation[i, 1]);
            }
            



            Console.ReadKey();
        }
    }
}
