namespace Notenrechner
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
            this.btnBedeutung = new System.Windows.Forms.Button();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBedeutung
            // 
            this.btnBedeutung.Location = new System.Drawing.Point(205, 294);
            this.btnBedeutung.Name = "btnBedeutung";
            this.btnBedeutung.Size = new System.Drawing.Size(111, 41);
            this.btnBedeutung.TabIndex = 0;
            this.btnBedeutung.Text = "Bedeutung";
            this.btnBedeutung.UseVisualStyleBackColor = true;
            this.btnBedeutung.Click += new System.EventHandler(this.btnBedeutung_Click);
            // 
            // tbxNote
            // 
            this.tbxNote.Location = new System.Drawing.Point(244, 53);
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.Size = new System.Drawing.Size(24, 22);
            this.tbxNote.TabIndex = 1;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(12, 78);
            this.lblNote.MaximumSize = new System.Drawing.Size(500, 200);
            this.lblNote.MinimumSize = new System.Drawing.Size(500, 200);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(500, 200);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "---";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 431);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.tbxNote);
            this.Controls.Add(this.btnBedeutung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBedeutung;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.Label lblNote;
    }
}

