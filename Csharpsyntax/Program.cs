using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpsyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            const int mojeKonstanta = 5;

            int polomer = 6;
            //polomer += 1;
            Console.WriteLine("Puvodni polomer {0}", polomer);

            int novypolomer = polomer++;
            Console.WriteLine("Novy polomer {0}", novypolomer);
            int zaseNovyPolomer = ++polomer;
            Console.WriteLine("Novy polomer {0}", zaseNovyPolomer);

            var vari = 6;

            Kalkulator.secti("4", "5");
            int vysledek =5;
            if (vysledek == 4) vysledek++;
            else
                --vysledek;

            switch (vysledek)
            {
                case 2:
                    Console.WriteLine();
                        break;

            }



            

            if (((vysledek >= 10 && vysledek <= 20) || (vysledek >= 40 && vysledek <= 60)) && vysledek !=16 )
            {
                Console.WriteLine("Vysledek: {vysledek}");
            }

                Console.ReadLine();
            
        }
    }
}
