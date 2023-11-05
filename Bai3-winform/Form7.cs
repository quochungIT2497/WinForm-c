using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_winform
{
    public partial class Form7 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string ConnectionString = "Data Source=DESKTOP-6HJIUMS;Initial Catalog=QuanLyKhachHang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable DT = new DataTable();
        public Form7()
        {
            InitializeComponent();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                String XoaKH = "Delete from KhachHang where MaKH = '" + txt_MaKH.Text + "'"; // "' or SDT=" + txt_SDTKH.Text;
                SqlCommand cmdXoa = new SqlCommand(XoaKH, conn);
                DT.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(cmdXoa);
                adapter.Fill(DT);
                //dataGridView1.DataSource = adapter;
                conn.Close();
                DialogResult TC = MessageBox.Show("Xoá thông tin thành công \nBạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (TC == DialogResult.OK)
                {
                    this.Hide();
                }
            }
            catch (SqlException ex)
            {
                DialogResult TB = MessageBox.Show("Xoá thông tin thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (TB == DialogResult.OK)
                {

                }
            }
        }
    }
}
