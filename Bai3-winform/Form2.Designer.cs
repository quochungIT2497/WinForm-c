namespace Bai3_winform
{
    partial class Form2
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
            Button_Compare = new Button();
            button_Concat = new Button();
            button_Insert = new Button();
            Button_Xoa = new Button();
            button_COMPA = new Button();
            button_index = new Button();
            button_substring = new Button();
            Button_Stop = new Button();
            lbl_banner = new Label();
            lbl_CT1 = new Label();
            lbl_CT2 = new Label();
            lbl_KQ = new Label();
            txt_CT1 = new TextBox();
            txt_CT2 = new TextBox();
            panel1 = new Panel();
            richTextBox_KQ = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Button_Compare
            // 
            Button_Compare.Location = new Point(26, 304);
            Button_Compare.Name = "Button_Compare";
            Button_Compare.Size = new Size(75, 23);
            Button_Compare.TabIndex = 0;
            Button_Compare.Text = "Compare";
            Button_Compare.UseVisualStyleBackColor = true;
            // 
            // button_Concat
            // 
            button_Concat.Location = new Point(107, 304);
            button_Concat.Name = "button_Concat";
            button_Concat.Size = new Size(75, 23);
            button_Concat.TabIndex = 1;
            button_Concat.Text = "Concat";
            button_Concat.UseVisualStyleBackColor = true;
            // 
            // button_Insert
            // 
            button_Insert.Location = new Point(188, 304);
            button_Insert.Name = "button_Insert";
            button_Insert.Size = new Size(75, 23);
            button_Insert.TabIndex = 2;
            button_Insert.Text = "Insert";
            button_Insert.UseVisualStyleBackColor = true;
            button_Insert.Click += button_Insert_Click;
            // 
            // Button_Xoa
            // 
            Button_Xoa.Location = new Point(269, 304);
            Button_Xoa.Name = "Button_Xoa";
            Button_Xoa.Size = new Size(75, 23);
            Button_Xoa.TabIndex = 3;
            Button_Xoa.Text = "Xoá";
            Button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_COMPA
            // 
            button_COMPA.Location = new Point(26, 333);
            button_COMPA.Name = "button_COMPA";
            button_COMPA.Size = new Size(75, 23);
            button_COMPA.TabIndex = 4;
            button_COMPA.Text = "COMPARE";
            button_COMPA.UseVisualStyleBackColor = true;
            // 
            // button_index
            // 
            button_index.Location = new Point(107, 333);
            button_index.Name = "button_index";
            button_index.Size = new Size(75, 23);
            button_index.TabIndex = 5;
            button_index.Text = "IndexOf";
            button_index.UseVisualStyleBackColor = true;
            button_index.Click += button_index_Click;
            // 
            // button_substring
            // 
            button_substring.Location = new Point(188, 333);
            button_substring.Name = "button_substring";
            button_substring.Size = new Size(75, 23);
            button_substring.TabIndex = 6;
            button_substring.Text = "Substring";
            button_substring.UseVisualStyleBackColor = true;
            // 
            // Button_Stop
            // 
            Button_Stop.Location = new Point(269, 333);
            Button_Stop.Name = "Button_Stop";
            Button_Stop.Size = new Size(75, 23);
            Button_Stop.TabIndex = 7;
            Button_Stop.Text = "Dừng";
            Button_Stop.UseVisualStyleBackColor = true;
            // 
            // lbl_banner
            // 
            lbl_banner.AutoSize = true;
            lbl_banner.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_banner.Location = new Point(27, 10);
            lbl_banner.Name = "lbl_banner";
            lbl_banner.Size = new Size(286, 25);
            lbl_banner.TabIndex = 8;
            lbl_banner.Text = "CHƯƠNG TRÌNH XỬ LÝ CHUỖI";
            // 
            // lbl_CT1
            // 
            lbl_CT1.AutoSize = true;
            lbl_CT1.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_CT1.Location = new Point(26, 66);
            lbl_CT1.Name = "lbl_CT1";
            lbl_CT1.Size = new Size(170, 19);
            lbl_CT1.TabIndex = 9;
            lbl_CT1.Text = "Nhập vào chuỗi thứ nhất:";
            // 
            // lbl_CT2
            // 
            lbl_CT2.AutoSize = true;
            lbl_CT2.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_CT2.Location = new Point(26, 125);
            lbl_CT2.Name = "lbl_CT2";
            lbl_CT2.Size = new Size(161, 19);
            lbl_CT2.TabIndex = 10;
            lbl_CT2.Text = "Nhập vào chuỗi thứ hai:";
            // 
            // lbl_KQ
            // 
            lbl_KQ.AutoSize = true;
            lbl_KQ.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lbl_KQ.Location = new Point(26, 173);
            lbl_KQ.Name = "lbl_KQ";
            lbl_KQ.Size = new Size(58, 19);
            lbl_KQ.TabIndex = 11;
            lbl_KQ.Text = "Kết quả";
            // 
            // txt_CT1
            // 
            txt_CT1.Location = new Point(70, 88);
            txt_CT1.Name = "txt_CT1";
            txt_CT1.PlaceholderText = "Nhập chuỗi 1";
            txt_CT1.Size = new Size(274, 23);
            txt_CT1.TabIndex = 12;
            // 
            // txt_CT2
            // 
            txt_CT2.Location = new Point(70, 147);
            txt_CT2.Name = "txt_CT2";
            txt_CT2.PlaceholderText = "Nhập chuỗi 2";
            txt_CT2.Size = new Size(274, 23);
            txt_CT2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(lbl_banner);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 44);
            panel1.TabIndex = 15;
            // 
            // richTextBox_KQ
            // 
            richTextBox_KQ.BackColor = Color.PaleGoldenrod;
            richTextBox_KQ.Location = new Point(26, 195);
            richTextBox_KQ.Name = "richTextBox_KQ";
            richTextBox_KQ.Size = new Size(318, 86);
            richTextBox_KQ.TabIndex = 13;
            richTextBox_KQ.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 364);
            Controls.Add(txt_CT2);
            Controls.Add(richTextBox_KQ);
            Controls.Add(txt_CT1);
            Controls.Add(lbl_KQ);
            Controls.Add(lbl_CT2);
            Controls.Add(lbl_CT1);
            Controls.Add(Button_Stop);
            Controls.Add(button_substring);
            Controls.Add(button_index);
            Controls.Add(button_COMPA);
            Controls.Add(Button_Xoa);
            Controls.Add(button_Insert);
            Controls.Add(button_Concat);
            Controls.Add(Button_Compare);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Bài 10 - xử lý chuối";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Compare;
        private Button button_Concat;
        private Button button_Insert;
        private Button Button_Xoa;
        private Button button_COMPA;
        private Button button_index;
        private Button button_substring;
        private Button Button_Stop;
        private Label lbl_banner;
        private Label lbl_CT1;
        private Label lbl_CT2;
        private Label lbl_KQ;
        private TextBox txt_CT1;
        private TextBox txt_CT2;
        private Panel panel1;
        private RichTextBox richTextBox_KQ;
    }
}