namespace rechner
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
            this.btnaddieren = new System.Windows.Forms.Button();
            this.btnquadrat = new System.Windows.Forms.Button();
            this.btnmultipliziren = new System.Windows.Forms.Button();
            this.btnpotenz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaddieren
            // 
            this.btnaddieren.Location = new System.Drawing.Point(425, 35);
            this.btnaddieren.Name = "btnaddieren";
            this.btnaddieren.Size = new System.Drawing.Size(110, 43);
            this.btnaddieren.TabIndex = 0;
            this.btnaddieren.Text = "Addieren";
            this.btnaddieren.UseVisualStyleBackColor = true;
            // 
            // btnquadrat
            // 
            this.btnquadrat.Location = new System.Drawing.Point(425, 102);
            this.btnquadrat.Name = "btnquadrat";
            this.btnquadrat.Size = new System.Drawing.Size(110, 43);
            this.btnquadrat.TabIndex = 1;
            this.btnquadrat.Text = "Quadrat";
            this.btnquadrat.UseVisualStyleBackColor = true;
            // 
            // btnmultipliziren
            // 
            this.btnmultipliziren.Location = new System.Drawing.Point(560, 35);
            this.btnmultipliziren.Name = "btnmultipliziren";
            this.btnmultipliziren.Size = new System.Drawing.Size(110, 43);
            this.btnmultipliziren.TabIndex = 2;
            this.btnmultipliziren.Text = "Multiplizieren";
            this.btnmultipliziren.UseVisualStyleBackColor = true;
            // 
            // btnpotenz
            // 
            this.btnpotenz.Location = new System.Drawing.Point(560, 102);
            this.btnpotenz.Name = "btnpotenz";
            this.btnpotenz.Size = new System.Drawing.Size(110, 43);
            this.btnpotenz.TabIndex = 3;
            this.btnpotenz.Text = "Potenz";
            this.btnpotenz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 367);
            this.Controls.Add(this.btnpotenz);
            this.Controls.Add(this.btnmultipliziren);
            this.Controls.Add(this.btnquadrat);
            this.Controls.Add(this.btnaddieren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaddieren;
        private System.Windows.Forms.Button btnquadrat;
        private System.Windows.Forms.Button btnmultipliziren;
        private System.Windows.Forms.Button btnpotenz;
    }
}

