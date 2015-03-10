using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace heizölrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heizölrechner");
            Console.WriteLine();
            Console.Write("Name des Kunden: ");
            string kunde = Console.ReadLine();
            
            Console.Write("Bitte geben Sie den aktuellen Heizölpreis pro Liter an: ");
            string eingabe = Console.ReadLine();
            double literpreis = Convert.ToDouble(eingabe);
            eingabe = "";

            Console.Write("Tankstand vor der Lieferung: ");
            eingabe = Console.ReadLine();
            double tankvorher = Convert.ToDouble(eingabe);
            eingabe = "";

            Console.Write("Tankstand nach der Lieferung: ");
            eingabe = Console.ReadLine();
            double tanknachher = Convert.ToDouble(eingabe);
            eingabe = "";

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("--- Heizölrechnung für " + kunde);
            Console.WriteLine(" ---");

            double tankverbrauch = tankvorher - tanknachher;
            Console.Write("Gelieferte Menge: " + tankverbrauch);
            Console.WriteLine(" Liter");

            double nettopreis = tankverbrauch * literpreis;
            Console.Write("Nettowert: " + nettopreis);
            Console.WriteLine(" Euro");

            double steuer = nettopreis * 0.19;
            Console.Write("Mehrwertsteuer: " + steuer);
            Console.WriteLine(" Euro");

            double fertigpreis = nettopreis + steuer;
            Console.Write("Rechnungsbetrag incl. MwSt: " + fertigpreis);
            Console.WriteLine(" Euro");
            Console.WriteLine();
            Console.WriteLine("Zum Beenden eine Taste drücken....");
            Console.ReadLine();
        }
    }
}
