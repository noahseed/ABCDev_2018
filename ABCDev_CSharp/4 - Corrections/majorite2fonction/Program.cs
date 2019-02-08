using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorite2fonction
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Ecrivez votre date de naissance en (jj/mm/AAAA):");
            string majorite = etreMajeur(Console.ReadLine());
           
            Console.WriteLine(majorite);
            Console.ReadKey();
        }
         static public string etreMajeur(string _datenaissance)
        {
            bool verification = false;
            string retour="";
            DateTime MaDateNaissance = DateTime.Today;     
    
            try
            {
                 MaDateNaissance = DateTime.Parse(_datenaissance);
                verification = true;
            }
            catch (FormatException )
            {
                retour="Erreur de saisie, veuillez réitérer votre opération";
                
            }
            
            if (verification==true)
            {
                DateTime dstart = DateTime.Today;
                DateTime dmajeur = dstart.AddYears(-18);
                DateTime dmajeur2 = new DateTime(dstart.Year - 18, dstart.Month, dstart.Day);

                if (DateTime.Compare(MaDateNaissance, dmajeur) == -1 || DateTime.Compare(MaDateNaissance, dmajeur) == 0)
                {
                   retour="Vous êtes majeur";
                }
                else
                {
                   retour="Vous êtes mineur";
                }
                
            }
            return retour;
         

        }



    }
}
