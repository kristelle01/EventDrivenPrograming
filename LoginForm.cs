﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elemStudentInfo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide(); // Hides the login form
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            // Assuming 'TextBoxPassword' is your password field,
            // and 'showpass' is the checkbox.
            if (showpass.Checked)
            {
                password.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                password.UseSystemPasswordChar = true;  // Hide password
            }
        }

    }
}
