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

namespace PhanMemQLBH
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            load_Form();
        }
        private void load_Form()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtNhaCC = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaKH as'Mã Khách Hàng',HoTen as'Tên Khách Hàng',DiaChi as'Địa Chỉ',DienThoai as'Điện Thoại',Email as'Email' FROM KHACHHANG", conn);
            da.Fill(dtNhaCC);
            dgvKhachHang.DataSource = dtNhaCC;
            dgvKhachHang.Refresh();

            conn.Close();
        }
        private void Reset()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtEmail.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (txtTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên Khách Hàng", "Thông Báo", MessageBoxButtons.OK);
                txtTenKH.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Địa Chỉ Khách Hàng", "Thông Báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Email Khách Hàng", "Thông Báo", MessageBoxButtons.OK);
                txtEmail.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Điện Thoại Khách Hàng", "Thông Báo", MessageBoxButtons.OK);
                txtDienThoai.Focus();
                return;
            }
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("ThemKhachHang", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@TenKH", txtTenKH.Text.Trim());
            comm.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
            comm.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            comm.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());

            int NumOfRuw = comm.ExecuteNonQuery();
            if (NumOfRuw < 0)
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK);
            load_Form();
            Reset();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKhachHang.CurrentRow.Index;
            txtMaKH.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("SuaKhachHang", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());
            comm.Parameters.AddWithValue("@TenKH", txtTenKH.Text.Trim());
            comm.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
            comm.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            comm.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());

            int NumOfRuw = comm.ExecuteNonQuery();
            if (NumOfRuw < 0)
            {
                MessageBox.Show("Cập Nhật Không Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK);
            load_Form();
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("XoaKhachHang", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());
            int NumOfRuw = comm.ExecuteNonQuery();
            if (NumOfRuw < 0)
            {
                MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
            load_Form();
            Reset();
        }
        private void TimKiem()
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtLSP = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHang where MaKH LIKE '%" + txtTimKiem.Text + "%'", conn);
            da.Fill(dtLSP);
            dgvKhachHang.DataSource = dtLSP;
            dgvKhachHang.Refresh();

            conn.Close();

        }

        private void butTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                load_Form();
            }
            else
                TimKiem();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
    
}
