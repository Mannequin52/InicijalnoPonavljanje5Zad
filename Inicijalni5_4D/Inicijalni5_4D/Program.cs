using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni5_4D
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Pojednostavljena provjera ispravnosti URL adrese registrirane u 
          * hrvatskom internetskom prostoru bila bi:
        • mora počinjati s www
        • mora završavati s hr
        • mora sadržavati točku nakon www i prije hr
        Napišite program koji će zatražiti od korisnika da unese URL adresu, 
            te će provjeriti je li adresa napisana u ispravnom formatu.
        */

            Console.WriteLine("Unesi URL adresu:");
            string a = Console.ReadLine();
            int duljina = a.Length;
            int b = duljina - 3;
            
            string pocetak = a.Substring(0, 4);
            string kraj = a.Substring(3, b);

            if (pocetak == "www." && kraj == ".hr")
            {
                Console.WriteLine("URL je ispravan!");
            }
            
            Console.ReadKey();
        }
    }
}
