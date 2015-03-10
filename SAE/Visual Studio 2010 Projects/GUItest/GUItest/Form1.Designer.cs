namespace GUItest
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
            this.btnHello = new System.Windows.Forms.Button();
            this.Auslesen = new System.Windows.Forms.Button();
            this.tbxEingabe = new System.Windows.Forms.TextBox();
            this.lblKopie = new System.Windows.Forms.Label();
            this.Löschen = new System.Windows.Forms.Button();
            this.Beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(185, 130);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(85, 38);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Say Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_click);
            // 
            // Auslesen
            // 
            this.Auslesen.Location = new System.Drawing.Point(185, 45);
            this.Auslesen.Name = "Auslesen";
            this.Auslesen.Size = new System.Drawing.Size(85, 38);
            this.Auslesen.TabIndex = 1;
            this.Auslesen.Text = "Auslesen";
            this.Auslesen.UseVisualStyleBackColor = true;
            this.Auslesen.Click += new System.EventHandler(this.Auslesen_Click);
            // 
            // tbxEingabe
            // 
            this.tbxEingabe.BackColor = System.Drawing.SystemColors.Window;
            this.tbxEingabe.Location = new System.Drawing.Point(37, 179);
            this.tbxEingabe.Name = "tbxEingabe";
            this.tbxEingabe.Size = new System.Drawing.Size(128, 22);
            this.tbxEingabe.TabIndex = 2;
            // 
            // lblKopie
            // 
            this.lblKopie.AutoSize = true;
            this.lblKopie.Location = new System.Drawing.Point(37, 150);
            this.lblKopie.Name = "lblKopie";
            this.lblKopie.Size = new System.Drawing.Size(46, 17);
            this.lblKopie.TabIndex = 3;
            this.lblKopie.Text = "label1";
            // 
            // Löschen
            // 
            this.Löschen.Location = new System.Drawing.Point(36, 28);
            this.Löschen.Name = "Löschen";
            this.Löschen.Size = new System.Drawing.Size(75, 23);
            this.Löschen.TabIndex = 4;
            this.Löschen.Text = "Löschen";
            this.Löschen.UseVisualStyleBackColor = true;
            this.Löschen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Beenden
            // 
            this.Beenden.Location = new System.Drawing.Point(36, 75);
            this.Beenden.Name = "Beenden";
            this.Beenden.Size = new System.Drawing.Size(75, 23);
            this.Beenden.TabIndex = 5;
            this.Beenden.Text = "Beenden";
            this.Beenden.UseVisualStyleBackColor = true;
            this.Beenden.Click += new System.EventHandler(this.Beenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.Beenden);
            this.Controls.Add(this.Löschen);
            this.Controls.Add(this.lblKopie);
            this.Controls.Add(this.tbxEingabe);
            this.Controls.Add(this.Auslesen);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button Auslesen;
        private System.Windows.Forms.TextBox tbxEingabe;
        private System.Windows.Forms.Label lblKopie;
        private System.Windows.Forms.Button Löschen;
        private System.Windows.Forms.Button Beenden;
    }
}

