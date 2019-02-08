using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recherche d'un nombre dans un tableau
            //Etant donné un tableau de nombres triés par ordre croissant, chercher si un nombre 
            //donné x figure parmi les éléments. Si oui, indiquer la valeur de l'indice correspondant.

            int N=0;
            int nombreSaisi;
            int compteur = 0;
            bool saisieN = false;
            bool recherche = false;

            do
            {
                Console.WriteLine("Combien de nombres souhaitez-vous saisir ?");
                try
                {
                    N = int.Parse(Console.ReadLine());
                    saisieN = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!saisieN);

            int[] tableau = new int[N];

          List<int> malist= new List<int>();
            

            for (int i = 0; i < N; i++)
            {
                try
                {   Console.Write("Veuillez saisir la valeur de la cellule n°{0} : ", i+1);
                    tableau[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            Array.Sort(tableau);

            Console.Write("Veuillez saisir un nombre : ");
            nombreSaisi = int.Parse(Console.ReadLine());

            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i].Equals(nombreSaisi))
                {
                    compteur++;
                    Console.WriteLine("L'occurence numéro {2} du nombre {0} a été trouvé dans le tableau, à la position {1}", nombreSaisi, i+1, compteur);
                    recherche = true;
                }
            }

            if (recherche == false)
            {
                Console.WriteLine("Le nombre n'a pas été trouvé dans le tableau.");
            }

            Console.ReadKey();
        }
    }
}
