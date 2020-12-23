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
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            load_Form();
        }
        private void Reset()
        {
            txtMaLSP.Text = "";
            txtTenSP.Text = "";
            
        }
        private void load_Form()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtLSP = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaLSP as'Mã Loại Sản Phẩm',TenSanPham as'Tên Loại Sản Phẩm' FROM LoaiSanPham", conn);
            da.Fill(dtLSP);
            dgvLSP.DataSource = dtLSP;
            dgvLSP.Refresh();

            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (txtTenSP.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên Sản Phẩm", "Thông Báo", MessageBoxButtons.OK);
                txtTenSP.Focus();
                return;
            }

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("ThemLoaiSP", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@TenSanpham", txtTenSP.Text.Trim());
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

        private void dgvLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvLSP.CurrentRow.Index;
            dgvLSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtMaLSP.Text = dgvLSP.Rows[i].Cells[0].Value.ToString();
            txtTenSP.Text = dgvLSP.Rows[i].Cells[1].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("SuaLSP", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaLSP", txtMaLSP.Text.Trim());
            comm.Parameters.AddWithValue("@TenSanpham", txtTenSP.Text.Trim());
            int NumOfRuw = comm.ExecuteNonQuery();
            if (NumOfRuw < 0)
            {
                MessageBox.Show("Sửa Không Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
            load_Form();
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("XoaLSP", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaLSP", txtMaLSP.Text.Trim());
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LoaiSanPham where MaLSP LIKE '%" + txtTimKiem.Text + "%'", conn);
            da.Fill(dtLSP);
            dgvLSP.DataSource = dtLSP;
            dgvLSP.Refresh();

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
