namespace Notenverwaltung
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
            this.lblneuenote = new System.Windows.Forms.Label();
            this.lblanzahl = new System.Windows.Forms.Label();
            this.tbxeingabe = new System.Windows.Forms.TextBox();
            this.tbxanzahl = new System.Windows.Forms.TextBox();
            this.btneinlesen = new System.Windows.Forms.Button();
            this.btndurchschnitt = new System.Windows.Forms.Button();
            this.btnminmax = new System.Windows.Forms.Button();
            this.btnbeenden = new System.Windows.Forms.Button();
            this.lbldurchschnitt = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.tbxdurchschnitt = new System.Windows.Forms.TextBox();
            this.tbxmin = new System.Windows.Forms.TextBox();
            this.tbxmax = new System.Windows.Forms.TextBox();
            this.lbltitel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblneuenote
            // 
            this.lblneuenote.AutoSize = true;
            this.lblneuenote.Location = new System.Drawing.Point(50, 59);
            this.lblneuenote.Name = "lblneuenote";
            this.lblneuenote.Size = new System.Drawing.Size(76, 17);
            this.lblneuenote.TabIndex = 0;
            this.lblneuenote.Text = "Neue Note";
            // 
            // lblanzahl
            // 
            this.lblanzahl.AutoSize = true;
            this.lblanzahl.Location = new System.Drawing.Point(75, 92);
            this.lblanzahl.Name = "lblanzahl";
            this.lblanzahl.Size = new System.Drawing.Size(51, 17);
            this.lblanzahl.TabIndex = 1;
            this.lblanzahl.Text = "Anzahl";
            // 
            // tbxeingabe
            // 
            this.tbxeingabe.Location = new System.Drawing.Point(143, 56);
            this.tbxeingabe.Name = "tbxeingabe";
            this.tbxeingabe.Size = new System.Drawing.Size(100, 22);
            this.tbxeingabe.TabIndex = 2;
            // 
            // tbxanzahl
            // 
            this.tbxanzahl.Location = new System.Drawing.Point(143, 92);
            this.tbxanzahl.Name = "tbxanzahl";
            this.tbxanzahl.ReadOnly = true;
            this.tbxanzahl.Size = new System.Drawing.Size(100, 22);
            this.tbxanzahl.TabIndex = 3;
            // 
            // btneinlesen
            // 
            this.btneinlesen.Location = new System.Drawing.Point(286, 49);
            this.btneinlesen.Name = "btneinlesen";
            this.btneinlesen.Size = new System.Drawing.Size(116, 29);
            this.btneinlesen.TabIndex = 4;
            this.btneinlesen.Text = "Noten einlesen";
            this.btneinlesen.UseVisualStyleBackColor = true;
            this.btneinlesen.Click += new System.EventHandler(this.btneinlesen_Click);
            // 
            // btndurchschnitt
            // 
            this.btndurchschnitt.Location = new System.Drawing.Point(286, 137);
            this.btndurchschnitt.Name = "btndurchschnitt";
            this.btndurchschnitt.Size = new System.Drawing.Size(116, 37);
            this.btndurchschnitt.TabIndex = 5;
            this.btndurchschnitt.Text = "Durchschnitt";
            this.btndurchschnitt.UseVisualStyleBackColor = true;
            this.btndurchschnitt.Click += new System.EventHandler(this.btndurchschnitt_Click);
            // 
            // btnminmax
            // 
            this.btnminmax.Location = new System.Drawing.Point(275, 186);
            this.btnminmax.Name = "btnminmax";
            this.btnminmax.Size = new System.Drawing.Size(141, 45);
            this.btnminmax.TabIndex = 6;
            this.btnminmax.Text = "Beste/Schlechteste Note";
            this.btnminmax.UseVisualStyleBackColor = true;
            this.btnminmax.Click += new System.EventHandler(this.btnminmax_Click);
            // 
            // btnbeenden
            // 
            this.btnbeenden.Location = new System.Drawing.Point(286, 86);
            this.btnbeenden.Name = "btnbeenden";
            this.btnbeenden.Size = new System.Drawing.Size(116, 28);
            this.btnbeenden.TabIndex = 7;
            this.btnbeenden.Text = "Beenden";
            this.btnbeenden.UseVisualStyleBackColor = true;
            this.btnbeenden.Click += new System.EventHandler(this.btnbeenden_Click);
            // 
            // lbldurchschnitt
            // 
            this.lbldurchschnitt.AutoSize = true;
            this.lbldurchschnitt.Location = new System.Drawing.Point(50, 147);
            this.lbldurchschnitt.Name = "lbldurchschnitt";
            this.lbldurchschnitt.Size = new System.Drawing.Size(87, 17);
            this.lbldurchschnitt.TabIndex = 8;
            this.lbldurchschnitt.Text = "Durchschnitt";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(57, 186);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(78, 17);
            this.lblmin.TabIndex = 9;
            this.lblmin.Text = "Beste Note";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Location = new System.Drawing.Point(12, 214);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(123, 17);
            this.lblmax.TabIndex = 10;
            this.lblmax.Text = "Schlechteste Note";
            // 
            // tbxdurchschnitt
            // 
            this.tbxdurchschnitt.Location = new System.Drawing.Point(143, 144);
            this.tbxdurchschnitt.Name = "tbxdurchschnitt";
            this.tbxdurchschnitt.ReadOnly = true;
            this.tbxdurchschnitt.Size = new System.Drawing.Size(100, 22);
            this.tbxdurchschnitt.TabIndex = 11;
            // 
            // tbxmin
            // 
            this.tbxmin.Location = new System.Drawing.Point(143, 183);
            this.tbxmin.Name = "tbxmin";
            this.tbxmin.ReadOnly = true;
            this.tbxmin.Size = new System.Drawing.Size(100, 22);
            this.tbxmin.TabIndex = 12;
            // 
            // tbxmax
            // 
            this.tbxmax.Location = new System.Drawing.Point(143, 211);
            this.tbxmax.Name = "tbxmax";
            this.tbxmax.ReadOnly = true;
            this.tbxmax.Size = new System.Drawing.Size(100, 22);
            this.tbxmax.TabIndex = 13;
            // 
            // lbltitel1
            // 
            this.lbltitel1.AutoSize = true;
            this.lbltitel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitel1.Location = new System.Drawing.Point(28, 18);
            this.lbltitel1.Name = "lbltitel1";
            this.lbltitel1.Size = new System.Drawing.Size(98, 25);
            this.lbltitel1.TabIndex = 14;
            this.lbltitel1.Text = "Eingabe:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 275);
            this.Controls.Add(this.lbltitel1);
            this.Controls.Add(this.tbxmax);
            this.Controls.Add(this.tbxmin);
            this.Controls.Add(this.tbxdurchschnitt);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.lbldurchschnitt);
            this.Controls.Add(this.btnbeenden);
            this.Controls.Add(this.btnminmax);
            this.Controls.Add(this.btndurchschnitt);
            this.Controls.Add(this.btneinlesen);
            this.Controls.Add(this.tbxanzahl);
            this.Controls.Add(this.tbxeingabe);
            this.Controls.Add(this.lblanzahl);
            this.Controls.Add(this.lblneuenote);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblneuenote;
        private System.Windows.Forms.Label lblanzahl;
        private System.Windows.Forms.TextBox tbxeingabe;
        private System.Windows.Forms.TextBox tbxanzahl;
        private System.Windows.Forms.Button btneinlesen;
        private System.Windows.Forms.Button btndurchschnitt;
        private System.Windows.Forms.Button btnminmax;
        private System.Windows.Forms.Button btnbeenden;
        private System.Windows.Forms.Label lbldurchschnitt;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.TextBox tbxdurchschnitt;
        private System.Windows.Forms.TextBox tbxmin;
        private System.Windows.Forms.TextBox tbxmax;
        private System.Windows.Forms.Label lbltitel1;
    }
}

