using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace schleifen_ums_geschenk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWuerfeln_Click(object sender, EventArgs e)
        {
            double dzufallszahl1, dzufallszahl2, dwieoft=1;

            Random rnd1 = new Random();

            dzufallszahl1 = rnd1.Next(1, 11);
            tbxGewuerfelt.Text = Convert.ToString(dzufallszahl1);
            tbxgewuerfelt2.Text = Convert.ToString(dzufallszahl1);

            
            
            dzufallszahl2 = rnd1.Next(1, 11);
        }
    }
}
