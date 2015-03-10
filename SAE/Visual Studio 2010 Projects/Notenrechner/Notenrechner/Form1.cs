using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBedeutung_Click(object sender, EventArgs e)
        {
            Int32 dnote;

            dnote = Convert.ToInt32(tbxNote.Text);

            switch (dnote)
            {
                case 1:
                lblNote.Text = "Die Note 1 soll erteilt werden, wenn die Leistung den Anforderungen im besonderen Maße entspricht.";
                break;
                case 2:
                lblNote.Text = "Die Note 2 soll erteilt werden, wenn die Leistung den Anforderungen voll entspricht.";
                break;
                case 3:
                lblNote.Text = "Die Note 3 soll erteilt werden, wenn die Leistung im allgemeinen den ANforderungen entspricht.";
                break;
                case 4:
                lblNote.Text = "Die Note 4 soll erteilt werden, wenn die Leistung zwar Mängel aufweißt, aber im Ganzen den Anforderungen noch entspricht.";
                break;
                case 5:
                lblNote.Text = "Die Note 5 soll erteilt werden, wenn die Leistung den Anforderungen nicht entspricht, jedoch erkennen läßt, dass die notwendigen Kenntnisse Grundkenntnisse vorhanden sind und die Mängel in absehbarer Zeit behoben werden können.";
                break;
                case 6:
                lblNote.Text = "Die Note 5 soll erteilt werden, wenn die Leistung den Anforderungen nicht entspricht und selbst die Grundkenntnisse so lückenhaft sind, dass die Mängel nciht in absehbarer Zeit behoben werden können.";
                break;

                default:
                lblNote.Text = "Keine gültige Note eingegeben !";
                break;
            }

        }
    }
}
