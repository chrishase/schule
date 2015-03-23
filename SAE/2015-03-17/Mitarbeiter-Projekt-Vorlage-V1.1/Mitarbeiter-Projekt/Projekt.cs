using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mitarbeiter_Projekt
{
    class Projekt
    {
        private string projektName;
        private double budget;
        private Mitarbeiter projektLeiter;

        public Projekt(string name, double betrag, Mitarbeiter leiter)
        {
            projektName = name;
            budget = betrag;
            projektLeiter = leiter;
        }
        private List<Mitarbeiter> projektMitarbeiter = new List<Mitarbeiter>();

        public void zuordnenMitarbeiter(Mitarbeiter ma)
        {
            projektMitarbeiter.Add(ma);
        }
        public int anzahlMitarbeiter()
        {
            return projektMitarbeiter.Count();
        }
        public void entferneMitarbeiter(int index)
        {
            projektMitarbeiter.RemoveAt(index);
        }
        public Mitarbeiter getMitarbeiter(int index)
        {
            return projektMitarbeiter.ElementAt(index);
        }

        public double getBudget()
        {
            return budget;
        }

        public void verbraucheBudget(double betrag)
        {
            budget = budget - betrag;
        }

        public void erhoeheBudget(double betrag)
        {
            budget = budget + betrag;
        }

        public Mitarbeiter getProjektLeiter()
        {
            return projektLeiter;
        }

        public string getProjektName()
        {
            return projektName;
        }
    }
}
