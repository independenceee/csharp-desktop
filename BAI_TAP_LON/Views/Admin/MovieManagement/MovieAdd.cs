using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BAI_TAP_LON.Views.Admin.MovieManagement
{
    public partial class MovieAdd : Form
    {

        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.CommonFunctions func  = new Classes.CommonFunctions();
        string NameImg = "";

        public MovieAdd()
        {
            InitializeComponent();
            DataTable dtNuocSX = new DataTable();
            dtNuocSX = dtBase.ReadData("Select * from b_NuocSanXuat");
            func.FillKryptonComboBox(cbNuocSX, dtNuocSX, "TenNuocSX", "MaNuocSX");

            func.FillKryptonComboBox(cbTheLoai,dtBase.ReadData("select * from b_TheLoai"), "TenTheLoai", "MaTheLoai");
            func.FillKryptonComboBox(cbHangSX,dtBase.ReadData("select * from b_HangSanXuat"), "TenHangSX", "MaHangSX");
           
        }
       
        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            NameImg = func.OpenFile(picAnhPhim);
           // MessageBox.Show(NameImg);
        }

        private void MovieAdd_Load(object sender, EventArgs e)
        {


        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlInsert;
            if (txtMaPhim.Text.Trim() == "")
            {
                errorChiTiet.SetError(txtMaPhim , "Bạn phải nhập mã phim");
                return;
            }
            else
            {
                errorChiTiet.Clear();
            }
            if (txtTenPhim.Text.Trim() == "")
            {
                errorChiTiet.SetError(txtTenPhim, "Bạn phải nhập mã phim");
                return;
            }
            else
            {
                errorChiTiet.Clear();
            }
            if (txtDaoDien.Text.Trim() == "")
            {
                errorChiTiet.SetError(txtDaoDien, "Bạn phải nhập mã phim");
                return;
            }
            else
            {
                errorChiTiet.Clear();
            }
            if (txtDienVienChinh.Text.Trim() == "")
            {
                errorChiTiet.SetError(txtDienVienChinh, "Bạn phải nhập mã phim");
                return;
            }
            else
            {
                errorChiTiet.Clear();
            }
            if (rtbMoTa.Text.Trim() == "")
            {
                errorChiTiet.SetError(rtbMoTa, "Bạn phải nhập mô tả phim");
                return;
            }
            else
            {
                errorChiTiet.Clear();
            }
            string sqlFormattedDateTime = dateNgayKhoiChieu.Value.ToString("yyyy-MM-dd");

            //Kiểm tra mã sản phim không được trùng.
            DataTable dt = new DataTable();
            dt = dtBase.ReadData("select * from b_PHIM where MaPhim = N'" + txtMaPhim.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại ! ");
                txtMaPhim.Text = "";
                txtMaPhim.Focus();
                return;
            }
            else
            {
                sqlInsert = "insert into b_PHIM(MaPhim, TenPhim, DaoDien,NgayKhoiChieu, NgayKetThuc,DienVienChinh,NoiDungChinh,AnhPhim,TongThu, TongChiPhi, MaNuocSX,MaTheLoai,MaHangSX) values(";
                sqlInsert += "N'" + txtMaPhim.Text +"',";
                sqlInsert += "N'" + txtTenPhim.Text + "',";
                sqlInsert += "N'" + txtDaoDien.Text + "',";
                sqlInsert += "N'" + sqlFormattedDateTime + "',";
                sqlInsert += "NULL,";
                sqlInsert += "N'" + txtDienVienChinh.Text + "',";
                sqlInsert += "N'" + rtbMoTa.Text + "',";
                sqlInsert += "N'" + NameImg + "',";
                sqlInsert += "NULL,";
                sqlInsert += "NULL,";
                sqlInsert += "N'" + cbNuocSX.SelectedValue + "',";
                sqlInsert += "N'" + cbTheLoai.SelectedValue + "',";
                sqlInsert += "N'" + cbHangSX.SelectedValue + "')";


            }
            dtBase.ChangeData(sqlInsert);
            MessageBox.Show("Bạn đã thêm phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }


       
       
    }
}
