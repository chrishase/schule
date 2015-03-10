namespace modulo_übung
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
            this.btnausrechnen = new System.Windows.Forms.Button();
            this.lbldividend = new System.Windows.Forms.Label();
            this.lbldivisor = new System.Windows.Forms.Label();
            this.lblquotient = new System.Windows.Forms.Label();
            this.lblrest = new System.Windows.Forms.Label();
            this.tbxdividend = new System.Windows.Forms.TextBox();
            this.tbxdivisor = new System.Windows.Forms.TextBox();
            this.tbxquotient = new System.Windows.Forms.TextBox();
            this.tbxrest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnausrechnen
            // 
            this.btnausrechnen.Location = new System.Drawing.Point(206, 191);
            this.btnausrechnen.Name = "btnausrechnen";
            this.btnausrechnen.Size = new System.Drawing.Size(88, 23);
            this.btnausrechnen.TabIndex = 0;
            this.btnausrechnen.Text = "Berechnen";
            this.btnausrechnen.UseVisualStyleBackColor = true;
            this.btnausrechnen.Click += new System.EventHandler(this.btnausrechnen_Click);
            // 
            // lbldividend
            // 
            this.lbldividend.AutoSize = true;
            this.lbldividend.Location = new System.Drawing.Point(37, 33);
            this.lbldividend.Name = "lbldividend";
            this.lbldividend.Size = new System.Drawing.Size(63, 17);
            this.lbldividend.TabIndex = 1;
            this.lbldividend.Text = "Dividend";
            // 
            // lbldivisor
            // 
            this.lbldivisor.AutoSize = true;
            this.lbldivisor.Location = new System.Drawing.Point(37, 70);
            this.lbldivisor.Name = "lbldivisor";
            this.lbldivisor.Size = new System.Drawing.Size(51, 17);
            this.lbldivisor.TabIndex = 2;
            this.lbldivisor.Text = "Divisor";
            // 
            // lblquotient
            // 
            this.lblquotient.AutoSize = true;
            this.lblquotient.Location = new System.Drawing.Point(37, 109);
            this.lblquotient.Name = "lblquotient";
            this.lblquotient.Size = new System.Drawing.Size(150, 17);
            this.lblquotient.TabIndex = 3;
            this.lblquotient.Text = "Ganzzahliger Quotient";
            // 
            // lblrest
            // 
            this.lblrest.AutoSize = true;
            this.lblrest.Location = new System.Drawing.Point(37, 147);
            this.lblrest.Name = "lblrest";
            this.lblrest.Size = new System.Drawing.Size(125, 17);
            this.lblrest.TabIndex = 4;
            this.lblrest.Text = "Ganzzahliger Rest";
            // 
            // tbxdividend
            // 
            this.tbxdividend.Location = new System.Drawing.Point(206, 30);
            this.tbxdividend.Name = "tbxdividend";
            this.tbxdividend.Size = new System.Drawing.Size(69, 22);
            this.tbxdividend.TabIndex = 5;
            // 
            // tbxdivisor
            // 
            this.tbxdivisor.Location = new System.Drawing.Point(206, 67);
            this.tbxdivisor.Name = "tbxdivisor";
            this.tbxdivisor.Size = new System.Drawing.Size(69, 22);
            this.tbxdivisor.TabIndex = 6;
            // 
            // tbxquotient
            // 
            this.tbxquotient.Location = new System.Drawing.Point(206, 106);
            this.tbxquotient.Name = "tbxquotient";
            this.tbxquotient.Size = new System.Drawing.Size(69, 22);
            this.tbxquotient.TabIndex = 7;
            // 
            // tbxrest
            // 
            this.tbxrest.Location = new System.Drawing.Point(206, 144);
            this.tbxrest.Name = "tbxrest";
            this.tbxrest.Size = new System.Drawing.Size(69, 22);
            this.tbxrest.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 232);
            this.Controls.Add(this.tbxrest);
            this.Controls.Add(this.tbxquotient);
            this.Controls.Add(this.tbxdivisor);
            this.Controls.Add(this.tbxdividend);
            this.Controls.Add(this.lblrest);
            this.Controls.Add(this.lblquotient);
            this.Controls.Add(this.lbldivisor);
            this.Controls.Add(this.lbldividend);
            this.Controls.Add(this.btnausrechnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnausrechnen;
        private System.Windows.Forms.Label lbldividend;
        private System.Windows.Forms.Label lbldivisor;
        private System.Windows.Forms.Label lblquotient;
        private System.Windows.Forms.Label lblrest;
        private System.Windows.Forms.TextBox tbxdividend;
        private System.Windows.Forms.TextBox tbxdivisor;
        private System.Windows.Forms.TextBox tbxquotient;
        private System.Windows.Forms.TextBox tbxrest;
    }
}

