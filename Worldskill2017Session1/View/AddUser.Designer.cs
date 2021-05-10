namespace Worldskill2017Session1.View
{
    partial class AddUser
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.dtpBirthdayDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthdayDate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitleAddUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(378, 306);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 31);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(233, 306);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(121, 31);
            this.btnAddUser.TabIndex = 48;
            this.btnAddUser.Text = "Agregar";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(387, 250);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(327, 29);
            this.cmbRol.TabIndex = 47;
            // 
            // lblRol
            // 
            this.lblRol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(383, 222);
            this.lblRol.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 21);
            this.lblRol.TabIndex = 46;
            this.lblRol.Text = "Rol";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Location = new System.Drawing.Point(387, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(327, 27);
            this.txtPassword.TabIndex = 45;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(387, 151);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 21);
            this.lblPassword.TabIndex = 44;
            this.lblPassword.Text = "Contraseña";
            // 
            // dtpBirthdayDate
            // 
            this.dtpBirthdayDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBirthdayDate.Location = new System.Drawing.Point(391, 111);
            this.dtpBirthdayDate.Name = "dtpBirthdayDate";
            this.dtpBirthdayDate.Size = new System.Drawing.Size(323, 27);
            this.dtpBirthdayDate.TabIndex = 43;
            // 
            // lblBirthdayDate
            // 
            this.lblBirthdayDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBirthdayDate.AutoSize = true;
            this.lblBirthdayDate.Location = new System.Drawing.Point(387, 83);
            this.lblBirthdayDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBirthdayDate.Name = "lblBirthdayDate";
            this.lblBirthdayDate.Size = new System.Drawing.Size(177, 21);
            this.lblBirthdayDate.TabIndex = 42;
            this.lblBirthdayDate.Text = "Fecha de nacimiento";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLastName.Location = new System.Drawing.Point(17, 250);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(337, 27);
            this.txtLastName.TabIndex = 41;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(17, 222);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 21);
            this.lblLastName.TabIndex = 40;
            this.lblLastName.Text = "Apellidos";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFirstName.Location = new System.Drawing.Point(17, 179);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(337, 27);
            this.txtFirstName.TabIndex = 39;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 151);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 21);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "Nombres";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(17, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 27);
            this.txtEmail.TabIndex = 37;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 83);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 21);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Correo";
            // 
            // lblTitleAddUser
            // 
            this.lblTitleAddUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitleAddUser.AutoSize = true;
            this.lblTitleAddUser.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblTitleAddUser.Location = new System.Drawing.Point(241, 22);
            this.lblTitleAddUser.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitleAddUser.Name = "lblTitleAddUser";
            this.lblTitleAddUser.Size = new System.Drawing.Size(268, 39);
            this.lblTitleAddUser.TabIndex = 35;
            this.lblTitleAddUser.Text = "Agregar Usuario";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 345);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.dtpBirthdayDate);
            this.Controls.Add(this.lblBirthdayDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitleAddUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.DateTimePicker dtpBirthdayDate;
        private System.Windows.Forms.Label lblBirthdayDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTitleAddUser;
    }
}