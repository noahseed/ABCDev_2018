using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Fraction
{
    class Ecran
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_Obj"></param>
        public static void Affiche(Fraction _Obj)
        {
            if (_Obj.Denominateur != 1)
            {
                Console.WriteLine(_Obj.Numerateur + "/" + _Obj.Denominateur);
            }
            else
            {
                Console.WriteLine(_Obj.Numerateur);
            }
        }
    }
}
