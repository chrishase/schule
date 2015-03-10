using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kindergeldrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 anzahl;
            double summe;
            anzahl =Convert.ToInt32(tbxEingabe.Text);
            switch (anzahl)
            {
                case 1:
                summe = 184;
                break;

                case 2:
                summe = anzahl * 184;
                break;
                
                case 3:
                summe = (2 * 184) + 190;
                break;
                
                default:
                summe = ((2 * 184) + 190) ;
                break;
            }
            
        }
    }
}
