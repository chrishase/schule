namespace Zahlenkette
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
            this.lblStart = new System.Windows.Forms.Label();
            this.lblStop = new System.Windows.Forms.Label();
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.tbxStop = new System.Windows.Forms.TextBox();
            this.btnAusrechnen = new System.Windows.Forms.Button();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(105, 70);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(38, 17);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start";
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(233, 70);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(37, 17);
            this.lblStop.TabIndex = 1;
            this.lblStop.Text = "Stop";
            // 
            // tbxStart
            // 
            this.tbxStart.Location = new System.Drawing.Point(108, 120);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(35, 22);
            this.tbxStart.TabIndex = 2;
            // 
            // tbxStop
            // 
            this.tbxStop.Location = new System.Drawing.Point(236, 120);
            this.tbxStop.Name = "tbxStop";
            this.tbxStop.Size = new System.Drawing.Size(34, 22);
            this.tbxStop.TabIndex = 3;
            // 
            // btnAusrechnen
            // 
            this.btnAusrechnen.Location = new System.Drawing.Point(144, 213);
            this.btnAusrechnen.Name = "btnAusrechnen";
            this.btnAusrechnen.Size = new System.Drawing.Size(93, 31);
            this.btnAusrechnen.TabIndex = 4;
            this.btnAusrechnen.Text = "Ausrechnen";
            this.btnAusrechnen.UseVisualStyleBackColor = true;
            this.btnAusrechnen.Click += new System.EventHandler(this.btnAusrechnen_Click);
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAusgabe.Location = new System.Drawing.Point(105, 181);
            this.lblAusgabe.MaximumSize = new System.Drawing.Size(180, 0);
            this.lblAusgabe.MinimumSize = new System.Drawing.Size(180, 0);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(180, 19);
            this.lblAusgabe.TabIndex = 5;
            this.lblAusgabe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 306);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.btnAusrechnen);
            this.Controls.Add(this.tbxStop);
            this.Controls.Add(this.tbxStart);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.lblStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.TextBox tbxStop;
        private System.Windows.Forms.Button btnAusrechnen;
        private System.Windows.Forms.Label lblAusgabe;
    }
}

