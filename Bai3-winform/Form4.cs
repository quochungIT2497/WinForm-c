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
    public partial class Form4 : Form
    {
        int[] a = { 10, 20, 30, 40, 50 };
        public Form4()
        {
            InitializeComponent();
        }

        private void button_In_Click(object sender, EventArgs e)
        {
            this.lbl_KQ.Text = "Mảng bao gồm các phần tử: \n\r";
            for (int i = 0; i < a.Length; i++)
            {
                this.lbl_KQ.Text += a[i] + " ";
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            this.lbl_KQ.Text = "";
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_bai7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Bai7 b7 = new Bai7();
            b7.Show();
            this.Location = b7.Location;
        }

        private void link_bai9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 b9 = new Form1();
            b9.Show();
            b9.Location = this.Location;
        }
    }
}
