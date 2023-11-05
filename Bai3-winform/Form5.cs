using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai3_winform
{
    public partial class Form5 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string ConnectionString = "Data Source=DESKTOP-6HJIUMS;Initial Catalog=QuanLyKhachHang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable DT = new DataTable();
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                //string ConnectionString = "Data Source=DESKTOP-6HJIUMS;Initial Catalog=QuanLyKhachHang;Integrated Security=True";
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                String query = "Select MaKH as [Mã Khách Hàng],TenCty as [Tên Công Ty], DiaChi as [Địa chỉ], ThanhPho as [Thành Phố], SDT as [Số Điện Thoại]" + "From KhachHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                //SqlDataAdapter adapter = new SqlDataAdapter("Select MaKH as [Mã Khách Hàng], TenCty as [Tên Công Ty], DiaChi as [Địa chỉ], ThanhPho as [Thành Phố], SDT as [Số Điện Thoại]" + "From KhachHang", conn);
                //DataTable DT = new DataTable();
                DT.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(DT);
                dataGridView1.DataSource = DT;
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không lấy được dữ liệu", "Thông báo");
            }
        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                String Query = "select MaKH as [Mã Khách Hàng],TenCty as [Tên Công Ty], DiaChi as [Địa chỉ], ThanhPho as [Thành Phố], SDT as [Số Điện Thoại] from KhachHang";
                String QuerySDT = "select MaKH as [Mã Khách Hàng],TenCty as [Tên Công Ty], DiaChi as [Địa chỉ], ThanhPho as [Thành Phố], SDT as [Số Điện Thoại] from KhachHang where SDT like" + "'%_" + txt_SDTKH.Text + "' or MaKH = '" + txt_MaKH.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerySDT, conn);
                SqlCommand QA = new SqlCommand(Query, conn);
                DT.Clear();
                if(txt_MaKH.Text != "" || txt_SDTKH.Text != "")
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
                DialogResult error = MessageBox.Show("Không tìm thấy người dùng","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (error == DialogResult.OK)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                String CheckVl = "Declare @SDT int SELECT @SDT = COUNT(*) FROM KhachHang WHERE SDT = " + txt_SDTKH.Text +
                " IF(@SDT > 0) Select MaKH as [Mã Khách Hàng],TenCty as [Tên Công Ty], DiaChi as [Địa chỉ], ThanhPho as [Thành Phố], SDT as [Số Điện Thoại] from KhachHang where SDT = " + txt_SDTKH.Text +
                " Else Insert Into KhachHang Values('" + txt_MaKH.Text + "','" + txt_TenCty.Text + "','" + txt_Dchi.Text
                    + "','" + txt_ThanhPho.Text + "'," + txt_SDTKH.Text + ")" +
                    "Select MaKH as [Mã Khách Hàng],TenCty as [Tên Công Ty], DiaChi as [Địa chỉ], ThanhPho as [Thành Phố], SDT as [Số Điện Thoại] from KhachHang where SDT =" + txt_SDTKH.Text;
                SqlCommand cmdadd = new SqlCommand(CheckVl, conn);
                DT.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(cmdadd);
                adapter.Fill(DT);
                dataGridView1.DataSource = DT;
                conn.Close();
                MessageBox.Show("Người dùng đã tồn tại", "Thông báo");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm Không Thành Công", "Lỗi");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                String SuaKH = "UPDATE KhachHang set TenCty = '" + txt_TenCty.Text + "', DiaChi = '" + txt_Dchi.Text + "',ThanhPho = '" + txt_ThanhPho.Text
                    + "', SDT=" + txt_SDTKH.Text + " Where MaKH= '" + txt_MaKH.Text + "' or SDT=" + txt_SDTKH.Text
                    + "\nSelect MaKH as [Mã Khách Hàng],TenCty as [Tên Công Ty], DiaChi as [Địa chỉ], ThanhPho as [Thành Phố], SDT as [Số Điện Thoại] from KhachHang where MaKH ='" + txt_MaKH.Text + "'";
                SqlCommand cmdSua = new SqlCommand(SuaKH, conn);
                DT.Clear();
                SqlDataAdapter Adapter = new SqlDataAdapter(cmdSua);
                Adapter.Fill(DT);
                dataGridView1.DataSource = DT;
                conn.Close();
                MessageBox.Show("Sửa Thông tin thành công", "Thông Báo");
            }
            catch (SqlException ex)
            {
                DialogResult loi = MessageBox.Show("Sửa Thất Bại!", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (loi == DialogResult.OK)
                {
                    //Chỉ đóng dialogresult
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                String XoaKH = "Delete from KhachHang where MaKH = '" + txt_MaKH.Text + "' or SDT=" + txt_SDTKH.Text;
                SqlCommand cmdXoa = new SqlCommand(XoaKH, conn);
                DT.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(cmdXoa);
                adapter.Fill(DT);
                dataGridView1.DataSource = adapter;
                conn.Close();
                DialogResult TC = MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (TC == DialogResult.OK)
                {

                }
            }
            catch(SqlException ex)
            {
                DialogResult TB = MessageBox.Show("Xoá thông tin thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (TB == DialogResult.OK)
                {

                }
            }
        }
    }
}
