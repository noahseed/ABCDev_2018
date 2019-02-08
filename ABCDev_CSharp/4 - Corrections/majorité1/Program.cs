using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorite1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dstart = DateTime.Today;
            DateTime dmajeur = dstart.AddYears(-18);
            DateTime dmajeur2 = new DateTime(dstart.Year - 18, dstart.Month, dstart.Day);
            DateTime datenaissance= DateTime.Today;
            bool verification = false;
            
            do
            {
                Console.Write("Ecrivez votre date de naissance en (jj/mm/AAAA):");
                try
                {
                    datenaissance = DateTime.Parse(Console.ReadLine());
                    verification = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message+"\nErreur de saisie, veuillez réitérer votre opération");                   
                }
                
            } while (!verification);

            if (DateTime.Compare(datenaissance,dmajeur)==-1|| DateTime.Compare(datenaissance,dmajeur)==0)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur");    
            }
            Console.ReadKey();

        }
    }
}
