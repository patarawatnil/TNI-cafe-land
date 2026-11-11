using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class REGIS : Form
    {
        public REGIS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = user.Text;
            string pass = this.pass.Text;
            string againpass = passagain.Text;
            if (pass != againpass)
            {
                MessageBox.Show("Plese input your pass again. . . ", "note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (string.IsNullOrEmpty(user.Text.Trim()))
            {
                MessageBox.Show("Please input your User again", "note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (string.IsNullOrEmpty(pass.Trim()) || string.IsNullOrEmpty(passagain.Text.Trim()))
            {
                MessageBox.Show("Please input your password again!!", "note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Properties.Settings.Default.username = user.Text.Trim();
            Properties.Settings.Default.password = pass.Trim();
            Properties.Settings.Default.Save();
            MessageBox.Show(" Successful Register ", "note", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            login regised = new login();
            regised.Show();
            this.Close();

        }
 
        private void user_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
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

        private void passagain_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
