using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class tni_cafe_land_main_menu : Form
    {
        public double total_price = 0;
        double discount = 10;
        //string filename = "D:\\bill.txt";


        public tni_cafe_land_main_menu()
        {
            InitializeComponent();
            total_price_menu.Text = total_price.ToString("n") + " บาท";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TNI_Cafe_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_menu_Click(object sender, EventArgs e)
        {
            Menu_selection menuform = new Menu_selection();
            if (menuform.ShowDialog(this) == DialogResult.OK)
            {
                selected_menu_list.Items.Add(menuform.add_selected_menu());
                total_price += menuform.add_price();
                total_price_menu.Text = total_price.ToString("n") + " บาท";
            }
            menuform.Close();
            menuform.Dispose();
        }//เมื่อกดปุ่มแล้วก็จะแสดงหน้าต่างใหม่ให้เลือกสินค้า

        private void delete_menu_Click(object sender, EventArgs e)
        {
            if(selected_menu_list.SelectedItem!=null)
            {
                string[] data = selected_menu_list.SelectedItem.ToString().Split(' ');
                if (data.Length == 7)
                {
                    total_price -= double.Parse(data[5]);
                }
                else if (data.Length == 6)
                {
                    total_price -= double.Parse(data[4]);
                }
                total_price_menu.Text = total_price.ToString("n") + " บาท";
                selected_menu_list.Items.Remove(selected_menu_list.SelectedItem);
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ");
            }
        }//ลบรายการที่เลือก

        private void clear_menu_Click(object sender, EventArgs e)
        {
            selected_menu_list.Items.Clear();
            total_price = 0;
            total_price_menu.Text = total_price.ToString("n") + " บาท";
        }//ล้างรายการทั้งหมด

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void edit_seleted_Click(object sender, EventArgs e)
        {
            if (selected_menu_list.SelectedItem != null)
            {

                Menu_selection menuform = new Menu_selection();
                if (menuform.ShowDialog(this) == DialogResult.OK)
                {
                    total_price += menuform.add_price();
                    selected_menu_list.Items.Insert(selected_menu_list.SelectedIndex, menuform.add_selected_menu());
                    string[] data = selected_menu_list.SelectedItem.ToString().Split(' ');
                    if (data.Length == 7)
                    {
                        total_price -= double.Parse(data[5]);
                    }
                    else if (data.Length == 6)
                    {
                        total_price -= double.Parse(data[4]);
                    }
                    total_price_menu.Text = total_price.ToString("n") + " บาท";
                    selected_menu_list.Items.Remove(selected_menu_list.SelectedItem);

                }
                menuform.Close();
                menuform.Dispose();

            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข");
            }

        }//ปุ่มนี้จะลบรายการที่เลือกแล้วเปิดหน้าเลือกเมนู(เหมือนเอาปุ่มลบรายการ+เพิ่มรายการ)

        private void confirm_menu_Click(object sender, EventArgs e)
        {
            if (selected_menu_list.Items.Count == 0)
            {
                MessageBox.Show("ท่านยังไม่ได้เลือกรายการใด ๆ กรุณาเลือกรายการก่อนดำเนินการต่อ");
            }
            else
            {
                Menu_confirmation open = new Menu_confirmation();
                open.total = total_price;
                open.discountp = discount;
                if (open.ShowDialog(this) == DialogResult.OK)
                {
                    bill();
                    MessageBox.Show("ขอบคุณที่ใช้บริการ");

                    Application.Exit();
                }
                open.Close();
                open.Dispose();
            }
        }//ยืนยันรายการ

        public void bill()
        {
            
            DateTime dataCurrect = new DateTime();
            dataCurrect = DateTime.Now;
            string filename = "D:\\bill" + dataCurrect.ToString("yyyy_MM_dd HH_mm_ss_ff") + ".txt";
            string line = "==========================================";
            StreamWriter bill = new StreamWriter(filename);
            bill.WriteLine("\t\tTNI Cafe Land");
            bill.WriteLine(line);
            bill.WriteLine("ใบเสร็จรับเงิน\t{0}",dataCurrect.ToString("HH:mm:ss dd/mm/yyy"));
            bill.WriteLine(line);
            for (int i = 0; i < selected_menu_list.Items.Count; i++)
            {
                string[] data = selected_menu_list.Items[i].ToString().Split(' ');
                if (data.Length == 7)
                {
                    bill.WriteLine("{0,-18}{1,-9}\t{2,3}\t\t{3,9} บาท", data[0], data[1], data[3], data[5]);
                }
                else if (data.Length == 6)
                {
                    bill.WriteLine("{0,-27}\t{1,3}\t\t{2,9} บาท", data[0], data[2], data[4]);
                }
            }
            bill.WriteLine(line);
            bill.WriteLine("{0,-27}\t  \t\t{1,9:n} บาท", "ราคารวม", total_price);
            bill.WriteLine("{0,-27}\t  \t\t{1,9:n} บาท", "ส่วนลด", total_price * discount / 100);
            bill.WriteLine("{0,-27}\t  \t\t{1,9:n} บาท", "ราคาสุทธิ", total_price - total_price * 10 / 100);
            bill.WriteLine(line);
            bill.WriteLine("\t\tขอบคุณที่มาใช้บริการ");
            bill.WriteLine(line);
            bill.Close();
        }

        private void total_price_menu_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selected_menu_list.Items.Count != 0)
            {
                if (MessageBox.Show("ท่านต้องการล้างรายการหรือไม่", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    selected_menu_list.Items.Clear();
                    total_price = 0;
                    total_price_menu.Text = total_price.ToString("n") + "บาท";
                }
            }

        }
    }
}
