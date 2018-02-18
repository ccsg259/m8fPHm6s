using capaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encuestas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuarios Us = new Usuarios();
            Us.usrLogin(this.txtUsuario.Text, this.txtPass.Text);
            if ( Us.IdUnico == null || Us.IdUnico == "")
                MessageBox.Show("Usuario no registrado");
            else
            {
                // Iniciar el programa.
                this.Hide();
                new frmGeneradorEncuestas().Show();
            }
        }
    }
}
