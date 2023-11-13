using BAI_TAP_LON.Components;
using BAI_TAP_LON.Views.Staff.OrderFood;
using BAI_TAP_LON.Views.Staff.ShowtimePage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;

namespace BAI_TAP_LON.Views.Staff.MovieScheduleWindow
{
    public partial class ScreenPage : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.CommonFunctions func = new Classes.CommonFunctions();

        DataTable dtGhe = new DataTable();
        UserControl4[] listGhe;

        string ngayChieu = MovieShowtimePage.GetStaticNgayChieu();
        string maNV;
        public static string staticMaHD;
        private static List<Model.Ve> staticListVe = new List<Model.Ve>();

        // Mức quyền truy cập là internal
        internal static void AddVe(Model.Ve lv)
        {
            staticListVe.Add(lv);
        }
        internal static void RemoveVe(Model.Ve lv)
        {
            staticListVe.Remove(lv);
        }

        internal static List<Model.Ve> GetListVe()
        {
            return staticListVe;    
        }
      
        public static void SetStaticMaHD(string maHD)
        {
            staticMaHD = maHD;
        }

        // Phương thức để lấy giá trị ngày chiếu từ biến static
        public static string GetStaticMaHD()
        {
            return staticMaHD;
        }

       
        public ScreenPage()
        {
            InitializeComponent();
                       
        }
		
		public ScreenPage(string maPhong, string maPhim, string gioChieu)
        {
            InitializeComponent();
            string maLichChieu;
            DataTable dt = dtBase.ReadData("select MaLichChieu from b_LICHCHIEU where b_LICHCHIEU.MaPhim ='"+maPhim+"' and NgayChieu ='"+ngayChieu+"' and b_Lichchieu.MaPhong='"+maPhong+"' and TGBatDauChieu='"+gioChieu+"'");
            if(dt.Rows.Count > 0)
            {
                maLichChieu = dt.Rows[0]["MaLichChieu"].ToString();
                dtGhe = dtBase.ReadData(" select b_GHE.TenGhe,b_CT_LICHCHIEU_GHE.MaGhe, MaLichChieu, TrangThai, b_CT_LICHCHIEU_GHE.DonGia " +
                    "from b_CT_LICHCHIEU_GHE inner join b_GHE on b_CT_LICHCHIEU_GHE.MaGhe = b_GHE.MaGhe " +
                    "where MaLichChieu ='"+maLichChieu+"'");
                int sl = dtGhe.Rows.Count;

                if (sl > 0)
                {

                    listGhe = new UserControl4[sl];
                    for (int i = 0; i < sl; i++)
                    {
                        listGhe[i] = new UserControl4();
                        DataRow row = dtGhe.Rows[i];

                        listGhe[i].MaGhe = row["MaGhe"].ToString();
                        listGhe[i].TenGhe = row["TenGhe"].ToString();
                        listGhe[i].MaLichChieu = maLichChieu;
                        listGhe[i].DonGia = double.Parse(row["DonGia"].ToString());
                        listGhe[i].TrangThai = int.Parse(row["TrangThai"].ToString());
                        listGhe[i].setTrangThai(listGhe[i].TrangThai);
                        listGhe[i].CheckBoxStateChanged += UserControl_CheckBoxStateChanged;

                        if (listGhe[i].MaGhe.Contains("8") || listGhe[i].MaGhe.Contains("9"))
                        {
                            flKhuVuc2.Controls.Add(listGhe[i]);
                        }
                        else
                        {
                            flKhuVuc1.Controls.Add(listGhe[i]);
                        }

                    }

                }
                //điền thông tin cho hóa đơn vé 
                DataTable dtPhim = dtBase.ReadData("select TenPhim, AnhPhim from b_PHIM where MaPhim='" + maPhim + "'");
                lblTenPhim.Text = dtPhim.Rows[0]["TenPhim"].ToString();
                string imgPath = dtPhim.Rows[0]["AnhPhim"].ToString();
                //MessageBox.Show(imgPath);
                if (imgPath!=null)
                {
                    picAnhPhim.Image = Image.FromFile(Application.StartupPath + "\\Resource\\Image\\Movies\\"+imgPath);
                    //MessageBox.Show("Hình ảnh đã được tải thành công");
                }
                else
                {
                    picAnhPhim.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resource", "Image", "Movies", "Oppenheimer.jpg"));
                }
                DataTable dtLichChieu = dtBase.ReadData(" select * from b_LICHCHIEU inner join b_PHONG on b_LICHCHIEU.MaPhong = b_PHONG.MaPhong where MaLichChieu='"+maLichChieu+"'");
                //lblXuatChieu.Text = ((DateTime)dtLichChieu.Rows[0]["TGBatDauChieu"]).ToString("HH:mm") +"-"+ ((DateTime)dtLichChieu.Rows[0]["TGKetThucChieu"]).ToString("HH:mm");
                lblXuatChieu.Text = dtLichChieu.Rows[0]["TGBatDauChieu"].ToString() + "-" + dtLichChieu.Rows[0]["TGKetThucChieu"].ToString();
                lblPhongChieu.Text= dtBase.ReadData("select TenPhong from b_PHONG where MaPHONG='" + maPhong + "'").Rows[0]["TenPhong"].ToString();
                 


                DataTable dtSL = dtBase.ReadData("select COUNT(MaGhe) as SL from b_CT_LICHCHIEU_GHE where MaLichChieu='" + maLichChieu + "' and TrangThai=1");
                string daDat = dtSL.Rows[0]["SL"].ToString();

                
                //set gia tri cho label thông tin phòng CGV | P02 (128/128)  | 30-12-2023 | 21:30-23:30 
                string thongTin = "CGV | "+maPhong+" | ("+daDat+"/72) | "+ ngayChieu +" | "+ gioChieu;
                lblThongTin.Text= thongTin;

                //insert hóa đơn với MaNV=NV0001 ->>> sau khi gộp lại thì insert với cái tài khoản nhân viên được đăng nhập vào 
                string maBatDau = "HD" + DateTime.Now.ToString("yyyyMMdd");
                string maHD = func.MaTuSinh("b_HOADON", "MaHD", maBatDau);
                SetStaticMaHD(maHD);
                maNV = "NV0001";
                string sqlInsertHD = "insert into b_HOADON(MaHD, NgayLap, GiamGia, TongTien, MaNV, MaKH) values ('"+maHD+"','"+DateTime.Now.ToString("yyyy-MM-dd HH:mm")+"',0,0,'"+maNV+"',null)";
                //MessageBox.Show(sqlInsertHD);
                dtBase.ChangeData(sqlInsertHD);
                
                
                
            }

            
            this.FormClosing += Form_FormClosing;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy Order không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "No", ngăn chặn đóng form
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                
            }
            else
            {
                List<Model.Ve> lv = GetListVe();
                foreach (var ve in lv)
                {
                    dtBase.ChangeData("delete b_VE where MaVe=N'" + ve.maVe + "'");
                }
                string sqlDeleteHD = "delete b_HOADON where MaHD='" + staticMaHD + "'";     
                dtBase.ChangeData(sqlDeleteHD);   
                staticListVe = new List<Model.Ve>();

                
                
            }
        }
        private void UserControl_CheckBoxStateChanged(object sender, EventArgs e)
        {
            // Gọi phương thức Load_Data trên form khi checkbox thay đổi
            Load_Data();
        }


        private void ScreenPage_Load(object sender, EventArgs e)
		{

            Load_Data();

        }

        //hàm load lại dữ liệu
        public void Load_Data()
        {
            lblDSGhe.Text = "";
            //doc dư lieu bang hoa đơn 
            DataTable dtHD = dtBase.ReadData("select * from b_HOADON where MaHD='" + staticMaHD + "'");
            //nếu ghê được chọn : có trang thái 1 thì thêm vào lblDSGhe
            List<Model.Ve> lv = GetListVe();
            foreach (var ve in lv)
            {
                lblDSGhe.Text += ve.TenGhe + ",";
            }
            lblGia.Text = "50000";
            lblTongTienVe.Text = dtHD.Rows[0]["TongTien"].ToString();
        }
		private void btnXacNhan_Click(object sender, EventArgs e)
        {
            ListProduct ls = new ListProduct();
            ls.StartPosition = FormStartPosition.CenterScreen;
            ls.ShowDialog();
        }
    }
}
