namespace config_lesen
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
            this.tbxInfos = new System.Windows.Forms.TextBox();
            this.btnInfosAuslesen = new System.Windows.Forms.Button();
            this.lblZieldatei = new System.Windows.Forms.Label();
            this.tbxDateipfad = new System.Windows.Forms.TextBox();
            this.btnDateiSpeichern = new System.Windows.Forms.Button();
            this.btnDateiLesen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxInfos
            // 
            this.tbxInfos.Location = new System.Drawing.Point(16, 49);
            this.tbxInfos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxInfos.Multiline = true;
            this.tbxInfos.Name = "tbxInfos";
            this.tbxInfos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxInfos.Size = new System.Drawing.Size(507, 170);
            this.tbxInfos.TabIndex = 0;
            // 
            // btnInfosAuslesen
            // 
            this.btnInfosAuslesen.Location = new System.Drawing.Point(201, 14);
            this.btnInfosAuslesen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfosAuslesen.Name = "btnInfosAuslesen";
            this.btnInfosAuslesen.Size = new System.Drawing.Size(140, 28);
            this.btnInfosAuslesen.TabIndex = 1;
            this.btnInfosAuslesen.Text = "Infos sammeln";
            this.btnInfosAuslesen.UseVisualStyleBackColor = true;
            this.btnInfosAuslesen.Click += new System.EventHandler(this.btnInfosAuslesen_Click);
            // 
            // lblZieldatei
            // 
            this.lblZieldatei.AutoSize = true;
            this.lblZieldatei.Location = new System.Drawing.Point(147, 231);
            this.lblZieldatei.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZieldatei.Name = "lblZieldatei";
            this.lblZieldatei.Size = new System.Drawing.Size(45, 17);
            this.lblZieldatei.TabIndex = 3;
            this.lblZieldatei.Text = "Datei:";
            // 
            // tbxDateipfad
            // 
            this.tbxDateipfad.Location = new System.Drawing.Point(201, 228);
            this.tbxDateipfad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDateipfad.Name = "tbxDateipfad";
            this.tbxDateipfad.Size = new System.Drawing.Size(139, 22);
            this.tbxDateipfad.TabIndex = 4;
            // 
            // btnDateiSpeichern
            // 
            this.btnDateiSpeichern.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDateiSpeichern.Location = new System.Drawing.Point(333, 260);
            this.btnDateiSpeichern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDateiSpeichern.Name = "btnDateiSpeichern";
            this.btnDateiSpeichern.Size = new System.Drawing.Size(191, 28);
            this.btnDateiSpeichern.TabIndex = 5;
            this.btnDateiSpeichern.Text = "In Datei speichern";
            this.btnDateiSpeichern.UseVisualStyleBackColor = true;
            this.btnDateiSpeichern.Click += new System.EventHandler(this.btnDateiSpeichern_Click);
            // 
            // btnDateiLesen
            // 
            this.btnDateiLesen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDateiLesen.Location = new System.Drawing.Point(16, 260);
            this.btnDateiLesen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDateiLesen.Name = "btnDateiLesen";
            this.btnDateiLesen.Size = new System.Drawing.Size(191, 28);
            this.btnDateiLesen.TabIndex = 6;
            this.btnDateiLesen.Text = "Aus Datei lesen";
            this.btnDateiLesen.UseVisualStyleBackColor = true;
            this.btnDateiLesen.Click += new System.EventHandler(this.btnDateiLesen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 316);
            this.Controls.Add(this.btnDateiLesen);
            this.Controls.Add(this.btnDateiSpeichern);
            this.Controls.Add(this.tbxDateipfad);
            this.Controls.Add(this.lblZieldatei);
            this.Controls.Add(this.btnInfosAuslesen);
            this.Controls.Add(this.tbxInfos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Environment Informationen - Admin Version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInfos;
        private System.Windows.Forms.Button btnInfosAuslesen;
        private System.Windows.Forms.Label lblZieldatei;
        private System.Windows.Forms.TextBox tbxDateipfad;
        private System.Windows.Forms.Button btnDateiSpeichern;
        private System.Windows.Forms.Button btnDateiLesen;
    }
}

