using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace umweltplakette
{
    public partial class Form1 : Form
    {
        Int32 zaehler = 0;
        double[] Messwerte = new double[366];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEinlesen_Click(object sender, EventArgs e)
        {
            double messeingabe;
            messeingabe=Convert.ToDouble(tbxmesseingabe.Text);
            Messwerte[zaehler] = messeingabe;
            tbxliste.Text = tbxliste.Text + Convert.ToString(messeingabe) + Environment.NewLine;
            zaehler++;
            tbxmessanzahl.Text = Convert.ToString(zaehler);
        }

        private void btnAuswerten_Click(object sender, EventArgs e)
        {
            double grenzwert = Convert.ToDouble(tbxgrenzeingabe.Text), durchschnitt = 0;
            UInt16 minwert=UInt16.MaxValue, maxwert=0;
            Int32 temp = 0, grenzanzahl = 0;
            while ( temp < zaehler)
            {
                if (Messwerte[temp] >= grenzwert) { grenzanzahl++; }

                if (Messwerte[temp] > maxwert) { maxwert = Convert.ToUInt16(Messwerte[temp]); }
                if (Messwerte[temp] < minwert) { minwert = Convert.ToUInt16(Messwerte[temp]); }
                
                durchschnitt = durchschnitt + Messwerte[temp];
                temp++;
            }
            tbxmaxwert.Text = Convert.ToString(maxwert);
            tbxminwert.Text = Convert.ToString(minwert);
            durchschnitt = durchschnitt / temp;
            tbxdurchschnitt.Text = Convert.ToString(Math.Round(durchschnitt,2));
            tbxgrenzanzahl.Text = Convert.ToString(grenzanzahl);
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            tbxgrenzanzahl.Text = "";
            tbxgrenzeingabe.Text = "";
            tbxliste.Text = "";
            tbxmessanzahl.Text = "";
            tbxmesseingabe.Text = "";
            double[] Messwerte = new double[366];
            zaehler = 0;
        }

        private void btnneuermesswert_Click(object sender, EventArgs e)
        {
            double neuerwert;
            UInt16 nummer;

            neuerwert = Convert.ToDouble(tbxneuerwert.Text);
            nummer=Convert.ToUInt16(tbxwertnummer.Text);
            Messwerte[nummer-1] = neuerwert;
            tbxliste.Text = "";

            for (int temp = 0; temp < zaehler; temp++)
            {
                tbxliste.Text = tbxliste.Text + Messwerte[temp] + Environment.NewLine;
            }
            this.btnAuswerten_Click(sender, e);
        }
    }
}
