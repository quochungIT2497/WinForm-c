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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lbl_time.Text = String.Format("{0:HH:mm:ss}", dt);
            lbl_Date.Text = String.Format("{0:ddd,dd/MM/yyy}", dt);
        }

        private void button_hienthi_Click(object sender, EventArgs e)
        {
            if (progressBar1.Enabled == true)
            {
                progressBar1.Enabled = false;
                timer2.Start();
                timer1.Start();
            }
            else
            {
                progressBar1.Enabled = true;
                timer2.Stop();
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form3 b7 = new Form3();
            progressBar1.Increment(10);
            lbl_Progress.Text = "Connecting to :D from :C " + progressBar1.Value.ToString() + " %";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer2.Enabled = false;
                b7.ShowDialog();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bai6 b6 = new Bai6();
            b6.Show();
            this.Hide();
            this.Location = b6.Location;
        }

        private void link_bai8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 b8 = new Form4();
            b8.Show();
            this.Hide();
            this.Location = b8.Location;
        }
    }
}
