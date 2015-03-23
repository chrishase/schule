using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mitarbeiter_Projekt
{
    class Mitarbeiter
    {
        private int personalNummer;
        private string name;
        private string vorname;
        private double stundenSatz;
        private static int naechsteNummer=1;

        public Mitarbeiter(string name, string vorname, double betrag)
        {
            personalNummer = Mitarbeiter.naechsteNummer;
            Mitarbeiter.naechsteNummer++;

            this.name = name;
            this.vorname = vorname;
            this.stundenSatz = betrag;
        }

        public string getName()
        {
            return name;
        }

        public string getVorname()
        {
            return vorname;
        }

        public int getPersonalNummer()
        {
            return personalNummer;
        }

        public double getStundenSatz()
        {
            return stundenSatz;
        }
    }
}
