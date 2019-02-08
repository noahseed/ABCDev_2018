using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu012
{
    class Program
    {
        static void Main(string[] args)
        { 
            int j, m;
            int compteurj=0, compteurm=0,compteurmanche=0;
            bool abandon = false;
            Random aleas = new Random();           
           

            do
            {
               Console.WriteLine("Choisissez un nombre de 0 à 2.");
               j=Convert.ToInt16(Console.ReadLine());
               if (j<0)
               {
                   abandon = true;
               }
               else
               {
                    
               m = aleas.Next(0,3);
               int dif =Math.Abs(j - m);
               if (dif==0)
               {
                   Console.WriteLine("Personne ne marque.");
               }
               else if (dif==1)
               {
                   if (j>m)
                   {
                       Console.WriteLine("La machine marque , essayez encore.");
                       compteurm++;
                   }
                   else
                   {
                       Console.WriteLine("Bravo , vous marquez un point!");
                       compteurj++;
                   }
               }
               else
               {
                   if (j>m)
                   {
                       Console.WriteLine("Bravo , vous marquez un point!");
                       compteurj++;
                   }
                   else
                   {
                       Console.WriteLine("La machine marque , essayez encore.");
                       compteurm++;
                   }
               }
               }

               compteurmanche++;
               Console.WriteLine("Manche numéro {1:0} vous avez : {0:0} point(s) et celui de la machine est de {2:0} point(s) ",compteurj,compteurmanche,compteurm);

               Console.WriteLine("---------------------------------------------------------");


            } while (abandon==false && compteurj<10 && compteurm<10);

            if (compteurm>=10)
            {
                Console.WriteLine("La machine gagne , vous avez perdu!");
            }
            else if (compteurj>=10)
            {
                Console.WriteLine("Vous avez Gagné !!!!");
            }
            else
            {
                Console.WriteLine("Bouhhhh Vous avez abandonné!");
            }
            Console.ReadKey();


        }
    }
}
