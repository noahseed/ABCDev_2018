using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEU_DE_L_EMPRUNT
{
    class Program
    {
        static void Main(string[] args)
        {
            double kal, txAnn = 0;
            int annee;
            bool test = false;
            //   double partInteret, partCapital, restantDu, mensualite;

            Console.WriteLine("Quelle somme voulez-vous emprunter ?");
            kal = double.Parse(Console.ReadLine());


            Console.WriteLine("Sur quelle durée en année(s) voulez-vous emprunter ?");
            annee = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Veuillez saisir le taux en % que nous vous proposons.");
                try
                {
                    string taux = Console.ReadLine();

                    taux = taux.Replace('.', ',');

                    txAnn = double.Parse(taux);

                    test = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Veuillez recommencer la saisie.");
                }
            } while (!test);

            // uint mois = annee * 12;
            //  mensualite = CalculMensualite(kal, txAnn, annee);

            //Console.WriteLine("Vous devez rembourser : {0:#,##0.00} Euros pendant {1} mois", mensualite, mois);
            //Console.WriteLine(Environment.NewLine);

            Console.WriteLine("--------------Tableau d'amortissement-----------\n");
            Console.WriteLine("Num Mois\tPart Interet\tPart Capital\tCapital Restant du\tMensualité");
            Console.WriteLine(Environment.NewLine);

            double[,] ResultTabAmort = GenerateurTabAmortissement(kal, txAnn, annee);

            for (int i = 0; i < ResultTabAmort.GetLength(0); i++)
            {
                for (int j = 0; j < ResultTabAmort.GetLength(1); j++)
                {
                    if (j == 0 || j == (ResultTabAmort.GetLength(1) - 1))
                    {
                    Console.Write( "{0:#,###.}\t",ResultTabAmort[i, j]);

                    }
                    else
                    {
                        Console.Write("{0:0,000.00}\t", ResultTabAmort[i, j]);

                    }
                }
                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadKey();

            //double txm = txAnn / (12 * 100);
            //restantDu = kal;
            //double coûtCredit = 0;

            //for (int i = 1; i <= mois; i++)
            //{

            //    partInteret = restantDu * txm;
            //    coûtCredit += partInteret;
            //    partCapital = mensualite - partInteret;
            //    //  restantDu = restantDu - partCapital;
            //    restantDu -= partCapital;
            //    Console.WriteLine(" {0}  \t\t| {1:#,###.00}   \t| {2:#,###.00}  \t| {3:#,###.00}  \t|  {4:#,###} ", i, partInteret, partCapital, restantDu, mensualite);
            //}
            //coûtCredit = Math.Round(coûtCredit, 2);
            //Console.WriteLine("Coût du crédit : " + coûtCredit + "Euros");

        }
        //public static double CalculMensualite(double _kal, double _txAnn, int _annee)
        //{
        //    double mensualite;
        //    int mois = _annee * 12;
        //    double txm = _txAnn / (12 * 100);

        //    double Q = (1 - (Math.Pow(1 + txm, -mois)));


        //    mensualite = _kal * txm / Q;

        //    return mensualite;
        //}
        public static double[,] GenerateurTabAmortissement(double _kal, double _txAnn, int _annee)
        {
            double mensualite;
            double mois = (double)_annee * 12;
            double txm = _txAnn / (12 * 100);
            int NbMois = Convert.ToInt32(mois);

            double Q = (1 - (Math.Pow(1 + txm, -mois)));
            mensualite = _kal * txm / Q;

            double[,] TabAmortissement = new double[NbMois, 5];
            double partInteret, partCapital, restantDu, coûtCredit = 0;
            restantDu = _kal;

            for (int i = 1; i <= NbMois; i++)
            {

                partInteret = restantDu * txm;
                coûtCredit += partInteret;
                partCapital = mensualite - partInteret;
                //  restantDu = restantDu - partCapital;
                restantDu -= partCapital;
                //              Console.WriteLine(" {0}  \t\t| {1:#,###.00}   \t| {2:#,###.00}  \t| {3:#,###.00}  \t|  {4:#,###} ", i, partInteret, partCapital, restantDu, mensualite);
                TabAmortissement[i - 1, 0] = i;
                TabAmortissement[i - 1, 1] = Math.Round(partInteret, 2);
                TabAmortissement[i - 1, 2] = Math.Round(partCapital, 2);
                TabAmortissement[i - 1, 3] = Math.Round(restantDu, 2);
                TabAmortissement[i - 1, 4] = Math.Round(mensualite, 2);

            }

            return TabAmortissement;

        }
    }
}



