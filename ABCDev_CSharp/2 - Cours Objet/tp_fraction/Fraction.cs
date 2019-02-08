using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Fraction
{
    class Fraction
    {
        private int numerateur;
        private int denominateur;

        public int Numerateur
        {
            get { return numerateur; }
            //set { numerateur = value; }
        }
        public int Denominateur
        {
            get { return denominateur; }
            //set { denominateur = value; }
        }
        public Fraction()
        {
            this.numerateur = 0;
            this.denominateur = 1;
        }
        public Fraction(int _numerateur, int _denominateur = 1)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;
        }
        public void Oppose()
        {
            this.numerateur = -this.numerateur;
        }
        public void Inverse()
        {
            int temp = this.numerateur;
            this.numerateur = this.denominateur;
            this.denominateur = temp;
        }
        public bool Superieur(Fraction _Obj)
        {
            if (numerateur / denominateur > _Obj.numerateur / _Obj.denominateur)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
