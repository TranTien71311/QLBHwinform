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
    public partial class frmQLNhapHang : Form
    {
        public frmQLNhapHang()
        {
            InitializeComponent();
        }

        private void frmQLNhapHang_Load(object sender, EventArgs e)
        {
            load_Form();
        }
        private void load_Form()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaHD,MaNV,MaNCC,NgayNhap,TongTien FROM HOADONNHAPHANG", conn);
            da.Fill(dtBanHang);
            dgvHDN.DataSource = dtBanHang;
            dgvHDN.Refresh();

            conn.Close();
        }
        private void TimKiem()
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();

            DataTable dtLSP = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CTHoaDonNhapHang where MaHD = '" + txtTimKiem.Text + "'", conn);
            da.Fill(dtLSP);
            dgvCTHDN.DataSource = dtLSP;
            dgvCTHDN.Refresh();

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


        private void bntNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
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

        private void dgvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgvHDN.CurrentRow.Index;
            dgvHDN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtTimKiem.Text = dgvHDN.Rows[i].Cells[0].Value.ToString();
        }
    }
}
