using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverHoulingBinaries1
{
    internal class CImaginario
    {
        private double entero;
        private double imaginario;

        public CImaginario(double entero, double imaginario)
        {
            this.entero = entero;
            this.imaginario = imaginario;
        }

        public double Entero { get => entero; set => entero = value; }
        public double Imaginario { get => imaginario; set => imaginario = value; }

        public override string ToString()
        {
            if (imaginario < 0)
            {
                return string.Format($"{entero}  {imaginario}i");
            }else  
            { 
                return string.Format($"{entero} + {imaginario}i");
            }
        }

        public static CImaginario operator +(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.Entero + i2.Entero;
            ri = i1.Imaginario + i2.Imaginario;

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }
        public static CImaginario operator -(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.Entero - i2.Entero;
            ri = i1.Imaginario - i2.Imaginario;

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }
        public static CImaginario operator *(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = (i1.Entero * i2.Entero) - (i2.Imaginario * i2.Imaginario); 
            ri = (i1.Entero * i2.Imaginario) - (i1.Imaginario * i2.Entero); 

            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }
        public static CImaginario operator /(CImaginario i1, CImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = ((i1.Entero * i2.Entero) + (i1.Imaginario * i2.Imaginario) )
                / ((i2.Entero * i2.Entero) +  (i2.imaginario * i2.imaginario));
            ri =  ((i1.Imaginario * i2.Entero) - (i1.Entero * i2.Imaginario)) 
                / ((i2.Entero * i2.Entero) +  (i2.imaginario * i2.imaginario));
 
            CImaginario temp = new CImaginario(re, ri);
            return temp;
        }

        public static CImaginario operator ++(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.Entero + 1, i1.Imaginario + 1);

            return temp;
        }

        public static CImaginario operator --(CImaginario i1)
        {
            CImaginario temp = new CImaginario(i1.Entero - 1, i1.Imaginario - 1);

            return temp;
        }

        public override bool Equals(object obj)
        {
            if (obj is CImaginario)
            {
                CImaginario temp= (CImaginario) obj;

                if (imaginario == temp.Imaginario && entero == temp.Entero)
                    return true;
            }
            return false;
        }

        public static bool operator ==(CImaginario i1, CImaginario i2)
        {
            return i1.Equals(i2);
        }

        public static bool operator !=(CImaginario i1, CImaginario i2)
        {
            return !(i1.Equals(i2));
        }
    }
}
