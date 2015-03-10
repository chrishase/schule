using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Häufigkeitsrechner_beim_würfeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwuerfeln_Click(object sender, EventArgs e)
        {
            int eingabe, anzahl=0, haeufigkeit, anzahl6er_gewuenscht =0, anzahl6er_ist=0, zufallszahl;

            eingabe = Convert.ToInt32(tbxeingabe.Text);
            Random rnd1 = new Random();

            do {  
                zufallszahl=rnd1.Next();
                if (zufallszahl == 6) { anzahl6er_ist++; }
                anzahl++;
            } while ( anzahl6er_ist == anzahl6er_gewuenscht);
            haeufigkeit = (anzahl6er_gewuenscht / anzahl) * 100;


         }
        }
    }
