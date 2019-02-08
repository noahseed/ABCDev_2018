using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiloutou
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = "2098";

            Voiture voitureSeb = new Voiture(serial);
            
            voitureSeb.AfficherVehicule();
            Console.ReadKey();
        }
    }
}
