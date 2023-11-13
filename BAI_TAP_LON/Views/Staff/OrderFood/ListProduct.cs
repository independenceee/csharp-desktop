using BAI_TAP_LON.Views.Staff.MovieScheduleWindow;
using BAI_TAP_LON.Views.Staff.TicketBillFoodPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Staff.OrderFood
{
    public partial class ListProduct : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        DataTable dtSanPham = new DataTable();
        UserControl1[] listSP;
        
        public ListProduct()
        {
            InitializeComponent();
            // lấy các thông tin sản phẩm từ database rồi gán từng chi tiết sản vào usercontrol1
            dtSanPham = dtBase.ReadData("select * from b_SANPHAM");
            this.FormClosing += Form_FormClosing;
        }

        private void guna2BtnBack_Click(object sender, EventArgs e)
        {
            ScreenPage sP = new ScreenPage();
            sP.Show();
        }

        private void ListProduct_Load(object sender, EventArgs e)
        {
            if (dtSanPham.Rows.Count > 0)
            {
                 listSP = new UserControl1[dtSanPham.Rows.Count];


                for (int i = 0; i < dtSanPham.Rows.Count; i++)
                {
                    DataRow row = dtSanPham.Rows[i];
                    listSP[i] = new UserControl1();

                    listSP[i].Name = row["MaSP"].ToString();
                    listSP[i].TenSP = row["TenSP"].ToString();
                    listSP[i].DonGia = row["DonGia"].ToString();
                    listSP[i].SoLuong = row["SL"].ToString();
                    listSP[i].LoaiSP = row["LoaiSP"].ToString();
                    listSP[i].setAnhSP(Application.StartupPath + "\\Resource\\Image\\Product\\" + row["AnhSP"].ToString());

                    string capmaSP = row["MaSP"].ToString();

                    //add sự kiện khi click or leave san phẩm
                    listSP[i].SanPham_Click += (clickedSender, clickedEvent) => usercontrol1_Click(clickedSender, clickedEvent, capmaSP);
                    listSP[i].SanPham_Leave += (clickedSender, clickedEvent) => usercontrol1_Leave(clickedSender, clickedEvent, capmaSP);

                    
                    flSanPham.Controls.Add(listSP[i]);
                    listSP[i].Size = new System.Drawing.Size(180, 250);
                }
            }
        }

        public void usercontrol1_Click(object sender, EventArgs e, string maSP)
        {
            string sqlInsertSP = "insert into CT_HOADON_SP(MaHD, MaSP, SL) values ('"+ScreenPage.GetStaticMaHD()+"', '"+maSP+"', 1)";
            dtBase.ChangeData(sqlInsertSP);
            UserControl2 ctSP = new UserControl2();
            DataTable dtsp = dtBase.ReadData("select * from b_SANPHAM where MaSP='" + maSP + "'");
            ctSP.MaSP= maSP;
            ctSP.TenSP = dtsp.Rows[0]["TenSP"].ToString();
            ctSP.SoLuong = 1;


            //ctSP.SoLuongSP_ValueChanged += (clickedSender, clickedEvent) => usercontrol2_numSoLuong_Changed(clickedSender, clickedEvent, maSP);

            DataTable dtctsp = dtBase.ReadData("select * from CT_HOADON_SP where MaHD='" + ScreenPage.GetStaticMaHD() + "' and MaSP='" + maSP + "'");
            ctSP.ThanhTien = dtctsp.Rows[0]["ThanhTien"].ToString();

            flCT_SanPham.Controls.Add(ctSP);
            
           
        }
        public void usercontrol1_Leave(object sender, EventArgs e, string maSP)
        {
            string sqlDeleteSP = "delete CT_HOADON_SP where MaHD='"+ ScreenPage.GetStaticMaHD() + "' and MaSP='"+maSP+"'";
            dtBase.ChangeData(sqlDeleteSP);
            // Xác định UserControl cần loại bỏ (ví dụ: UserControl có tên là "MaSP")
           
            UserControl2 userControlToRemove = flCT_SanPham.Controls.OfType<UserControl2>().FirstOrDefault(control => control.Name == maSP);

            // Kiểm tra nếu UserControl tồn tại trong flDanhSachSP
            if (userControlToRemove != null)
            {
                // Loại bỏ UserControl khỏi flDanhSachSP
                flCT_SanPham.Controls.Remove(userControlToRemove);
            }


        }
        public void usercontrol2_numSoLuong_Changed(object sender, EventArgs e, string maSP)
        {
            MessageBox.Show("so luong san pham " + maSP + "Thay doi");
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            OrderBill orderBill = new OrderBill();
            orderBill.Show();
        }

        private void AllProducttion_Click(object sender, EventArgs e)
        {
            flSanPham.Controls.Clear();
            foreach (UserControl1 sp in listSP)
            {
                flSanPham.Controls.Add(sp);
            }

        }

        private void menuDoAn_Click(object sender, EventArgs e)
        {
            flSanPham.Controls.Clear();
            foreach (UserControl1 sp in listSP)
            {
                if (sp.LoaiSP.Equals("Đồ ăn")){
                    flSanPham.Controls.Add(sp);
                }
            }
        }

        private void menuDoUong_Click(object sender, EventArgs e)
        {
            flSanPham.Controls.Clear();
            foreach (UserControl1 sp in listSP)
            {
                if (sp.LoaiSP.Equals("Đồ uống"))
                {
                    flSanPham.Controls.Add(sp);
                }
            }
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát sản phẩm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "No", ngăn chặn đóng form
            if (result == DialogResult.No)
            {
                e.Cancel = true;

            }
            else
            {
                
            }
        }
    }
}
