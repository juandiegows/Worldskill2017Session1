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
using Worldskill2017Session1.ViewClass;

namespace Worldskill2017Session1.View
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillUserTable()
        {
            using (Model.Session1Entities modelo = new Model.Session1Entities())
            {
                int.TryParse(cmbOffices.SelectedValue.ToString(), out int id);
                List<UserView> usuariosList = modelo.Users.Where(u => u.OfficeID == id || id == 0).ToList().Select(u => new UserView
                {
                    ID = u.ID,
                    Nombre = u.FirstName,
                    Apellido = u.LastName,
                    Correo = u.Email,
                    Edad = DateTime.Now.Year - u.Birthdate.Value.Year,
                    Rol = u.Roles.Title,
                    Oficina = u.Offices.Title,
                    Activo = (int)u.Active

                }).ToList();
                tableUser.DataSource = usuariosList;
                tableUser.Columns[0].Visible = false;
                tableUser.Columns[7].Visible = false;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form formA = new AddUser{ StartPosition = FormStartPosition.CenterScreen };
            this.Enabled = false;
            formA.Show();
            formA.FormClosed += (object s, FormClosedEventArgs e1) =>
            {
                this.Enabled = true;
                FillUserTable();
            };
        }
        private void FillOfficesCombobox()
        {
            using (Model.Session1Entities modelo = new Model.Session1Entities())
            {
                List<Offices> offices = modelo.Offices.ToList();
                offices.Insert(0, new Offices { Title = "Todas", ID = 0 });
                cmbOffices.DataSource = offices;
                cmbOffices.DisplayMember = "Title";
                cmbOffices.ValueMember = "ID";
            }

        }
        private void Admin_Load(object sender, EventArgs e)
        {
            FillOfficesCombobox();
            FillUserTable();
        }
    }
}
