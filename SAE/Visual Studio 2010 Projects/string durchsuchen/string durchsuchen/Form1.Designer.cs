namespace string_durchsuchen
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
            this.tbxtext = new System.Windows.Forms.TextBox();
            this.tbxchar = new System.Windows.Forms.TextBox();
            this.lblstring = new System.Windows.Forms.Label();
            this.lblchar = new System.Windows.Forms.Label();
            this.btnsuchen = new System.Windows.Forms.Button();
            this.btnbeenden = new System.Windows.Forms.Button();
            this.lblmenge = new System.Windows.Forms.Label();
            this.tbxanzahl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxtext
            // 
            this.tbxtext.Location = new System.Drawing.Point(157, 43);
            this.tbxtext.Name = "tbxtext";
            this.tbxtext.Size = new System.Drawing.Size(100, 22);
            this.tbxtext.TabIndex = 0;
            // 
            // tbxchar
            // 
            this.tbxchar.Location = new System.Drawing.Point(157, 83);
            this.tbxchar.Name = "tbxchar";
            this.tbxchar.Size = new System.Drawing.Size(100, 22);
            this.tbxchar.TabIndex = 1;
            // 
            // lblstring
            // 
            this.lblstring.AutoSize = true;
            this.lblstring.Location = new System.Drawing.Point(88, 46);
            this.lblstring.Name = "lblstring";
            this.lblstring.Size = new System.Drawing.Size(45, 17);
            this.lblstring.TabIndex = 2;
            this.lblstring.Text = "String";
            // 
            // lblchar
            // 
            this.lblchar.AutoSize = true;
            this.lblchar.Location = new System.Drawing.Point(63, 86);
            this.lblchar.Name = "lblchar";
            this.lblchar.Size = new System.Drawing.Size(70, 17);
            this.lblchar.TabIndex = 3;
            this.lblchar.Text = "Character";
            // 
            // btnsuchen
            // 
            this.btnsuchen.Location = new System.Drawing.Point(310, 43);
            this.btnsuchen.Name = "btnsuchen";
            this.btnsuchen.Size = new System.Drawing.Size(129, 23);
            this.btnsuchen.TabIndex = 4;
            this.btnsuchen.Text = "Zeichen suchen";
            this.btnsuchen.UseVisualStyleBackColor = true;
            this.btnsuchen.Click += new System.EventHandler(this.btnsuchen_Click);
            // 
            // btnbeenden
            // 
            this.btnbeenden.Location = new System.Drawing.Point(310, 83);
            this.btnbeenden.Name = "btnbeenden";
            this.btnbeenden.Size = new System.Drawing.Size(129, 23);
            this.btnbeenden.TabIndex = 5;
            this.btnbeenden.Text = "Beenden";
            this.btnbeenden.UseVisualStyleBackColor = true;
            this.btnbeenden.Click += new System.EventHandler(this.btnbeenden_Click);
            // 
            // lblmenge
            // 
            this.lblmenge.AutoSize = true;
            this.lblmenge.Location = new System.Drawing.Point(82, 124);
            this.lblmenge.Name = "lblmenge";
            this.lblmenge.Size = new System.Drawing.Size(51, 17);
            this.lblmenge.TabIndex = 6;
            this.lblmenge.Text = "Anzahl";
            // 
            // tbxanzahl
            // 
            this.tbxanzahl.Location = new System.Drawing.Point(157, 121);
            this.tbxanzahl.Name = "tbxanzahl";
            this.tbxanzahl.ReadOnly = true;
            this.tbxanzahl.Size = new System.Drawing.Size(100, 22);
            this.tbxanzahl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 237);
            this.Controls.Add(this.tbxanzahl);
            this.Controls.Add(this.lblmenge);
            this.Controls.Add(this.btnbeenden);
            this.Controls.Add(this.btnsuchen);
            this.Controls.Add(this.lblchar);
            this.Controls.Add(this.lblstring);
            this.Controls.Add(this.tbxchar);
            this.Controls.Add(this.tbxtext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxtext;
        private System.Windows.Forms.TextBox tbxchar;
        private System.Windows.Forms.Label lblstring;
        private System.Windows.Forms.Label lblchar;
        private System.Windows.Forms.Button btnsuchen;
        private System.Windows.Forms.Button btnbeenden;
        private System.Windows.Forms.Label lblmenge;
        private System.Windows.Forms.TextBox tbxanzahl;
    }
}

