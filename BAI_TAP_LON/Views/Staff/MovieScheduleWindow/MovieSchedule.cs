using BAI_TAP_LON.Views.Staff.ShowtimePage;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Staff.MovieScheduleWindow
{
    public partial class MovieSchedule : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();

        // láy ra ngày chiếu được chọn từ form trước 
        string ngayChieu = MovieShowtimePage.GetStaticNgayChieu();


        public MovieSchedule()
        {
            InitializeComponent();
            customizeDesing();
        }
        public MovieSchedule(string maPhim)
        {
            InitializeComponent();
            customizeDesing();

            DataTable dtPhim = dtBase.ReadData("select * from b_PHIM where MaPhim ='"+maPhim+"'");
            userControlPhim.TenPhim = dtPhim.Rows[0]["TenPhim"].ToString();
            userControlPhim.setAnhPhim(Application.StartupPath + "\\Resource\\Image\\Movies\\" + dtPhim.Rows[0]["AnhPhim"].ToString());
            rtbNoiDung.Text = dtPhim.Rows[0]["NoiDungChinh"].ToString() + dtPhim.Rows[0]["DaoDien"].ToString() + dtPhim.Rows[0]["DienVienChinh"].ToString();
            gunatxtNgayChieu.Text = ngayChieu;
            gunatxtNgayChieu.Enabled = false;
            FillPhongChieu(maPhim);
            
            
            
        }
        public void FillPhongChieu(string maPhim)
        {
            DataTable dtPhong = dtBase.ReadData("select distinct b_LICHCHIEU.MaPhong,TenPhong from b_PHONG inner join b_LICHCHIEU on b_PHONG.MaPhong = b_LICHCHIEU.MaPhong where b_LICHCHIEU.MaPhim ='" + maPhim+ "' and NgayChieu ='"+ngayChieu+"'");
            if (dtPhong.Rows.Count > 0)
            {
                //list phim 
                Guna2Button[] listPhong = new Guna2Button[dtPhong.Rows.Count];
                for (int i = 0; i < dtPhong.Rows.Count; i++)
                {
                    DataRow row = dtPhong.Rows[i];

                    listPhong[i] = new Guna2Button();

                    string maPhongValue = row["MaPhong"].ToString();
                    listPhong[i].Name = row["MaPhong"].ToString();
                    listPhong[i].Text = row["TenPhong"].ToString();

                    //chinh sua cho button cho dep nha 
                    listPhong[i].Width = 121;
                    listPhong[i].Height = 56;
                    listPhong[i].FillColor = Color.Gainsboro;
                    listPhong[i].ForeColor = Color.Sienna;
                    listPhong[i].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    listPhong[i].BorderRadius = 6;
                    listPhong[i].BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    listPhong[i].BorderColor = Color.Black;
                    listPhong[i].Margin = new Padding(25, 25, 25, 25);

                    //add buton vao flPhongChieu 
                    flPhongChieu.Controls.Add(listPhong[i]);

                    //add sự kiên click vào nut phong 
                    listPhong[i].Click += (sender, e) => btnPhong_Click(sender, e, maPhim, maPhongValue);

                }
            }
        }
        
        public void FillGioChieu(string maPhim, string maPhong)
        {
            DataTable dtGio = dtBase.ReadData("select TGBatDauChieu from b_LICHCHIEU where MaPhong ='"+maPhong+"' and MaPhim ='"+maPhim+ "' and NgayChieu ='" + ngayChieu + "'");
            if (dtGio.Rows.Count > 0)
            {
                //list phim 
                Guna2Button[] listGio = new Guna2Button[dtGio.Rows.Count];
                for (int i = 0; i < dtGio.Rows.Count; i++)
                {
                    DataRow row = dtGio.Rows[i];

                    listGio[i] = new Guna2Button();
                    listGio[i].Name = i.ToString();
                    listGio[i].Text = row["TGBatDauChieu"].ToString();
                    string gioChieu = row["TGBatDauChieu"].ToString();

					//chinh sua cho button cho dep nha 
					listGio[i].Width = 121;
                    listGio[i].Height = 56;
                    listGio[i].FillColor = Color.Gainsboro;
                    listGio[i].ForeColor = Color.Sienna;
                    listGio[i].Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    listGio[i].BorderRadius = 6;
                    listGio[i].BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    listGio[i].BorderColor = Color.Black;
                    listGio[i].Margin = new Padding(25, 25, 25, 25);

                    //add sự kiên click vào nut gio
                    listGio[i].Click += (sender, e) => btnGio_Click(sender, e, maPhong, maPhim, gioChieu );

                    //add buton vao flGioChieu 
                    
                    flGioChieu.Controls.Add(listGio[i]);
                }
            }


        }

        private void customizeDesing()
        {
            flPhongChieu.Visible = false;
            flGioChieu.Visible = false;
        }

        private void gunaBtnChose_Click(object sender, EventArgs e)
        {

           
            if(flPhongChieu.Visible == false)
            {
                flPhongChieu.Visible = true;
            }
        }
        
        private void btnPhong_Click(object sender, EventArgs e, string maPhim, string maPhong)
        {
            //xóa các giờ chiếu của phòng khác 
            flGioChieu.Controls.Clear();
            
            Guna2Button btn= sender as Guna2Button;
            if(flGioChieu.Visible == false)
            {
                flGioChieu.Visible= true;
                //thêm giờ chiếu của phòng mới  
                FillGioChieu(maPhim, maPhong);
            }
            else
            {
                flGioChieu.Controls.Clear();
                FillGioChieu(maPhim, maPhong);
            }
           
           
        }
        public void btnGio_Click(object sender, EventArgs e, string maPhong, string maPhim, string gioChieu)
        {
           
            ScreenPage page = new ScreenPage(maPhong, maPhim, gioChieu);
            page.StartPosition = FormStartPosition.CenterScreen;
            page.ShowDialog();

        }

    }
}
