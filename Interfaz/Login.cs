﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            txtusuario.Text = @"Nombre de Usuario";
            txtcontraseña.Text = "Contraseña";
            txtcontraseña.UseSystemPasswordChar = false;
        }




        // weas para que se vea bonito, para que se coloque la descripcion en el txtbox si no se ha rellenado
        private void txtUserEnter(object sender, EventArgs e)
        {
            if(txtusuario.Text.Equals(@"Nombre de Usuario"))
            {
                txtusuario.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtusuario.Text.Equals(""))
            {
                txtusuario.Text = @"Nombre de Usuario";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text.Equals("Contraseña"))
            {
                txtcontraseña.Text = "";
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text.Equals(""))
            {

                txtcontraseña.Text = "Contraseña";
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

    }
}
