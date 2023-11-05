namespace Bai3_winform
{
    partial class Bai7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_baygio = new Label();
            lbl_time = new Label();
            lbl_Date = new Label();
            lbl_Progress = new Label();
            button_hienthi = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            link_bai8 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // lbl_baygio
            // 
            lbl_baygio.AutoSize = true;
            lbl_baygio.Location = new Point(60, 25);
            lbl_baygio.Name = "lbl_baygio";
            lbl_baygio.Size = new Size(58, 15);
            lbl_baygio.TabIndex = 0;
            lbl_baygio.Text = "Bây giờ là";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new Point(190, 25);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(79, 15);
            lbl_time.TabIndex = 1;
            lbl_time.Text = "Giờ:Phút:Giây";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Location = new Point(322, 25);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(104, 15);
            lbl_Date.TabIndex = 2;
            lbl_Date.Text = "Ngày/Tháng/Năm";
            // 
            // lbl_Progress
            // 
            lbl_Progress.AutoSize = true;
            lbl_Progress.Location = new Point(269, 76);
            lbl_Progress.Name = "lbl_Progress";
            lbl_Progress.Size = new Size(140, 15);
            lbl_Progress.TabIndex = 3;
            lbl_Progress.Text = "Connecting to :D from :C";
            // 
            // button_hienthi
            // 
            button_hienthi.FlatAppearance.BorderColor = Color.Cyan;
            button_hienthi.FlatAppearance.BorderSize = 2;
            button_hienthi.Location = new Point(60, 125);
            button_hienthi.Name = "button_hienthi";
            button_hienthi.Size = new Size(75, 23);
            button_hienthi.TabIndex = 4;
            button_hienthi.Text = "Hiển thị ngày giờ";
            button_hienthi.UseVisualStyleBackColor = true;
            button_hienthi.Click += button_hienthi_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(190, 125);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(236, 23);
            progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // link_bai8
            // 
            link_bai8.AutoSize = true;
            link_bai8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            link_bai8.LinkColor = Color.Red;
            link_bai8.Location = new Point(397, 244);
            link_bai8.Name = "link_bai8";
            link_bai8.Size = new Size(47, 21);
            link_bai8.TabIndex = 6;
            link_bai8.TabStop = true;
            link_bai8.Text = "Bài 8";
            link_bai8.LinkClicked += link_bai8_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Red;
            linkLabel2.Location = new Point(12, 244);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(47, 21);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Bài 6";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 268);
            Controls.Add(linkLabel2);
            Controls.Add(link_bai8);
            Controls.Add(progressBar1);
            Controls.Add(button_hienthi);
            Controls.Add(lbl_Progress);
            Controls.Add(lbl_Date);
            Controls.Add(lbl_time);
            Controls.Add(lbl_baygio);
            Name = "Form2";
            Text = "Bài 7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_baygio;
        private Label lbl_time;
        private Label lbl_Date;
        private Label lbl_Progress;
        private Button button_hienthi;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private LinkLabel link_bai8;
        private LinkLabel linkLabel2;
    }
}