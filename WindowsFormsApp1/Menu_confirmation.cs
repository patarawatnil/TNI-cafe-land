using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu_confirmation : Form
    {
        public double total,discountp;

        public Menu_confirmation()
        {
            InitializeComponent();
        }

        private void Menu_confirmation_Load(object sender, EventArgs e)
        {
            label3.Text="ส่วนลดสมาชิก("+discountp.ToString()+"%)";

            total_price_text.Text = total.ToString("n") + " บาท";
            double discount = total * discountp / 100;
            discount_text.Text = discount.ToString("n") + " บาท";
            total -= discount;
            total_net_text.Text = total.ToString("n") + " บาท";

        }

        private void confirm_Click(object sender, EventArgs e)
        {
         
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
