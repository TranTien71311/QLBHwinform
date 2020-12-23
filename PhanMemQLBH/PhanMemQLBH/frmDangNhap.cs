using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
namespace PhanMemQLBH
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        List<NhanVien_DTO> listnv = null;
        private void xetChucVu()
        {

            NhanVien_BUS sp = new NhanVien_BUS();
            listnv = sp.LayDanhSach();

            if (txtUserName.Text.Length > 0 && txtPassWord.Text.Length > 0)
            {
                for (int i = 0; i < listnv.Count; i++)
                {

                    if (listnv[i].MaNV.ToString() == txtUserName.Text && listnv[i].Pass.ToString() == txtPassWord.Text)
                    {
                        if (listnv[i].ChucVu == "QuanLy")
                        {
                            frmQuanLy frm = new frmQuanLy();
                            this.Hide();
                            frm.ShowDialog();
                            //this.Show();
                            break;
                        }
                        if (listnv[i].ChucVu == "BanHang")
                        {
                            frmNVBanHang frm = new frmNVBanHang(txtUserName.Text);
                            this.Hide();
                            frm.ShowDialog();
                            //this.Show();
                            break;
                        }
                        if (listnv[i].ChucVu == "NhapHang")
                        {
                            frmNVNhapHang frm = new frmNVNhapHang(txtUserName.Text);
                            this.Hide();
                            frm.ShowDialog();
                            //this.Show();
                            break;
                            
                        }
                        

                    }
                    else
                    {

                        if (i == listnv.Count - 1)
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lê!", "Thông báo", MessageBoxButtons.OK);
                        }

                    }
                    
                }
            }



        }
        public static string ChucVu1 = "";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {  
                MessageBox.Show("Vui Lòng Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OK);
                txtUserName.Focus();

                return;
            }
            if (txtPassWord.Text.Trim() == "")
            {
              
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK);
                txtPassWord.Focus();
                return;
            }
            xetChucVu(); 
            
    }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
