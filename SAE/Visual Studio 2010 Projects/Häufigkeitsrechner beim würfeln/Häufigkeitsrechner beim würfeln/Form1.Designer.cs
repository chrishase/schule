namespace Häufigkeitsrechner_beim_würfeln
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
            this.lblgewuenscht = new System.Windows.Forms.Label();
            this.lblanzahl = new System.Windows.Forms.Label();
            this.lblHaeufigkeit = new System.Windows.Forms.Label();
            this.tbxeingabe = new System.Windows.Forms.TextBox();
            this.lblanzahl2 = new System.Windows.Forms.Label();
            this.lblhaeufigkeit2 = new System.Windows.Forms.Label();
            this.btnwuerfeln = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgewuenscht
            // 
            this.lblgewuenscht.AutoSize = true;
            this.lblgewuenscht.Location = new System.Drawing.Point(50, 55);
            this.lblgewuenscht.Name = "lblgewuenscht";
            this.lblgewuenscht.Size = new System.Drawing.Size(159, 17);
            this.lblgewuenscht.TabIndex = 0;
            this.lblgewuenscht.Text = "gewünschte Anzahl 6er:";
            // 
            // lblanzahl
            // 
            this.lblanzahl.AutoSize = true;
            this.lblanzahl.Location = new System.Drawing.Point(21, 106);
            this.lblanzahl.Name = "lblanzahl";
            this.lblanzahl.Size = new System.Drawing.Size(188, 17);
            this.lblanzahl.TabIndex = 1;
            this.lblanzahl.Text = "benötigte Anzahl an Würfen:";
            // 
            // lblHaeufigkeit
            // 
            this.lblHaeufigkeit.AutoSize = true;
            this.lblHaeufigkeit.Location = new System.Drawing.Point(53, 160);
            this.lblHaeufigkeit.Name = "lblHaeufigkeit";
            this.lblHaeufigkeit.Size = new System.Drawing.Size(156, 17);
            this.lblHaeufigkeit.TabIndex = 2;
            this.lblHaeufigkeit.Text = "relative Häufigkeit in %:";
            // 
            // tbxeingabe
            // 
            this.tbxeingabe.Location = new System.Drawing.Point(234, 52);
            this.tbxeingabe.Name = "tbxeingabe";
            this.tbxeingabe.Size = new System.Drawing.Size(66, 22);
            this.tbxeingabe.TabIndex = 3;
            // 
            // lblanzahl2
            // 
            this.lblanzahl2.AutoSize = true;
            this.lblanzahl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblanzahl2.Location = new System.Drawing.Point(234, 106);
            this.lblanzahl2.MaximumSize = new System.Drawing.Size(40, 20);
            this.lblanzahl2.MinimumSize = new System.Drawing.Size(40, 20);
            this.lblanzahl2.Name = "lblanzahl2";
            this.lblanzahl2.Size = new System.Drawing.Size(40, 20);
            this.lblanzahl2.TabIndex = 4;
            // 
            // lblhaeufigkeit2
            // 
            this.lblhaeufigkeit2.AutoSize = true;
            this.lblhaeufigkeit2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblhaeufigkeit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblhaeufigkeit2.Location = new System.Drawing.Point(234, 160);
            this.lblhaeufigkeit2.MinimumSize = new System.Drawing.Size(40, 0);
            this.lblhaeufigkeit2.Name = "lblhaeufigkeit2";
            this.lblhaeufigkeit2.Size = new System.Drawing.Size(40, 19);
            this.lblhaeufigkeit2.TabIndex = 5;
            // 
            // btnwuerfeln
            // 
            this.btnwuerfeln.Location = new System.Drawing.Point(234, 223);
            this.btnwuerfeln.Name = "btnwuerfeln";
            this.btnwuerfeln.Size = new System.Drawing.Size(82, 37);
            this.btnwuerfeln.TabIndex = 6;
            this.btnwuerfeln.Text = "Würfeln";
            this.btnwuerfeln.UseVisualStyleBackColor = true;
            this.btnwuerfeln.Click += new System.EventHandler(this.btnwuerfeln_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 287);
            this.Controls.Add(this.btnwuerfeln);
            this.Controls.Add(this.lblhaeufigkeit2);
            this.Controls.Add(this.lblanzahl2);
            this.Controls.Add(this.tbxeingabe);
            this.Controls.Add(this.lblHaeufigkeit);
            this.Controls.Add(this.lblanzahl);
            this.Controls.Add(this.lblgewuenscht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgewuenscht;
        private System.Windows.Forms.Label lblanzahl;
        private System.Windows.Forms.Label lblHaeufigkeit;
        private System.Windows.Forms.TextBox tbxeingabe;
        private System.Windows.Forms.Label lblanzahl2;
        private System.Windows.Forms.Label lblhaeufigkeit2;
        private System.Windows.Forms.Button btnwuerfeln;
    }
}

