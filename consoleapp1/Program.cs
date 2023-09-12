using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ket szam bekerese es osszeadasa
            int szamA, szamB; // deklaralas

            //bekérek egy szamot

            szamA = szamotKer("Adj meg egy szamot: ");


            //bekérek egy szamot
            szamB = szamotKer("Adj meg egy masik szamot: ");

            Console.Write("A két szám összege: " +(szamA + szamB).ToString());
            Console.ReadLine();
        }

        private static int szamotKer(string szöveg)
        {
            int bekertSzam;
            Console.Write("Kérek egy szamot: ");
            bekertSzam = int.Parse(Console.ReadLine());
            return bekertSzam;
        }
    }
}
