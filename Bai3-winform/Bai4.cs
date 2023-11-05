using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_winform
{
    public partial class Bai4 : System.Windows.Forms.Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MinDate = new DateTime(1985, 6, 20);
            int dayofmonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month, dayofmonth);
        }

        private void TxtHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= ' ') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void button_Dky_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtHoten.Text) || string.IsNullOrEmpty(txt_SDT.Text) || string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else if (!string.IsNullOrEmpty(TxtHoten.Text) || !string.IsNullOrEmpty(txt_SDT.Text) || !string.IsNullOrEmpty(txt_email.Text) == true)
            {
                MessageBox.Show("Chúc mừng bạn" + TxtHoten.Text + "\nSố Điện Thoại: " + txt_SDT.Text + "\nEmail: " + txt_email.Text + "\nThời gian lựa chọn: " + dateTimePicker1.Value.ToShortDateString());
            }
        }

        private void Button_thoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void link_next_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Bai5 f3 = new Bai5();
            f3.Show();
            f3.Location = this.Location;
        }

        private void link_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Bai3 f1 = new Bai3();
            f1.Show(); f1.Location = this.Location;
        }
    }
}
