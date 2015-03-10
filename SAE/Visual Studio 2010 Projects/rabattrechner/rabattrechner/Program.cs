using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rabattrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            double preis, rabatt, summe;
            anfang:
            Console.WriteLine();
            Console.WriteLine("             Rabattrechner");
            Console.WriteLine("             =============");
            Console.WriteLine();
            Console.Write("Bitte geben Sie den Preis in Euro ein: ");
            preis = Convert.ToDouble(Console.ReadLine());
            if (preis >= 2000)
            {
                rabatt = preis * 0.05;
            }
            else
            {

                if (preis > 1000)
                {
                    rabatt = preis * 0.03;
                }
                else
                {
                    rabatt = 0;
                }
            }

            Console.WriteLine();
            Console.WriteLine("      Preis          : " + preis + " Euro");
            Console.WriteLine("      Rabatt         : " + rabatt + " Euro");
            Console.WriteLine();
            summe = preis - rabatt;
            Console.WriteLine("      Rechnungssumme :" + summe + " Euro");
            System.Threading.Thread.Sleep(2500);
            }
    }
}
