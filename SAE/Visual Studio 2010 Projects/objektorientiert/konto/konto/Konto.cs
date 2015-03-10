using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konto_einfach
{
    class Konto
    {
        public int kontoNummer;
        public String inhaber;
        public double kontoStand;

        public void einzahlen(double betrag)
        {
            this.kontoStand = this.kontoStand + betrag;
        }

        public void abheben(double betrag)
        {
            this.kontoStand = this.kontoStand - betrag;
        }

        public double kontoStandAbfragen()
        {
            return this.kontoStand;
        }
    }
}