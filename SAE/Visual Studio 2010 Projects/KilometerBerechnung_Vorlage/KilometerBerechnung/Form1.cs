using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KilometerBerechnung
{
    public partial class Form1 : Form
    {
        int[] arKilometer = new int[40];
        int iAnzahlFahrten = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKMEinlesen_Click(object sender, EventArgs e)
        {
            int iKilometer;
            iKilometer = Convert.ToInt32(tbxKilometer.Text);
            arKilometer[iAnzahlFahrten] = iKilometer;
            iAnzahlFahrten++;
            tbxAnzFahrten.Text = Convert.ToString(iAnzahlFahrten);
            tbxFahrten.Text = tbxFahrten.Text + Convert.ToString(iAnzahlFahrten + ". Fahrt: " + iKilometer + " km") + Environment.NewLine;
            tbxKilometer.Text = "";
        }

        private void btnDurchBerechnen_Click(object sender, EventArgs e)
        {
            double durchschnitt=0;
            for (int zaehler = 0; zaehler < iAnzahlFahrten; zaehler++)
            {
                durchschnitt = durchschnitt + arKilometer[zaehler];
            }

            durchschnitt = durchschnitt / iAnzahlFahrten;
            tbxDurchschnittkilometer.Text = Convert.ToString(Math.Round(durchschnitt, 2));
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
