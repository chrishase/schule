using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kontorechner
{
    public partial class Form1 : Form
    {
        double dkontostand, dbuchung;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuchen_Click(object sender, EventArgs e)
        {
            dbuchung = Convert.ToDouble(tbxBuchung.Text.Replace(".", ","));     // Eingabe einlesen, Punkte in Kommas unwandeln und zuletzt 
            
            if (dkontostand + dbuchung >= 0)                                    // Rechnung nur wenn Konto nicht ins Minus geht
            {
                dkontostand = dkontostand + dbuchung;
                lblBuchunganzeige.Text = Convert.ToString(dbuchung);
                lblKontostandanzeige.Text = Convert.ToString(Math.Round(dkontostand, 2));
                lblKontostand.ForeColor = Color.LightGreen;
                lblKontostandanzeige.ForeColor = Color.LightGreen;
            }
            else
            {
                lblKontostandanzeige.ForeColor = Color.Red;
                lblKontostand.ForeColor = Color.Red;
                lblKontostandanzeige.Text = "Nicht genug Geld verfügbar !";
               
                
            }
        }

    }
}
