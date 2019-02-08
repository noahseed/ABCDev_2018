using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiloutou
{
    class Voiture
    {
        private string serialNb;
        private string brand;
        private string model;

        public string SerialNb
        {
            get { return serialNb; }
            set { serialNb = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Voiture()
        {

        }

        public Voiture(string serial)
        {
            string[,] maVoiture = new string[6, 3] {
            {"2098", "Peugeot", "307"},
            {"1987", "Renault", "Espace"},
            {"1203", "Lancia", "Dedra"},
            {"3049", "Bmw", "324d"},
            {"1500", "Peugeot", "406"},
            {"2500", "Ford", "Mondeo"}
            };

            for (int i = 0; i < maVoiture.GetLength(0); i++)
            {
                if (maVoiture[i, 0] == serial)
                {
                    SerialNb = maVoiture[i, 0];
                    Brand = maVoiture[i, 1];
                    Model = maVoiture[i, 2];
                }
            }
        }

        ~Voiture()
        {
            Console.WriteLine("Plus de voiture...");
        }

        public void AfficherVehicule()
        {
            Console.WriteLine(SerialNb + ", " + Brand + ", " + Model);
        }
    }
}
