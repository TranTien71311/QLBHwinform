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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            Load_TimNVTot();
            Load_ThongKe();
            Load_TimKHVip();
        }
        private void Load_TimNVTot()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("TimNVBanTot", conn);
            comm.CommandType = CommandType.StoredProcedure;
            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dtBanHang);
            dtgNVTot.DataSource = dtBanHang;
            dtgNVTot.Refresh();
            conn.Close();
        }
        private void Load_ThongKe()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("ThogKe", conn);
            comm.CommandType = CommandType.StoredProcedure;
            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dtBanHang);
            dgvSPE.DataSource = dtBanHang;
            dgvSPE.Refresh();
            conn.Close();
        }
        private void Load_TimKHVip()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";
            conn.Open();
            SqlCommand comm = new SqlCommand("TimKHVip", conn);
            comm.CommandType = CommandType.StoredProcedure;
            DataTable dtBanHang = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dtBanHang);
            dgvKHVip.DataSource = dtBanHang;
            dgvKHVip.Refresh();
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
