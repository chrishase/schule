using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variablen
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl1;
            double zahl2;
            double summe;
            string eingabe;

            Console.Write("Bitte ersten Wert eingeben:");
            eingabe = Console.ReadLine();
            zahl1=Convert.ToDouble(eingabe);

            Console.Write("Bitte zweiten Wert eingeben:");
            eingabe=Console.ReadLine();
            zahl2=Convert.ToDouble(eingabe);

            summe= zahl1 + zahl2;
            Console.Write("Das Ergebnis ist: ");
            Console.WriteLine(summe);
            Console.ReadLine();
        }
    }
}
