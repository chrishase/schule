using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace modulo_übung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnausrechnen_Click(object sender, EventArgs e)
        {
            int dividend, divisor, quotient=0, rest;
            Boolean ausfuehren = true;

            dividend = Convert.ToInt32(tbxdividend.Text);
            divisor = Convert.ToInt32(tbxdivisor.Text);
            rest = dividend;
            if (dividend < 0) { MessageBox.Show(Convert.ToString("Der Dividend darf nicht negativ sein!!")); ausfuehren = false; }
            if (divisor <= 0) { MessageBox.Show(Convert.ToString("Der Divisor darf nicht negativ oder null sein!!")); ausfuehren = false; }

            if (ausfuehren == true)
            {

                do
                {
                    rest = rest - divisor;
                    quotient++;
                } while (rest > divisor);
                tbxquotient.Text = Convert.ToString(divisor);
                tbxrest.Text = Convert.ToString(rest);
                ausfuehren = true;
            }
        }
    }
}
