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
    public partial class Welcome : Form
    {
        public Users Usuario { get; set; }
        private int Intento { get; set; }
        public Welcome(Users u, int intento)
        {
            InitializeComponent();
            Usuario = u;
            Intento = intento;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
         
            lblWelcome.Text = $"Hola {Usuario.FirstName } { Usuario.LastName} Bienvenido al sistema de autentificación de amonic";
            lblTry.Text = $"numero de intentos fallido : {Intento}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Form formB = new ChangePassword (Usuario) { StartPosition = FormStartPosition.CenterScreen };
            this.Enabled = false;
            formB.Show();
            formB.FormClosed += (object s, FormClosedEventArgs e1) =>
            {
                this.Enabled = true;
            };
        }
    }
}
