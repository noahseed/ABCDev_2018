using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_minima
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;

            //saisie du nombre de case du tableau
            Console.WriteLine("indiquez le nombre de case : ");
            a = int.Parse(Console.ReadLine());

            //déclaration du tableau
            int[] monTableau = new int[a];

            //saisie du tableau
            for (int i = 0; i < monTableau.Length; i++)
            {
                Console.Write("Veuillez saisir un nombre pour la case n° " + i + " : ");
                monTableau[i] = int.Parse(Console.ReadLine());
            }
            string chainetab = "";
            foreach (int nb in monTableau)
            {
                chainetab += "," + nb;
                
            }
            chainetab = chainetab.Substring(1,chainetab.Length -1);

            Console.WriteLine(chainetab);

            Console.WriteLine("\n");
            //tri à minima

            for (int j = 0; j < monTableau.Length; j++)
            {
                //monTableau[posidepart] = minimum
                for (int k = j; k < monTableau.Length; k++)
                {
                    if (monTableau[k] < monTableau[j])
                    {
                        int temp = monTableau[j];
                        monTableau[j] = monTableau[k];
                        monTableau[k] = temp;

                    }
                }
            }
            Console.WriteLine("Voici le tableau trié par ordre croissant");
            chainetab = "";
            foreach (int nb in monTableau)
            {
                chainetab += "," + nb;

            }
            chainetab = chainetab.Substring(1, chainetab.Length - 1);

            Console.WriteLine(chainetab);
           
            Console.ReadKey();
        }
    }
}
//Tri d'un tableau
//Nous désignerons par a1, a2, ..., an les éléments d'un tableau à trier par ordre croissant.
//On commence par chercher l'indice du plus petit des éléments, soit j cet indice. 
//On permute alors les valeurs de a1 et aj .
//On cherche ensuite l'indice du plus petit des éléments a2, a3, ..., an et on permute avec a2, etc.
