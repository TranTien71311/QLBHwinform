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
    public partial class frmNVNhapHang : Form
    {
        List<NhanVien_DTO> listnv = null;
        private string _message;

        public frmNVNhapHang()
        {
            InitializeComponent();
        }
        public frmNVNhapHang(string Message) : this()
        {
            _message = Message;
            txtMaNV.Text = _message;
        }
        private void frmNVNhaHang_Load(object sender, EventArgs e)
        {
            
            load_Form();
            cbbMaNCC.DataSource = LayDuLieuNCC();
            cbbMaNCC.DisplayMember = "TenNhaCungCap";
            cbbMaNCC.ValueMember = "MaNCC";
            cbbMaSP.DataSource = LayDuLieuSP();
            cbbMaSP.DisplayMember = "TenSanPham";
            cbbMaSP.ValueMember = "MaSP";


        }
       
        private void load_Form()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaHD as'Mã Hóa Đơn',MaNV as'Mã Nhân Viên',MaNCC as'Mã Nhà Cung Cấp',NgayNhap as'Ngày Nhập',TongTien as'Tổng Tiền' FROM HOADONNHAPHANG", conn);
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaHD as'Mã Hóa Đơn',MaSP as'Mã Sản Phẩm',SoLuong as'Số Lượng',DonGia as'Đơn Giá',ThanhTien as'Thành Tiền' FROM CTHOADONNHAPHANG WHERE TrangThai=1", conn);
            da.Fill(dtBanHang);
            dgvBanHang.DataSource = dtBanHang;
            dgvBanHang.Refresh();

            conn.Close();
        }
        private DataTable LayDuLieuNCC()
        {
            DataTable KQ = new System.Data.DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHACUNGCAP", conn);
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
                    double kq = slc + sl;
                    lbeSoLuong.Text = kq.ToString();
                }

            }
        }


        private void txtSoL_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
            TinhSLCon();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void butThem_Click(object sender, EventArgs e)
        {

            if (cbbMaNCC.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Tên Nhà Cung Cấp", "Thông Báo", MessageBoxButtons.OK);
                cbbMaNCC.Focus();
                return;
            }
            if (dtpNgayNhap.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Nhập Ngày Bán", "Thông Báo", MessageBoxButtons.OK);
                dtpNgayNhap.Focus();
                return;
            }


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("TaoHoaDonNhap", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
            comm.Parameters.AddWithValue("@MaNCC", cbbMaNCC.SelectedValue.ToString().Trim());
            comm.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
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
            btnThem.Enabled = false;
            btnhemHD.Enabled = true;
            btnReset.Enabled = false;
        }

        private void btnhemHD_Click(object sender, EventArgs e)
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
            

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("ThemCTHoaDonNhap", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
            comm.Parameters.AddWithValue("@MaSP", cbbMaSP.SelectedValue.ToString().Trim());
            comm.Parameters.AddWithValue("@SoLuong", txtSoL.Text.Trim());
            comm.Parameters.AddWithValue("@DonGia", txtDonGia.Text.Trim());
            comm.Parameters.AddWithValue("@ThanhTien", txtThanhTien.Text.Trim());
            comm.Parameters.AddWithValue("@SoLuongc", lbeSoLuong.Text.Trim());

            int NumOfRuw = comm.ExecuteNonQuery();
            if (NumOfRuw > 0)
            {
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
            load_Form1();
            long TongTien = long.Parse(txtTongTien.Text);
            long thanhtien = long.Parse(txtThanhTien.Text);
            long kq = TongTien + thanhtien;
            txtTongTien.Text = kq.ToString();
            SqlCommand com = new SqlCommand("TongTienNhap", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
            com.Parameters.AddWithValue("@TongTien", int.Parse(txtTongTien.Text.Trim()));
            btnThem.Enabled = false;
            btnReset.Enabled = false;
            btnLuu.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("LuuHDNhap", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@MaHD", txtMaHD.Text.Trim());
            comm.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
            comm.Parameters.AddWithValue("@MaNCC", cbbMaNCC.SelectedValue.ToString().Trim());
            comm.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
            comm.Parameters.AddWithValue("@TongTien", txtTongTien.Text.Trim());
            int NumOfRuw = comm.ExecuteNonQuery();
            if (NumOfRuw < 0)
            {
                MessageBox.Show("Lưu không Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK);
            load_Form();
            txtTongTien.Text = "0";
            btnLuu.Enabled = false;
            btnhemHD.Enabled = false;
            btnThem.Enabled = true;
            btnReset.Enabled = true;
        }

       
        private void TimKiem()
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtLSP = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CTHoaDonNhapHang where MaHD = '" + txtTimKiem.Text + "'", conn);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtSoL.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
            cbbMaNCC.Text = "";
            cbbMaSP.Text = "";
            txtDonGia.Text = "";
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

        private void dgvBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvBanHang.CurrentRow.Index;
            dgvBanHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtMaHD.Text = dgvBanHang.Rows[i].Cells[0].Value.ToString();
        }

        private void txtSoL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
