namespace Worldskill2017Session1.View
{
    partial class Welcome
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblTry = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(19, 373);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 35);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Location = new System.Drawing.Point(19, 328);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(203, 35);
            this.btnChangePassword.TabIndex = 25;
            this.btnChangePassword.Text = "Cambiar  Contraseña";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTry.Location = new System.Drawing.Point(297, 328);
            this.lblTry.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(96, 21);
            this.lblTry.TabIndex = 24;
            this.lblTry.Text = "Intentos : 0";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblWelcome.Location = new System.Drawing.Point(135, 53);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(423, 213);
            this.lblWelcome.TabIndex = 23;
            this.lblWelcome.Text = "Mesaje bienvenida";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 416);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblTry);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.Label lblWelcome;
    }
}