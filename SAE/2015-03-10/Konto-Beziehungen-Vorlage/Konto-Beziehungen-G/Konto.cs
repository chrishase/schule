using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konto_Beziehungen
{
    class Konto
    {
        private string inhaberl;
        public Kunde inhaber;
        //private string name1;
        private int kontoNummer;
        private double kontoStand;

        public Konto(int nr)
        {
            
            kontoNummer = nr;
            inhaberl = inhaber.getName();
            kontoStand = 0;
        }

        public string getInhaber()
        {
            return inhaberl;
        }

        public double getkontoStand()
        {
            return kontoStand;
        }

        public void einzahlen(double betrag)
        {
            kontoStand = kontoStand + betrag;
        }

        public void abheben(double betrag)
        {
            kontoStand = kontoStand - betrag;
        }

        public int getKontoNummer()
        {
            return kontoNummer;
        }

    }
}
