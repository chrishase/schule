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
            this.tbxGesamtPreis = new System.Windows.Forms.TextBox();
            this.tbxGesamtRabatt = new System.Windows.Forms.TextBox();
            this.tbxMwSt = new System.Windows.Forms.TextBox();
            this.btnPreis = new System.Windows.Forms.Button();
            this.btnMitarbeiterPreis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listenpreis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rabatt in €:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gesamtpreis  in €:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gesamtrabatt in %:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enthaltene MwSt:";
            // 
            // txbListenpreis
            // 
            this.txbListenpreis.Location = new System.Drawing.Point(211, 31);
            this.txbListenpreis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbListenpreis.Name = "txbListenpreis";
            this.txbListenpreis.Size = new System.Drawing.Size(132, 22);
            this.txbListenpreis.TabIndex = 5;
            this.txbListenpreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbRabatt
            // 
            this.txbRabatt.Location = new System.Drawing.Point(211, 76);
            this.txbRabatt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbRabatt.Name = "txbRabatt";
            this.txbRabatt.Size = new System.Drawing.Size(132, 22);
            this.txbRabatt.TabIndex = 6;
            this.txbRabatt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxGesamtPreis
            // 
            this.tbxGesamtPreis.Enabled = false;
            this.tbxGesamtPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGesamtPreis.Location = new System.Drawing.Point(101, 161);
            this.tbxGesamtPreis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxGesamtPreis.Name = "tbxGesamtPreis";
            this.tbxGesamtPreis.ReadOnly = true;
            this.tbxGesamtPreis.Size = new System.Drawing.Size(167, 34);
            this.tbxGesamtPreis.TabIndex = 7;
            this.tbxGesamtPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxGesamtRabatt
            // 
            this.tbxGesamtRabatt.Enabled = false;
            this.tbxGesamtRabatt.Location = new System.Drawing.Point(211, 225);
            this.tbxGesamtRabatt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxGesamtRabatt.Name = "tbxGesamtRabatt";
            this.tbxGesamtRabatt.ReadOnly = true;
            this.tbxGesamtRabatt.Size = new System.Drawing.Size(132, 22);
            this.tbxGesamtRabatt.TabIndex = 8;
            this.tbxGesamtRabatt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxMwSt
            // 
            this.tbxMwSt.Enabled = false;
            this.tbxMwSt.Location = new System.Drawing.Point(211, 270);
            this.tbxMwSt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMwSt.Name = "tbxMwSt";
            this.tbxMwSt.ReadOnly = true;
            this.tbxMwSt.Size = new System.Drawing.Size(132, 22);
            this.tbxMwSt.TabIndex = 9;
            this.tbxMwSt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPreis
            // 
            this.btnPreis.Location = new System.Drawing.Point(52, 343);
            this.btnPreis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreis.Name = "btnPreis";
            this.btnPreis.Size = new System.Drawing.Size(100, 28);
            this.btnPreis.TabIndex = 10;
            this.btnPreis.Text = "Preis";
            this.btnPreis.UseVisualStyleBackColor = true;
            this.btnPreis.Click += new System.EventHandler(this.btnPreis_Click);
            // 
            // btnMitarbeiterPreis
            // 
            this.btnMitarbeiterPreis.Location = new System.Drawing.Point(211, 343);
            this.btnMitarbeiterPreis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMitarbeiterPreis.Name = "btnMitarbeiterPreis";
            this.btnMitarbeiterPreis.Size = new System.Drawing.Size(133, 28);
            this.btnMitarbeiterPreis.TabIndex = 11;
            this.btnMitarbeiterPreis.Text = "Mitarbeiter Preis";
            this.btnMitarbeiterPreis.UseVisualStyleBackColor = true;
            this.btnMitarbeiterPreis.Click += new System.EventHandler(this.btnMitarbeiterPreis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 389);
            this.Controls.Add(this.btnMitarbeiterPreis);
            this.Controls.Add(this.btnPreis);
            this.Controls.Add(this.tbxMwSt);
            this.Controls.Add(this.tbxGesamtRabatt);
            this.Controls.Add(this.tbxGesamtPreis);
            this.Controls.Add(this.txbRabatt);
            this.Controls.Add(this.txbListenpreis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "y";
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
        private System.Windows.Forms.TextBox tbxGesamtPreis;
        private System.Windows.Forms.TextBox tbxGesamtRabatt;
        private System.Windows.Forms.TextBox tbxMwSt;
        private System.Windows.Forms.Button btnPreis;
        private System.Windows.Forms.Button btnMitarbeiterPreis;
    }
}

