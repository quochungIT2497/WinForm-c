namespace Bai3_winform
{
    partial class Bai3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai3));
            label_month = new Label();
            monthCalendar1 = new MonthCalendar();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txt_Day = new TextBox();
            txt_Max = new TextBox();
            txt_Min = new TextBox();
            txt_end = new TextBox();
            txt_start = new TextBox();
            label_daydate = new Label();
            label_maxdate = new Label();
            label_Mindate = new Label();
            label_selectend = new Label();
            label_selectstart = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            label_countday = new Label();
            label_chour = new Label();
            txt_cDay = new TextBox();
            txt_chour = new TextBox();
            button2 = new Button();
            button3 = new Button();
            link_next = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label_month
            // 
            label_month.AutoSize = true;
            label_month.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_month.ForeColor = Color.DarkBlue;
            label_month.Location = new Point(261, 9);
            label_month.Name = "label_month";
            label_month.Size = new Size(322, 45);
            label_month.TabIndex = 0;
            label_month.Text = "MONTH CALENDAR";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(37, 79);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_Day);
            groupBox1.Controls.Add(txt_Max);
            groupBox1.Controls.Add(txt_Min);
            groupBox1.Controls.Add(txt_end);
            groupBox1.Controls.Add(txt_start);
            groupBox1.Controls.Add(label_daydate);
            groupBox1.Controls.Add(label_maxdate);
            groupBox1.Controls.Add(label_Mindate);
            groupBox1.Controls.Add(label_selectend);
            groupBox1.Controls.Add(label_selectstart);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(364, 79);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 227);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Day_Month_Year";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(140, 189);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(241, 23);
            button1.TabIndex = 10;
            button1.Text = "Hiển thị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_hienthi;
            // 
            // txt_Day
            // 
            txt_Day.Location = new Point(140, 158);
            txt_Day.Name = "txt_Day";
            txt_Day.Size = new Size(241, 25);
            txt_Day.TabIndex = 9;
            // 
            // txt_Max
            // 
            txt_Max.Location = new Point(140, 127);
            txt_Max.Name = "txt_Max";
            txt_Max.Size = new Size(241, 25);
            txt_Max.TabIndex = 8;
            // 
            // txt_Min
            // 
            txt_Min.Location = new Point(140, 96);
            txt_Min.Name = "txt_Min";
            txt_Min.Size = new Size(241, 25);
            txt_Min.TabIndex = 7;
            // 
            // txt_end
            // 
            txt_end.Location = new Point(140, 65);
            txt_end.Name = "txt_end";
            txt_end.Size = new Size(241, 25);
            txt_end.TabIndex = 6;
            // 
            // txt_start
            // 
            txt_start.Location = new Point(140, 34);
            txt_start.Name = "txt_start";
            txt_start.Size = new Size(241, 25);
            txt_start.TabIndex = 5;
            // 
            // label_daydate
            // 
            label_daydate.AutoSize = true;
            label_daydate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_daydate.ForeColor = Color.Navy;
            label_daydate.Location = new Point(17, 162);
            label_daydate.Name = "label_daydate";
            label_daydate.Size = new Size(74, 21);
            label_daydate.TabIndex = 4;
            label_daydate.Text = "Daydate";
            // 
            // label_maxdate
            // 
            label_maxdate.AutoSize = true;
            label_maxdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_maxdate.ForeColor = Color.Navy;
            label_maxdate.Location = new Point(17, 131);
            label_maxdate.Name = "label_maxdate";
            label_maxdate.Size = new Size(79, 21);
            label_maxdate.TabIndex = 3;
            label_maxdate.Text = "MaxDate";
            // 
            // label_Mindate
            // 
            label_Mindate.AutoSize = true;
            label_Mindate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Mindate.ForeColor = Color.Navy;
            label_Mindate.Location = new Point(17, 100);
            label_Mindate.Name = "label_Mindate";
            label_Mindate.Size = new Size(76, 21);
            label_Mindate.TabIndex = 2;
            label_Mindate.Text = "MinDate";
            // 
            // label_selectend
            // 
            label_selectend.AutoSize = true;
            label_selectend.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_selectend.ForeColor = Color.Navy;
            label_selectend.Location = new Point(17, 69);
            label_selectend.Name = "label_selectend";
            label_selectend.Size = new Size(110, 21);
            label_selectend.TabIndex = 1;
            label_selectend.Text = "SelectionEnd";
            // 
            // label_selectstart
            // 
            label_selectstart.AutoSize = true;
            label_selectstart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_selectstart.ForeColor = Color.Navy;
            label_selectstart.Location = new Point(17, 39);
            label_selectstart.Name = "label_selectstart";
            label_selectstart.Size = new Size(117, 21);
            label_selectstart.TabIndex = 0;
            label_selectstart.Text = "SelectionStart";
            // 
            // label_countday
            // 
            label_countday.AutoSize = true;
            label_countday.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_countday.ForeColor = Color.Navy;
            label_countday.Location = new Point(59, 330);
            label_countday.Name = "label_countday";
            label_countday.Size = new Size(227, 21);
            label_countday.TabIndex = 3;
            label_countday.Text = "Count day from Select range";
            // 
            // label_chour
            // 
            label_chour.AutoSize = true;
            label_chour.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_chour.ForeColor = Color.Navy;
            label_chour.Location = new Point(59, 367);
            label_chour.Name = "label_chour";
            label_chour.Size = new Size(235, 21);
            label_chour.TabIndex = 4;
            label_chour.Text = "Count hour from Select range";
            // 
            // txt_cDay
            // 
            txt_cDay.Location = new Point(311, 328);
            txt_cDay.Name = "txt_cDay";
            txt_cDay.Size = new Size(169, 23);
            txt_cDay.TabIndex = 5;
            // 
            // txt_chour
            // 
            txt_chour.Location = new Point(311, 365);
            txt_chour.Name = "txt_chour";
            txt_chour.Size = new Size(169, 23);
            txt_chour.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(523, 328);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(208, 23);
            button2.TabIndex = 7;
            button2.Text = "Count Day";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Cday;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(523, 364);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(208, 23);
            button3.TabIndex = 8;
            button3.Text = "Count Hour";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonchour_click;
            // 
            // link_next
            // 
            link_next.AutoSize = true;
            link_next.BackColor = Color.DarkOrange;
            link_next.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            link_next.ForeColor = SystemColors.ControlText;
            link_next.LinkColor = Color.Red;
            link_next.Location = new Point(728, 434);
            link_next.Name = "link_next";
            link_next.Size = new Size(60, 21);
            link_next.TabIndex = 9;
            link_next.TabStop = true;
            link_next.Text = "Form 4";
            link_next.LinkClicked += link_next_LinkClicked;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(799, 464);
            Controls.Add(link_next);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txt_chour);
            Controls.Add(txt_cDay);
            Controls.Add(label_chour);
            Controls.Add(label_countday);
            Controls.Add(groupBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(label_month);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bai3";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_month;
        private MonthCalendar monthCalendar1;
        private GroupBox groupBox1;
        private Label label_selectstart;
        private TextBox txt_start;
        private Label label_daydate;
        private Label label_maxdate;
        private Label label_Mindate;
        private Label label_selectend;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button button1;
        private TextBox txt_Day;
        private TextBox txt_Max;
        private TextBox txt_Min;
        private TextBox txt_end;
        private Label label_countday;
        private Label label_chour;
        private TextBox txt_cDay;
        private TextBox txt_chour;
        private Button button2;
        private Button button_chour;
        private Button button3;
        private LinkLabel link_next;
    }
}