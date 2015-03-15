using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Konto_Beziehungen
{
    public partial class BuchungsKing : Form
    {
        Konto meinKonto;
        Kunde meinKunde;

        public BuchungsKing()
        {
            InitializeComponent();
            
            meinKunde = new Kunde("Testuser", "Hauptstraße 1", "01234", "Testhausen");
            meinKonto = new Konto(4711);
            anzeige();
        }

        private void btnEinzahlen_Click(object sender, EventArgs e)
        {
            double eingabe = Convert.ToDouble(txbBetrag.Text);
            meinKonto.einzahlen(eingabe);
            //anzeige();
        }

        private void anzeige()
        {
            /*txbInhaber.Text = meinKonto.getInhaber();
            txbKontoNummer.Text = meinKonto.getKontoNummer().ToString();
            txbKontoStand.Text = meinKonto.getkontoStand().ToString();
             */
            //txbInhaber.Text=;
            string name = meinKunde.getName(), plz = meinKunde.getplz(), strasse = meinKunde.getstrasse(), ort = meinKunde.getort();

            txbInhaber.Text = name + Environment.NewLine + strasse + Environment.NewLine + plz + " " + ort;

        }

        private void btnAbheben_Click(object sender, EventArgs e)
        {
            double eingabe = Convert.ToDouble(txbBetrag.Text);
            meinKonto.abheben(eingabe);
            anzeige();
        }
    }
}
