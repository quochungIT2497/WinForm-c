namespace Bai3_winform
{
    public partial class Bai3 : System.Windows.Forms.Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button_hienthi(object sender, EventArgs e)
        {
            txt_start.Text = monthCalendar1.SelectionStart.ToShortDateString();
            txt_end.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            txt_Min.Text = monthCalendar1.MinDate.ToShortDateString();
            txt_Max.Text = monthCalendar1.MaxDate.ToShortDateString();
            txt_Day.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void button_Cday(object sender, EventArgs e)
        {
            int numdays;
            numdays = Convert.ToInt32((monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalDays);
            txt_cDay.Text = numdays.ToString();
        }

        private void buttonchour_click(object sender, EventArgs e)
        {
            int numhours;
            numhours = Convert.ToInt32((monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalHours);
            txt_chour.Text = numhours.ToString();
        }

        private void link_next_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Bai4 f2 = new Bai4();
            f2.Show();
            f2.Location = this.Location;
        }
    }
}