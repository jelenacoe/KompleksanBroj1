using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KompleksanBroj
{
    class Program
    {
        static void Main()
        {
            KompleksanBroj k1 = new KompleksanBroj(1, -2);
            KompleksanBroj k2 = new KompleksanBroj(3, -4);

            KompleksanBroj k3 = k1 - k2;
            KompleksanBroj k4 = k1 + k2;

            KompleksanBroj k5 = KompleksanBroj.Oduzmi(k1, k2);
            KompleksanBroj k6 = KompleksanBroj.Saberi(k1, k2);

            Console.WriteLine("k1 = {0}, apsolutna vrednost broja je {1}", k1, k1.ApsolutnaVrednost);
            Console.WriteLine("k2 = {0}, apsolutna vrednost broja je {1}", k2, k2.ApsolutnaVrednost);

            Console.WriteLine("Preklapanje operatora : k1 - k2 = {0}, apsolutna vrednost broja je {1}", k3, k3.ApsolutnaVrednost);
            Console.WriteLine("Pozivanje metode : k1 - k2 = {0}, apsolutna vrednost broja je {1}", k5, k3.ApsolutnaVrednost);

            Console.WriteLine("Preklapanje operatora : k1 + k2 = {0}, apsolutna vrednost broja je {1}", k4, k4.ApsolutnaVrednost);
            Console.WriteLine("Pozivanje metode :  k1 + k2 = {0}, apsolutna vrednost broja je {1}", k6, k4.ApsolutnaVrednost);

            Console.WriteLine("Ukupan broj kreiranih brojeva je {0}", KompleksanBroj.BrojInstanci);

            Console.ReadKey();
        }
    }
}
