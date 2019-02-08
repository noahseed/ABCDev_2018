using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            bool testSaisie = false;
            DateTime now = DateTime.Today;
            DateTime bday;
            DateTime bday18;
            int age;
            int res;
            
            do
            {
                Console.Write("Veuillez entrer votre date de naissance (jj/mm/aaaa): ");
                testSaisie = DateTime.TryParse(Console.ReadLine(), out bday);
            } while (!testSaisie);
            
            bday18 = new DateTime(bday.Year+18, bday.Month, bday.Day);
            res = DateTime.Compare(now, bday18);
            age = now.Year - bday.Year;

            if (bday > now.AddYears(-age))
            {
                age--;
            }

            if (res < 0)
            {
                Console.WriteLine("Vous n'êtes pas majeur, vous n'avez que {0} ans !", age);
            }
            else
            {
                Console.WriteLine("Vous êtes majeur, vous avez {0} ans !", age);
            }

            Console.ReadKey();
        }
    }
}
