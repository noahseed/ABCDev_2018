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
            
            Console.Write("Veuillez entrer votre date de naissance (jj/mm/aaaa): ");
            string majorite = etreMajeur(Console.ReadLine());
            Console.WriteLine(majorite);
            Console.ReadKey();
        }
        static public string etreMajeur(string _datenaissance)
        {
            DateTime now = DateTime.Today;
            DateTime bday = DateTime.Today;
            DateTime bday18;
            int age;
            int res;
            string retour = "";
            
            try 
	        {	        
		        bday = DateTime.Parse(_datenaissance);               
	        }
	        catch (FormatException)
	        {
        		retour = "Erreur de saisie !";
	        }

            bday18 = new DateTime(bday.Year+18, bday.Month, bday.Day);
            res = DateTime.Compare(now, bday18);
            age = now.Year - bday.Year;
            if (bday > now.AddYears(-age))
            {
                age--;
            }

            if (res == -1)
            {
                retour = "Vous n'êtes pas majeur, vous n'avez que " + age + " ans !";
            }
            else
            {
                retour = "Vous êtes majeur, vous avez " + age + " ans !";
            }
            return retour;
        }
    }
}
