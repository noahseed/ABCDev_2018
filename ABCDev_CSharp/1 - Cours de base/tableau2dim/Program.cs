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
            int nbF;
            string[,] tabF;
            string t1;
            string t2;
            bool actionTri;

            Console.Write("Combien de formations souhaitez-vous entrer ? : ");
            nbF = int.Parse(Console.ReadLine());

            tabF = new string[nbF, 2];

            for (int i = 0; i < nbF; i++)
            {
                Console.Write("Entrez le nom de la formation n° " + (i+1) + " : ");
                tabF[i, 0] = Console.ReadLine();
            }
            for (int j = 0; j < nbF; j++)
            {
                Console.Write("Entrez le nombre d'élèves pour la formation n° " + (j+1) + " : ");
                tabF[j, 1] = Console.ReadLine();
            }

            //TRI DU TABLEAU
            do
            {
                actionTri = false;
                for (int l = 0; l < nbF - 1; l++)
                {
                    if (Convert.ToInt32(tabF[l, 1]) > Convert.ToInt32(tabF[l + 1, 1]))
                    {
                        t1 = tabF[l + 1, 1];
                        t2 = tabF[l + 1, 0];
                        tabF[l + 1, 1] = tabF[l, 1];
                        tabF[l + 1, 0] = tabF[l, 0];
                        tabF[l, 1] = t1;
                        tabF[l, 0] = t2;
                        actionTri = true;
                    }
                }
            } while (actionTri);

            //AFFICHAGE DU TABLEAU
            for (int i = 0; i < nbF; i++)
            {
                Console.WriteLine(tabF[i, 0] + "\t" + tabF[i, 1]);
            }
            
            Console.ReadKey();
        }
    }
}
