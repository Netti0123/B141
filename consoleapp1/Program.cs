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
            Console.WriteLine("Adj meg egy szamot: ");
            szamA = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy masik szamot: ");
            szamB = int.Parse(Console.ReadLine());

            Console.WriteLine("A két szám összege" +(szamA + szamB).ToString());
            Console.ReadLine();
        }
    }
}
