using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUItest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHello_click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            tbxEingabe.Text = "Hello World!";
            lblKopie.Text = "Hello World!";
        }

        private void Auslesen_Click(object sender, EventArgs e)
        {
            lblKopie.Text = tbxEingabe.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxEingabe.Clear();
            lblKopie.ResetText();
        }

        private void Beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
