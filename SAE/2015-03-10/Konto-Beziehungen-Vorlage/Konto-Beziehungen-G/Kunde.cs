using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konto_Beziehungen
{
    public class Kunde
    {
        private string strasse,plz,ort,name;

        public Kunde(string name, string str, string plz, string ort)
        {
            this.strasse = str;
            this.plz = plz;
            this.ort = ort;
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
        public string getstrasse() 
        {
            return this.strasse;
        }
        public string getplz()
        {
            return this.plz;
        }
        public string getort()
        {
            return this.ort;
        }
        
    }
}
