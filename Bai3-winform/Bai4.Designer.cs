namespace Bai3_winform
{
    partial class Bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label_Hten = new Label();
            label_SDT = new Label();
            label_email = new Label();
            label_thoigian = new Label();
            TxtHoten = new TextBox();
            txt_SDT = new TextBox();
            txt_email = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button_Dky = new Button();
            Button_thoát = new Button();
            link_next = new LinkLabel();
            link_back = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 73);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 182);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(41, 258);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(317, 180);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(315, 18);
            label1.Name = "label1";
            label1.Size = new Size(391, 26);
            label1.TabIndex = 2;
            label1.Text = "ĐĂNG KÝ KHÓA HỌC TRỰC TUYẾN";
            // 
            // label_Hten
            // 
            label_Hten.AutoSize = true;
            label_Hten.Location = new Point(315, 73);
            label_Hten.Name = "label_Hten";
            label_Hten.Size = new Size(43, 15);
            label_Hten.TabIndex = 3;
            label_Hten.Text = "Họ tên";
            // 
            // label_SDT
            // 
            label_SDT.AutoSize = true;
            label_SDT.Location = new Point(315, 102);
            label_SDT.Name = "label_SDT";
            label_SDT.Size = new Size(76, 15);
            label_SDT.TabIndex = 4;
            label_SDT.Text = "Số điện thoại";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(315, 131);
            label_email.Name = "label_email";
            label_email.Size = new Size(36, 15);
            label_email.TabIndex = 5;
            label_email.Text = "Email";
            // 
            // label_thoigian
            // 
            label_thoigian.AutoSize = true;
            label_thoigian.Location = new Point(315, 163);
            label_thoigian.Name = "label_thoigian";
            label_thoigian.Size = new Size(57, 15);
            label_thoigian.TabIndex = 6;
            label_thoigian.Text = "Thời Gian";
            // 
            // TxtHoten
            // 
            TxtHoten.Location = new Point(396, 70);
            TxtHoten.Name = "TxtHoten";
            TxtHoten.Size = new Size(381, 23);
            TxtHoten.TabIndex = 7;
            TxtHoten.KeyPress += TxtHoten_KeyPress;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(396, 99);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(381, 23);
            txt_SDT.TabIndex = 8;
            txt_SDT.KeyPress += txt_SDT_KeyPress;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(396, 128);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(381, 23);
            txt_email.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(396, 157);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(381, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // button_Dky
            // 
            button_Dky.Location = new Point(419, 217);
            button_Dky.Name = "button_Dky";
            button_Dky.Size = new Size(75, 23);
            button_Dky.TabIndex = 11;
            button_Dky.Text = "Đăng ký";
            button_Dky.UseVisualStyleBackColor = true;
            button_Dky.Click += button_Dky_Click;
            // 
            // Button_thoát
            // 
            Button_thoát.Location = new Point(557, 217);
            Button_thoát.Name = "Button_thoát";
            Button_thoát.Size = new Size(75, 23);
            Button_thoát.TabIndex = 12;
            Button_thoát.Text = "Thoát";
            Button_thoát.UseVisualStyleBackColor = true;
            Button_thoát.Click += Button_thoát_Click;
            // 
            // link_next
            // 
            link_next.AutoSize = true;
            link_next.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            link_next.LinkColor = Color.Red;
            link_next.Location = new Point(717, 423);
            link_next.Name = "link_next";
            link_next.Size = new Size(61, 21);
            link_next.TabIndex = 13;
            link_next.TabStop = true;
            link_next.Text = "Form 5";
            link_next.LinkClicked += link_next_LinkClicked;
            // 
            // link_back
            // 
            link_back.AutoSize = true;
            link_back.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            link_back.LinkColor = Color.Red;
            link_back.Location = new Point(406, 423);
            link_back.Name = "link_back";
            link_back.Size = new Size(62, 21);
            link_back.TabIndex = 14;
            link_back.TabStop = true;
            link_back.Text = "Form 3";
            link_back.LinkClicked += link_back_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(link_back);
            Controls.Add(link_next);
            Controls.Add(Button_thoát);
            Controls.Add(button_Dky);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_email);
            Controls.Add(txt_SDT);
            Controls.Add(TxtHoten);
            Controls.Add(label_thoigian);
            Controls.Add(label_email);
            Controls.Add(label_SDT);
            Controls.Add(label_Hten);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Đăng ký khóa học trực tuyến";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label_Hten;
        private Label label_SDT;
        private Label label_email;
        private Label label_thoigian;
        private TextBox TxtHoten;
        private TextBox txt_SDT;
        private TextBox txt_email;
        private DateTimePicker dateTimePicker1;
        private Button button_Dky;
        private Button Button_thoát;
        private LinkLabel link_next;
        private LinkLabel link_back;
    }
}