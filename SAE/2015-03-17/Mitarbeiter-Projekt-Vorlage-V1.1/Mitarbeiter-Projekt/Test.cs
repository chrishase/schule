using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mitarbeiter_Projekt
{
    class Test
    {
        static void Main(string[] args)
        {

            Projekt messe;

            Mitarbeiter schlau, schlapp, jung, boss;

            schlau = new Mitarbeiter("Schlau", "Stefan", 150);
            schlapp = new Mitarbeiter("Schlapp", "Schorsch", 100);
            jung = new Mitarbeiter("Jung", "Janine", 200);
            boss = new Mitarbeiter("Boss", "Benjamin", 250);

            


            messe = new Projekt("Messe", 250000, schlau);

            messe.zuordnenMitarbeiter(schlapp);
            messe.zuordnenMitarbeiter(jung);

            messe.verbraucheBudget(50*schlapp.getStundenSatz());
            messe.verbraucheBudget(80 * jung.getStundenSatz());

            messe.verbraucheBudget(100 * schlau.getStundenSatz());

            messe.verbraucheBudget(15000);



            //messe.verbraucheBudget(30000);


            Console.WriteLine("Projektname: " + messe.getProjektName());
            
            Mitarbeiter prLeiter = messe.getProjektLeiter();

            Console.WriteLine("Name des Projektleiters " + prLeiter.getName());
            Console.WriteLine("Restliches Budget " + messe.getBudget());

            Console.WriteLine("Anzahl der MItarbeiter: " + messe.anzahlMitarbeiter());

            for (int i=0)

            Console.ReadLine();

        }
    }
}
