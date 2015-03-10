namespace lottorechner
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
            this.btnerzeugen = new System.Windows.Forms.Button();
            this.lbllottozahlen = new System.Windows.Forms.Label();
            this.gbxerzeugt = new System.Windows.Forms.GroupBox();
            this.gbxeigenezahlen = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxzahl1 = new System.Windows.Forms.TextBox();
            this.tbxzahl5 = new System.Windows.Forms.TextBox();
            this.tbxzahl4 = new System.Windows.Forms.TextBox();
            this.tbxzahl6 = new System.Windows.Forms.TextBox();
            this.tbxzahl3 = new System.Windows.Forms.TextBox();
            this.tbxzahl2 = new System.Windows.Forms.TextBox();
            this.btnauswerten = new System.Windows.Forms.Button();
            this.tbxrichtige = new System.Windows.Forms.TextBox();
            this.btnloeschen = new System.Windows.Forms.Button();
            this.btnbeenden = new System.Windows.Forms.Button();
            this.gbxerzeugt.SuspendLayout();
            this.gbxeigenezahlen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnerzeugen
            // 
            this.btnerzeugen.Location = new System.Drawing.Point(305, 30);
            this.btnerzeugen.Name = "btnerzeugen";
            this.btnerzeugen.Size = new System.Drawing.Size(108, 28);
            this.btnerzeugen.TabIndex = 0;
            this.btnerzeugen.Text = "Erzeugen";
            this.btnerzeugen.UseVisualStyleBackColor = true;
            this.btnerzeugen.Click += new System.EventHandler(this.btnerzeugen_Click);
            // 
            // lbllottozahlen
            // 
            this.lbllottozahlen.AutoSize = true;
            this.lbllottozahlen.Location = new System.Drawing.Point(22, 36);
            this.lbllottozahlen.MinimumSize = new System.Drawing.Size(150, 10);
            this.lbllottozahlen.Name = "lbllottozahlen";
            this.lbllottozahlen.Size = new System.Drawing.Size(150, 20);
            this.lbllottozahlen.TabIndex = 1;
            // 
            // gbxerzeugt
            // 
            this.gbxerzeugt.Controls.Add(this.lbllottozahlen);
            this.gbxerzeugt.Controls.Add(this.btnerzeugen);
            this.gbxerzeugt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxerzeugt.Location = new System.Drawing.Point(12, 12);
            this.gbxerzeugt.Name = "gbxerzeugt";
            this.gbxerzeugt.Size = new System.Drawing.Size(432, 83);
            this.gbxerzeugt.TabIndex = 2;
            this.gbxerzeugt.TabStop = false;
            this.gbxerzeugt.Text = "Erzeugte Lottozahlen";
            // 
            // gbxeigenezahlen
            // 
            this.gbxeigenezahlen.Controls.Add(this.btnbeenden);
            this.gbxeigenezahlen.Controls.Add(this.btnloeschen);
            this.gbxeigenezahlen.Controls.Add(this.tbxrichtige);
            this.gbxeigenezahlen.Controls.Add(this.btnauswerten);
            this.gbxeigenezahlen.Controls.Add(this.tbxzahl2);
            this.gbxeigenezahlen.Controls.Add(this.tbxzahl3);
            this.gbxeigenezahlen.Controls.Add(this.tbxzahl6);
            this.gbxeigenezahlen.Controls.Add(this.tbxzahl4);
            this.gbxeigenezahlen.Controls.Add(this.tbxzahl5);
            this.gbxeigenezahlen.Controls.Add(this.tbxzahl1);
            this.gbxeigenezahlen.Controls.Add(this.label6);
            this.gbxeigenezahlen.Controls.Add(this.label5);
            this.gbxeigenezahlen.Controls.Add(this.label4);
            this.gbxeigenezahlen.Controls.Add(this.label3);
            this.gbxeigenezahlen.Controls.Add(this.label2);
            this.gbxeigenezahlen.Controls.Add(this.lbl1);
            this.gbxeigenezahlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxeigenezahlen.Location = new System.Drawing.Point(12, 115);
            this.gbxeigenezahlen.Name = "gbxeigenezahlen";
            this.gbxeigenezahlen.Size = new System.Drawing.Size(484, 250);
            this.gbxeigenezahlen.TabIndex = 3;
            this.gbxeigenezahlen.TabStop = false;
            this.gbxeigenezahlen.Text = "Gewinnzahlen";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(38, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(19, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "2";
            // 
            // tbxzahl1
            // 
            this.tbxzahl1.Location = new System.Drawing.Point(72, 39);
            this.tbxzahl1.Name = "tbxzahl1";
            this.tbxzahl1.Size = new System.Drawing.Size(100, 27);
            this.tbxzahl1.TabIndex = 6;
            // 
            // tbxzahl5
            // 
            this.tbxzahl5.Location = new System.Drawing.Point(72, 172);
            this.tbxzahl5.Name = "tbxzahl5";
            this.tbxzahl5.Size = new System.Drawing.Size(100, 27);
            this.tbxzahl5.TabIndex = 7;
            // 
            // tbxzahl4
            // 
            this.tbxzahl4.Location = new System.Drawing.Point(72, 139);
            this.tbxzahl4.Name = "tbxzahl4";
            this.tbxzahl4.Size = new System.Drawing.Size(100, 27);
            this.tbxzahl4.TabIndex = 8;
            // 
            // tbxzahl6
            // 
            this.tbxzahl6.Location = new System.Drawing.Point(72, 205);
            this.tbxzahl6.Name = "tbxzahl6";
            this.tbxzahl6.Size = new System.Drawing.Size(100, 27);
            this.tbxzahl6.TabIndex = 9;
            // 
            // tbxzahl3
            // 
            this.tbxzahl3.Location = new System.Drawing.Point(72, 106);
            this.tbxzahl3.Name = "tbxzahl3";
            this.tbxzahl3.Size = new System.Drawing.Size(100, 27);
            this.tbxzahl3.TabIndex = 10;
            // 
            // tbxzahl2
            // 
            this.tbxzahl2.Location = new System.Drawing.Point(72, 72);
            this.tbxzahl2.Name = "tbxzahl2";
            this.tbxzahl2.Size = new System.Drawing.Size(100, 27);
            this.tbxzahl2.TabIndex = 11;
            // 
            // btnauswerten
            // 
            this.btnauswerten.Location = new System.Drawing.Point(265, 36);
            this.btnauswerten.Name = "btnauswerten";
            this.btnauswerten.Size = new System.Drawing.Size(180, 33);
            this.btnauswerten.TabIndex = 12;
            this.btnauswerten.Text = "Zahlen auswerten";
            this.btnauswerten.UseVisualStyleBackColor = true;
            this.btnauswerten.Click += new System.EventHandler(this.btnauswerten_Click);
            // 
            // tbxrichtige
            // 
            this.tbxrichtige.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxrichtige.Location = new System.Drawing.Point(265, 102);
            this.tbxrichtige.Name = "tbxrichtige";
            this.tbxrichtige.Size = new System.Drawing.Size(180, 27);
            this.tbxrichtige.TabIndex = 13;
            // 
            // btnloeschen
            // 
            this.btnloeschen.Location = new System.Drawing.Point(265, 154);
            this.btnloeschen.Name = "btnloeschen";
            this.btnloeschen.Size = new System.Drawing.Size(180, 28);
            this.btnloeschen.TabIndex = 14;
            this.btnloeschen.Text = "Löschen";
            this.btnloeschen.UseVisualStyleBackColor = true;
            this.btnloeschen.Click += new System.EventHandler(this.btnloeschen_Click);
            // 
            // btnbeenden
            // 
            this.btnbeenden.Location = new System.Drawing.Point(265, 205);
            this.btnbeenden.Name = "btnbeenden";
            this.btnbeenden.Size = new System.Drawing.Size(180, 26);
            this.btnbeenden.TabIndex = 15;
            this.btnbeenden.Text = "Beenden";
            this.btnbeenden.UseVisualStyleBackColor = true;
            this.btnbeenden.Click += new System.EventHandler(this.btnbeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 384);
            this.Controls.Add(this.gbxeigenezahlen);
            this.Controls.Add(this.gbxerzeugt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxerzeugt.ResumeLayout(false);
            this.gbxerzeugt.PerformLayout();
            this.gbxeigenezahlen.ResumeLayout(false);
            this.gbxeigenezahlen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnerzeugen;
        private System.Windows.Forms.Label lbllottozahlen;
        private System.Windows.Forms.GroupBox gbxerzeugt;
        private System.Windows.Forms.GroupBox gbxeigenezahlen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tbxzahl2;
        private System.Windows.Forms.TextBox tbxzahl3;
        private System.Windows.Forms.TextBox tbxzahl6;
        private System.Windows.Forms.TextBox tbxzahl4;
        private System.Windows.Forms.TextBox tbxzahl5;
        private System.Windows.Forms.TextBox tbxzahl1;
        private System.Windows.Forms.Button btnbeenden;
        private System.Windows.Forms.Button btnloeschen;
        private System.Windows.Forms.TextBox tbxrichtige;
        private System.Windows.Forms.Button btnauswerten;
    }
}

