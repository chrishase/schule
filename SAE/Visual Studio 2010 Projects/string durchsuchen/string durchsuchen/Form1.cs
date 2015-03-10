using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace string_durchsuchen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuchen_Click(object sender, EventArgs e)
        {
            string text=tbxtext.Text;
            char character=Convert.ToChar(tbxchar.Text);
            int zaehler=0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == character) { zaehler++; }
            }
            tbxanzahl.Text = Convert.ToString(zaehler);
        }

        private void btnbeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
