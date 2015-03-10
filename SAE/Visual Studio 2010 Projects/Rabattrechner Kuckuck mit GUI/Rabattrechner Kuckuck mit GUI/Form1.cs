using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rabattrechner_Kuckuck_mit_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAusrechnen_Click(object sender, EventArgs e)
        {
            double drechnungssumme, drabatt = 0, dergebnis;
           
            drechnungssumme = Convert.ToDouble(tbxRechnung.Text);

            if (drechnungssumme > 1000) {
                drabatt = drechnungssumme * 0.03;
                drabatt = Math.Round(drabatt, 2);
            }

            if (drechnungssumme <= 1000)
            {
                drabatt = 0;
            }

            tbxRabatt.Text = Convert.ToString(drabatt);

            dergebnis = Math.Round(drechnungssumme - drabatt,2);
            tbxErgebnis.Text = Convert.ToString(dergebnis);
        }

        private void btnloeschen_Click(object sender, EventArgs e)
        {
            tbxErgebnis.Text = "";
            tbxRabatt.Text = "";
            tbxRechnung.Text="";
        }

        private void btnEnde_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
