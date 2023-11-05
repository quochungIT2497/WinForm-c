namespace Bai3_winform
{
    partial class Bai6
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
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            HienThitoolStripComboBox = new ToolStripComboBox();
            lbl_Menu = new Label();
            lbl_Time = new Label();
            lbl_Date = new Label();
            timerTime = new System.Windows.Forms.Timer(components);
            timerDate = new System.Windows.Forms.Timer(components);
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem, HienThitoolStripComboBox });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(435, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(79, 23);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            thoátToolStripMenuItem.Size = new Size(144, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // HienThitoolStripComboBox
            // 
            HienThitoolStripComboBox.Items.AddRange(new object[] { "Hiển thị thời gian hiện hành", "Hiển thị ngày tháng năm hiện hành" });
            HienThitoolStripComboBox.Name = "HienThitoolStripComboBox";
            HienThitoolStripComboBox.Size = new Size(121, 23);
            HienThitoolStripComboBox.Text = "Hiển Thị";
            HienThitoolStripComboBox.SelectedIndexChanged += HienThitoolStripComboBox_SelectedIndexChanged;
            // 
            // lbl_Menu
            // 
            lbl_Menu.AutoSize = true;
            lbl_Menu.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Menu.Location = new Point(102, 52);
            lbl_Menu.Name = "lbl_Menu";
            lbl_Menu.Size = new Size(217, 37);
            lbl_Menu.TabIndex = 1;
            lbl_Menu.Text = "Menu Lựa Chọn";
            // 
            // lbl_Time
            // 
            lbl_Time.AutoSize = true;
            lbl_Time.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Time.Location = new Point(217, 161);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(98, 25);
            lbl_Time.TabIndex = 2;
            lbl_Time.Text = "Thời Gian";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Date.Location = new Point(217, 203);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(167, 25);
            lbl_Date.TabIndex = 3;
            lbl_Date.Text = "Ngày Tháng Năm";
            // 
            // timerTime
            // 
            timerTime.Tick += timerTime_Tick;
            // 
            // timerDate
            // 
            timerDate.Tick += timerDate_Tick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(24, 310);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(47, 21);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bài 5";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Red;
            linkLabel2.Location = new Point(367, 310);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(47, 21);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Bài 7";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 346);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(lbl_Date);
            Controls.Add(lbl_Time);
            Controls.Add(lbl_Menu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Bai6";
            Text = "Bai 6";
            Load += Bai6_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripComboBox HienThitoolStripComboBox;
        private Label lbl_Menu;
        private Label lbl_Time;
        private Label lbl_Date;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timerDate;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}