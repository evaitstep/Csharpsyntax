using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpsyntax
{
    class Kalkulator
    {
        public static int secti(int a, int b)
        {
            int vysledek = a + b;
            return vysledek;
        }
        public static int secti(int a, int b, int c)
        {
            int vysledek = a + b + c;
            return vysledek;
        }
        public static int secti(string a, string b)
        {
            int vysledek = int.Parse(a) + int.Parse(b);
          
            return vysledek;
        }
    }
}
