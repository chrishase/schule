using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zahlenkette
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAusrechnen_Click(object sender, EventArgs e)
        {
            // Variablendeklaration
            Int32 istart, istop;
            string soutput="";

            //Einlesen
            istart = Convert.ToInt32(tbxStart.Text);
            istop = Convert.ToInt32(tbxStop.Text);

            //
            while (istart <= istop)
            {
                soutput = soutput + Convert.ToString(istart) + " ";
                istart = ++istart;
            }
            lblAusgabe.Text = soutput;
        }

        
    }
}
