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
    public partial class Bai6 : System.Windows.Forms.Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Đóng Chương Trình?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lbl_Time.Text = String.Format("{0:HH:mm:ss}", dt);
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lbl_Date.Text = string.Format("{0:ddd,dd MMMM yyy}", dt);
        }

        private void HienThitoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HienThitoolStripComboBox.SelectedItem == "Hiển thị thời gian hiện hành")
            {
                timerTime.Start();
            }
            if (HienThitoolStripComboBox.SelectedItem == "Hiển thị ngày tháng năm hiện hành")
            {
                timerDate.Start();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Bai5 f5 = new Bai5();
            f5.Show();
            this.Location = f5.Location;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Bai7 b7 = new Bai7();
            b7.Show();
            this.Location = b7.Location;
        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }
    }
}
