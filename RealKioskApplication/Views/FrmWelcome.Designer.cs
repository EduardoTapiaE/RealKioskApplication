namespace RealKioskApplication.Views
{
    partial class FrmWelcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlWelcome = new System.Windows.Forms.Panel();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.PnlWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlWelcome
            // 
            this.PnlWelcome.Controls.Add(this.LblWelcome);
            this.PnlWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlWelcome.Location = new System.Drawing.Point(0, 0);
            this.PnlWelcome.Name = "PnlWelcome";
            this.PnlWelcome.Size = new System.Drawing.Size(705, 512);
            this.PnlWelcome.TabIndex = 0;
            this.PnlWelcome.Click += new System.EventHandler(this.PnlWelcome_Click);
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.Color.MediumBlue;
            this.LblWelcome.Location = new System.Drawing.Point(106, 219);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(477, 40);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Toque la pantalla para iniciar";
            this.LblWelcome.Click += new System.EventHandler(this.LblWelcome_Click);
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 512);
            this.Controls.Add(this.PnlWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.PnlWelcome.ResumeLayout(false);
            this.PnlWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlWelcome;
        private System.Windows.Forms.Label LblWelcome;
    }
}