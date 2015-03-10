using System;
using System.Windows.Forms;
using System.IO;

namespace config_lesen
{
    public partial class Form1 : Form
    {
        string datei;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInfosAuslesen_Click(object sender, EventArgs e)
        {
            String sInfos = "";

            // Die Environment-Klasse stellt Informationen für die aktuelle Umgebung und Plattform zur Verfügung.
            // Auslesen der Informationen und anhängen an den String sInfos:
            sInfos = sInfos + "OS-Version: " + Environment.OSVersion + "\r\n";
            sInfos = sInfos + "Computername: " + Environment.MachineName + "\r\n";
            sInfos = sInfos + "Benutzername: " + Environment.UserName + "\r\n";
            
            // Ausgabe des String in der Textbox
            tbxInfos.Text = sInfos;
        }

        private void btnDateiSpeichern_Click(object sender, EventArgs e)
        {
            datei = tbxDateipfad.Text;
            string inhalt=tbxInfos.Text;


            StreamWriter sw_datei=new StreamWriter(datei);

            sw_datei.WriteLine(inhalt);

            sw_datei.Close();
        }

        private void btnDateiLesen_Click(object sender, EventArgs e)
        {

        }
    }
}
