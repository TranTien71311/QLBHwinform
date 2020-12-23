using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
    


namespace BUS
{
    public class NhanVien_BUS
    {
        public List<NhanVien_DTO> LayDanhSach()
        {
            NhanVien_DAO objnhanVien_DAO = new NhanVien_DAO();
            return objnhanVien_DAO.LayDanhSachNhanVien();
        }
    }
}
