using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Staff.OrderFood
{
    public partial class FoodandDrinkPage : Form
    {
        Classes.DataProcesser dtbase= new Classes.DataProcesser();
        DataTable dtSanPham = new DataTable();
    
        public FoodandDrinkPage()
        {
            InitializeComponent();
            // lấy các thông tin sản phẩm từ database rồi gán từng chi tiết sản vào usercontrol1
            dtSanPham = dtbase.ReadData("select * from b_SANPHAM");

        }

        private void FoodandDrinkPage_Load(object sender, EventArgs e)
        {
            if (dtSanPham.Rows.Count > 0)
            {
                UserControl1[] listSP = new UserControl1[dtSanPham.Rows.Count];
               

                for (int i = 0; i < dtSanPham.Rows.Count; i++)
                {
                    DataRow row = dtSanPham.Rows[i];
                    listSP[i] = new UserControl1();
                    listSP[i].TenSP = row["TenSP"].ToString();
                    listSP[i].DonGia = row["DonGia"].ToString();
                    listSP[i].SoLuong = row["SL"].ToString();
                    listSP[i].setAnhSP(Application.StartupPath + "\\Resource\\Image\\Product\\" + row["AnhSP"].ToString());
                   
                    flSanPham.Controls.Add(listSP[i]);
                    listSP[i].Size = new System.Drawing.Size(180,250);
                }
            }



        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
