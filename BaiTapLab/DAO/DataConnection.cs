using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLab.DAO
{
    class DataConnection
    {
        string strcon = null;
        public DataConnection()
        {
            strcon = "Data Source=DESKTOP-UOLK6O3\\SQLEXPRESS01;Initial Catalog=QLTHUVIEN;Integrated Security=True";
        }
        public SqlConnection getconnet()
        {
            return new SqlConnection(strcon);
        }
    }
}
