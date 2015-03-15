namespace Konto_Beziehungen
{
    partial class BuchungsKing
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
            this.btnEinzahlen = new System.Windows.Forms.Button();
            this.btnAbheben = new System.Windows.Forms.Button();
            this.txbKontoNummer = new System.Windows.Forms.TextBox();
            this.txbKontoStand = new System.Windows.Forms.TextBox();
            this.txbInhaber = new System.Windows.Forms.TextBox();
            this.txbBetrag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEinzahlen
            // 
            this.btnEinzahlen.Location = new System.Drawing.Point(44, 283);
            this.btnEinzahlen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEinzahlen.Name = "btnEinzahlen";
            this.btnEinzahlen.Size = new System.Drawing.Size(112, 35);
            this.btnEinzahlen.TabIndex = 0;
            this.btnEinzahlen.Text = "einzahlen";
            this.btnEinzahlen.UseVisualStyleBackColor = true;
            this.btnEinzahlen.Click += new System.EventHandler(this.btnEinzahlen_Click);
            // 
            // btnAbheben
            // 
            this.btnAbheben.Location = new System.Drawing.Point(214, 283);
            this.btnAbheben.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbheben.Name = "btnAbheben";
            this.btnAbheben.Size = new System.Drawing.Size(112, 35);
            this.btnAbheben.TabIndex = 1;
            this.btnAbheben.Text = "abheben";
            this.btnAbheben.UseVisualStyleBackColor = true;
            this.btnAbheben.Click += new System.EventHandler(this.btnAbheben_Click);
            // 
            // txbKontoNummer
            // 
            this.txbKontoNummer.Location = new System.Drawing.Point(177, 38);
            this.txbKontoNummer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbKontoNummer.Name = "txbKontoNummer";
            this.txbKontoNummer.Size = new System.Drawing.Size(100, 26);
            this.txbKontoNummer.TabIndex = 3;
            this.txbKontoNummer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbKontoStand
            // 
            this.txbKontoStand.Location = new System.Drawing.Point(177, 83);
            this.txbKontoStand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbKontoStand.Name = "txbKontoStand";
            this.txbKontoStand.Size = new System.Drawing.Size(100, 26);
            this.txbKontoStand.TabIndex = 4;
            this.txbKontoStand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbInhaber
            // 
            this.txbInhaber.BackColor = System.Drawing.Color.White;
            this.txbInhaber.Location = new System.Drawing.Point(362, 83);
            this.txbInhaber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbInhaber.Multiline = true;
            this.txbInhaber.Name = "txbInhaber";
            this.txbInhaber.ReadOnly = true;
            this.txbInhaber.Size = new System.Drawing.Size(148, 163);
            this.txbInhaber.TabIndex = 5;
            // 
            // txbBetrag
            // 
            this.txbBetrag.Location = new System.Drawing.Point(140, 220);
            this.txbBetrag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbBetrag.Name = "txbBetrag";
            this.txbBetrag.Size = new System.Drawing.Size(138, 26);
            this.txbBetrag.TabIndex = 6;
            this.txbBetrag.Text = "0";
            this.txbBetrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kontonummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kontostand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inhaber:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Betrag: ";
            // 
            // BuchungsKing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBetrag);
            this.Controls.Add(this.txbInhaber);
            this.Controls.Add(this.txbKontoStand);
            this.Controls.Add(this.txbKontoNummer);
            this.Controls.Add(this.btnAbheben);
            this.Controls.Add(this.btnEinzahlen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BuchungsKing";
            this.Text = "BuchungsKing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEinzahlen;
        private System.Windows.Forms.Button btnAbheben;
        private System.Windows.Forms.TextBox txbKontoNummer;
        private System.Windows.Forms.TextBox txbKontoStand;
        private System.Windows.Forms.TextBox txbInhaber;
        private System.Windows.Forms.TextBox txbBetrag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

