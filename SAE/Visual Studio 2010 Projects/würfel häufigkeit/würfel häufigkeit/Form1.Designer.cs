namespace würfel_häufigkeit
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
            this.btnwuerfeln = new System.Windows.Forms.Button();
            this.lblgewuenscht = new System.Windows.Forms.Label();
            this.lblbenoetigt = new System.Windows.Forms.Label();
            this.lblhaeufigkeit = new System.Windows.Forms.Label();
            this.tbxgewuenscht = new System.Windows.Forms.TextBox();
            this.tbxbenoetigt = new System.Windows.Forms.TextBox();
            this.tbxhaeufigkeit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnwuerfeln
            // 
            this.btnwuerfeln.Location = new System.Drawing.Point(97, 170);
            this.btnwuerfeln.Name = "btnwuerfeln";
            this.btnwuerfeln.Size = new System.Drawing.Size(98, 31);
            this.btnwuerfeln.TabIndex = 0;
            this.btnwuerfeln.Text = "Würfeln";
            this.btnwuerfeln.UseVisualStyleBackColor = true;
            this.btnwuerfeln.Click += new System.EventHandler(this.btnwuerfeln_Click);
            // 
            // lblgewuenscht
            // 
            this.lblgewuenscht.AutoSize = true;
            this.lblgewuenscht.Location = new System.Drawing.Point(43, 43);
            this.lblgewuenscht.Name = "lblgewuenscht";
            this.lblgewuenscht.Size = new System.Drawing.Size(159, 17);
            this.lblgewuenscht.TabIndex = 1;
            this.lblgewuenscht.Text = "gewünschte Anzahl 6er:";
            // 
            // lblbenoetigt
            // 
            this.lblbenoetigt.AutoSize = true;
            this.lblbenoetigt.Location = new System.Drawing.Point(14, 78);
            this.lblbenoetigt.Name = "lblbenoetigt";
            this.lblbenoetigt.Size = new System.Drawing.Size(188, 17);
            this.lblbenoetigt.TabIndex = 2;
            this.lblbenoetigt.Text = "benötigte Anzahl an Würfen:";
            // 
            // lblhaeufigkeit
            // 
            this.lblhaeufigkeit.AutoSize = true;
            this.lblhaeufigkeit.Location = new System.Drawing.Point(46, 119);
            this.lblhaeufigkeit.Name = "lblhaeufigkeit";
            this.lblhaeufigkeit.Size = new System.Drawing.Size(156, 17);
            this.lblhaeufigkeit.TabIndex = 3;
            this.lblhaeufigkeit.Text = "relative Häufigkeit in %:";
            // 
            // tbxgewuenscht
            // 
            this.tbxgewuenscht.Location = new System.Drawing.Point(208, 40);
            this.tbxgewuenscht.Name = "tbxgewuenscht";
            this.tbxgewuenscht.Size = new System.Drawing.Size(65, 22);
            this.tbxgewuenscht.TabIndex = 4;
            // 
            // tbxbenoetigt
            // 
            this.tbxbenoetigt.Location = new System.Drawing.Point(208, 75);
            this.tbxbenoetigt.Name = "tbxbenoetigt";
            this.tbxbenoetigt.Size = new System.Drawing.Size(65, 22);
            this.tbxbenoetigt.TabIndex = 5;
            // 
            // tbxhaeufigkeit
            // 
            this.tbxhaeufigkeit.Location = new System.Drawing.Point(208, 116);
            this.tbxhaeufigkeit.Name = "tbxhaeufigkeit";
            this.tbxhaeufigkeit.Size = new System.Drawing.Size(65, 22);
            this.tbxhaeufigkeit.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 225);
            this.Controls.Add(this.tbxhaeufigkeit);
            this.Controls.Add(this.tbxbenoetigt);
            this.Controls.Add(this.tbxgewuenscht);
            this.Controls.Add(this.lblhaeufigkeit);
            this.Controls.Add(this.lblbenoetigt);
            this.Controls.Add(this.lblgewuenscht);
            this.Controls.Add(this.btnwuerfeln);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnwuerfeln;
        private System.Windows.Forms.Label lblgewuenscht;
        private System.Windows.Forms.Label lblbenoetigt;
        private System.Windows.Forms.Label lblhaeufigkeit;
        private System.Windows.Forms.TextBox tbxgewuenscht;
        private System.Windows.Forms.TextBox tbxbenoetigt;
        private System.Windows.Forms.TextBox tbxhaeufigkeit;
    }
}

