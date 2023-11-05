namespace Bai3_winform
{
    partial class Form5
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btn_Thoát = new Button();
            lbl_SDTKH = new Label();
            txt_SDTKH = new TextBox();
            button1 = new Button();
            btn_Sua = new Button();
            lbl_ThanhPho = new Label();
            txt_ThanhPho = new TextBox();
            txt_Dchi = new TextBox();
            lbl_DChi = new Label();
            txt_TenCty = new TextBox();
            lbl_TenCty = new Label();
            txt_MaKH = new TextBox();
            lbl_MaKH = new Label();
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            tìmKiếmToolStripMenuItem = new ToolStripMenuItem();
            xóaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(650, 163);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(63, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(650, 180);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // btn_Thoát
            // 
            btn_Thoát.Location = new Point(350, 382);
            btn_Thoát.Name = "btn_Thoát";
            btn_Thoát.Size = new Size(75, 23);
            btn_Thoát.TabIndex = 3;
            btn_Thoát.Text = "Thoát";
            btn_Thoát.UseVisualStyleBackColor = true;
            btn_Thoát.Click += btn_Thoát_Click;
            // 
            // lbl_SDTKH
            // 
            lbl_SDTKH.AutoSize = true;
            lbl_SDTKH.Location = new Point(410, 314);
            lbl_SDTKH.Name = "lbl_SDTKH";
            lbl_SDTKH.Size = new Size(94, 15);
            lbl_SDTKH.TabIndex = 4;
            lbl_SDTKH.Text = "SDT Khách Hàng";
            // 
            // txt_SDTKH
            // 
            txt_SDTKH.Location = new Point(510, 311);
            txt_SDTKH.Name = "txt_SDTKH";
            txt_SDTKH.PlaceholderText = "Ví dụ: 01111111";
            txt_SDTKH.Size = new Size(141, 23);
            txt_SDTKH.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(269, 353);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Thêm Khách Hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(429, 353);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(75, 23);
            btn_Sua.TabIndex = 7;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // lbl_ThanhPho
            // 
            lbl_ThanhPho.AutoSize = true;
            lbl_ThanhPho.Location = new Point(410, 278);
            lbl_ThanhPho.Name = "lbl_ThanhPho";
            lbl_ThanhPho.Size = new Size(64, 15);
            lbl_ThanhPho.TabIndex = 8;
            lbl_ThanhPho.Text = "Thành Phố";
            // 
            // txt_ThanhPho
            // 
            txt_ThanhPho.Location = new Point(510, 275);
            txt_ThanhPho.Name = "txt_ThanhPho";
            txt_ThanhPho.PlaceholderText = "Ví dụ: Hà Nội";
            txt_ThanhPho.Size = new Size(141, 23);
            txt_ThanhPho.TabIndex = 9;
            // 
            // txt_Dchi
            // 
            txt_Dchi.Location = new Point(207, 313);
            txt_Dchi.Name = "txt_Dchi";
            txt_Dchi.PlaceholderText = "Ví dụ: 15 Hoàng Hoa Thám";
            txt_Dchi.Size = new Size(141, 23);
            txt_Dchi.TabIndex = 11;
            // 
            // lbl_DChi
            // 
            lbl_DChi.AutoSize = true;
            lbl_DChi.Location = new Point(107, 316);
            lbl_DChi.Name = "lbl_DChi";
            lbl_DChi.Size = new Size(45, 15);
            lbl_DChi.TabIndex = 10;
            lbl_DChi.Text = "Địa Chỉ";
            // 
            // txt_TenCty
            // 
            txt_TenCty.Location = new Point(207, 275);
            txt_TenCty.Name = "txt_TenCty";
            txt_TenCty.PlaceholderText = "Ví dụ: COMPUTER....";
            txt_TenCty.Size = new Size(141, 23);
            txt_TenCty.TabIndex = 13;
            // 
            // lbl_TenCty
            // 
            lbl_TenCty.AutoSize = true;
            lbl_TenCty.Location = new Point(107, 278);
            lbl_TenCty.Name = "lbl_TenCty";
            lbl_TenCty.Size = new Size(71, 15);
            lbl_TenCty.TabIndex = 12;
            lbl_TenCty.Text = "Tên Công Ty";
            // 
            // txt_MaKH
            // 
            txt_MaKH.Location = new Point(350, 219);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.PlaceholderText = "Ví dụ: KH01";
            txt_MaKH.Size = new Size(141, 23);
            txt_MaKH.TabIndex = 16;
            // 
            // lbl_MaKH
            // 
            lbl_MaKH.AutoSize = true;
            lbl_MaKH.Location = new Point(273, 227);
            lbl_MaKH.Name = "lbl_MaKH";
            lbl_MaKH.Size = new Size(43, 15);
            lbl_MaKH.TabIndex = 15;
            lbl_MaKH.Text = "Mã KH";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(805, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tìmKiếmToolStripMenuItem, xóaToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(79, 20);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            tìmKiếmToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            tìmKiếmToolStripMenuItem.Size = new Size(180, 22);
            tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            tìmKiếmToolStripMenuItem.Click += tìmKiếmToolStripMenuItem_Click;
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.D;
            xóaToolStripMenuItem.Size = new Size(180, 22);
            xóaToolStripMenuItem.Text = "Xóa";
            xóaToolStripMenuItem.Click += xóaToolStripMenuItem_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 417);
            Controls.Add(txt_MaKH);
            Controls.Add(lbl_MaKH);
            Controls.Add(txt_TenCty);
            Controls.Add(lbl_TenCty);
            Controls.Add(txt_Dchi);
            Controls.Add(lbl_DChi);
            Controls.Add(txt_ThanhPho);
            Controls.Add(lbl_ThanhPho);
            Controls.Add(btn_Sua);
            Controls.Add(button1);
            Controls.Add(txt_SDTKH);
            Controls.Add(lbl_SDTKH);
            Controls.Add(btn_Thoát);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "Form5";
            Text = "Bai CSDL";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btn_Thoát;
        private Label lbl_SDTKH;
        private TextBox txt_SDTKH;
        private Button button1;
        private Button btn_Sua;
        private Label lbl_ThanhPho;
        private TextBox txt_ThanhPho;
        private TextBox txt_Dchi;
        private Label lbl_DChi;
        private TextBox txt_TenCty;
        private Label lbl_TenCty;
        private TextBox txt_MaKH;
        private Label lbl_MaKH;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private ToolStripMenuItem xóaToolStripMenuItem;
    }
}