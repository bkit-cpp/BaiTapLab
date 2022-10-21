using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLab
{
    public partial class Form1 : Form
    {
        BUS.NhanVien nhanvienbus;
        DAO.NhanVien daonv;
        public Form1()
        {
            InitializeComponent();
            nhanvienbus = new BUS.NhanVien();
            daonv = new DAO.NhanVien();
        }
        public void ShowList()
        {
             DataTable dt = nhanvienbus.getds();


             for (int i=0;i<dt.Rows.Count;i++)
             {
                 
                     ListViewItem lvi = new ListViewItem();
                     lvi.Text = dt.Rows[i][0].ToString();
                     lvi.SubItems.Add(dt.Rows[i][1].ToString());
                     lvi.SubItems.Add(dt.Rows[i][2].ToString());
                     lvi.SubItems.Add(dt.Rows[i][3].ToString());
                     lvi.SubItems.Add(dt.Rows[i][4].ToString());
                     lvi.SubItems.Add(dt.Rows[i][5].ToString());
                   
                    listNhanVien.View = View.Details;
                     listNhanVien.Items.Add(lvi);
                 

             }
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            ShowList();
        }
    }
}
