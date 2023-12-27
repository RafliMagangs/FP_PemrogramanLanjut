using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Login.Model.Context;
using Login.Model.Entity;
using System.Drawing.Text;
using Login.Controller;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class frmLogin : Form
    {
        private LoginController controller;
        public frmLogin()
        {
            InitializeComponent();
            //controller = new LoginRepository();
            controller = new LoginController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen kotak1 = new Pen(Color.FromArgb(255,255,255,255),2);
            e.Graphics.DrawRectangle(kotak1,10,10,600,400);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginController login = new LoginController();
            int result = login.Login_bo(txtUsername.Text, txtPassword.Text);  
            if(result > 0)
            {
                
                frmHome form2 = new frmHome();
                form2.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Username atau Password Salah !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Clear();
                txtPassword.Clear();
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
