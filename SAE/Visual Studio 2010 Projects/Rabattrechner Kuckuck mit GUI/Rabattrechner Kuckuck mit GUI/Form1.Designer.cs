namespace Rabattrechner_Kuckuck_mit_GUI
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
            this.tbxRechnung = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnAusrechnen = new System.Windows.Forms.Button();
            this.tbxErgebnis = new System.Windows.Forms.TextBox();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.lblRabatt = new System.Windows.Forms.Label();
            this.tbxRabatt = new System.Windows.Forms.TextBox();
            this.btnloeschen = new System.Windows.Forms.Button();
            this.btnEnde = new System.Windows.Forms.Button();
            this.lblEurorabatt = new System.Windows.Forms.Label();
            this.lblEuroSumme = new System.Windows.Forms.Label();
            this.lblEuroendbetrag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxRechnung
            // 
            this.tbxRechnung.Location = new System.Drawing.Point(178, 49);
            this.tbxRechnung.Name = "tbxRechnung";
            this.tbxRechnung.Size = new System.Drawing.Size(72, 22);
            this.tbxRechnung.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(38, 52);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(125, 17);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Rechnungssumme";
            // 
            // btnAusrechnen
            // 
            this.btnAusrechnen.Location = new System.Drawing.Point(342, 49);
            this.btnAusrechnen.Name = "btnAusrechnen";
            this.btnAusrechnen.Size = new System.Drawing.Size(93, 23);
            this.btnAusrechnen.TabIndex = 2;
            this.btnAusrechnen.Text = "Ausrechnen";
            this.btnAusrechnen.UseVisualStyleBackColor = true;
            this.btnAusrechnen.Click += new System.EventHandler(this.btnAusrechnen_Click);
            // 
            // tbxErgebnis
            // 
            this.tbxErgebnis.Location = new System.Drawing.Point(178, 130);
            this.tbxErgebnis.Name = "tbxErgebnis";
            this.tbxErgebnis.Size = new System.Drawing.Size(72, 22);
            this.tbxErgebnis.TabIndex = 3;
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.Location = new System.Drawing.Point(89, 133);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(74, 17);
            this.lblErgebnis.TabIndex = 4;
            this.lblErgebnis.Text = "Endbetrag";
            // 
            // lblRabatt
            // 
            this.lblRabatt.AutoSize = true;
            this.lblRabatt.Location = new System.Drawing.Point(46, 92);
            this.lblRabatt.Name = "lblRabatt";
            this.lblRabatt.Size = new System.Drawing.Size(117, 17);
            this.lblRabatt.TabIndex = 5;
            this.lblRabatt.Text = "gewährter Rabatt";
            // 
            // tbxRabatt
            // 
            this.tbxRabatt.Location = new System.Drawing.Point(178, 89);
            this.tbxRabatt.Name = "tbxRabatt";
            this.tbxRabatt.Size = new System.Drawing.Size(72, 22);
            this.tbxRabatt.TabIndex = 6;
            // 
            // btnloeschen
            // 
            this.btnloeschen.Location = new System.Drawing.Point(342, 89);
            this.btnloeschen.Name = "btnloeschen";
            this.btnloeschen.Size = new System.Drawing.Size(93, 23);
            this.btnloeschen.TabIndex = 7;
            this.btnloeschen.Text = "Löschen";
            this.btnloeschen.UseVisualStyleBackColor = true;
            this.btnloeschen.Click += new System.EventHandler(this.btnloeschen_Click);
            // 
            // btnEnde
            // 
            this.btnEnde.Location = new System.Drawing.Point(342, 130);
            this.btnEnde.Name = "btnEnde";
            this.btnEnde.Size = new System.Drawing.Size(93, 23);
            this.btnEnde.TabIndex = 8;
            this.btnEnde.Text = "Beenden";
            this.btnEnde.UseVisualStyleBackColor = true;
            this.btnEnde.Click += new System.EventHandler(this.btnEnde_Click);
            // 
            // lblEurorabatt
            // 
            this.lblEurorabatt.AutoSize = true;
            this.lblEurorabatt.Location = new System.Drawing.Point(264, 92);
            this.lblEurorabatt.Name = "lblEurorabatt";
            this.lblEurorabatt.Size = new System.Drawing.Size(38, 17);
            this.lblEurorabatt.TabIndex = 9;
            this.lblEurorabatt.Text = "Euro";
            // 
            // lblEuroSumme
            // 
            this.lblEuroSumme.AutoSize = true;
            this.lblEuroSumme.Location = new System.Drawing.Point(264, 52);
            this.lblEuroSumme.Name = "lblEuroSumme";
            this.lblEuroSumme.Size = new System.Drawing.Size(38, 17);
            this.lblEuroSumme.TabIndex = 10;
            this.lblEuroSumme.Text = "Euro";
            // 
            // lblEuroendbetrag
            // 
            this.lblEuroendbetrag.AutoSize = true;
            this.lblEuroendbetrag.Location = new System.Drawing.Point(264, 133);
            this.lblEuroendbetrag.Name = "lblEuroendbetrag";
            this.lblEuroendbetrag.Size = new System.Drawing.Size(38, 17);
            this.lblEuroendbetrag.TabIndex = 11;
            this.lblEuroendbetrag.Text = "Euro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 206);
            this.Controls.Add(this.lblEuroendbetrag);
            this.Controls.Add(this.lblEuroSumme);
            this.Controls.Add(this.lblEurorabatt);
            this.Controls.Add(this.btnEnde);
            this.Controls.Add(this.btnloeschen);
            this.Controls.Add(this.tbxRabatt);
            this.Controls.Add(this.lblRabatt);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.tbxErgebnis);
            this.Controls.Add(this.btnAusrechnen);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.tbxRechnung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRechnung;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnAusrechnen;
        private System.Windows.Forms.TextBox tbxErgebnis;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.Label lblRabatt;
        private System.Windows.Forms.TextBox tbxRabatt;
        private System.Windows.Forms.Button btnloeschen;
        private System.Windows.Forms.Button btnEnde;
        private System.Windows.Forms.Label lblEurorabatt;
        private System.Windows.Forms.Label lblEuroSumme;
        private System.Windows.Forms.Label lblEuroendbetrag;
    }
}

