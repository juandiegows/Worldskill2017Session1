using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worldskill2017Session1.Model;

namespace Worldskill2017Session1.View
{
    public partial class ChangePassword : Form
    {
        private Users User { set; get; }
        public ChangePassword(Users u)
        {
            InitializeComponent();
            User = u;
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            String OldPassword = txtOldPassword.Text;
            String NewPassword = txtNewPassword.Text;
            String ReConfirme = txtConfirm.Text;
            if ( OldPassword != User.Password)
            {
                MessageBox.Show("La contraseña anterior no coincide");
                return;

            }

            if (NewPassword != ReConfirme)
            {
                MessageBox.Show("La contraseña nueva con coincide con la confirmación");
                return;
            }


            using (Session1Entities modelo = new Session1Entities())
            {
                Users users = modelo.Users.FirstOrDefault(u => u.ID == User.ID);
                users.Password = NewPassword;
                modelo.Entry(users).State = System.Data.Entity.EntityState.Modified;
                if (modelo.SaveChanges() > 0)
                {
                    MessageBox.Show("Se ha cambiado al contraseña");
                }
                else
                {
                    MessageBox.Show("NO Se ha cambiado al contraseña");
                }
            }
        }
    }
}
