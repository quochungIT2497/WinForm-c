namespace Bai3_winform
{
    partial class Form6
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
            lbl_MaKH = new Label();
            lbl_SDT = new Label();
            txt_MaKH = new TextBox();
            txt_SDT = new TextBox();
            btn_TK = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(480, 114);
            dataGridView1.TabIndex = 0;
            // 
            // lbl_MaKH
            // 
            lbl_MaKH.AutoSize = true;
            lbl_MaKH.Location = new Point(194, 152);
            lbl_MaKH.Name = "lbl_MaKH";
            lbl_MaKH.Size = new Size(43, 15);
            lbl_MaKH.TabIndex = 1;
            lbl_MaKH.Text = "Mã KH";
            // 
            // lbl_SDT
            // 
            lbl_SDT.AutoSize = true;
            lbl_SDT.Location = new Point(194, 186);
            lbl_SDT.Name = "lbl_SDT";
            lbl_SDT.Size = new Size(27, 15);
            lbl_SDT.TabIndex = 2;
            lbl_SDT.Text = "SĐT";
            // 
            // txt_MaKH
            // 
            txt_MaKH.Location = new Point(243, 149);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.PlaceholderText = "<KH>+<STT>";
            txt_MaKH.Size = new Size(100, 23);
            txt_MaKH.TabIndex = 3;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(243, 178);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.PlaceholderText = "00000000";
            txt_SDT.Size = new Size(100, 23);
            txt_SDT.TabIndex = 4;
            // 
            // btn_TK
            // 
            btn_TK.Location = new Point(254, 218);
            btn_TK.Name = "btn_TK";
            btn_TK.Size = new Size(75, 23);
            btn_TK.TabIndex = 5;
            btn_TK.Text = "Tìm Kiếm";
            btn_TK.UseVisualStyleBackColor = true;
            btn_TK.Click += btn_TK_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 276);
            Controls.Add(btn_TK);
            Controls.Add(txt_SDT);
            Controls.Add(txt_MaKH);
            Controls.Add(lbl_SDT);
            Controls.Add(lbl_MaKH);
            Controls.Add(dataGridView1);
            Name = "Form6";
            Text = "Tìm Kiếm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_MaKH;
        private Label lbl_SDT;
        private TextBox txt_MaKH;
        private TextBox txt_SDT;
        private Button btn_TK;
    }
}