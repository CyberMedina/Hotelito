﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BancoSangre.Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string contraseña;
        private void buttonIniciar_Click(object sender, EventArgs e)
        {
           
                string user = txtUser.Text;
                string password = txtPassword.Text;
                string DiscoLocal = "C:\\Base de datos Hotel\\" + user + ".txt";

                if (File.Exists(DiscoLocal))
                {
                    contraseña = File.ReadAllText(DiscoLocal);
                    if (password.Equals(contraseña))
                    {
                        Form1 obj = new Form1();
                        this.Hide();
                        obj.Show();
                        MessageBox.Show("Ha entrado exitosamente al Sistema!");
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta");
                    }

                }
                else
                {
                    MessageBox.Show("No se reconoce al Usuario");
                }
            
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            picuser.BackgroundImage = Properties.Resources.UsuarioCeleste;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtUser.ForeColor = Color.FromArgb(78, 184, 206);

            picpass.BackgroundImage = Properties.Resources.LlaveCeleste;
            panel2.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
           
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
            picpass.BackgroundImage = Properties.Resources.LlaveBlanca;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            picuser.BackgroundImage = Properties.Resources.UsuarioBlanco;
            panel1.BackColor = Color.WhiteSmoke;
            txtUser.ForeColor = Color.WhiteSmoke;
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Click_1(object sender, EventArgs e)
        {
            txtUser.Clear();
            picuser.BackgroundImage = Properties.Resources.UsuarioCeleste;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtUser.ForeColor = Color.FromArgb(78, 184, 206);

            picpass.BackgroundImage = Properties.Resources.LlaveCeleste;
            panel2.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
        }
    }
}
