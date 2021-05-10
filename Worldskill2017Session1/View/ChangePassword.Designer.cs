namespace Worldskill2017Session1.View
{
    partial class ChangePassword
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
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(23, 308);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(5);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(414, 27);
            this.txtConfirm.TabIndex = 27;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(23, 262);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(115, 21);
            this.lblConfirm.TabIndex = 26;
            this.lblConfirm.Text = "Confirmación";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(23, 220);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(414, 27);
            this.txtNewPassword.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(262, 367);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 32);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Location = new System.Drawing.Point(23, 367);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(175, 32);
            this.btnChangePassword.TabIndex = 23;
            this.btnChangePassword.Text = "Cambiar ";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(23, 174);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(160, 21);
            this.lblNewPassword.TabIndex = 22;
            this.lblNewPassword.Text = "Contraseña Nueva";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(23, 122);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(414, 27);
            this.txtOldPassword.TabIndex = 21;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblChangePassword.Location = new System.Drawing.Point(47, 9);
            this.lblChangePassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(375, 39);
            this.lblChangePassword.TabIndex = 20;
            this.lblChangePassword.Text = "Recuperar Contraseña";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(23, 76);
            this.lblOldPassword.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(172, 21);
            this.lblOldPassword.TabIndex = 19;
            this.lblOldPassword.Text = "Contraseña Antigua";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 415);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.lblOldPassword);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Label lblOldPassword;
    }
}