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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            cbbLSP.DataSource = LayDuLieuLSP();
            cbbLSP.DisplayMember = "TenSanPham";
            cbbLSP.ValueMember = "MaLSP";
            cbbNSX.DataSource = LayDuLieuNSX();
            cbbNSX.DisplayMember = "TenSanPham";
            cbbNSX.ValueMember = "MaNSX";
            load_Form();
          
        }
        private void load_Form()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtLSP = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaSP as'Mã Sản Phẩm',TenSanPham as'Tên Sản Phẩm',MaLSP as'Mã Loại Sản Phẩm',MaNSX as'Mã Nhà Sản Xuất',SoLuong as'Số Lượng',DonGia as'Đơn Giá' FROM SANPHAM", conn);
            da.Fill(dtLSP);
            dgvSanPham.DataSource = dtLSP;
            dgvSanPham.Refresh();

            conn.Close();
            txtSoLuong.Text = "0";
        }
        private DataTable LayDuLieuLSP()
        {
            DataTable KQ = new System.Data.DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAISANPHAM", conn);
            da.Fill(KQ);

            conn.Close();
            return KQ;
        }
        private DataTable LayDuLieuNSX()
        {
            DataTable KQ = new System.Data.DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHASANXUAT", conn);
            da.Fill(KQ);

            conn.Close();
            return KQ;

        }
        private void Reset()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "0";
            txtDonGia.Text = "";
            cbbLSP.Text = "";
            cbbNSX.Text = "";

                
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

          
            if (txtTenSP.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên Sản Phẩm", "Thông Báo", MessageBoxButtons.OK);
                txtTenSP.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Số Lượng Sản Phẩm", "Thông Báo", MessageBoxButtons.OK);
                txtSoLuong.Focus();
                return;
            }
            if (txtDonGia.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Đơn Giá Sản Phẩm", "Thông Báo", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return;
            }
            if (cbbLSP.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Số Lượng Sản Phẩm", "Thông Báo", MessageBoxButtons.OK);
                cbbLSP.Focus();
                return;
            }
            if (cbbNSX.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên Sản Phẩm", "Thông Báo", MessageBoxButtons.OK);
                cbbNSX.Focus();
                return;
            }

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("ThemSanPham", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@TenSanpham", txtTenSP.Text.Trim());
            comm.Parameters.AddWithValue("@MaLSP", cbbLSP.SelectedValue.ToString().Trim());
            comm.Parameters.AddWithValue("@MaNSX", cbbNSX.SelectedValue.ToString().Trim());
            comm.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text.Trim());
            comm.Parameters.AddWithValue("@DonGia", txtDonGia.Text.Trim());

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
            SqlCommand comm = new SqlCommand("SuaSanPham", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());
            comm.Parameters.AddWithValue("@TenSanpham", txtTenSP.Text.Trim());
            comm.Parameters.AddWithValue("@MaLSP", cbbLSP.SelectedValue.ToString().Trim());
            comm.Parameters.AddWithValue("@MaNSX", cbbNSX.SelectedValue.ToString().Trim());
            comm.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text.Trim());
            comm.Parameters.AddWithValue("@DonGia", txtDonGia.Text.Trim());

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


        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maLSP;
            string maNSX;
            int i;
            i = dgvSanPham.CurrentRow.Index;
            txtMaSP.Text = dgvSanPham.Rows[i].Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.Rows[i].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvSanPham.Rows[i].Cells[4].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[i].Cells[5].Value.ToString();
            maLSP = dgvSanPham.Rows[i].Cells[2].Value.ToString();
            maNSX = dgvSanPham.Rows[i].Cells[3].Value.ToString();

            cbbLSP.SelectedValue = maLSP;
            cbbNSX.SelectedValue = maNSX;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("XoaSanPham", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());

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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SanPham where MaSP LIKE '%" + txtTimKiem.Text + "%'", conn);
            da.Fill(dtLSP);
            dgvSanPham.DataSource = dtLSP;
            dgvSanPham.Refresh();

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

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frm = new frmLoaiSanPham();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnNhaSX_Click(object sender, EventArgs e)
        {
            frmNhaSanXuat frm = new frmNhaSanXuat();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }
    }
}
