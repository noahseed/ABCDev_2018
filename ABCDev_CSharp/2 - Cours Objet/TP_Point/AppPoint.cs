using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPoint
{
    class AppPoint
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0;
            int operation = 0;
            bool testSaisie1 = false;
            bool testSaisie2 = false;
            bool testSaisie3 = false;
            bool quitter = false;

            do
            {
                try
                {
                    Console.Write("Veuillez entrer la valeur de x : ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Veuillez entrer la valeur de y : ");
                    y = double.Parse(Console.ReadLine());
                    testSaisie1 = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message + "\nVeuillez entrer un nombre !");
                    Console.ReadKey();
                }
            } while (!testSaisie1);

            Point monPoint = new Point(x, y);

            do
            {
                Console.WriteLine("Choisissez l'opération à effectuer :");
                Console.WriteLine("\n1) Afficher\t2) Déplacer\t3) SymX\t4) SymY\t5) SymOrigine\t6) PermuteXY\t7) Quitter");

                do
                {
                    try
                    {
                        operation = int.Parse(Console.ReadLine());
                        testSaisie2 = true;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message + "\nVeuillez entrer un nombre !");
                        Console.ReadKey();
                    }
                } while (!testSaisie2);

                switch (operation)
                {
                    case 1:
                        monPoint.ToString();
                        break;
                    case 2:
                        do
                        {
                            try
                            {
                                Console.Write("Veuillez entrer la nouvelle valeur de x : ");
                                x = double.Parse(Console.ReadLine());
                                Console.Write("Veuillez entrer la nouvelle valeur de y : ");
                                y = double.Parse(Console.ReadLine());
                                testSaisie3 = true;
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message + "\nVeuillez entrer un nombre !");
                                Console.ReadKey();
                            }
                        } while (!testSaisie3);
                        monPoint.Deplace(x, y);
                        break;

                    case 3:
                        monPoint.symX();
                        break;
                    case 4:
                        monPoint.symX();
                        break;
                    case 5:
                        monPoint.symOrigine();
                        break;
                    case 6:
                        monPoint.permuteXY();
                        break;
                    case 7:
                        Console.WriteLine("Au revoir, à bientôt !");
                        quitter = true;
                        break;
                    default:
                        Console.WriteLine("Veuillez entrer un nombre de 1 à 9 !");
                        break;
                }
            } while (!quitter);

            Console.ReadKey();
        }
    }
}
