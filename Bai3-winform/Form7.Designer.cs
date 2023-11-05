namespace Bai3_winform
{
    partial class Form7
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
            lbl_MaKH = new Label();
            txt_MaKH = new TextBox();
            btn_Xoa = new Button();
            SuspendLayout();
            // 
            // lbl_MaKH
            // 
            lbl_MaKH.AutoSize = true;
            lbl_MaKH.Location = new Point(30, 28);
            lbl_MaKH.Name = "lbl_MaKH";
            lbl_MaKH.Size = new Size(43, 15);
            lbl_MaKH.TabIndex = 0;
            lbl_MaKH.Text = "Mã KH";
            // 
            // txt_MaKH
            // 
            txt_MaKH.Location = new Point(79, 20);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.Size = new Size(100, 23);
            txt_MaKH.TabIndex = 1;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(79, 59);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(75, 23);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 111);
            Controls.Add(btn_Xoa);
            Controls.Add(txt_MaKH);
            Controls.Add(lbl_MaKH);
            Name = "Form7";
            Text = "Xoá";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_MaKH;
        private TextBox txt_MaKH;
        private Button btn_Xoa;
    }
}