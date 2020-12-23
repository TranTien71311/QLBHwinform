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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void bntNCC_Click(object sender, EventArgs e)
        {

            frmKhachHang f = new frmKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            load_Form();
        }
        private void load_Form()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaHD,MaNV,MaKH,NgayBan,TongTien FROM HOADONBANHANG", conn);
            da.Fill(dtBanHang);
            dgvHDB.DataSource = dtBanHang;
            dgvHDB.Refresh();

            conn.Close();
        }
        private void TimKiem()
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtLSP = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CTHoaDonBanHang where MaHD = '" + txtTimKiem.Text + "'", conn);
            da.Fill(dtLSP);
            dgvCTHDB.DataSource = dtLSP;
            dgvCTHDB.Refresh();

            conn.Close();

        }

        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgvHDB.CurrentRow.Index;
            dgvHDB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtTimKiem.Text = dgvHDB.Rows[i].Cells[0].Value.ToString();
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
            this.Close();
            
            Application.Exit();
        }
    }
}
