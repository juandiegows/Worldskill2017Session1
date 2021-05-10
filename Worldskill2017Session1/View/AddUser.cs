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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillRole()
        {
            using (Model.Session1Entities model = new Model.Session1Entities())
            {
                List<Roles> role = model.Roles.ToList();
                cmbRol.DataSource = role;
                cmbRol.DisplayMember = "Title";
                cmbRol.ValueMember = "ID";
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == String.Empty)
                    {
                        MessageBox.Show("Debe llenar todos los datos");
                        return;
                    }
                    if (c is DateTimePicker)
                    {
                        if ((c as DateTimePicker).Value.Date == DateTime.Now.Date)
                        {
                            MessageBox.Show("selecione una fecha correcta");
                            return;
                        }
                    }
                }
            }
            using (Session1Entities model = new Session1Entities())
            {
                model.Users.Add(
                    new Users
                    {
                        Active = 1,
                        Birthdate = dtpBirthdayDate.Value,
                        Email = txtEmail.Text,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        OfficeID = 3,
                        Password = txtPassword.Text,
                        RoleID = 2
                    }
                    );
                if (model.SaveChanges() > 0)
                {
                    MessageBox.Show("Se ha guardado correctamente");

                }
                else
                {
                    MessageBox.Show("No se ha guardado correctamente");
                }
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            FillRole();

        }
    }
}
