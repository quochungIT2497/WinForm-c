namespace Bai3_winform
{
    partial class Form1
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
            lbl_S1 = new Label();
            lbl_S2 = new Label();
            label3 = new Label();
            txt_S1 = new TextBox();
            txt_S2 = new TextBox();
            txt_KQ = new TextBox();
            button_chia = new Button();
            button_Xoa = new Button();
            button_stop = new Button();
            link_Bai8 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // lbl_S1
            // 
            lbl_S1.AutoSize = true;
            lbl_S1.Location = new Point(71, 67);
            lbl_S1.Name = "lbl_S1";
            lbl_S1.Size = new Size(66, 15);
            lbl_S1.TabIndex = 0;
            lbl_S1.Text = "Số đầu tiên";
            // 
            // lbl_S2
            // 
            lbl_S2.AutoSize = true;
            lbl_S2.Location = new Point(71, 111);
            lbl_S2.Name = "lbl_S2";
            lbl_S2.Size = new Size(60, 15);
            lbl_S2.TabIndex = 1;
            lbl_S2.Text = "Số thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 147);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Thương là";
            // 
            // txt_S1
            // 
            txt_S1.Location = new Point(190, 66);
            txt_S1.Name = "txt_S1";
            txt_S1.Size = new Size(100, 23);
            txt_S1.TabIndex = 3;
            // 
            // txt_S2
            // 
            txt_S2.Location = new Point(190, 103);
            txt_S2.Name = "txt_S2";
            txt_S2.Size = new Size(100, 23);
            txt_S2.TabIndex = 4;
            // 
            // txt_KQ
            // 
            txt_KQ.Location = new Point(190, 139);
            txt_KQ.Name = "txt_KQ";
            txt_KQ.Size = new Size(100, 23);
            txt_KQ.TabIndex = 5;
            // 
            // button_chia
            // 
            button_chia.Location = new Point(357, 66);
            button_chia.Name = "button_chia";
            button_chia.Size = new Size(75, 23);
            button_chia.TabIndex = 6;
            button_chia.Text = "Chia";
            button_chia.UseVisualStyleBackColor = true;
            button_chia.Click += button_chia_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.Location = new Point(357, 103);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(75, 23);
            button_Xoa.TabIndex = 7;
            button_Xoa.Text = "Xóa";
            button_Xoa.UseVisualStyleBackColor = true;
            button_Xoa.Click += button_Xoa_Click;
            // 
            // button_stop
            // 
            button_stop.Location = new Point(357, 139);
            button_stop.Name = "button_stop";
            button_stop.Size = new Size(75, 23);
            button_stop.TabIndex = 8;
            button_stop.Text = "Thoát";
            button_stop.UseVisualStyleBackColor = true;
            button_stop.Click += button_stop_Click;
            // 
            // link_Bai8
            // 
            link_Bai8.AutoSize = true;
            link_Bai8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            link_Bai8.LinkColor = Color.Red;
            link_Bai8.Location = new Point(12, 214);
            link_Bai8.Name = "link_Bai8";
            link_Bai8.Size = new Size(55, 25);
            link_Bai8.TabIndex = 9;
            link_Bai8.TabStop = true;
            link_Bai8.Text = "Bài 8";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(387, 222);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(60, 15);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "linkLabel2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 246);
            Controls.Add(linkLabel2);
            Controls.Add(link_Bai8);
            Controls.Add(button_stop);
            Controls.Add(button_Xoa);
            Controls.Add(button_chia);
            Controls.Add(txt_KQ);
            Controls.Add(txt_S2);
            Controls.Add(txt_S1);
            Controls.Add(label3);
            Controls.Add(lbl_S2);
            Controls.Add(lbl_S1);
            Name = "Form1";
            Text = "Bài 9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_S1;
        private Label lbl_S2;
        private Label label3;
        private TextBox txt_S1;
        private TextBox txt_S2;
        private TextBox txt_KQ;
        private Button button_chia;
        private Button button_Xoa;
        private Button button_stop;
        private LinkLabel link_Bai8;
        private LinkLabel linkLabel2;
    }
}