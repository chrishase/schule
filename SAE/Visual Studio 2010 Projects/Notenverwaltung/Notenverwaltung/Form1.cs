using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notenverwaltung
{
    public partial class Form1 : Form
    {
        int[] arNote = new int[32];
        int zaehler = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneinlesen_Click(object sender, EventArgs e)
        {
            int note;
            note = Convert.ToInt32(tbxeingabe.Text);
            arNote[zaehler] = note;
            zaehler++;
            tbxanzahl.Text = Convert.ToString(zaehler);
        }

        private void btndurchschnitt_Click(object sender, EventArgs e)
        {
            double durchschnitt = 0;
            for (int i = 0; i < zaehler ; i++)
            {
                durchschnitt = durchschnitt + arNote[i];
            }

            durchschnitt = durchschnitt / zaehler;
            tbxdurchschnitt.Text = Convert.ToString(Math.Round(durchschnitt, 1));
        }

        private void btnminmax_Click(object sender, EventArgs e)
        {
            int i=0;
            int minwert = Int32.MaxValue, maxwert = 0;
            while (i < zaehler)
            {
                if (arNote[i] > maxwert) { maxwert = Convert.ToInt32(arNote[i]); }
                if (arNote[i] < minwert) { minwert = Convert.ToInt32(arNote[i]); }
                i++;
            }
            tbxmin.Text = Convert.ToString(minwert);
            tbxmax.Text = Convert.ToString(maxwert);
        }
    }
}
