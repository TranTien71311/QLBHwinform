using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAO
{
    public class NhanVien_DAO
    {
        public List<NhanVien_DTO> LayDanhSachNhanVien()
        {
            List<NhanVien_DTO> listNV = new List<NhanVien_DTO>();
            #region Tạo Kết Nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            #endregion
            if (conn != null)
            {
                #region Tạo đối tượng truy vấn 
                SqlCommand command = new SqlCommand();
                command.CommandText = @"select * from NhanVien ";
                command.Connection = conn;

                SqlDataReader dataReader = command.ExecuteReader();
                #endregion
                while (dataReader.Read())
                {
                    NhanVien_DTO nv = new NhanVien_DTO();
                    nv.MaNV = (int)dataReader[0];
                    nv.TenNhanVien = dataReader["TenNhanVien"].ToString();
                    nv.DiaChi = dataReader["DiaChi"].ToString();
                    nv.DienThoai = dataReader["DienThoai"].ToString();
                    nv.Email = dataReader["Email"].ToString();
                    nv.ChucVu = dataReader["ChucVu"].ToString();
                    nv.Pass = dataReader["Pass"].ToString();
                    nv.NgaySinh = (DateTime)dataReader["NgaySinh"];

                    listNV.Add(nv);
                }
                #region đóng kết nối
                dataReader.Close();
                conn.Close();
                #endregion
            }
            return listNV;
        }
    }
}
