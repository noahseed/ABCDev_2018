using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableaux7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prenoms = new string[7] { "agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie" };
            string saisie;
            int min = 1;
            int max = prenoms.Length - 1;
            int mid;
            int res;
            int rang = -1;

            Console.Write("Veuillez entrer un prénom : ");
            saisie = Console.ReadLine();

            do
            {
                mid = (min + max) / 2;
                res = prenoms[mid].CompareTo(saisie);
                
                if (res == 0)
                {
                    rang = mid;
                }
                else if (res == 1)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }

            } while ((saisie != prenoms[mid]) && (min <= max));
            Console.WriteLine("Le prénom a été trouvé à la position {0}", rang);
            Console.ReadLine();
        }
    }
}
