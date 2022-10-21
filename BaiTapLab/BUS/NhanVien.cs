using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLab.BUS
{
    
    class NhanVien
    {
        DAO.NhanVien daonv;
        public NhanVien()
        {
            daonv = new DAO.NhanVien();
        }
        public DataTable getds()
        {
            return daonv.getdsnhanvien();
        }
    }
}
