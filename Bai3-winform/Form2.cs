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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_index_Click(object sender, EventArgs e)
        {
            string s1 = this.txt_CT1.Text;
            string s2 = this.txt_CT2.Text;
            if (s1.IndexOf(s2) >= 0)// Chỉ vị trí của chuỗi 2 trong chuỗi 1
            {
                this.richTextBox_KQ.Text = "Chuỗi 2 xuất hiện trong chuỗi 1 tại vị trí ";
                this.richTextBox_KQ.Text += ".!";
                string s = "Mẹ"; //Thay thế chuỗi s="Chỗ này" vào vị trí chuỗi 2 trong chuỗi 1
                this.richTextBox_KQ.Text += "\n\rThay thế chuỗi 2 trong chuỗi 1 bằng chuỗi Mẹ,";
                this.richTextBox_KQ.Text += "\n\rKết quả:" + s1.Replace(s2, s);
            }
            else this.richTextBox_KQ.Text = "chuỗi 2 không xuất hiện trong chuỗi 1!";
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {

        }
    }
}
