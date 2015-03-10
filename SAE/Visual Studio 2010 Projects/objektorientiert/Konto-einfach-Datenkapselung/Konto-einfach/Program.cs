using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konto_einfach
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto kontoA;

            kontoA = new Konto(1007);

            //kontoA.setKontoNummer(123);
            kontoA.setInhaber("Emil Braun");
            kontoA.setKontoStand(1340.0);

            Console.WriteLine("Daten für das Konto kontoA");
            Console.WriteLine("Inhaber: " + kontoA.getInhaber());
            Console.WriteLine("Kontonummer: " + kontoA.getKontoNummer());
            Console.WriteLine("Kontostand: " + kontoA.getKontoStand());

            kontoA.einzahlen(200.0);
            Console.WriteLine("Kontostand nach der Einzahlung: " + kontoA.getKontoStand());

            kontoA.abheben(400);
            Console.WriteLine("Kontostand nach dem Abheben: " + kontoA.getKontoStand());

            Console.ReadLine();
        }
    }
}
