namespace umweltplakette
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxmesseingabe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxmessanzahl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxgrenzanzahl = new System.Windows.Forms.TextBox();
            this.tbxgrenzeingabe = new System.Windows.Forms.TextBox();
            this.tbxliste = new System.Windows.Forms.TextBox();
            this.btnEinlesen = new System.Windows.Forms.Button();
            this.btnAuswerten = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.lblwertnummer = new System.Windows.Forms.Label();
            this.btnneuermesswert = new System.Windows.Forms.Button();
            this.tbxwertnummer = new System.Windows.Forms.TextBox();
            this.tbxneuerwert = new System.Windows.Forms.TextBox();
            this.lblneuerwert = new System.Windows.Forms.Label();
            this.lbldurchschnitt = new System.Windows.Forms.Label();
            this.tbxdurchschnitt = new System.Windows.Forms.TextBox();
            this.lblminwert = new System.Windows.Forms.Label();
            this.tbxminwert = new System.Windows.Forms.TextBox();
            this.lblmaxwert = new System.Windows.Forms.Label();
            this.tbxmaxwert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxmesseingabe
            // 
            this.tbxmesseingabe.Location = new System.Drawing.Point(228, 66);
            this.tbxmesseingabe.Margin = new System.Windows.Forms.Padding(4);
            this.tbxmesseingabe.Name = "tbxmesseingabe";
            this.tbxmesseingabe.Size = new System.Drawing.Size(132, 22);
            this.tbxmesseingabe.TabIndex = 2;
            this.tbxmesseingabe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eingabe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Auswertung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Neuer Messwert:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Anzahl Messwerte:";
            // 
            // tbxmessanzahl
            // 
            this.tbxmessanzahl.BackColor = System.Drawing.SystemColors.Window;
            this.tbxmessanzahl.Enabled = false;
            this.tbxmessanzahl.Location = new System.Drawing.Point(228, 103);
            this.tbxmessanzahl.Margin = new System.Windows.Forms.Padding(4);
            this.tbxmessanzahl.Name = "tbxmessanzahl";
            this.tbxmessanzahl.ReadOnly = true;
            this.tbxmessanzahl.Size = new System.Drawing.Size(132, 22);
            this.tbxmessanzahl.TabIndex = 7;
            this.tbxmessanzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zulässiger Grenzwert:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Anzahl Überschreitungen:";
            // 
            // tbxgrenzanzahl
            // 
            this.tbxgrenzanzahl.BackColor = System.Drawing.SystemColors.Window;
            this.tbxgrenzanzahl.Enabled = false;
            this.tbxgrenzanzahl.Location = new System.Drawing.Point(228, 225);
            this.tbxgrenzanzahl.Margin = new System.Windows.Forms.Padding(4);
            this.tbxgrenzanzahl.Name = "tbxgrenzanzahl";
            this.tbxgrenzanzahl.ReadOnly = true;
            this.tbxgrenzanzahl.Size = new System.Drawing.Size(132, 22);
            this.tbxgrenzanzahl.TabIndex = 10;
            this.tbxgrenzanzahl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxgrenzeingabe
            // 
            this.tbxgrenzeingabe.Location = new System.Drawing.Point(228, 189);
            this.tbxgrenzeingabe.Margin = new System.Windows.Forms.Padding(4);
            this.tbxgrenzeingabe.Name = "tbxgrenzeingabe";
            this.tbxgrenzeingabe.Size = new System.Drawing.Size(132, 22);
            this.tbxgrenzeingabe.TabIndex = 11;
            this.tbxgrenzeingabe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxliste
            // 
            this.tbxliste.BackColor = System.Drawing.SystemColors.Window;
            this.tbxliste.Location = new System.Drawing.Point(600, 41);
            this.tbxliste.Margin = new System.Windows.Forms.Padding(4);
            this.tbxliste.Multiline = true;
            this.tbxliste.Name = "tbxliste";
            this.tbxliste.ReadOnly = true;
            this.tbxliste.Size = new System.Drawing.Size(225, 407);
            this.tbxliste.TabIndex = 12;
            // 
            // btnEinlesen
            // 
            this.btnEinlesen.Location = new System.Drawing.Point(420, 22);
            this.btnEinlesen.Margin = new System.Windows.Forms.Padding(4);
            this.btnEinlesen.Name = "btnEinlesen";
            this.btnEinlesen.Size = new System.Drawing.Size(132, 28);
            this.btnEinlesen.TabIndex = 13;
            this.btnEinlesen.Text = "Wert einlesen";
            this.btnEinlesen.UseVisualStyleBackColor = true;
            this.btnEinlesen.Click += new System.EventHandler(this.btnEinlesen_Click);
            // 
            // btnAuswerten
            // 
            this.btnAuswerten.Location = new System.Drawing.Point(420, 146);
            this.btnAuswerten.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuswerten.Name = "btnAuswerten";
            this.btnAuswerten.Size = new System.Drawing.Size(132, 28);
            this.btnAuswerten.TabIndex = 14;
            this.btnAuswerten.Text = "Auswerten";
            this.btnAuswerten.UseVisualStyleBackColor = true;
            this.btnAuswerten.Click += new System.EventHandler(this.btnAuswerten_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(420, 224);
            this.btnBeenden.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(132, 28);
            this.btnBeenden.TabIndex = 15;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(420, 261);
            this.btnLoeschen.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(132, 28);
            this.btnLoeschen.TabIndex = 16;
            this.btnLoeschen.Text = "Zurücksetzen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // lblwertnummer
            // 
            this.lblwertnummer.AutoSize = true;
            this.lblwertnummer.Location = new System.Drawing.Point(17, 386);
            this.lblwertnummer.Name = "lblwertnummer";
            this.lblwertnummer.Size = new System.Drawing.Size(79, 17);
            this.lblwertnummer.TabIndex = 17;
            this.lblwertnummer.Text = "Messwert #";
            // 
            // btnneuermesswert
            // 
            this.btnneuermesswert.Location = new System.Drawing.Point(420, 400);
            this.btnneuermesswert.Name = "btnneuermesswert";
            this.btnneuermesswert.Size = new System.Drawing.Size(132, 46);
            this.btnneuermesswert.TabIndex = 18;
            this.btnneuermesswert.Text = "Messwert ersetzen";
            this.btnneuermesswert.UseVisualStyleBackColor = true;
            this.btnneuermesswert.Click += new System.EventHandler(this.btnneuermesswert_Click);
            // 
            // tbxwertnummer
            // 
            this.tbxwertnummer.Location = new System.Drawing.Point(228, 383);
            this.tbxwertnummer.Name = "tbxwertnummer";
            this.tbxwertnummer.Size = new System.Drawing.Size(132, 22);
            this.tbxwertnummer.TabIndex = 19;
            // 
            // tbxneuerwert
            // 
            this.tbxneuerwert.Location = new System.Drawing.Point(228, 426);
            this.tbxneuerwert.Name = "tbxneuerwert";
            this.tbxneuerwert.Size = new System.Drawing.Size(132, 22);
            this.tbxneuerwert.TabIndex = 20;
            // 
            // lblneuerwert
            // 
            this.lblneuerwert.AutoSize = true;
            this.lblneuerwert.Location = new System.Drawing.Point(17, 429);
            this.lblneuerwert.Name = "lblneuerwert";
            this.lblneuerwert.Size = new System.Drawing.Size(81, 17);
            this.lblneuerwert.TabIndex = 21;
            this.lblneuerwert.Text = "Neuer Wert";
            // 
            // lbldurchschnitt
            // 
            this.lbldurchschnitt.AutoSize = true;
            this.lbldurchschnitt.Location = new System.Drawing.Point(16, 267);
            this.lbldurchschnitt.Name = "lbldurchschnitt";
            this.lbldurchschnitt.Size = new System.Drawing.Size(120, 17);
            this.lbldurchschnitt.TabIndex = 22;
            this.lbldurchschnitt.Text = "Durchschnittswert";
            // 
            // tbxdurchschnitt
            // 
            this.tbxdurchschnitt.Enabled = false;
            this.tbxdurchschnitt.Location = new System.Drawing.Point(228, 264);
            this.tbxdurchschnitt.Name = "tbxdurchschnitt";
            this.tbxdurchschnitt.Size = new System.Drawing.Size(132, 22);
            this.tbxdurchschnitt.TabIndex = 23;
            // 
            // lblminwert
            // 
            this.lblminwert.AutoSize = true;
            this.lblminwert.Location = new System.Drawing.Point(19, 307);
            this.lblminwert.Name = "lblminwert";
            this.lblminwert.Size = new System.Drawing.Size(111, 17);
            this.lblminwert.TabIndex = 24;
            this.lblminwert.Text = "Niedrigster Wert";
            // 
            // tbxminwert
            // 
            this.tbxminwert.Enabled = false;
            this.tbxminwert.Location = new System.Drawing.Point(136, 304);
            this.tbxminwert.Name = "tbxminwert";
            this.tbxminwert.Size = new System.Drawing.Size(88, 22);
            this.tbxminwert.TabIndex = 25;
            // 
            // lblmaxwert
            // 
            this.lblmaxwert.AutoSize = true;
            this.lblmaxwert.Location = new System.Drawing.Point(248, 307);
            this.lblmaxwert.Name = "lblmaxwert";
            this.lblmaxwert.Size = new System.Drawing.Size(99, 17);
            this.lblmaxwert.TabIndex = 26;
            this.lblmaxwert.Text = "Höchster Wert";
            // 
            // tbxmaxwert
            // 
            this.tbxmaxwert.Enabled = false;
            this.tbxmaxwert.Location = new System.Drawing.Point(353, 304);
            this.tbxmaxwert.Name = "tbxmaxwert";
            this.tbxmaxwert.Size = new System.Drawing.Size(86, 22);
            this.tbxmaxwert.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 484);
            this.Controls.Add(this.tbxmaxwert);
            this.Controls.Add(this.lblmaxwert);
            this.Controls.Add(this.tbxminwert);
            this.Controls.Add(this.lblminwert);
            this.Controls.Add(this.tbxdurchschnitt);
            this.Controls.Add(this.lbldurchschnitt);
            this.Controls.Add(this.lblneuerwert);
            this.Controls.Add(this.tbxneuerwert);
            this.Controls.Add(this.tbxwertnummer);
            this.Controls.Add(this.btnneuermesswert);
            this.Controls.Add(this.lblwertnummer);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnAuswerten);
            this.Controls.Add(this.btnEinlesen);
            this.Controls.Add(this.tbxliste);
            this.Controls.Add(this.tbxgrenzeingabe);
            this.Controls.Add(this.tbxgrenzanzahl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxmessanzahl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxmesseingabe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MesswerteVerwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxmesseingabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxmessanzahl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxgrenzanzahl;
        private System.Windows.Forms.TextBox tbxgrenzeingabe;
        private System.Windows.Forms.TextBox tbxliste;
        private System.Windows.Forms.Button btnEinlesen;
        private System.Windows.Forms.Button btnAuswerten;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.Label lblwertnummer;
        private System.Windows.Forms.Button btnneuermesswert;
        private System.Windows.Forms.TextBox tbxwertnummer;
        private System.Windows.Forms.TextBox tbxneuerwert;
        private System.Windows.Forms.Label lblneuerwert;
        private System.Windows.Forms.Label lbldurchschnitt;
        private System.Windows.Forms.TextBox tbxdurchschnitt;
        private System.Windows.Forms.Label lblminwert;
        private System.Windows.Forms.TextBox tbxminwert;
        private System.Windows.Forms.Label lblmaxwert;
        private System.Windows.Forms.TextBox tbxmaxwert;

    }
}

