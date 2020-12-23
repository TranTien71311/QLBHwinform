using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLBH
{
    public partial class frmQuanLy : Form
    {
       
        public frmQuanLy()
        {
            InitializeComponent();
        }



        private void bntNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmQLNhapHang frm = new frmQLNhapHang();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void bntBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void bntSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void bntThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void bntDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu frm = new frmDoanhThu();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void butTroVe_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            this.Close();
        }
        

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
               
        }
    }
}
