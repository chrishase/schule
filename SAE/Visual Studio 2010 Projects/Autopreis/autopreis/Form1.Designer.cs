namespace autopreis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbListenpreis = new System.Windows.Forms.TextBox();
            this.txbRabatt = new System.Windows.Forms.TextBox();
            this.txbGesamtPreis = new System.Windows.Forms.TextBox();
            this.txbGesamtRabatt = new System.Windows.Forms.TextBox();
            this.txbMwSt = new System.Windows.Forms.TextBox();
            this.btnPreis = new System.Windows.Forms.Button();
            this.btnMitarbeiterPreis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listenpreis in €:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rabatt in €:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gesamtpreis  in €:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gesamtrabatt in %:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enthaltene MwSt in €:";
            // 
            // txbListenpreis
            // 
            this.txbListenpreis.Location = new System.Drawing.Point(158, 25);
            this.txbListenpreis.Name = "txbListenpreis";
            this.txbListenpreis.Size = new System.Drawing.Size(100, 20);
            this.txbListenpreis.TabIndex = 5;
            this.txbListenpreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbRabatt
            // 
            this.txbRabatt.Location = new System.Drawing.Point(158, 62);
            this.txbRabatt.Name = "txbRabatt";
            this.txbRabatt.Size = new System.Drawing.Size(100, 20);
            this.txbRabatt.TabIndex = 6;
            this.txbRabatt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbGesamtPreis
            // 
            this.txbGesamtPreis.Enabled = false;
            this.txbGesamtPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGesamtPreis.Location = new System.Drawing.Point(76, 131);
            this.txbGesamtPreis.Name = "txbGesamtPreis";
            this.txbGesamtPreis.Size = new System.Drawing.Size(126, 29);
            this.txbGesamtPreis.TabIndex = 7;
            this.txbGesamtPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbGesamtRabatt
            // 
            this.txbGesamtRabatt.Enabled = false;
            this.txbGesamtRabatt.Location = new System.Drawing.Point(158, 183);
            this.txbGesamtRabatt.Name = "txbGesamtRabatt";
            this.txbGesamtRabatt.Size = new System.Drawing.Size(100, 20);
            this.txbGesamtRabatt.TabIndex = 8;
            this.txbGesamtRabatt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbMwSt
            // 
            this.txbMwSt.Enabled = false;
            this.txbMwSt.Location = new System.Drawing.Point(158, 219);
            this.txbMwSt.Name = "txbMwSt";
            this.txbMwSt.Size = new System.Drawing.Size(100, 20);
            this.txbMwSt.TabIndex = 9;
            this.txbMwSt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPreis
            // 
            this.btnPreis.Location = new System.Drawing.Point(39, 279);
            this.btnPreis.Name = "btnPreis";
            this.btnPreis.Size = new System.Drawing.Size(75, 23);
            this.btnPreis.TabIndex = 10;
            this.btnPreis.Text = "Preis";
            this.btnPreis.UseVisualStyleBackColor = true;
            this.btnPreis.Click += new System.EventHandler(this.btnPreis_Click);
            // 
            // btnMitarbeiterPreis
            // 
            this.btnMitarbeiterPreis.Location = new System.Drawing.Point(158, 279);
            this.btnMitarbeiterPreis.Name = "btnMitarbeiterPreis";
            this.btnMitarbeiterPreis.Size = new System.Drawing.Size(100, 23);
            this.btnMitarbeiterPreis.TabIndex = 11;
            this.btnMitarbeiterPreis.Text = "Mitarbeiter Preis";
            this.btnMitarbeiterPreis.UseVisualStyleBackColor = true;
            this.btnMitarbeiterPreis.Click += new System.EventHandler(this.btnMitarbeiterPreis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 316);
            this.Controls.Add(this.btnMitarbeiterPreis);
            this.Controls.Add(this.btnPreis);
            this.Controls.Add(this.txbMwSt);
            this.Controls.Add(this.txbGesamtRabatt);
            this.Controls.Add(this.txbGesamtPreis);
            this.Controls.Add(this.txbRabatt);
            this.Controls.Add(this.txbListenpreis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Autopreis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbListenpreis;
        private System.Windows.Forms.TextBox txbRabatt;
        private System.Windows.Forms.TextBox txbGesamtPreis;
        private System.Windows.Forms.TextBox txbGesamtRabatt;
        private System.Windows.Forms.TextBox txbMwSt;
        private System.Windows.Forms.Button btnPreis;
        private System.Windows.Forms.Button btnMitarbeiterPreis;
    }
}

