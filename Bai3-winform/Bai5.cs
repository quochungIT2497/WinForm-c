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
    public partial class Bai5 : System.Windows.Forms.Form
    {
        public Bai5()
        {
            InitializeComponent();
            //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dangnhap.Text) || string.IsNullOrEmpty(Txt_mk.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else
            {
                if ((this.txt_dangnhap.Text == "hung") && (this.Txt_mk.Text == "123456"))
                    this.Close();
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
                    this.txt_dangnhap.Focus();
                }
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_mk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void check_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (check_hienthi.Checked == true)
            {
                Txt_mk.PasswordChar = (char)0;
            }
            else
            {
                Txt_mk.PasswordChar = '*';
            }
        }

        private void link_tooltip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.TableOfContents);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = "https://www.google.com";
        }

        private void link_qmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Visitlink();
            }
            catch (Exception)
            {
                MessageBox.Show("Truy cập không thành công!", "Thông báo");
            }
        }
        private void Visitlink()
        {
            link_qmk.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.twitch.tv/");
        }

        private void link_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Bai4 f2 = new Bai4();
            f2.Show();
            this.Location = f2.Location;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Bai6 f1 = new Bai6();
            f1.Show();
            this.Location = f1.Location;
        }
    }
}
