using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu_selection : Form
    {
        double total_product = 0;
        double price = 0;

        public Menu_selection()
        {
            InitializeComponent();
            total_selected_menu.Text = total_product.ToString("n") + " บาท";
            product_price.Text = price.ToString()+" บาท";
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void coffee_selected()
        {
            comboBox2.Items.Add("Espresso");
            comboBox2.Items.Add("Americano");
            comboBox2.Items.Add("Latte");
            comboBox2.Items.Add("Cappuccino");
            comboBox2.Items.Add("Mocha");
        }//เพิ่มกาแแฟ

        private void tea_selected()
        {
            comboBox2.Items.Add("ชาเขียว");
            comboBox2.Items.Add("ชาดำ");
            comboBox2.Items.Add("ชานม");
            comboBox2.Items.Add("ชาเขียวนมสด");
            comboBox2.Items.Add("ชามะนาว");
        }//เพิ่มชา

        private void milk_selected()
        {
            comboBox2.Items.Add("นมสด");
            comboBox2.Items.Add("นมถั่วเหลือง");

        }//เพิ่มนม

        private void chocolate_selected()
        {
            comboBox2.Items.Add("ช็อกโกแลต");
            comboBox2.Items.Add("นมช็อกโกแลต");

        }//เพิ่มช็อกโกแลต

        private void snack_selected()
        {
            comboBox2.Items.Add("แซนด์วิช");
            comboBox2.Items.Add("คุกกี้");
            comboBox2.Items.Add("วาฟเฟิล");
            comboBox2.Items.Add("เค้ก");

        }//เพิ่มอาหารว่าง

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            total_product = 0;
            total_selected_menu.Text = total_product.ToString("n") + " บาท";
            price = 0;
            product_price.Text = price.ToString() + " บาท";
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            number_product.Value = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                coffee_selected();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                tea_selected();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                milk_selected();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                chocolate_selected();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                snack_selected();
            }
        }//ให้เราเลือกประเภทอาหารก่อนจะเลือกอย่างอื่นและเมื่อเลือกใหม่เมนูก็จะเปลี่ยนไปตามประเภทอาหาร

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            total_product = 0;
            total_selected_menu.Text = total_product.ToString("n") + " บาท";
            price = 0;
            product_price.Text = price.ToString() + " บาท";
            comboBox3.Items.Clear();
            number_product.Value = 0;
            if (check_item_1(comboBox2.SelectedItem.ToString()))
            {
                comboBox3.Items.Add("ร้อน");
                comboBox3.Items.Add("เย็น");
                comboBox3.Items.Add("ปั่น");
            }
            else if (check_item_2(comboBox2.SelectedItem.ToString()))
            {
                comboBox3.Items.Add("ร้อน");
                comboBox3.Items.Add("เย็น");
            }
            else//กรณีเลือกอาหารว่าง_in_case_selected_snack
            {
                if (comboBox2.SelectedItem.ToString().Equals("แซนด์วิช"))
                {
                    price = 20;
                }
                else if (comboBox2.SelectedItem.ToString().Equals("คุกกี้"))
                {
                    price = 25;
                }
                else if (comboBox2.SelectedItem.ToString().Equals("วาฟเฟิล"))
                {
                    price = 30;
                }
                else if (comboBox2.SelectedItem.ToString().Equals("เค้ก"))
                {
                    price = 40;
                }
                product_price.Text = price.ToString() + " บาท";

            }
        }//เลือกเมนูที่ต้องการ

        private bool check_item_1(string item)//ตรวจรายการมีแบบร้อน,เย็น,ปั่น_in_case_selected_menu_that_has_hot,cold,frappe
        {
            if (item.Equals("Espresso")||item.Equals("Americano")||item.Equals("Latte")||
                item.Equals("Cappuccino") || item.Equals("Mocha") || item.Equals("ชานม") ||
                item.Equals("ชาเขียวนมสด") || item.Equals("ชามะนาว") || item.Equals("นมสด") ||
                item.Equals("นมถั่วเหลือง") || item.Equals("ช็อกโกแลต") || item.Equals("นมช็อกโกแลต"))
            {
                return true;
            }
            return false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            number_product.Value = 0;
            if (comboBox3.SelectedItem.ToString().Equals("ร้อน"))
            {
                price = 15;
            }
            else if (comboBox3.SelectedItem.ToString().Equals("เย็น"))
            {
                price = 20;
            }
            else if (comboBox3.SelectedItem.ToString().Equals("ปั่น"))
            {
                price = 25;
            }

            product_price.Text = price.ToString() + " บาท";
        }//เลือกรูปแบบอาหาร(ถ้ามี)

        private void number_product_ValueChanged(object sender, EventArgs e)
        {
            total_product = price * Convert.ToDouble(number_product.Value);
            total_selected_menu.Text = total_product.ToString("n") + " บาท";
        }//สั่งจำนวนที่ต้องการ

        private void confirm_selected_menu_button_Click(object sender, EventArgs e)
        {
            if (total_product == 0)
            {
                MessageBox.Show("กรุณาเลือกรายการอาหารและระบุจำนวนให้เรียบร้อยก่อนดำเนินการต่อไป");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
               
            }
            
            /*เมื่อกดยืนยันก็จะตรวจว่ารายการถูกต้องไหมถ้าถูกก็จะนำรายการอาหาร(+รูปแบบ)
             ,จำนวน,ราคารวมลงไปใน selected_menu_list ใน Form1*/
        }//จะยืนยันได้ก็ต่อเมื่อสั่งทุกอย่างเรียบร้อย(รวม!=0)

        private bool check_item_2(string item)//ตรวจรายการมีแบบร้อน,เย็น_in_case_selected_menu_that_has_hot,cold
        {
            if (item.Equals("ชาเขียว") || item.Equals("ชาดำ"))
            {
                return true;
            }
            return false;
        }

        public string add_selected_menu()
        {
            string item = comboBox2.SelectedItem.ToString();
            if (comboBox3.Items.Count > 0)
            {
                item += " (" + comboBox3.SelectedItem.ToString() + ")";
            }
            item += " * " + number_product.Value.ToString() + " ==> " + total_product.ToString("n") + " บาท";
            return item;
        }//ส่งค่าเมนูที่เลือกให้ selected_menu_list ใน Form1

        public double add_price()
        {
            return total_product;
        }//ส่งราคาไปรวมให้ total_price ใน Form1 ไปคำนวณ

        private void total_selected_menu_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Menu_selection_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void product_price_Click(object sender, EventArgs e)
        {

        }
    }
}
