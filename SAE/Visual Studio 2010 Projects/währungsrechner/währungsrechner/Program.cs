using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace währungsrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            anfang:
            double dollar, euro, franken;
            string wahl;
            double kursdollar, kursfranken;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                         W ä h r u n g s r e c h n e r");
            Console.WriteLine("");
            Console.Write("Bitte geben Sie einen Euro-Betrag ein: ");
            euro = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Wollen Sie US Dollar (USD) oder Schweizer Franken (SFR)? ");
            
            wahl = Console.ReadLine();

            if ((wahl == "USD")||(wahl=="usd"))
            {
                Console.Write("Bitte geben Sie den aktuellen Umrechnungskurs ein: ");
                kursdollar = Convert.ToDouble(Console.ReadLine());
                dollar = euro * kursdollar;
                Console.Write("Dies sind " + dollar + " USD");
                System.Threading.Thread.Sleep(1950);
                goto ende;
            }
            
            if ((wahl == "SFR")||(wahl == "sfr"))
            {
                Console.Write("Bitte geben Sie den aktuellen Umrechnungskurs ein: ");
                kursfranken = Convert.ToDouble(Console.ReadLine());
                franken = euro * kursfranken ;
                Console.WriteLine("Dies sind "+franken+" Schweizer Franken");
                System.Threading.Thread.Sleep(1950);
                goto ende;
            }

            if ((wahl != "USD")&&(wahl != "usd")) {
                if ((wahl != "SFR")&&(wahl != "sfr")) { 
                    Console.WriteLine("Das war keine bekannte Währung !!");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    goto anfang;
                }
            }

            ende:
            Console.WriteLine();
            Console.Write("Noch eine Rechnung ? ");
            bool nochmal = Convert.ToBoolean(Console.ReadLine());

        }
    }
}
