using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateTempo;
            Console.Write("Merci de renseigner votre date de naissance (jj/mm/aaaa): ");
            dateTempo = Console.ReadLine();
            string[] dateExplode = dateTempo.Split('/');
            Convert.ToInt32(dateExplode);
            Console.WriteLine(dateExplode);
            Console.ReadKey();
        }
    }
}
