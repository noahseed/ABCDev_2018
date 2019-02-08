using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPoint
{
    class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        /// <summary>
        /// Constructeur
        /// </summary>
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }
        /// <summary>
        /// Déplace le point
        /// </summary>
        /// <param name="_x">Abcisse</param>
        /// <param name="_y">Ordonnée</param>
        public void Deplace(double _x, double _y)
        {
            this.x = x + _x;
            this.y = y + _y;
        }
        public override string ToString()
        {
            return "le point a pour abscisse : " + this.X + " et pour ordonnée : " + this.Y;
        }

        /// <summary>
        /// Affiche les coordonnées du point
        /// </summary>
        public void Affiche()
        {
            Console.WriteLine(ToString());
        }
        public Point permuteXY()
        {
            Point monNouveauPoint = new Point(y, x);
            return monNouveauPoint;
        }

        public Point symX()
        {
            Point monNouveauPoint = new Point(x, -y);
            return monNouveauPoint;
        }

        public Point symY()
        {
            Point monNouveauPoint = new Point(-x, y);
            return monNouveauPoint;
        }

        public Point symOrigine()
        {
            Point monNouveauPoint = new Point(-x, -y);
            return monNouveauPoint;
        }
    }
}
