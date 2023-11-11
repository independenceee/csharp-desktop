using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Admin.MovieManagement
{
    public partial class EditMovie : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.CommonFunctions func = new Classes.CommonFunctions();
        string NameImg = "";
        public EditMovie()
        {
            InitializeComponent();

        }
        public EditMovie(DataRow rowData)
        {
            InitializeComponent();
            // Khởi tạo các thành phần khác của form
            DataTable dtNuocSX = new DataTable();
            dtNuocSX = dtBase.ReadData("Select * from b_NuocSanXuat");
            func.FillKryptonComboBox(cbNuocSX, dtNuocSX, "TenNuocSX", "MaNuocSX");

            func.FillKryptonComboBox(cbTheLoai, dtBase.ReadData("select * from b_TheLoai"), "TenTheLoai", "MaTheLoai");
            func.FillKryptonComboBox(cbHangSX, dtBase.ReadData("select * from b_HangSanXuat"), "TenHangSX", "MaHangSX");
            // Xử lý thông tin từ DataRow (rowData) và hiển thị lên form
            DisplayData(rowData);
        }

        // Thêm phương thức để hiển thị dữ liệu lên form
        private void DisplayData(DataRow rowData)
        {
            // Xử lý và hiển thị dữ liệu từ DataRow lên form
            txtMaPhim.Enabled = false;
            txtMaPhim.Text = rowData[0].ToString();
            txtTenPhim.Text = rowData[1].ToString();
            txtDaoDien.Text = rowData[2].ToString();
            // Giả sử dateFromDatabase là giá trị ngày tháng từ cơ sở dữ liệu
            DateTime dateFromDatabase = (DateTime)rowData[3];
            dateNgayKhoiChieu.Value = dateFromDatabase;
            txtDienVienChinh.Text = rowData[5].ToString();
            rtbMoTa.Text = rowData[6].ToString();
            if (rowData[7].ToString() == "")
            {
                picAnhPhim.Image = null;
            }
            else
            {
                NameImg = rowData[7].ToString();    
                picAnhPhim.Image = Image.FromFile(Application.StartupPath + "\\Resource\\Image\\Movies\\" + rowData[7].ToString());
            }
            cbNuocSX.SelectedValue = rowData[10].ToString();
            cbTheLoai.SelectedValue = rowData[11].ToString();
            cbHangSX.SelectedValue = rowData[12].ToString();

        }
        private void btnUpLoad_Click(object sender, EventArgs e)
        {

            NameImg = func.OpenFile(picAnhPhim);
        }
        // lưu lại sau khi chỉnh sửa 
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlFormattedDateTime = dateNgayKhoiChieu.Value.ToString("yyyy-MM-dd");
            

            string sqlUpdate = "UPDATE b_PHIM SET ";
            sqlUpdate += "TenPhim=N'" + txtTenPhim.Text + "', ";
            sqlUpdate += "DaoDien=N'" + txtDaoDien.Text + "', ";
            sqlUpdate += "NgayKhoiChieu='" + sqlFormattedDateTime + "', ";
            //sqlUpdate += "NgayKetThuc=null, ";
            sqlUpdate += "DienVienChinh=N'" + txtDienVienChinh.Text + "', ";
            sqlUpdate += "NoiDungChinh=N'" + rtbMoTa.Text + "', ";
            sqlUpdate += "AnhPhim=N'" + NameImg + "', ";
            //sqlUpdate += "TongThu=null, ";
            //sqlUpdate += "TongChiPhi=null, ";
            sqlUpdate += "MaNuocSX=N'" + cbNuocSX.SelectedValue + "', ";
            sqlUpdate += "MaTheLoai=N'" + cbTheLoai.SelectedValue + "', ";
            sqlUpdate += "MaHangSX=N'" + cbHangSX.SelectedValue + "' ";
            sqlUpdate += "WHERE MaPhim=N'" + txtMaPhim.Text + "';";

            dtBase.ChangeData(sqlUpdate);
            MessageBox.Show("Sửa dữ liệu thành công");
            this.Close();

        }
        private void EditMovie_Load(object sender, EventArgs e)
        {

        }

      
    }
}
