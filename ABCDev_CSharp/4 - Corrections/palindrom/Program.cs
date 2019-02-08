using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool palindrome = true;
            string phrase;
            do
            {
                Console.WriteLine("Donnez moi une phrase avec un point");
                phrase = Console.ReadLine();

            } while (phrase[phrase.Length - 1] != '.');

            phrase = phrase.ToUpper();
            phrase = phrase.Replace(" ","");
            phrase = phrase.Substring(0, phrase.Length - 1);
            char[] phraseInv = new char[phrase.Length];

            for (int i = 0; i < phraseInv.Length; i++)
            {
                phraseInv[i]= phrase[phrase.Length-1-i];
            }
            foreach (char lettre in phraseInv)
            {
                Console.Write(lettre);
            }
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i].CompareTo(phraseInv[i]) != 0)
                {
                    palindrome = false;
                }
            }
            if (!palindrome)
            {
                Console.WriteLine(" La phrase n'est pas un palindrome.");
            }
            else
            {
                Console.WriteLine(" La phrase est un palindrome.");
            }
            Console.ReadKey();
        }
    }
}
//Enoncé 5 : Rechercher la symétrie dans une chaîne de caractères
//Un palindrome est une chaîne de caractères que l'on peut lire identiquement de droite à gauche, et gauche à droite.
//Par exemple:
//AA.
//38783.
//LAVAL.
//LAVAL A ETE A LAVAL.
//ET LA MARINE VA VENIR A MALTE
//Soit une chaîne de caractères terminée par un point. Ecrivez l'algorithme d'un programme permettant d'affirmer si cette phrase est ou non un palindrome.
//Si la chaîne de caractères n'est composée que du caractère '.', le message 'LA CHAINE EST VIDE' sera affiché.

//Proposez un jeu d'essai prévoyant les 3 cas suivants:
//1)	la phrase est vide
//2)	la chaîne de caractères n'est pas un palindrome
//3)	la chaîne de caractères est un palindrome

