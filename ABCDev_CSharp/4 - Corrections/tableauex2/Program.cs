using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableauex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string texte;
            int compteurc = 0;
            char cara;
            bool testpoint = false;

            do
            {
                Console.WriteLine("Veuillez saisir un texte terminé par un . SVP");
                texte = Console.ReadLine();

                if (texte[texte.Length - 1] == '.')
                {
                    testpoint = true;
                }
            } while (!testpoint);

           
            if (texte==".")
            {
                Console.WriteLine("LA CHAINE EST VIDE");
            }
            else
	          {

	
            Console.WriteLine("Veuillez saisir une lettre . SVP");
            cara = char.Parse(Console.ReadLine());
            // cara = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < texte.Length; i++)
            {
                if (texte[i]==cara)
                {
                    compteurc++;
                    Console.WriteLine("Le caractère se trouve à la position {0} " , i+1);
                }
                
            }
           

            if (compteurc>0)
            {
               Console.WriteLine("la lettre est présente: "+compteurc+" fois"); 
            }
            else
            {
                Console.WriteLine("la lettre n'est pas présente"); 
            }
            
            }
     Console.ReadKey(); 
        }
    }
}
