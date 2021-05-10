namespace Worldskill2017Session1
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.linkShowHide = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(34, 281);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(306, 42);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "Usuario";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // linkShowHide
            // 
            this.linkShowHide.AutoSize = true;
            this.linkShowHide.Location = new System.Drawing.Point(245, 213);
            this.linkShowHide.Name = "linkShowHide";
            this.linkShowHide.Size = new System.Drawing.Size(69, 21);
            this.linkShowHide.TabIndex = 16;
            this.linkShowHide.TabStop = true;
            this.linkShowHide.Text = "Mostrar";
            this.linkShowHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowHide_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(195, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(50, 247);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(266, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 151);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 21);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(50, 111);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(266, 27);
            this.txtUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label2.Location = new System.Drawing.Point(138, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Login";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(50, 83);
            this.lblUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(66, 21);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 330);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.linkShowHide);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.LinkLabel linkShowHide;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUser;
    }
}

