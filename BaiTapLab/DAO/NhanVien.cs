using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BaiTapLab.DAO
{
   public  class NhanVien
    {
     
         SqlDataAdapter da;
        DataConnection dtc;
        public NhanVien() {
            dtc = new DataConnection();
        }
        public DataTable getdsnhanvien()
        {
            string sql = "select * from NHANVIEN";
            SqlConnection con = dtc.getconnet();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
