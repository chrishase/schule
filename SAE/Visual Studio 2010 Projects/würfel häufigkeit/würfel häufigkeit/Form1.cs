using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace würfel_häufigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwuerfeln_Click(object sender, EventArgs e)
        {
            int anzahl = 0, anzahl6er_gewuenscht = 0, anzahl6er_ist = 0, zufallszahl;
            double haeufigkeit = 0;
            anzahl6er_gewuenscht = Convert.ToInt32(tbxgewuenscht.Text);
            Random rnd1 = new Random();

            do
            {
                zufallszahl = rnd1.Next(1,7);
                if (zufallszahl == 6) { anzahl6er_ist++; }
                anzahl++;
            } while (anzahl6er_ist != anzahl6er_gewuenscht);

            haeufigkeit = Math.Round(((Convert.ToDouble(anzahl6er_ist) / anzahl) * 100),2);
            tbxhaeufigkeit.Text = Convert.ToString(haeufigkeit);
            tbxbenoetigt.Text = Convert.ToString(anzahl);
        }
    }
}
