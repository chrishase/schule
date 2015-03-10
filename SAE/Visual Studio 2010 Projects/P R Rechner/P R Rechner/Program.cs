using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P_R_Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            double spannung, strom, widerstand, leistung;
            string berechnung;
            anfang:
            Console.WriteLine("\t\t P/R-Rechner");
            Console.WriteLine();
            Console.WriteLine("P für Leistung\tR für Widerstand\tQ für Quit");
            Console.WriteLine();
            Console.WriteLine("Welche Berechnung möchten Sie ?");
            
            berechnung = Console.ReadLine();

            Console.Write("Bitte Spannung in Volt eingeben: ");
            spannung = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte Strom in Ampére eingeben: ");
            strom = Convert.ToDouble(Console.ReadLine());

            switch (berechnung)
            {
                case "P":
                    leistung = spannung * strom;
                    Console.WriteLine();
                    Console.WriteLine("Die Leistung beträgt " + leistung + " Watt");
                    System.Threading.Thread.Sleep(2500);
                    break;
                case "p":
                    leistung = spannung * strom;
                    Console.WriteLine();
                    Console.WriteLine("Die Leistung beträgt " + leistung + " Watt");
                    System.Threading.Thread.Sleep(2500);
                    break;

                case "R":
                    widerstand = spannung / strom;
                    Console.WriteLine("Der Widerstand beträgt " + widerstand + " Ohm");
                    System.Threading.Thread.Sleep(2500);
                    break;
                case "r":
                    widerstand = spannung / strom;
                    Console.WriteLine("Der Widerstand beträgt " + widerstand + " Ohm");
                    System.Threading.Thread.Sleep(2500);
                    break;

                case "q":
                    Console.WriteLine("Ende!");
                    System.Threading.Thread.Sleep(1000);
                    break;

                default:
                    Console.WriteLine("Keine passende Berechnung gefunden !");
                    System.Threading.Thread.Sleep(1750);
                    Console.Clear();
                    goto anfang;
                    break;
            }

        }
    }
}
