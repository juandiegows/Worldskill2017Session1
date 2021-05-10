namespace Worldskill2017Session1.View
{
    partial class Admin
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
            this.btnChangeRole = new System.Windows.Forms.Button();
            this.btnResetAccount = new System.Windows.Forms.Button();
            this.btnSuspendAccount = new System.Windows.Forms.Button();
            this.tableUser = new System.Windows.Forms.DataGridView();
            this.cmbOffices = new System.Windows.Forms.ComboBox();
            this.lblOffices = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeRole
            // 
            this.btnChangeRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeRole.Location = new System.Drawing.Point(559, 412);
            this.btnChangeRole.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangeRole.Name = "btnChangeRole";
            this.btnChangeRole.Size = new System.Drawing.Size(203, 35);
            this.btnChangeRole.TabIndex = 40;
            this.btnChangeRole.Text = "Cambiar Rol";
            this.btnChangeRole.UseVisualStyleBackColor = true;
            this.btnChangeRole.Click += new System.EventHandler(this.btnChangeRole_Click);
            // 
            // btnResetAccount
            // 
            this.btnResetAccount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetAccount.Location = new System.Drawing.Point(290, 412);
            this.btnResetAccount.Margin = new System.Windows.Forms.Padding(5);
            this.btnResetAccount.Name = "btnResetAccount";
            this.btnResetAccount.Size = new System.Drawing.Size(203, 35);
            this.btnResetAccount.TabIndex = 39;
            this.btnResetAccount.Text = "Restablecer cuenta";
            this.btnResetAccount.UseVisualStyleBackColor = true;
            this.btnResetAccount.Click += new System.EventHandler(this.btnResetAccount_Click);
            // 
            // btnSuspendAccount
            // 
            this.btnSuspendAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuspendAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuspendAccount.Location = new System.Drawing.Point(21, 412);
            this.btnSuspendAccount.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuspendAccount.Name = "btnSuspendAccount";
            this.btnSuspendAccount.Size = new System.Drawing.Size(203, 35);
            this.btnSuspendAccount.TabIndex = 38;
            this.btnSuspendAccount.Text = "Suspender cuenta";
            this.btnSuspendAccount.UseVisualStyleBackColor = true;
            this.btnSuspendAccount.Click += new System.EventHandler(this.btnSuspendAccount_Click);
            // 
            // tableUser
            // 
            this.tableUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUser.Location = new System.Drawing.Point(21, 159);
            this.tableUser.Name = "tableUser";
            this.tableUser.Size = new System.Drawing.Size(742, 245);
            this.tableUser.TabIndex = 37;
            this.tableUser.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tableUser_CellFormatting);
            this.tableUser.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tableUser_DataBindingComplete);
            this.tableUser.Validating += new System.ComponentModel.CancelEventHandler(this.tableUser_Validating);
            // 
            // cmbOffices
            // 
            this.cmbOffices.FormattingEnabled = true;
            this.cmbOffices.Location = new System.Drawing.Point(21, 119);
            this.cmbOffices.Name = "cmbOffices";
            this.cmbOffices.Size = new System.Drawing.Size(229, 29);
            this.cmbOffices.TabIndex = 36;
            this.cmbOffices.SelectedIndexChanged += new System.EventHandler(this.cmbOffices_SelectedIndexChanged);
            // 
            // lblOffices
            // 
            this.lblOffices.AutoSize = true;
            this.lblOffices.Location = new System.Drawing.Point(17, 95);
            this.lblOffices.Name = "lblOffices";
            this.lblOffices.Size = new System.Drawing.Size(138, 21);
            this.lblOffices.TabIndex = 35;
            this.lblOffices.Text = "Filtrar por oficina";
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblAdmin.Location = new System.Drawing.Point(292, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(233, 39);
            this.lblAdmin.TabIndex = 34;
            this.lblAdmin.Text = "Administrador";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(624, 35);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 35);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(21, 35);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(203, 35);
            this.btnAddUser.TabIndex = 32;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 461);
            this.Controls.Add(this.btnChangeRole);
            this.Controls.Add(this.btnResetAccount);
            this.Controls.Add(this.btnSuspendAccount);
            this.Controls.Add(this.tableUser);
            this.Controls.Add(this.cmbOffices);
            this.Controls.Add(this.lblOffices);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeRole;
        private System.Windows.Forms.Button btnResetAccount;
        private System.Windows.Forms.Button btnSuspendAccount;
        private System.Windows.Forms.DataGridView tableUser;
        private System.Windows.Forms.ComboBox cmbOffices;
        private System.Windows.Forms.Label lblOffices;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddUser;
    }
}