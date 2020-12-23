using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    class DataProvider
    {
        private static string chuoiKetNoi = @"Data source=DESKTOP-U8KAEQT\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=true";

        //Để thuận tiện sử dụng ở nhiều nới do đó tạo ra phương thức TaoKetNoi()
        public static SqlConnection TaoKetNoi()
        {
            SqlConnection conn = null;
            conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            return conn;
        }
        public static void NgatKetNoi(SqlConnection con)
        {
            con.Close();
        }
    }
}
