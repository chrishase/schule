using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zufallszahl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Würfelergebnis;
            int Würfelergebnis2 = 0;
            int Anzahl = 1;
            int Min = 1;
            int Max = 11;

            Min = Convert.ToInt32(textBox4.Text);
            Max = Convert.ToInt32(textBox5.Text);

            Random rnd1 = new Random();
            Würfelergebnis = rnd1.Next(Min, Max);
            textBox1.Text = Convert.ToString(Würfelergebnis);
            textBox2.Text = Convert.ToString(Würfelergebnis);


            while(Würfelergebnis != Würfelergebnis2)
            {

               
                Würfelergebnis2 = rnd1.Next(Min, Max);
                Anzahl++;
            }
            if (Würfelergebnis == Würfelergebnis2)
            {
                textBox3.Text = Convert.ToString(Anzahl);
        }}


    }
}
