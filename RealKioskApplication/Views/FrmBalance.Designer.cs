namespace RealKioskApplication.Views
{
    partial class FrmBalance
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
            this.BtnPagar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.LblCuenta = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblDeuda = new System.Windows.Forms.Label();
            this.TxtCuenta = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtDeuda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackColor = System.Drawing.Color.Green;
            this.BtnPagar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPagar.Location = new System.Drawing.Point(542, 410);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(112, 44);
            this.BtnPagar.TabIndex = 25;
            this.BtnPagar.Text = "Pagar >";
            this.BtnPagar.UseVisualStyleBackColor = false;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.Red;
            this.BtnVolver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnVolver.Location = new System.Drawing.Point(57, 410);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(112, 44);
            this.BtnVolver.TabIndex = 24;
            this.BtnVolver.Text = "< Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // LblCuenta
            // 
            this.LblCuenta.AutoSize = true;
            this.LblCuenta.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuenta.ForeColor = System.Drawing.Color.Black;
            this.LblCuenta.Location = new System.Drawing.Point(305, 48);
            this.LblCuenta.Name = "LblCuenta";
            this.LblCuenta.Size = new System.Drawing.Size(102, 30);
            this.LblCuenta.TabIndex = 26;
            this.LblCuenta.Text = "Cuenta";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.Black;
            this.LblUsuario.Location = new System.Drawing.Point(302, 149);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(113, 30);
            this.LblUsuario.TabIndex = 27;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblDeuda
            // 
            this.LblDeuda.AutoSize = true;
            this.LblDeuda.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeuda.ForeColor = System.Drawing.Color.Black;
            this.LblDeuda.Location = new System.Drawing.Point(310, 253);
            this.LblDeuda.Name = "LblDeuda";
            this.LblDeuda.Size = new System.Drawing.Size(95, 30);
            this.LblDeuda.TabIndex = 28;
            this.LblDeuda.Text = "Deuda";
            // 
            // TxtCuenta
            // 
            this.TxtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuenta.ForeColor = System.Drawing.Color.MediumBlue;
            this.TxtCuenta.Location = new System.Drawing.Point(211, 92);
            this.TxtCuenta.Name = "TxtCuenta";
            this.TxtCuenta.Size = new System.Drawing.Size(294, 22);
            this.TxtCuenta.TabIndex = 29;
            this.TxtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.MediumBlue;
            this.TxtUsuario.Location = new System.Drawing.Point(211, 195);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(294, 22);
            this.TxtUsuario.TabIndex = 30;
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDeuda
            // 
            this.TxtDeuda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDeuda.ForeColor = System.Drawing.Color.MediumBlue;
            this.TxtDeuda.Location = new System.Drawing.Point(211, 300);
            this.TxtDeuda.Name = "TxtDeuda";
            this.TxtDeuda.Size = new System.Drawing.Size(294, 22);
            this.TxtDeuda.TabIndex = 31;
            this.TxtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 512);
            this.Controls.Add(this.TxtDeuda);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtCuenta);
            this.Controls.Add(this.LblDeuda);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblCuenta);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.BtnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBalance_FormClosed);
            this.Load += new System.EventHandler(this.FrmBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label LblCuenta;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblDeuda;
        private System.Windows.Forms.TextBox TxtCuenta;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtDeuda;
    }
}