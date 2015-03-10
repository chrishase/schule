namespace schleifen_ums_geschenk
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.tbxGewuerfelt = new System.Windows.Forms.TextBox();
            this.btnWuerfeln = new System.Windows.Forms.Button();
            this.lblgewuerfelt = new System.Windows.Forms.Label();
            this.lblGewuerfelt1 = new System.Windows.Forms.Label();
            this.tbxgewuerfelt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAnzahl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(13, 13);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(173, 17);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Zufallszahlen von 1 bis 10";
            // 
            // tbxGewuerfelt
            // 
            this.tbxGewuerfelt.Location = new System.Drawing.Point(245, 129);
            this.tbxGewuerfelt.Name = "tbxGewuerfelt";
            this.tbxGewuerfelt.Size = new System.Drawing.Size(39, 22);
            this.tbxGewuerfelt.TabIndex = 1;
            // 
            // btnWuerfeln
            // 
            this.btnWuerfeln.Location = new System.Drawing.Point(33, 61);
            this.btnWuerfeln.Name = "btnWuerfeln";
            this.btnWuerfeln.Size = new System.Drawing.Size(89, 34);
            this.btnWuerfeln.TabIndex = 2;
            this.btnWuerfeln.Text = "Würfeln";
            this.btnWuerfeln.UseVisualStyleBackColor = true;
            this.btnWuerfeln.Click += new System.EventHandler(this.btnWuerfeln_Click);
            // 
            // lblgewuerfelt
            // 
            this.lblgewuerfelt.AutoSize = true;
            this.lblgewuerfelt.Location = new System.Drawing.Point(131, 132);
            this.lblgewuerfelt.Name = "lblgewuerfelt";
            this.lblgewuerfelt.Size = new System.Drawing.Size(108, 17);
            this.lblgewuerfelt.TabIndex = 3;
            this.lblgewuerfelt.Text = "Gewürfelte Zahl";
            // 
            // lblGewuerfelt1
            // 
            this.lblGewuerfelt1.AutoSize = true;
            this.lblGewuerfelt1.Location = new System.Drawing.Point(13, 171);
            this.lblGewuerfelt1.Name = "lblGewuerfelt1";
            this.lblGewuerfelt1.Size = new System.Drawing.Size(226, 17);
            this.lblGewuerfelt1.TabIndex = 4;
            this.lblGewuerfelt1.Text = "Wie oft muss gewürfelt werden, bis";
            // 
            // tbxgewuerfelt2
            // 
            this.tbxgewuerfelt2.Location = new System.Drawing.Point(245, 168);
            this.tbxgewuerfelt2.Name = "tbxgewuerfelt2";
            this.tbxgewuerfelt2.Size = new System.Drawing.Size(39, 22);
            this.tbxgewuerfelt2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "zum zweiten Mal gewürfelt wird ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Antwort";
            // 
            // tbxAnzahl
            // 
            this.tbxAnzahl.Location = new System.Drawing.Point(245, 208);
            this.tbxAnzahl.Name = "tbxAnzahl";
            this.tbxAnzahl.Size = new System.Drawing.Size(39, 22);
            this.tbxAnzahl.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "mal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxAnzahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxgewuerfelt2);
            this.Controls.Add(this.lblGewuerfelt1);
            this.Controls.Add(this.lblgewuerfelt);
            this.Controls.Add(this.btnWuerfeln);
            this.Controls.Add(this.tbxGewuerfelt);
            this.Controls.Add(this.lblTitel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox tbxGewuerfelt;
        private System.Windows.Forms.Button btnWuerfeln;
        private System.Windows.Forms.Label lblgewuerfelt;
        private System.Windows.Forms.Label lblGewuerfelt1;
        private System.Windows.Forms.TextBox tbxgewuerfelt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAnzahl;
        private System.Windows.Forms.Label label3;
    }
}

