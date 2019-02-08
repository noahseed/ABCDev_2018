using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableaux1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int chiffreSaisi;
            bool testSaisie = false;
            bool IsFound = false;

            int[] nombres = new int[10] { 5, 49, 36, 24, 55, 16, 70, 18, 69, 10 };

            Array.Sort(nombres);

            do
            {
                Console.Write("Indiquez le chiffre à rechercher dans le tableau : ");
                testSaisie = int.TryParse(Console.ReadLine(), out chiffreSaisi);
            } while (testSaisie == false);

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] == chiffreSaisi)
                {
                    Console.WriteLine("Le chiffre {0} a été trouvé dans l'index {1}", chiffreSaisi, i);
                    IsFound = true;
                }
            }

            if (IsFound == false)
            {
                Console.WriteLine("Le chiffre {0} n'a pas été trouvé dans le tableau", chiffreSaisi);
            }

            Console.ReadKey();
        }
    }
}
