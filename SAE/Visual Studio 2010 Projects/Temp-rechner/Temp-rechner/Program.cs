using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Temp_rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;
            string eingabe;

            Console.WriteLine("Temperaturumrechnung");
            Console.WriteLine();
            Console.Write("Bitte aktuelle Temp. in Celsius eingeben: ");
            eingabe = Console.ReadLine();
            celsius = Convert.ToDouble(eingabe);

            fahrenheit = (celsius * 1.8) + 32;

            Console.Write("Dies sind "+ fahrenheit);
            Console.WriteLine(" Fahrenheit");
            Console.ReadLine();
        }
    }
}
