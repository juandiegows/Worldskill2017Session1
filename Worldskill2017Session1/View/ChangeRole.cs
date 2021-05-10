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
    public partial class ChangeRole : Form
    {

        private Users Usuario { get; set; }
        public ChangeRole()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FillRole()
        {
            using (Model.Session1Entities model = new Model.Session1Entities())
            {
                List<Roles> rol = model.Roles.ToList();
                cmbRole.DataSource = rol;
                cmbRole.DisplayMember = "Title";
                cmbRole.ValueMember = "ID";
            }
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            using (Session1Entities model = new Session1Entities())
            {
                Users users = model.Users.FirstOrDefault(u => u.ID == Usuario.ID);
                users.RoleID = (int)cmbRole.SelectedValue;
                model.Entry(users).State = System.Data.Entity.EntityState.Modified;
                if (model.SaveChanges() > 0)
                {
                    MessageBox.Show("Se ha actualizado el rol");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No Se ha actualizado el rol");
                }
            }
        }

        private void ChangeRole_Load(object sender, EventArgs e)
        {
            FillRole();
        }
    }
}
