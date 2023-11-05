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
    public partial class Form6 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string ConnectionString = "Data Source=DESKTOP-6HJIUMS;Initial Catalog=QuanLyKhachHang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable DT = new DataTable();

        public Form6()
        {
            InitializeComponent();
        }


        private void btn_TK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                String Query = "select MaKH as [Mã Khách Hàng],TenCty as [Tên Công Ty], DiaChi as [Địa chỉ], ThanhPho as [Thành Phố], SDT as [Số Điện Thoại] from KhachHang";
                String QuerySDT = "select MaKH as [Mã Khách Hàng],TenCty as [Tên Công Ty], DiaChi as [Địa chỉ], ThanhPho as [Thành Phố], SDT as [Số Điện Thoại] from KhachHang where SDT like" + "'%_" + txt_SDT.Text + "_%' or MaKH = '" + txt_MaKH.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerySDT, conn);
                SqlCommand QA = new SqlCommand(Query, conn);
                DT.Clear();
                if (txt_MaKH.Text != "" || txt_SDT.Text != "")
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(DT);
                    dataGridView1.DataSource = DT;
                }
                else
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(QA);
                    adapter.Fill(DT);
                    dataGridView1.DataSource = DT;
                }
            }
            catch (SqlException ex)
            {
                DialogResult error = MessageBox.Show("Không tìm thấy người dùng, Thoát tìm kiếm?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (error == DialogResult.OK)
                {
                    this.Hide();
                }
            }
        }
    }
}
