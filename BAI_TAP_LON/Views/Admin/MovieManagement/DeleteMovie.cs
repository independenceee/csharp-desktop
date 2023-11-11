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
    public partial class DeleteMovie : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.CommonFunctions func = new Classes.CommonFunctions();
        public DeleteMovie()
        {
            InitializeComponent();
        }
        public DeleteMovie(DataRow rowData)
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
                picAnhPhim.Image = Image.FromFile(Application.StartupPath + "\\Resource\\Image\\Movies\\" + rowData[7].ToString());
            }
            cbNuocSX.SelectedValue = rowData[10].ToString();
            cbTheLoai.SelectedValue = rowData[11].ToString();
            cbHangSX.SelectedValue = rowData[12].ToString();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlDelete;
            if (MessageBox.Show("Bạn có muốn xóa phim không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sqlDelete = "Delete from b_PHIM where MaPhim=N'" + txtMaPhim.Text + "'";
                dtBase.ChangeData(sqlDelete);
                MessageBox.Show("Xóa dữ liệu thành công");
                this.Close();   
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy thao tác không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
