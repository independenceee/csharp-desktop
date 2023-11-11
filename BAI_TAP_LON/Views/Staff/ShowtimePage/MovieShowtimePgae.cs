using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Staff.ShowtimePage
{
    public partial class MovieShowtimePage : Form
    {
        private static string staticNgayChieu;

        // Phương thức để lưu ngày chiếu vào biến static
        public static void SetStaticNgayChieu(string ngayChieu)
        {
            staticNgayChieu = ngayChieu;
        }

        // Phương thức để lấy giá trị ngày chiếu từ biến static
        public static string GetStaticNgayChieu()
        {
            return staticNgayChieu;
        }

        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.CommonFunctions func = new Classes.CommonFunctions();

        UserControl3[] listPhim; //lưu tat ca cac phim trong lichchieu
        DataTable dtPhim = new DataTable();//bảng taat ca cac phim dang chieu
        string ngayChieu; // biến dùng để chọn ngày chiếu

        //thêm một biến check khi chọn thể loại
        bool checkTL;
        public MovieShowtimePage()
        {
            InitializeComponent();
            //tất cá cac phim có trong lich chiếu 
            func.FillGunaComboBox(gunaCbTheLoai, dtBase.ReadData("select * from b_TheLoai"), "TenTheLoai", "MaTheLoai");
            checkTL = false;

        }
        //phương thức để đọc dư liệu phim có trong lịch chiếu theo ngày
        public void PhimByDate(string ngayChieu)
        {
            
            dtPhim = dtBase.ReadData("select distinct b_LichChieu.MaPhim, TenPhim, AnhPhim, MaTheLoai, NgayChieu from b_PHIM inner join b_LICHCHIEU on b_PHIM.MaPhim = b_LICHCHIEU.MaPhim where NgayChieu='" + ngayChieu + "'");
            int slPhim = dtPhim.Rows.Count;
            if (slPhim > 0)
            {
                //list phim 
                listPhim = new UserControl3[slPhim];
                for (int i = 0; i < slPhim; i++)
                {
                    DataRow row = dtPhim.Rows[i];

                    listPhim[i] = new UserControl3();

                    listPhim[i].TenPhim = row["TenPhim"].ToString();
                    listPhim[i].setAnhPhim(Application.StartupPath + "\\Resource\\Image\\Movies\\" + row["AnhPhim"].ToString());
                    listPhim[i].MaPhim = row["MaPhim"].ToString();
                    listPhim[i].MaTheLoai = row["MaTheLoai"].ToString();


                }
                // lưu ngày chiếu được chọn
                SetStaticNgayChieu(ngayChieu);

            }
            else
            {
                listPhim = null;
            }
           

        }
        //khi load form thi hien ra danh sach phim dang chiếu
        private void MovieShowtimePgae_Load(object sender, EventArgs e)
        {
            gunaDateNgayChieu.Value = DateTime.Now;
            ngayChieu = DateTime.Now.ToString("yyyy-MM-dd");
            Load_Data(ngayChieu);

        }

        //dùng để hiển thị các phim đang chiếu trong ngày hôm nay 
        public void Load_Data(string ngayChieu) 
        {
            // Xóa toàn bộ phim trên danh sách phim
            flDanhSachPhim.Controls.Clear();
            PhimByDate(ngayChieu);
            if (listPhim != null)
            {
                //doc danh sach phim, gan cho ussercontrol 3

                //Thêm danh sách phim đang chiếu
                foreach (UserControl3 phim in listPhim)
                {
                    // Kiểm tra xem UserControl3 đã tồn tại trên flDanhSachPhim chưa
                    if (!flDanhSachPhim.Controls.Contains(phim))
                    {
                        // Nếu chưa, thêm UserControl3 vào flDanhSachPhim
                        flDanhSachPhim.Controls.Add(phim);

                    }

                }
            }
            
           
        }
        private void gunaDateNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            //lấy ra ngày được chọn
            ngayChieu = gunaDateNgayChieu.Value.ToString("yyyy-MM-dd");
            Load_Data(ngayChieu);

        }

        private void gunaDateNgayChieu_Leave(object sender, EventArgs e)
        {
            //Load_Data();

        }

        // khi click thi xóa chữ search for movies
        private void gunatxtSearch_Click(object sender, EventArgs e)
        {
            if(gunatxtSearch.Text.Trim() != "")
            {
                gunatxtSearch.Text = "";
            }

        }
        // khi leave thì hiện lại chữ search ...
        private void gunatxtSearch_Leave(object sender, EventArgs e)
        {
            if (gunatxtSearch.Text.Trim() == "")
            {
                gunatxtSearch.Text = "Search for Movies";
                // Nếu TextBox Search trống, hiển thị lại tất cả các phim đang chiếu trong ngày hôm nay lên flDanhSachPhim            
            }

        }

        //tìm kiếm film bằng cách search 
        private void gunatxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            string searchKeyword = gunatxtSearch.Text.Trim();
            if (e.KeyCode == Keys.Enter)
            {              
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    flDanhSachPhim.Controls.Clear();
                    // Duyệt qua danh sách UserControl3 để tìm kiếm
                    foreach (UserControl3 phim in listPhim)
                    {
                        // Kiểm tra xem tên phim có chứa từ khóa tìm kiếm không
                        if (phim.TenPhim.ToLower().Contains(searchKeyword.ToLower()))
                        {
                            
                            // Nếu có, hiển thị UserControl3 lên flDanhSachPhim
                            flDanhSachPhim.Controls.Add(phim);
                        }
                    }
                }
               

            }
            
        }
      

        // tìm kiếm phim theo thể loại 
        private void gunaCbTheLoai_SelectedValueChanged(object sender, EventArgs e)
        {
            string maTheLoai = gunaCbTheLoai.SelectedValue.ToString();
            flDanhSachPhim.Controls.Clear();

            if (checkTL == true)
            {

                foreach (UserControl3 phim in listPhim)
                {
                    // Kiểm tra xem tên phim có chứa từ khóa tìm kiếm không
                    if (phim.MaTheLoai.Equals(maTheLoai))
                    {

                        // Nếu có, hiển thị UserControl3 lên flDanhSachPhim
                        flDanhSachPhim.Controls.Add(phim);
                    }
                }

                

            }
            checkTL = false;
            
        }

        private void gunaCbTheLoai_Click(object sender, EventArgs e)
        {
            checkTL = true;
        }

        private void gunaCbTheLoai_Leave(object sender, EventArgs e)
        {
            if(checkTL == false)
            {
                
            }
        }

        //tìm kiếm theo ngày chiếu phim

       
	}
}
