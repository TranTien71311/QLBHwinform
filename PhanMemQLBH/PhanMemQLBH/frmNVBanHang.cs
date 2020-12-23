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
using BUS;
using DTO;

namespace PhanMemQLBH
{
    public partial class frmNVBanHang : Form
    {
        List<NhanVien_DTO> listnv = null;
        public frmNVBanHang()
        {
            InitializeComponent();
        }
        private string _message;
        public frmNVBanHang(string Message) : this()
        {
            _message = Message;
            txtMaNV.Text = _message;
        }
        private void frmNVBanHang_Load(object sender, EventArgs e)
        {
            cbbMaKH.DataSource = LayDuLieuKH();
            cbbMaKH.DisplayMember = "HoTen";
            cbbMaKH.ValueMember = "MaKH";
            cbbMaSP.DataSource = LayDuLieuSP();
            cbbMaSP.DisplayMember = "TenSanPham";
            cbbMaSP.ValueMember = "MaSP";
            
            load_Form(); 
        }
        private void load_Form()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaHD as 'Mã Hóa Đơn',MaNV as'Mã Nhân Viên',MaKH as'Mã Khách Hàng',NgayBan as'Ngày Bán',TongTien as'Tổng Tiền' FROM HOADONBANHANG", conn);
            da.Fill(dtBanHang);
            dgvBanHang.DataSource = dtBanHang;
            dgvBanHang.Refresh();
            

            conn.Close();
        }
        private void load_Form1()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaHD as'Mã Hóa Đơn',MaSP as'Mã Sản Phẩm',SoLuong as'Số Lượng',DonGia as'Đơn Giá',ThanhTien as'Thành Tiền' FROM CTHOADONBANHANG WHERE TrangThai=1", conn);
            da.Fill(dtBanHang);
            dgvBanHang.DataSource = dtBanHang;
            dgvBanHang.Refresh();

            conn.Close();
        }
        

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private DataTable LayDuLieuKH()
        {
            DataTable KQ = new System.Data.DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG", conn);
            da.Fill(KQ);

            conn.Close();
            return KQ;
        }
        private DataTable LayDuLieuSP()
        {
            DataTable KQ = new System.Data.DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SANPHAM", conn);
            da.Fill(KQ);

            conn.Close();
            return KQ;
        }
        private void TinhSLCon()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("Select *  From SANPHAM Where MaSP ='" + cbbMaSP.SelectedValue.ToString() + "'", conn);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (txtSoL.Text == "")
                {
                    lbeSoLuong.Text = "";
                }
                else
                {
                    double sl = double.Parse(txtSoL.Text);
                    double slc = double.Parse(reader.GetInt32(5).ToString());
                    double kq = slc - sl;
                    lbeSoLuong.Text = kq.ToString();
                }

            }
        }

        private void TinhThanhTien()
        {
            if (txtSoL.Text == "" || txtDonGia.Text == "")
            {
                txtThanhTien.Text = "";
            }
            else
            {
                long soThuNhat = long.Parse(txtDonGia.Text);
                long soThuHai = long.Parse(txtSoL.Text);
                long kq = soThuHai * soThuNhat;
                txtThanhTien.Text = kq.ToString();
            }
        }

        private void cbbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("Select *  From SANPHAM Where MaSP ='" + cbbMaSP.SelectedValue.ToString() + "'", conn);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txtDonGia.Text = reader.GetInt32(6).ToString();

            }
            TinhThanhTien();
            TinhSLCon();
        }

        private void txtSoL_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
            TinhSLCon();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            
            if (cbbMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên Khách Hàng", "Thông Báo", MessageBoxButtons.OK);
                cbbMaKH.Focus();
                return;
            }
            if (dtpNgayBan.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Ngày Bán", "Thông Báo", MessageBoxButtons.OK);
                dtpNgayBan.Focus();
                return;
            }


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("TaoHoaDon", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
            comm.Parameters.AddWithValue("@MaKH", cbbMaKH.SelectedValue.ToString().Trim());
            comm.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
            comm.Parameters.AddWithValue("@TongTien", 0);


            int NumOfRuw = comm.ExecuteNonQuery();
            if (NumOfRuw < 0)
            {
                MessageBox.Show("Tạo Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Tạo Không Thành Công", "Thông Báo", MessageBoxButtons.OK);
            load_Form();
            txtTongTien.Text = "0";
            butThem.Enabled = false;
            buthemHD.Enabled = true;
            bntReset.Enabled = false;
        }

        private void buthemHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã Hóa Đơn", "Thông Báo", MessageBoxButtons.OK);
                txtMaHD.Focus();
                return;
            }
            if (cbbMaSP.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Mã Sản Phẩm", "Thông Báo", MessageBoxButtons.OK);
                cbbMaSP.Focus();
                return;
            }

            if (txtSoL.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Số Lượng", "Thông Báo", MessageBoxButtons.OK);
                txtSoL.Focus();
                return;
            }
            int sl = int.Parse(lbeSoLuong.Text);
            if (sl < 0)
            {
                MessageBox.Show("Sản Phẩm Không Đủ Cung Cấp", "Thông Báo", MessageBoxButtons.OK);
                txtSoL.Focus();
                return;
            }

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("ThemCTHoaDon", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
            comm.Parameters.AddWithValue("@MaSP", cbbMaSP.SelectedValue.ToString().Trim());
            comm.Parameters.AddWithValue("@SoLuong", txtSoL.Text.Trim());
            comm.Parameters.AddWithValue("@DonGia", txtDonGia.Text.Trim());
            comm.Parameters.AddWithValue("@ThanhTien", txtThanhTien.Text.Trim());
            comm.Parameters.AddWithValue("@SoLuongc", lbeSoLuong.Text.Trim());

            int NumOfRuw = comm.ExecuteNonQuery();
            if (NumOfRuw < 0)
            {
                MessageBox.Show("Thêm  Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK);
            load_Form1();
            long TongTien = long.Parse(txtTongTien.Text);
            long thanhtien = long.Parse(txtThanhTien.Text);
            long kq = TongTien + thanhtien;
            txtTongTien.Text = kq.ToString();
            SqlCommand com = new SqlCommand("TongTien", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
            com.Parameters.AddWithValue("@TongTien", int.Parse(txtTongTien.Text.Trim()));
            butThem.Enabled = false;
            bntReset.Enabled = false;
            butLuu.Enabled = true;
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("LuuHD", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
            comm.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
            comm.Parameters.AddWithValue("@MaKH", cbbMaKH.SelectedValue.ToString().Trim());
            comm.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
            comm.Parameters.AddWithValue("@TongTien", txtTongTien.Text.Trim());
            int NumOfRuw = comm.ExecuteNonQuery();
            if (NumOfRuw < 0)
            {
                MessageBox.Show("Lưu Không Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK);
            load_Form();
            txtTongTien.Text = "0";
            butLuu.Enabled = false;
            buthemHD.Enabled = false;
            butThem.Enabled = true;
            bntReset.Enabled = true;
        }

        private void dgvBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvBanHang.CurrentRow.Index;
            dgvBanHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtMaHD.Text = dgvBanHang.Rows[i].Cells[0].Value.ToString();
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtSoL.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
            cbbMaKH.Text = "";
            cbbMaSP.Text = "";
            frmNVBanHang_Load(sender, e); 
        }
        private void TimKiem()
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtLSP = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CTHoaDonBanHang where MaHD = '" + txtTimKiem.Text + "'", conn);
            da.Fill(dtLSP);
            dgvBanHang.DataSource = dtLSP;
            dgvBanHang.Refresh();

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
            frmDangNhap f = new frmDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Show();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void txtSoL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }

}
