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
        int mitarbeiterrabatt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPreis_Click(object sender, EventArgs e)
        {
            mitarbeiterrabatt = 0;
            berechnen(mitarbeiterrabatt);
        }

        private void btnMitarbeiterPreis_Click(object sender, EventArgs e)
        {
            mitarbeiterrabatt = 20;
            berechnen(mitarbeiterrabatt);
        }


        void berechnen(int zusatzrabatt)
        {
            double listenpreis = Convert.ToDouble(txbListenpreis.Text);
            double rabatt = Convert.ToDouble(txbRabatt.Text);

            double gesamtpreis = listenpreis - rabatt - (listenpreis / 100) * zusatzrabatt;
            double gesamtrabatt = rabatt / (listenpreis / 100) + zusatzrabatt;
            double mwst = (gesamtpreis / 100) * 19;

            tbxGesamtPreis.Text = Convert.ToString(gesamtpreis);
            tbxGesamtRabatt.Text = Convert.ToString(gesamtrabatt);
            tbxMwSt.Text = Convert.ToString(mwst);
        }
    }
}
