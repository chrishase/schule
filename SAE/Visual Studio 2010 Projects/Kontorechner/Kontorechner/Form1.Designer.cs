namespace Kontorechner
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
            this.btnBuchen = new System.Windows.Forms.Button();
            this.lblKontostand = new System.Windows.Forms.Label();
            this.lblKontostandanzeige = new System.Windows.Forms.Label();
            this.lblbuchung = new System.Windows.Forms.Label();
            this.lblBuchunganzeige = new System.Windows.Forms.Label();
            this.tbxBuchung = new System.Windows.Forms.TextBox();
            this.lblEurobox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuchen
            // 
            this.btnBuchen.Location = new System.Drawing.Point(239, 34);
            this.btnBuchen.Name = "btnBuchen";
            this.btnBuchen.Size = new System.Drawing.Size(97, 37);
            this.btnBuchen.TabIndex = 0;
            this.btnBuchen.Text = "Buchen";
            this.btnBuchen.UseVisualStyleBackColor = true;
            this.btnBuchen.Click += new System.EventHandler(this.btnBuchen_Click);
            // 
            // lblKontostand
            // 
            this.lblKontostand.AutoSize = true;
            this.lblKontostand.Location = new System.Drawing.Point(66, 106);
            this.lblKontostand.Name = "lblKontostand";
            this.lblKontostand.Size = new System.Drawing.Size(84, 17);
            this.lblKontostand.TabIndex = 1;
            this.lblKontostand.Text = "Kontostand:";
            // 
            // lblKontostandanzeige
            // 
            this.lblKontostandanzeige.AutoSize = true;
            this.lblKontostandanzeige.Location = new System.Drawing.Point(177, 106);
            this.lblKontostandanzeige.Name = "lblKontostandanzeige";
            this.lblKontostandanzeige.Size = new System.Drawing.Size(16, 17);
            this.lblKontostandanzeige.TabIndex = 2;
            this.lblKontostandanzeige.Text = "0";
            // 
            // lblbuchung
            // 
            this.lblbuchung.AutoSize = true;
            this.lblbuchung.Location = new System.Drawing.Point(39, 152);
            this.lblbuchung.Name = "lblbuchung";
            this.lblbuchung.Size = new System.Drawing.Size(111, 17);
            this.lblbuchung.TabIndex = 3;
            this.lblbuchung.Text = "Letzte Buchung:";
            // 
            // lblBuchunganzeige
            // 
            this.lblBuchunganzeige.AutoSize = true;
            this.lblBuchunganzeige.Location = new System.Drawing.Point(177, 152);
            this.lblBuchunganzeige.Name = "lblBuchunganzeige";
            this.lblBuchunganzeige.Size = new System.Drawing.Size(16, 17);
            this.lblBuchunganzeige.TabIndex = 4;
            this.lblBuchunganzeige.Text = "0";
            // 
            // tbxBuchung
            // 
            this.tbxBuchung.Location = new System.Drawing.Point(62, 41);
            this.tbxBuchung.Name = "tbxBuchung";
            this.tbxBuchung.Size = new System.Drawing.Size(88, 22);
            this.tbxBuchung.TabIndex = 5;
            // 
            // lblEurobox
            // 
            this.lblEurobox.AutoSize = true;
            this.lblEurobox.Location = new System.Drawing.Point(177, 44);
            this.lblEurobox.Name = "lblEurobox";
            this.lblEurobox.Size = new System.Drawing.Size(38, 17);
            this.lblEurobox.TabIndex = 6;
            this.lblEurobox.Text = "Euro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 190);
            this.Controls.Add(this.lblEurobox);
            this.Controls.Add(this.tbxBuchung);
            this.Controls.Add(this.lblBuchunganzeige);
            this.Controls.Add(this.lblbuchung);
            this.Controls.Add(this.lblKontostandanzeige);
            this.Controls.Add(this.lblKontostand);
            this.Controls.Add(this.btnBuchen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuchen;
        private System.Windows.Forms.Label lblKontostand;
        private System.Windows.Forms.Label lblKontostandanzeige;
        private System.Windows.Forms.Label lblbuchung;
        private System.Windows.Forms.Label lblBuchunganzeige;
        private System.Windows.Forms.TextBox tbxBuchung;
        private System.Windows.Forms.Label lblEurobox;
    }
}

