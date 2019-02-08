using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau2dim
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbF = 0;
            string[,] tabF;
            
            bool formatage = false;

            do
            {
                Console.Write("Combien de formations souhaitez-vous entrer ? : ");
                try
                {
                    nbF = int.Parse(Console.ReadLine());
                    formatage = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Votre saisie est erronée, veuillez recommencer.\n" + ex.Message);
                }
            } while (!formatage);

            tabF = new string[nbF, 2];

            SaisieFormation(ref tabF);
            SaisieNbreStag(ref tabF);
            Trier(ref tabF);
            Afficher(ref tabF);

            Console.ReadKey();
        }
        private static void SaisieFormation(ref string[,] _tabF)
        {
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.Write("Entrez le nom de la formation n° " + (i + 1) + " : ");
                _tabF[i, 0] = Console.ReadLine();
            }
        }
        private static void SaisieNbreStag(ref string[,] _tabF)
        {
            for (int j = 0; j < _tabF.GetLength(0); j++)
            {
                Console.Write("Entrez le nombre d'élèves pour la formation n° " + (j + 1) + " : ");
                _tabF[j, 1] = Console.ReadLine();
            }
        }
        private static void Trier(ref string[,] _tabF)
        {
            bool actionTri;
            string t1;
            string t2;
            //TRI DU TABLEAU
            do
            {
                actionTri = false;

                for (int l = 0; l < _tabF.GetLength(0) - 1; l++)
                {
                    if (Convert.ToInt32(_tabF[l, 1]) > Convert.ToInt32(_tabF[l + 1, 1]))
                    {
                        t1 = _tabF[l + 1, 1];
                        t2 = _tabF[l + 1, 0];
                        _tabF[l + 1, 1] = _tabF[l, 1];
                        _tabF[l + 1, 0] = _tabF[l, 0];
                        _tabF[l, 1] = t1;
                        _tabF[l, 0] = t2;
                        actionTri = true;
                    }
                }
            } while (actionTri);
        }
        private static void Afficher(ref string[,] _tabF)
        {
            //AFFICHAGE DU TABLEAU
            for (int i = 0; i < _tabF.GetLength(0); i++)
            {
                Console.WriteLine(_tabF[i, 0] + "\t" + _tabF[i, 1]);
            }
        }
    }
}
