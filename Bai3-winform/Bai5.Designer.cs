namespace Bai3_winform
{
    partial class Bai5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai5));
            label_dangnhap = new Label();
            label_matkhau = new Label();
            txt_dangnhap = new TextBox();
            Txt_mk = new TextBox();
            check_hienthi = new CheckBox();
            button_thoat = new Button();
            link_tooltip = new LinkLabel();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            link_qmk = new LinkLabel();
            button_dangnhap = new Button();
            helpProvider1 = new HelpProvider();
            helpProvider2 = new HelpProvider();
            helpProvider3 = new HelpProvider();
            toolTip2 = new ToolTip(components);
            helpProvider4 = new HelpProvider();
            link_back = new LinkLabel();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_dangnhap
            // 
            label_dangnhap.AutoSize = true;
            label_dangnhap.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_dangnhap.Location = new Point(265, 25);
            label_dangnhap.Name = "label_dangnhap";
            label_dangnhap.Size = new Size(94, 15);
            label_dangnhap.TabIndex = 0;
            label_dangnhap.Text = "Tên Đăng Nhập";
            // 
            // label_matkhau
            // 
            label_matkhau.AutoSize = true;
            label_matkhau.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_matkhau.Location = new Point(265, 54);
            label_matkhau.Name = "label_matkhau";
            label_matkhau.Size = new Size(56, 15);
            label_matkhau.TabIndex = 1;
            label_matkhau.Text = "Mật khẩu";
            // 
            // txt_dangnhap
            // 
            txt_dangnhap.Location = new Point(365, 22);
            txt_dangnhap.Name = "txt_dangnhap";
            txt_dangnhap.PlaceholderText = "Nhập tên đăng nhập";
            txt_dangnhap.Size = new Size(175, 23);
            txt_dangnhap.TabIndex = 2;
            toolTip1.SetToolTip(txt_dangnhap, "Không được bỏ trống");
            // 
            // Txt_mk
            // 
            Txt_mk.Location = new Point(365, 51);
            Txt_mk.Name = "Txt_mk";
            Txt_mk.PasswordChar = '*';
            Txt_mk.PlaceholderText = "Nhập Mật Khẩu";
            Txt_mk.Size = new Size(175, 23);
            Txt_mk.TabIndex = 3;
            toolTip2.SetToolTip(Txt_mk, "a->z, 1->9");
            Txt_mk.KeyPress += Txt_mk_KeyPress;
            // 
            // check_hienthi
            // 
            check_hienthi.AutoSize = true;
            check_hienthi.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            check_hienthi.Location = new Point(399, 80);
            check_hienthi.Name = "check_hienthi";
            check_hienthi.Size = new Size(122, 19);
            check_hienthi.TabIndex = 5;
            check_hienthi.Text = "Hiển thị mật khẩu";
            check_hienthi.UseVisualStyleBackColor = true;
            check_hienthi.CheckedChanged += check_hienthi_CheckedChanged;
            // 
            // button_thoat
            // 
            button_thoat.FlatAppearance.BorderColor = Color.Black;
            button_thoat.FlatAppearance.BorderSize = 2;
            button_thoat.FlatStyle = FlatStyle.Popup;
            button_thoat.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_thoat.Location = new Point(453, 142);
            button_thoat.Name = "button_thoat";
            button_thoat.Size = new Size(87, 23);
            button_thoat.TabIndex = 7;
            button_thoat.Text = "Thoát";
            button_thoat.UseVisualStyleBackColor = true;
            button_thoat.Click += button_thoat_Click;
            // 
            // link_tooltip
            // 
            link_tooltip.AutoSize = true;
            link_tooltip.Location = new Point(431, 209);
            link_tooltip.Name = "link_tooltip";
            helpProvider1.SetShowHelp(link_tooltip, true);
            link_tooltip.Size = new Size(132, 15);
            link_tooltip.TabIndex = 8;
            link_tooltip.TabStop = true;
            link_tooltip.Text = "Nhấn F1 để được hỗ trợ";
            link_tooltip.LinkClicked += link_tooltip_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 176);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // link_qmk
            // 
            link_qmk.AutoSize = true;
            link_qmk.Location = new Point(419, 102);
            link_qmk.Name = "link_qmk";
            link_qmk.Size = new Size(94, 15);
            link_qmk.TabIndex = 11;
            link_qmk.TabStop = true;
            link_qmk.Text = "Quên mật khẩu?";
            toolTip1.SetToolTip(link_qmk, "Bấm vào đây");
            link_qmk.LinkClicked += link_qmk_LinkClicked;
            // 
            // button_dangnhap
            // 
            button_dangnhap.FlatAppearance.BorderColor = Color.Black;
            button_dangnhap.FlatAppearance.BorderSize = 2;
            button_dangnhap.FlatStyle = FlatStyle.Popup;
            button_dangnhap.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_dangnhap.Location = new Point(344, 142);
            button_dangnhap.Name = "button_dangnhap";
            button_dangnhap.Size = new Size(88, 23);
            button_dangnhap.TabIndex = 10;
            button_dangnhap.Text = "Đăng nhập";
            button_dangnhap.UseVisualStyleBackColor = true;
            button_dangnhap.Click += button_dangnhap_Click;
            // 
            // link_back
            // 
            link_back.AutoSize = true;
            link_back.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            link_back.LinkColor = Color.Red;
            link_back.Location = new Point(9, 227);
            link_back.Name = "link_back";
            link_back.Size = new Size(47, 21);
            link_back.TabIndex = 12;
            link_back.TabStop = true;
            link_back.Text = "Bài 4";
            link_back.LinkClicked += link_back_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(177, 227);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(47, 21);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bài 6";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 250);
            Controls.Add(linkLabel1);
            Controls.Add(link_back);
            Controls.Add(link_qmk);
            Controls.Add(button_dangnhap);
            Controls.Add(pictureBox1);
            Controls.Add(link_tooltip);
            Controls.Add(button_thoat);
            Controls.Add(check_hienthi);
            Controls.Add(Txt_mk);
            Controls.Add(txt_dangnhap);
            Controls.Add(label_matkhau);
            Controls.Add(label_dangnhap);
            Name = "Form3";
            helpProvider1.SetShowHelp(this, true);
            Text = "Đăng nhập";
            toolTip1.SetToolTip(this, "Không dùng kí tự đặc biệt");
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_dangnhap;
        private Label label_matkhau;
        private TextBox txt_dangnhap;
        private TextBox Txt_mk;
        private Label label3;
        private CheckBox check_hienthi;
        private Button button1;
        private Button button_thoat;
        private LinkLabel link_tooltip;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Button button_dangnhap;
        private HelpProvider helpProvider1;
        private HelpProvider helpProvider2;
        private HelpProvider helpProvider3;
        private ToolTip toolTip2;
        private HelpProvider helpProvider4;
        private LinkLabel link_qmk;
        private LinkLabel link_back;
        private LinkLabel linkLabel1;
    }
}