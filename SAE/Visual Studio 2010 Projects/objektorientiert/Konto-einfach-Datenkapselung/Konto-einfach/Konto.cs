using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konto_einfach
{
    class Konto
    {
        private int kontoNummer;
        private string inhaber;
        private double kontoStand;

        public Konto(int nummer)
        {
            this.kontoNummer = nummer;
        }
        public void einzahlen(double betrag)
        {
            kontoStand = kontoStand + betrag;
        }

        public void abheben(double betrag)
        {
            kontoStand = kontoStand - betrag;
        }

        public double kontoStandAnzeigen()
        {
            return kontoStand;
        }

/*
 * set- und get-Methoden für die Datenkapselung * 
 */
        
        public void setKontoNummer(int nr)
        {
            kontoNummer = nr;
        }

        public int getKontoNummer()
        {
            return kontoNummer;
        }

        public void setInhaber(String name)
        {
            inhaber = name;
        }

        public String getInhaber()
        {
            return inhaber;
        }

        public void setKontoStand(double betrag)
        {
            kontoStand = betrag;
        }

        public double getKontoStand()
        {
            return kontoStand;
        }
    }
}
