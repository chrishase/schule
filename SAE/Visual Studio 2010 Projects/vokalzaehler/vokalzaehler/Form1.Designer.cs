namespace vokalzaehler
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
            this.tbxeingabe = new System.Windows.Forms.TextBox();
            this.tbxausgabe = new System.Windows.Forms.TextBox();
            this.btnzaehlen = new System.Windows.Forms.Button();
            this.btnloeschen = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxeingabe
            // 
            this.tbxeingabe.Location = new System.Drawing.Point(56, 53);
            this.tbxeingabe.Multiline = true;
            this.tbxeingabe.Name = "tbxeingabe";
            this.tbxeingabe.Size = new System.Drawing.Size(342, 68);
            this.tbxeingabe.TabIndex = 0;
            // 
            // tbxausgabe
            // 
            this.tbxausgabe.Location = new System.Drawing.Point(56, 171);
            this.tbxausgabe.Multiline = true;
            this.tbxausgabe.Name = "tbxausgabe";
            this.tbxausgabe.Size = new System.Drawing.Size(215, 207);
            this.tbxausgabe.TabIndex = 1;
            // 
            // btnzaehlen
            // 
            this.btnzaehlen.Location = new System.Drawing.Point(477, 53);
            this.btnzaehlen.Name = "btnzaehlen";
            this.btnzaehlen.Size = new System.Drawing.Size(112, 37);
            this.btnzaehlen.TabIndex = 2;
            this.btnzaehlen.Text = "Zählen";
            this.btnzaehlen.UseVisualStyleBackColor = true;
            this.btnzaehlen.Click += new System.EventHandler(this.btnzaehlen_Click);
            // 
            // btnloeschen
            // 
            this.btnloeschen.Location = new System.Drawing.Point(477, 171);
            this.btnloeschen.Name = "btnloeschen";
            this.btnloeschen.Size = new System.Drawing.Size(112, 39);
            this.btnloeschen.TabIndex = 3;
            this.btnloeschen.Text = "Löschen";
            this.btnloeschen.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(477, 312);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(112, 40);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Beenden";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 469);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnloeschen);
            this.Controls.Add(this.btnzaehlen);
            this.Controls.Add(this.tbxausgabe);
            this.Controls.Add(this.tbxeingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxeingabe;
        private System.Windows.Forms.TextBox tbxausgabe;
        private System.Windows.Forms.Button btnzaehlen;
        private System.Windows.Forms.Button btnloeschen;
        private System.Windows.Forms.Button btnexit;
    }
}

