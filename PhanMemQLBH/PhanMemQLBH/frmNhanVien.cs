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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            load_Form();
        }
        private void load_Form()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtNhaCC = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaNV as'Mã Nhân Viên',TenNhanVien as'Tên Nhân Viên',DiaChi as'Địa Chỉ',DienThoai as'Điện Thoại',Email as'Email',ChucVu as'Chức Vụ',Pass as'Mật Khẩu',NgaySinh as'Ngày Sinh' FROM NhanVien", conn);
            da.Fill(dtNhaCC);
            dgvNhanVien.DataSource = dtNhaCC;
            dgvNhanVien.Refresh();

            conn.Close();
        }
        private void Reset()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtPassWord.Text = "";
            dtpNgaySinh.Text = "";
            cbbChucVu.Text = "";
        }
        private void bntThem_Click(object sender, EventArgs e)
        {
            
            if (txtTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên Nhân Viên", "Thông Báo", MessageBoxButtons.OK);
                txtTenNV.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Địa Chỉ", "Thông Báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Điện Thoại", "Thông Báo", MessageBoxButtons.OK);
                txtDienThoai.Focus();
                return;
            }
            if (dtpNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Ngày Sinh", "Thông Báo", MessageBoxButtons.OK);
                dtpNgaySinh.Focus();
                return;
            }
            if (cbbChucVu.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Chức Vụ", "Thông Báo", MessageBoxButtons.OK);
                cbbChucVu.Focus();
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Email", "Thông Báo", MessageBoxButtons.OK);
                txtEmail.Focus();
                return;
            }
            if (txtPassWord.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập PassWord", "Thông Báo", MessageBoxButtons.OK);
                txtPassWord.Focus();
                return;
            }


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("ThemNhanVien", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@TenNhanVien", txtTenNV.Text.Trim());
            comm.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
            comm.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());
            comm.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
            comm.Parameters.AddWithValue("@ChucVu", cbbChucVu.Text.Trim());
            comm.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            comm.Parameters.AddWithValue("@Pass", txtPassWord.Text.Trim());


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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtDienThoai.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            cbbChucVu.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txtPassWord.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
        }

        private void butCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("SuaNhanVien", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
            comm.Parameters.AddWithValue("@TenNhanVien", txtTenNV.Text.Trim());
            comm.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
            comm.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());
            comm.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
            comm.Parameters.AddWithValue("@ChucVu", cbbChucVu.Text.Trim());
            comm.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            comm.Parameters.AddWithValue("@Pass", txtPassWord.Text.Trim());

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

        private void butXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("XoaNhanVien", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());


            int NumOfRuw = comm.ExecuteNonQuery();
            if (NumOfRuw < 0)
            {
                MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Xóa  Thành Công", "Thông Báo", MessageBoxButtons.OK);
            load_Form();
            Reset();
        }

        private void butTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TimKiem()
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtLSP = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien where MaNV LIKE '%" + txtTimKiem.Text + "%'", conn);
            da.Fill(dtLSP);
            dgvNhanVien.DataSource = dtLSP;
            dgvNhanVien.Refresh();

            conn.Close();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                load_Form();
            }
            else
                TimKiem();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
   
}

