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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            load_Form();
        }
        private void load_Form()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtNhaCC = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaNCC as'Mã Nhà Cung Cấp',TenNhaCungCap as'Tên Nhà Cung Cấp',DiaChi as'Địa Chỉ',Email as'Email' FROM NHACUNGCAP", conn);
            da.Fill(dtNhaCC);
            dgvNCC.DataSource = dtNhaCC;
            dgvNCC.Refresh();

            conn.Close();
        }
        private void Reset()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtEnail.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenNCC.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên Nhà Cung Cấp", "Thông Báo", MessageBoxButtons.OK);
                txtTenNCC.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Địa Chỉ Nhà Cung Cấp", "Thông Báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }
            if (txtEnail.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Email Nhà Cung Cấp", "Thông Báo", MessageBoxButtons.OK);
                txtEnail.Focus();
                return;
            }
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("ThemNhaCC", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@TenNhaCungCAp", txtTenNCC.Text.Trim());
            comm.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
            comm.Parameters.AddWithValue("@Email", txtEnail.Text.Trim());

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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("SuaNhaCC", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text.Trim());
            comm.Parameters.AddWithValue("@TenNhaCungCAp", txtTenNCC.Text.Trim());
            comm.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
            comm.Parameters.AddWithValue("@Email", txtEnail.Text.Trim());

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

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNCC.CurrentRow.Index;
            txtMaNCC.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNCC.Rows[i].Cells[2].Value.ToString();
            txtEnail.Text = dgvNCC.Rows[i].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("XoaNhaCC", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text.Trim());
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhaCungCap where MaNCC LIKE '%" + txtTimKiem.Text + "%'", conn);
            da.Fill(dtLSP);
            dgvNCC.DataSource = dtLSP;
            dgvNCC.Refresh();

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

        private void bntReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
