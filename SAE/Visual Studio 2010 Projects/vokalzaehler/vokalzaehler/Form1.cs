using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vokalzaehler
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnzaehlen_Click(object sender, EventArgs e)
        {
            string text = tbxeingabe.Text;
            text.ToLower();
            int stringlength = text.Length;
            char vokal;
            int anzahla = 0, anzahle = 0, anzahli = 0, anzahlo = 0, anzahlu = 0;

            vokal = 'a';
            anzahla = zaehler(vokal, text);

            vokal = 'e';
            anzahle = zaehler(vokal, text);

            vokal = 'i';
            anzahle = zaehler(vokal, text);

            vokal = 'o';
            anzahle = zaehler(vokal, text);

            vokal = 'u';
            anzahle = zaehler(vokal, text);

            ausgabe(anzahla, anzahle, anzahli, anzahlo, anzahlu);

        }


        private int zaehler(char vokal, string text)
        {
            int zähler=0;
            char temp;

            for (int i=0; i <= text.Length; i++)
            {
                temp = text[i];
                if (vokal == temp) { zähler++; }
            }

            return zähler;
        }


        private void ausgabe(int anzahla, int anzahle, int anzahli, int anzahlo, int anzahlu)
        {
            tbxausgabe.Text = "Anzahl a= " + anzahla + "\n" + "Anzahl e= " + anzahle + "\n" + "Anzahl i= " + anzahli + "\n" + "Anzahl o= " + anzahlo + "\n" + "Anzahl u= " + anzahlu + "\n";
        }


    }
}
