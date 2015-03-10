using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalverwaltung
{
    public class Mitarbeiter
    {
        private int personalnummer;
        private double stundenlohn;
        private double arbeitszeit;
        private string name;
        private double bruttolohn;

        /*
         * 
         * Methoden laut Aufgabenstellung
         * 
         */

        public void erfassenArbeitszeit(double arbeitszeit)
        {
           this.arbeitszeit = arbeitszeit;
        }

        public double ermittleBrutto()
        {
            this.bruttolohn = stundenlohn * arbeitszeit;
            return this.bruttolohn;
        }

        public void aendereStundenlohn(double prozentsatz)
        {
            this.stundenlohn = this.stundenlohn * (prozentsatz/100) + this.stundenlohn;
        } 


        /*
         * setter- und getter- Methoden
         * Hinweise: 
         * - setArbeitszeit(...) nicht implementiert --> erfasseArbeitszeit(...) hat selbe Funktion 
         * - setBruttolohn(...) und getBruttolohn() nicht implementiert --> Bruttolohn soll nicht gesetzt werden können, sondern muss errechnet und zurückgegeben werden --> ermittleBrutto() 
         * 
         */

        public void setStundenlohn(double stundenlohn)
        {
            this.stundenlohn = stundenlohn;
        }

        public double getStundenlohn()
        {
            return this.stundenlohn;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        
        public string getName()
        {
            return this.name;
        }

        public double getArbeitszeit()
        {
            return this.arbeitszeit;
        }

        public void setPersonalnummer(int persNr)
        {
            this.personalnummer = persNr;
        }

        public int getPersonalnummer()
        {
            return this.personalnummer;
        }
    }
}
