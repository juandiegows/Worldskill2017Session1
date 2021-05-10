using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worldskill2017Session1.Model;
using Worldskill2017Session1.View;

namespace Worldskill2017Session1
{
    public partial class Login : Form
    {
        public int Intento { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string correo = txtUser.Text;
            String contraseña = txtPassword.Text;
            if (correo== String.Empty || contraseña == String.Empty)
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            using (Model.Session1Entities modelo = new Model.Session1Entities())
            {
                Users users = modelo.Users.FirstOrDefault(u => u.Email == correo && u.Password == contraseña);


                if (users != default(Users) && users.Active == 1)
                {
                    if (users.RoleID == 1)
                    {
                        Form formA = new Admin { StartPosition = FormStartPosition.CenterScreen };
                        this.Hide();
                        formA.Show();
                        formA.FormClosed += (object s, FormClosedEventArgs e1) =>
                        {
                            this.Show();
                        };
                    }
                    else
                    {
                        Form formB = new Welcome(users, Intento) { StartPosition = FormStartPosition.CenterScreen };
                        this.Hide();
                        formB.Show();
                        formB.FormClosed += (object s, FormClosedEventArgs e1) =>
                        {
                            this.Show();
                        };
                    }
                }
                else if (users == null)
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = "Su usuario o contraseña son incorrectos";
                    lblMessage.ForeColor = Color.Orange;
                    Intento++;
                    if (Intento == 3)
                    {
                        this.Enabled = false;
                        for (int i = 10; i >= 0; i--)
                        {
                            await Task.Run(() => { Thread.Sleep(1000); });
                            lblMessage.Text = $"Por favor, espero {i} segundo para intentar de nuevo";
                        }
                        lblMessage.Visible = false;
                        this.Enabled = true;
                    }
                }
                else if (users.Active == 0)
                {
                    lblMessage.Visible = true;
                    string usuarioBloquedor = "Sistema";
                    lblMessage.Text = $"Su usuario ha sido supendido por el { usuarioBloquedor }";
                    lblMessage.ForeColor = Color.Red;
                    return;


                }

            }


        }

        private void linkShowHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkShowHide.Text == "Mostrar")
            {
                linkShowHide.Text = "Ocultar";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {

                linkShowHide.Text = "Mostrar";
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    } 
}
