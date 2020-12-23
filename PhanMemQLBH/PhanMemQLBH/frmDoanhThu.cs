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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            Load_DoanhThuNgay();
            Load_DoanhThuThang();
            Load_DoanhThuNam();
            Load_TongBan();
            Load_TongNhap();
        }
        private void Load_DoanhThuNgay()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("DoanhThuNgay", conn);
            comm.CommandType = CommandType.StoredProcedure;
            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dtBanHang);
            dgvNgay.DataSource = dtBanHang;
            dgvNgay.Refresh();
            conn.Close();
        }
        private void Load_DoanhThuThang()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("DoanhThuThang", conn);
            comm.CommandType = CommandType.StoredProcedure;
            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dtBanHang);
            dgvThang.DataSource = dtBanHang;
            dgvThang.Refresh();
            conn.Close();
        }
        private void Load_DoanhThuNam()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("DoanhThuNam", conn);
            comm.CommandType = CommandType.StoredProcedure;
            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dtBanHang);
            dgvNam.DataSource = dtBanHang;
            dgvNam.Refresh();
            conn.Close();
        }
        private void Load_TongBan()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("TongNhap", conn);
            comm.CommandType = CommandType.StoredProcedure;
            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dtBanHang);
            dgvTongBan.DataSource = dtBanHang;
            dgvTongBan.Refresh();
            conn.Close();
        }
        private void Load_TongNhap()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("TongBan", conn);
            comm.CommandType = CommandType.StoredProcedure;
            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dtBanHang);
            dgvTongNhap.DataSource = dtBanHang;
            dgvTongNhap.Refresh();
            conn.Close();
        }

        private void butTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
