using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursObjet2
{
    class Bouteille
    {
        private bool bouteilleOuverte = false;

        public bool BouteilleOuverte
        {
            get { return bouteilleOuverte; }
            set { bouteilleOuverte = value; }
        }

        public void Ouvrir()
        {
            bouteilleOuverte = true;
        }
        public void Fermer()
        {
            bouteilleOuverte = false;
        }
        public void Vider()
        {

        }
        public void Remplir()
        {

        }
    }
}
