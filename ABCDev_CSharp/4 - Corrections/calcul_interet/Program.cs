using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcul_interet
{
    class Program
    {
        static void Main(string[] args)
        {
            double S;
            //S: somme initial placé
            int n;
            // Nombre d'année
            double i;
            // Taux d'intêret annuel en %
            int Reponse = 0;
            // réponse de l'utilisateur
            double valeuracquise;
            bool testnb;


            Console.WriteLine("Combien souhaitez-vous placer?");
            S = double.Parse(Console.ReadLine());
            Console.WriteLine("Souhaitez-vous placer votre argent sur un compte bloqué (intérêt composé):1 ou sur un compte rémunéré( intérêt simple):2 ?");
            testnb = int.TryParse(Console.ReadLine(),out Reponse);


            if (Reponse == 1 && testnb == true)
            {
                Console.Write("Combien d'année de placement?");
                n = int.Parse(Console.ReadLine());
                Console.Write("Quel est le taux de placement? %");
                i = double.Parse(Console.ReadLine());

                valeuracquise = S * Math.Pow((1 + (i / 100)), n);
                double gain = valeuracquise - S;

                valeuracquise = Math.Round(valeuracquise, 2);
                gain = Math.Round(gain, 2);

                Console.WriteLine(" La valeur acquise sera " + valeuracquise + "euros Vous aurez gagné à l'issue de " + n + " années:" + gain + " euros");
                Console.ReadKey();
            }
            else if (Reponse == 2 && testnb == true)
            {
                Console.Write("Combien d'année de placement?");
                n = int.Parse(Console.ReadLine());
                Console.Write("Quel est le taux de placement? %");
                i = double.Parse(Console.ReadLine());

                valeuracquise = S * (1 + n * (i / 100));
                double gain = valeuracquise - S;

                valeuracquise = Math.Round(valeuracquise, 2);
                gain = Math.Round(gain, 2);

                Console.WriteLine(" La valeur acquise sera " + valeuracquise + "euros Vous aurez gagné à l'issue de " + n + " années:" + gain + " euros");
                Console.ReadKey();
            }
            else if(Reponse != 1  && Reponse != 2 && testnb == true)
            {
                Console.WriteLine(" erreur le nombre saisi doit-être 1 ou 2! ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Veuillez taper un nombre svp!");
                Console.ReadKey();
            }


                
            
            


        }
    }
}
