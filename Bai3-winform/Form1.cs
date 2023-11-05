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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_chia_Click(object sender, EventArgs e)
        {
            txt_KQ.ResetText();
            try
            {
                int so1 = int.Parse(this.txt_S1.Text);
                int so2 = int.Parse(this.txt_S2.Text);
                this.txt_KQ.Text += (float)so1 / so2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yêu cầu nhập lại", "Thông báo");
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            this.txt_S1.ResetText();
            this.txt_S2.ResetText();
            this.txt_KQ.ResetText();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
