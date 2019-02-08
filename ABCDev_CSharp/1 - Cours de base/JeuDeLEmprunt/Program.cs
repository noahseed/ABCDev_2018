using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLEmprunt
{
    class Program
    {
        static void Main(string[] args)
        {
            double tauxAnnuel = 0;
            double tauxMensuel = 0;
            int nbrAnneeRbmt = 0;
            double capitalEmprunte = 0;
            double Q;
            double a;
            int mois;
            //double annuite;
            //double mensualite;
            //double interetMois;
            //double amortissementMois;
            bool testSaisie1 = false;
            bool testSaisie2 = false;
            bool testSaisie3 = false;

            do
            {
                try
                {
                    Console.Write("Veuillez entrer le taux annuel : ");
                    tauxAnnuel = double.Parse(Console.ReadLine());
                    testSaisie1 = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + "\nVeuillez recommencer.\n");

                }
            } while (!testSaisie1);

            do
            {
                try
                {
                    Console.Write("Veuillez entrer le capital emprunté : ");
                    capitalEmprunte = double.Parse(Console.ReadLine());
                    testSaisie2 = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + "\nVeuillez recommencer.\n");

                }
            } while (!testSaisie2);

            do
            {
                try
                {
                    Console.Write("Veuillez entrer le nombre d'années de remboursement : ");
                    nbrAnneeRbmt = int.Parse(Console.ReadLine());
                    testSaisie3 = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + "\nVeuillez recommencer.\n");

                }
            } while (!testSaisie3);

            mois = nbrAnneeRbmt * 12;

            tauxMensuel = tauxAnnuel / 12;
            Q = 1 - Math.Pow( (1 + tauxMensuel), - mois);
            a = capitalEmprunte * tauxMensuel / Q;

            Console.WriteLine("L'annuité est de {0:#,#00.00} euros et la mensualité de {1:#,#00.00} euros.", a, Q);

            //partInteret(mois + 1) = capitalEmprunte(mois) * tauxMensuel;
            //partCapital(mois + 1) = Mensualité- partInteret(mois + 1)

            Console.ReadKey();
        }
    }
}
