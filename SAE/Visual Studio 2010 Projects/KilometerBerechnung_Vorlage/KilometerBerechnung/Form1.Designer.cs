namespace KilometerBerechnung
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxKilometer = new System.Windows.Forms.TextBox();
            this.tbxAnzFahrten = new System.Windows.Forms.TextBox();
            this.tbxFahrten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDurchschnittkilometer = new System.Windows.Forms.TextBox();
            this.btnKMEinlesen = new System.Windows.Forms.Button();
            this.btnDurchBerechnen = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eingabe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auswertung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kilometer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Anzahl Fahrten:";
            // 
            // tbxKilometer
            // 
            this.tbxKilometer.Location = new System.Drawing.Point(187, 94);
            this.tbxKilometer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxKilometer.Name = "tbxKilometer";
            this.tbxKilometer.Size = new System.Drawing.Size(132, 22);
            this.tbxKilometer.TabIndex = 4;
            this.tbxKilometer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAnzFahrten
            // 
            this.tbxAnzFahrten.Enabled = false;
            this.tbxAnzFahrten.Location = new System.Drawing.Point(187, 137);
            this.tbxAnzFahrten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxAnzFahrten.Name = "tbxAnzFahrten";
            this.tbxAnzFahrten.ReadOnly = true;
            this.tbxAnzFahrten.Size = new System.Drawing.Size(132, 22);
            this.tbxAnzFahrten.TabIndex = 5;
            this.tbxAnzFahrten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxFahrten
            // 
            this.tbxFahrten.Location = new System.Drawing.Point(51, 199);
            this.tbxFahrten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxFahrten.Multiline = true;
            this.tbxFahrten.Name = "tbxFahrten";
            this.tbxFahrten.Size = new System.Drawing.Size(267, 173);
            this.tbxFahrten.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Durchschnittkilometer:";
            // 
            // tbxDurchschnittkilometer
            // 
            this.tbxDurchschnittkilometer.Enabled = false;
            this.tbxDurchschnittkilometer.Location = new System.Drawing.Point(457, 137);
            this.tbxDurchschnittkilometer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDurchschnittkilometer.Name = "tbxDurchschnittkilometer";
            this.tbxDurchschnittkilometer.ReadOnly = true;
            this.tbxDurchschnittkilometer.Size = new System.Drawing.Size(144, 22);
            this.tbxDurchschnittkilometer.TabIndex = 8;
            this.tbxDurchschnittkilometer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKMEinlesen
            // 
            this.btnKMEinlesen.Location = new System.Drawing.Point(457, 222);
            this.btnKMEinlesen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKMEinlesen.Name = "btnKMEinlesen";
            this.btnKMEinlesen.Size = new System.Drawing.Size(145, 28);
            this.btnKMEinlesen.TabIndex = 9;
            this.btnKMEinlesen.Text = "Kilometer einlesen";
            this.btnKMEinlesen.UseVisualStyleBackColor = true;
            this.btnKMEinlesen.Click += new System.EventHandler(this.btnKMEinlesen_Click);
            // 
            // btnDurchBerechnen
            // 
            this.btnDurchBerechnen.Location = new System.Drawing.Point(457, 281);
            this.btnDurchBerechnen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDurchBerechnen.Name = "btnDurchBerechnen";
            this.btnDurchBerechnen.Size = new System.Drawing.Size(145, 28);
            this.btnDurchBerechnen.TabIndex = 10;
            this.btnDurchBerechnen.Text = "Durchschnitt";
            this.btnDurchBerechnen.UseVisualStyleBackColor = true;
            this.btnDurchBerechnen.Click += new System.EventHandler(this.btnDurchBerechnen_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(457, 345);
            this.btnBeenden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(145, 28);
            this.btnBeenden.TabIndex = 11;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 416);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnDurchBerechnen);
            this.Controls.Add(this.btnKMEinlesen);
            this.Controls.Add(this.tbxDurchschnittkilometer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxFahrten);
            this.Controls.Add(this.tbxAnzFahrten);
            this.Controls.Add(this.tbxKilometer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kilometerberechnung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxKilometer;
        private System.Windows.Forms.TextBox tbxAnzFahrten;
        private System.Windows.Forms.TextBox tbxFahrten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDurchschnittkilometer;
        private System.Windows.Forms.Button btnKMEinlesen;
        private System.Windows.Forms.Button btnDurchBerechnen;
        private System.Windows.Forms.Button btnBeenden;
    }
}

