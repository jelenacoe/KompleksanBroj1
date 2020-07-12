using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KompleksanBroj
{
    class KompleksanBroj
    {
        private int realanDeo;
        private int imaginaranDeo;
        private static int brojInstanci = 0;

        public KompleksanBroj(int realan, int imaginaran)
        {
            this.realanDeo = realan;
            this.imaginaranDeo = imaginaran;
            ++BrojInstanci;
        }


        public int RealanDeo
        {
            get { return realanDeo; }
        }


        public int ImaginaranDeo
        {
            get { return imaginaranDeo; }
        }


        public double ApsolutnaVrednost
        {
            get 
            {
                double kvadrat = (realanDeo * realanDeo) + (imaginaranDeo * imaginaranDeo);
                return Math.Sqrt(kvadrat);
            }
        }


        public override string ToString()
        {
            string im = ImaginaranDeo < 0 ? " - " + (-ImaginaranDeo) : " + " + ImaginaranDeo;
            return RealanDeo + im + "i";
        }


        public static int BrojInstanci
        {
            get { return brojInstanci; }

            protected set { brojInstanci = value; }
        }

        // preklapanje operatora +
        public static KompleksanBroj operator +(KompleksanBroj k1, KompleksanBroj k2)
        {
            return new KompleksanBroj(k1.RealanDeo + k2.RealanDeo, k1.ImaginaranDeo + k2.ImaginaranDeo);
        }

        // preklapanje operatora -
        public static KompleksanBroj operator -(KompleksanBroj k1, KompleksanBroj k2)
        {
            return new KompleksanBroj(k1.RealanDeo - k2.RealanDeo, k1.ImaginaranDeo - k2.ImaginaranDeo);
        }

        // metoda za sabiranje
        public static KompleksanBroj Saberi(KompleksanBroj k1, KompleksanBroj k2)
        {
            return new KompleksanBroj(k1.RealanDeo + k2.RealanDeo, k1.ImaginaranDeo + k2.ImaginaranDeo);
        }

        // metoda za oduzimanje
        public static KompleksanBroj Oduzmi(KompleksanBroj k1, KompleksanBroj k2)
        {
            return new KompleksanBroj(k1.RealanDeo - k2.RealanDeo, k1.ImaginaranDeo - k2.ImaginaranDeo);
        }

    }
}
