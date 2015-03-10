using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lottorechner
{
    public partial class Form1 : Form
    {
        int[] arlotto = new int[6];
        Random rnd1 = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnerzeugen_Click(object sender, EventArgs e)
        {
            int zwischen = 0, lastrnd1 = 0;
            if (lbllottozahlen.Text != "") { lbllottozahlen.Text = ""; }
            for (int i = 0; i < 6; i++) { zwischen = rnd1.Next(1, 50); if (zwischen == lastrnd1) { zwischen = rnd1.Next(1, 49); } arlotto[i] = zwischen; lbllottozahlen.Text = lbllottozahlen.Text + " " + Convert.ToString(arlotto[i]); lastrnd1 = arlotto[i]; }
        }

        private void btnbeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnloeschen_Click(object sender, EventArgs e)
        {
            lbllottozahlen.Text = "";
            tbxrichtige.Text = "";
            tbxzahl1.Text = "";
            tbxzahl2.Text = "";
            tbxzahl3.Text = "";
            tbxzahl4.Text = "";
            tbxzahl5.Text = "";
            tbxzahl6.Text = "";
        }

        private void btnauswerten_Click(object sender, EventArgs e)
        {
            int richtige = 0;
            for (int i = 0; i < 6; i++) { if (Convert.ToInt32(tbxzahl1.Text) == arlotto[i]) { richtige++; } }
            for (int i = 0; i < 6; i++) { if (Convert.ToInt32(tbxzahl2.Text) == arlotto[i]) { richtige++; } }
            for (int i = 0; i < 6; i++) { if (Convert.ToInt32(tbxzahl3.Text) == arlotto[i]) { richtige++; } }
            for (int i = 0; i < 6; i++) { if (Convert.ToInt32(tbxzahl4.Text) == arlotto[i]) { richtige++; } }
            for (int i = 0; i < 6; i++) { if (Convert.ToInt32(tbxzahl5.Text) == arlotto[i]) { richtige++; } }
            for (int i = 0; i < 6; i++) { if (Convert.ToInt32(tbxzahl6.Text) == arlotto[i]) { richtige++; } }

            tbxrichtige.Text = Convert.ToString(richtige) + " Richtige";
        }
    }
}
