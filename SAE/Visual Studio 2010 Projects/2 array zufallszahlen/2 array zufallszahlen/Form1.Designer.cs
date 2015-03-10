namespace _2_array_zufallszahlen
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblarray1liste = new System.Windows.Forms.Label();
            this.lblarray2liste = new System.Windows.Forms.Label();
            this.lblgleichezahlen = new System.Windows.Forms.Label();
            this.tbxlistegleichezahlen = new System.Windows.Forms.TextBox();
            this.lbldoppeltarray1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zufallszahlen erzeugen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblarray1liste
            // 
            this.lblarray1liste.AutoSize = true;
            this.lblarray1liste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblarray1liste.Location = new System.Drawing.Point(31, 87);
            this.lblarray1liste.MinimumSize = new System.Drawing.Size(100, 550);
            this.lblarray1liste.Name = "lblarray1liste";
            this.lblarray1liste.Size = new System.Drawing.Size(100, 550);
            this.lblarray1liste.TabIndex = 1;
            this.lblarray1liste.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblarray2liste
            // 
            this.lblarray2liste.AutoSize = true;
            this.lblarray2liste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblarray2liste.Location = new System.Drawing.Point(151, 87);
            this.lblarray2liste.MinimumSize = new System.Drawing.Size(100, 550);
            this.lblarray2liste.Name = "lblarray2liste";
            this.lblarray2liste.Size = new System.Drawing.Size(100, 550);
            this.lblarray2liste.TabIndex = 2;
            this.lblarray2liste.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblgleichezahlen
            // 
            this.lblgleichezahlen.AutoSize = true;
            this.lblgleichezahlen.Location = new System.Drawing.Point(287, 87);
            this.lblgleichezahlen.Name = "lblgleichezahlen";
            this.lblgleichezahlen.Size = new System.Drawing.Size(108, 17);
            this.lblgleichezahlen.TabIndex = 3;
            this.lblgleichezahlen.Text = "Gleiche Zahlen:";
            // 
            // tbxlistegleichezahlen
            // 
            this.tbxlistegleichezahlen.Location = new System.Drawing.Point(411, 87);
            this.tbxlistegleichezahlen.Multiline = true;
            this.tbxlistegleichezahlen.Name = "tbxlistegleichezahlen";
            this.tbxlistegleichezahlen.ReadOnly = true;
            this.tbxlistegleichezahlen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxlistegleichezahlen.Size = new System.Drawing.Size(100, 145);
            this.tbxlistegleichezahlen.TabIndex = 4;
            // 
            // lbldoppeltarray1
            // 
            this.lbldoppeltarray1.AutoSize = true;
            this.lbldoppeltarray1.Location = new System.Drawing.Point(290, 244);
            this.lbldoppeltarray1.Name = "lbldoppeltarray1";
            this.lbldoppeltarray1.Size = new System.Drawing.Size(181, 17);
            this.lbldoppeltarray1.TabIndex = 5;
            this.lbldoppeltarray1.Text = "Doppelte Zahlen im Array 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 692);
            this.Controls.Add(this.lbldoppeltarray1);
            this.Controls.Add(this.tbxlistegleichezahlen);
            this.Controls.Add(this.lblgleichezahlen);
            this.Controls.Add(this.lblarray2liste);
            this.Controls.Add(this.lblarray1liste);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblarray1liste;
        private System.Windows.Forms.Label lblarray2liste;
        private System.Windows.Forms.Label lblgleichezahlen;
        private System.Windows.Forms.TextBox tbxlistegleichezahlen;
        private System.Windows.Forms.Label lbldoppeltarray1;
    }
}

