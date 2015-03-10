using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter ma1 = new Mitarbeiter();

            ma1.setName("Leo Lustig");
            ma1.setPersonalnummer(11);
            ma1.setStundenlohn(17.50);
            ma1.erfassenArbeitszeit(149);

            Console.WriteLine("Mitarbeitername: " + ma1.getName());
            Console.WriteLine("Personalnummer: " + ma1.getPersonalnummer());
            Console.WriteLine("Stundenlohn: " + Math.Round(ma1.getStundenlohn(),2));
            Console.WriteLine("Arbeitszeit: " + ma1.getArbeitszeit());
            Console.WriteLine("");

            double prozentsatz = 2.5;
            ma1.aendereStundenlohn(prozentsatz);
            Console.WriteLine("Stundenlohn wurde um "+prozentsatz+"% erhöht");
            Console.WriteLine("Neuer Stundenlohn: " +Math.Round(ma1.getStundenlohn(),2));

            Console.ReadLine();
        }
    }
}
