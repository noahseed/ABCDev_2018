using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau5
{
    class Program
    {
        public static bool IsPalindrome(string text)
        {
            int min = 0;
            int max = text.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = text[min];
                char b = text[max];

                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        return true;
                    }
                    a = text[min];
                }

                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        return true;
                    }
                    b = text[max];
                }

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        static void Main(string[] args)
        {
            string text;
            Console.Write("Veuillez entrer une phrase : ");
            text = Console.ReadLine();

            if (text == "." || text == "")
            {
                Console.WriteLine("LA CHAINE EST VIDE.");
            }
            else
            {
                if (IsPalindrome(text))
                {
                    Console.WriteLine("{0} est un palindrome.", text);
                }
                else
                {
                    Console.WriteLine("{0} n'est pas un palindrome.", text);
                }
            }
            Console.ReadKey();
        }
    }
}
