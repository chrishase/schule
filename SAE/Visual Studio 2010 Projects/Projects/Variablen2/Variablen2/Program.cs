using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variablen2
{
    class Program
    {
        static void Main(string[] args)
        {
            int izahl1 = 1;
            double dzahl2 = 2.5;
            double dsumme = izahl1 + dzahl2;
            double dmultipl = izahl1 * dzahl2;
            double ddivision = izahl1 / dzahl2;
            double dmodulo = izahl1 % dzahl2;

            Console.WriteLine("Zahl1:   " + izahl1);
            Console.WriteLine("Zahl2:   " + dzahl2);
            Console.WriteLine();
            Console.WriteLine("Summe:   " + dsumme);
            Console.WriteLine("Multipl. " + dmultipl);
            Console.WriteLine("Modulo:  " + dmodulo);

            Console.ReadLine();
        }
    }
}
