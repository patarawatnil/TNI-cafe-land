using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

       

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameBox.Text.Trim()) || string.IsNullOrEmpty(passwordBox.Text.Trim()))
            {
                MessageBox.Show(" INPUT YOUR INFORMATION AGAIN !!", "note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            if (usernameBox.Text.Trim() == Properties.Settings.Default.username && passwordBox.Text.Trim() == Properties.Settings.Default.password)
            {
                tni_cafe_land_main_menu Menu = new tni_cafe_land_main_menu();
                Menu.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Please input your User and Passwordagain. . .", "note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            REGIS register = new REGIS();
            register.Show();
        }

        private void usernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                if ((e.KeyChar < 97 || e.KeyChar > 122))
                {
                    if (e.KeyChar < 65 || e.KeyChar > 90)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                if ((e.KeyChar < 97 || e.KeyChar > 122))
                {
                    if (e.KeyChar < 65 || e.KeyChar > 90)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
