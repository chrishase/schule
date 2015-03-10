using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace autopreis
{
    public partial class Form1 : Form
    {
        double listenpreis;
        double rabatt;

        public Form1()
        {
            InitializeComponent();
        }

        void einlesenDaten()
        {
            listenpreis = Convert.ToDouble(txbListenpreis.Text);
            rabatt = Convert.ToDouble(txbRabatt.Text);
        }

        private void btnPreis_Click(object sender, EventArgs e)
        {
            einlesenDaten();
            
            double gesamtpreis = listenpreis - rabatt;

            double gesamtrabatt = rabatt / (listenpreis / 100);

            double mwst = (gesamtpreis / 100) * 19;

            txbGesamtPreis.Text = String.Format("{0:f}", gesamtpreis);
            txbGesamtRabatt.Text = String.Format("{0:f}", gesamtrabatt);
            txbMwSt.Text = String.Format("{0:f}", mwst);
        }

        private void btnMitarbeiterPreis_Click(object sender, EventArgs e)
        {
            einlesenDaten();

            double gesamtpreis = listenpreis - rabatt - (listenpreis/100)*20;

            double gesamtrabatt = rabatt / (listenpreis / 100) + 20;

            double mwst = (gesamtpreis / 100) * 19;

            txbGesamtPreis.Text = String.Format("{0:f}", gesamtpreis);
            txbGesamtRabatt.Text = String.Format("{0:f}", gesamtrabatt);
            txbMwSt.Text = String.Format("{0:f}", mwst);
        }
    }
}
