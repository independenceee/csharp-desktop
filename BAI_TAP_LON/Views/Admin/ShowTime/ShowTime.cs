using BAI_TAP_LON.Views.Admin.MovieManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Admin.ShowTime
{
    public partial class ShowTime : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.CommonFunctions func   = new Classes.CommonFunctions();
        Boolean checkClick = false;
        DataRow row; // để lưu thông tin phim khi cel click

        public ShowTime()
        {
            InitializeComponent();
        }

        private void ShowTime_Load(object sender, EventArgs e)
        {
            load_Data();
        }


        // THÊM phim mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            AddShow addShow = new AddShow();
            addShow.FormClosed += Form2_FormClosed;
            addShow.ShowDialog();
        }
        //khi thêm xong phim thì đóng form addphim và load lại form chính 
        public void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Xử lý khi Form 2 đóng
            load_Data();


        }
        //load lại dữ liệu 
        public void load_Data()
        {
             DataTable dtDSShow = dtBase.ReadData("SELECT TenPhong, TenPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu " +
                                      "FROM b_LICHCHIEU " +
                                      "INNER JOIN b_PHIM ON b_LICHCHIEU.MaPhim = b_PHIM.MaPhim " +
                                      "INNER JOIN b_PHONG ON b_LICHCHIEU.MaPhong = b_PHONG.MaPhong");

            dgvDanhSachXuatChieu.DataSource = dtDSShow;
            dgvDanhSachXuatChieu.Columns[0].HeaderText = "Tên phòng";
            dgvDanhSachXuatChieu.Columns[1].HeaderText = "Tên phim";
            dgvDanhSachXuatChieu.Columns[2].HeaderText = "Ngày chiếu";
            dgvDanhSachXuatChieu.Columns[3].HeaderText = "Thời gian bắt đầu chiếu";
            dgvDanhSachXuatChieu.Columns[4].HeaderText = "Thời gian kết thúc chiếu";
            
            // Reset trạng thái click 
            checkClick = false;
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
            // Kiểm tra xem TextBox có chứa chữ "Tìm kiếm" không
            if (txtFind.Text == "Tìm kiếm")
            {
                // Nếu có, xóa chữ "Tìm kiếm"
                txtFind.Text = "";
            }

        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            // Kiểm tra xem TextBox có trống không
            if (string.IsNullOrWhiteSpace(txtFind.Text))
            {
                // Nếu trống, thiết lập chữ "Tìm kiếm" vào TextBox
                txtFind.Text = "Tìm kiếm";
            }
        }

        private void btnToanBo_Click(object sender, EventArgs e)
        {
            string sqlFormattedDateTime = dateNgayChose.Value.ToString("yyyy-MM-dd");
            string sqlToanBo = "SELECT DISTINCT TenPhong, TenPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu " +
                              "FROM b_LICHCHIEU " +
                              "INNER JOIN b_PHIM ON b_LICHCHIEU.MaPhim = b_PHIM.MaPhim " +
                              "INNER JOIN b_PHONG ON b_LICHCHIEU.MaPhong = b_PHONG.MaPhong " +
                              "WHERE NgayChieu = '" + sqlFormattedDateTime + "'";
            dgvDanhSachXuatChieu.DataSource = dtBase.ReadData(sqlToanBo);
            dgvDanhSachXuatChieu.Columns[0].HeaderText = "Tên phòng";
            dgvDanhSachXuatChieu.Columns[1].HeaderText = "Tên phim";
            dgvDanhSachXuatChieu.Columns[2].HeaderText = "Ngày chiếu";
            dgvDanhSachXuatChieu.Columns[3].HeaderText = "Thời gian bắt đầu chiếu";
            dgvDanhSachXuatChieu.Columns[4].HeaderText = "Thời gian kết thúc chiếu";
        }

        private void btnP01_Click(object sender, EventArgs e)
        {
            string sqlFormattedDateTime = dateNgayChose.Value.ToString("yyyy-MM-dd");
            string sqlToanBo = "SELECT DISTINCT TenPhong, TenPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu " +
                              "FROM b_LICHCHIEU " +
                              "INNER JOIN b_PHIM ON b_LICHCHIEU.MaPhim = b_PHIM.MaPhim " +
                              "INNER JOIN b_PHONG ON b_LICHCHIEU.MaPhong = b_PHONG.MaPhong " +
                              "WHERE NgayChieu = '" + sqlFormattedDateTime + "' and b_PHONG.MaPhong ='P001'";
            dgvDanhSachXuatChieu.DataSource = dtBase.ReadData(sqlToanBo);
            dgvDanhSachXuatChieu.Columns[0].HeaderText = "Tên phòng";
            dgvDanhSachXuatChieu.Columns[1].HeaderText = "Tên phim";
            dgvDanhSachXuatChieu.Columns[2].HeaderText = "Ngày chiếu";
            dgvDanhSachXuatChieu.Columns[3].HeaderText = "Thời gian bắt đầu chiếu";
            dgvDanhSachXuatChieu.Columns[4].HeaderText = "Thời gian kết thúc chiếu";
        }

        private void btnP02_Click(object sender, EventArgs e)
        {
            string sqlFormattedDateTime = dateNgayChose.Value.ToString("yyyy-MM-dd");
            string sqlToanBo = "SELECT DISTINCT TenPhong, TenPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu " +
                              "FROM b_LICHCHIEU " +
                              "INNER JOIN b_PHIM ON b_LICHCHIEU.MaPhim = b_PHIM.MaPhim " +
                              "INNER JOIN b_PHONG ON b_LICHCHIEU.MaPhong = b_PHONG.MaPhong " +
                              "WHERE NgayChieu = '" + sqlFormattedDateTime + "' and b_PHONG.MaPhong ='P002'";
            dgvDanhSachXuatChieu.DataSource = dtBase.ReadData(sqlToanBo);
            dgvDanhSachXuatChieu.Columns[0].HeaderText = "Tên phòng";
            dgvDanhSachXuatChieu.Columns[1].HeaderText = "Tên phim";
            dgvDanhSachXuatChieu.Columns[2].HeaderText = "Ngày chiếu";
            dgvDanhSachXuatChieu.Columns[3].HeaderText = "Thời gian bắt đầu chiếu";
            dgvDanhSachXuatChieu.Columns[4].HeaderText = "Thời gian kết thúc chiếu";
        }

        private void btnP03_Click(object sender, EventArgs e)
        {
            string sqlFormattedDateTime = dateNgayChose.Value.ToString("yyyy-MM-dd");
            string sqlToanBo = "SELECT DISTINCT TenPhong, TenPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu " +
                              "FROM b_LICHCHIEU " +
                              "INNER JOIN b_PHIM ON b_LICHCHIEU.MaPhim = b_PHIM.MaPhim " +
                              "INNER JOIN b_PHONG ON b_LICHCHIEU.MaPhong = b_PHONG.MaPhong " +
                              "WHERE NgayChieu = '" + sqlFormattedDateTime + "' and b_PHONG.MaPhong ='P003'";
            dgvDanhSachXuatChieu.DataSource = dtBase.ReadData(sqlToanBo);
            dgvDanhSachXuatChieu.Columns[0].HeaderText = "Tên phòng";
            dgvDanhSachXuatChieu.Columns[1].HeaderText = "Tên phim";
            dgvDanhSachXuatChieu.Columns[2].HeaderText = "Ngày chiếu";
            dgvDanhSachXuatChieu.Columns[3].HeaderText = "Thời gian bắt đầu chiếu";
            dgvDanhSachXuatChieu.Columns[4].HeaderText = "Thời gian kết thúc chiếu";

        }

        private void btnP04_Click(object sender, EventArgs e)
        {
            string sqlFormattedDateTime = dateNgayChose.Value.ToString("yyyy-MM-dd");
            string sqlToanBo = "SELECT DISTINCT TenPhong, TenPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu " +
                              "FROM b_LICHCHIEU " +
                              "INNER JOIN b_PHIM ON b_LICHCHIEU.MaPhim = b_PHIM.MaPhim " +
                              "INNER JOIN b_PHONG ON b_LICHCHIEU.MaPhong = b_PHONG.MaPhong " +
                              "WHERE NgayChieu = '" + sqlFormattedDateTime + "' and b_PHONG.MaPhong ='P004'";
            dgvDanhSachXuatChieu.DataSource = dtBase.ReadData(sqlToanBo);
            dgvDanhSachXuatChieu.Columns[0].HeaderText = "Tên phòng";
            dgvDanhSachXuatChieu.Columns[1].HeaderText = "Tên phim";
            dgvDanhSachXuatChieu.Columns[2].HeaderText = "Ngày chiếu";
            dgvDanhSachXuatChieu.Columns[3].HeaderText = "Thời gian bắt đầu chiếu";
            dgvDanhSachXuatChieu.Columns[4].HeaderText = "Thời gian kết thúc chiếu";
        }

        private void btnP05_Click(object sender, EventArgs e)
        {
            string sqlFormattedDateTime = dateNgayChose.Value.ToString("yyyy-MM-dd");
            string sqlToanBo = "SELECT DISTINCT TenPhong, TenPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu " +
                              "FROM b_LICHCHIEU " +
                              "INNER JOIN b_PHIM ON b_LICHCHIEU.MaPhim = b_PHIM.MaPhim " +
                              "INNER JOIN b_PHONG ON b_LICHCHIEU.MaPhong = b_PHONG.MaPhong " +
                              "WHERE NgayChieu = '" + sqlFormattedDateTime + "' and b_PHONG.MaPhong ='P005'";
            dgvDanhSachXuatChieu.DataSource = dtBase.ReadData(sqlToanBo);
            dgvDanhSachXuatChieu.Columns[0].HeaderText = "Tên phòng";
            dgvDanhSachXuatChieu.Columns[1].HeaderText = "Tên phim";
            dgvDanhSachXuatChieu.Columns[2].HeaderText = "Ngày chiếu";
            dgvDanhSachXuatChieu.Columns[3].HeaderText = "Thời gian bắt đầu chiếu";
            dgvDanhSachXuatChieu.Columns[4].HeaderText = "Thời gian kết thúc chiếu";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sqlSearch = "SELECT DISTINCT TenPhong, TenPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu " +
                              "FROM b_LICHCHIEU " +
                              "INNER JOIN b_PHIM ON b_LICHCHIEU.MaPhim = b_PHIM.MaPhim " +
                              "INNER JOIN b_PHONG ON b_LICHCHIEU.MaPhong = b_PHONG.MaPhong " +
                              "WHERE TenPhim LIKE '%" + txtFind.Text + "%'";
            dt = dtBase.ReadData(sqlSearch);
            dgvDanhSachXuatChieu.DataSource = dt;
            dgvDanhSachXuatChieu.Columns[0].HeaderText = "Tên phòng";
            dgvDanhSachXuatChieu.Columns[1].HeaderText = "Tên phim";
            dgvDanhSachXuatChieu.Columns[2].HeaderText = "Ngày chiếu";
            dgvDanhSachXuatChieu.Columns[3].HeaderText = "Thời gian bắt đầu chiếu";
            dgvDanhSachXuatChieu.Columns[4].HeaderText = "Thời gian kết thúc chiếu";
            
        }

        //nút chi tiết nhé , t chưa kịp sủa tên sự kiện mấy con lợn
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(checkClick == true)
            {
                ShowChiTietXuatChieuForm(row);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn phim");
            }
        }

        private void dgvDanhSachXuatChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkClick = true;
            // lấy hàng được chọn tuef datagridview
            DataGridViewRow seletedRow = dgvDanhSachXuatChieu.Rows[e.RowIndex];
            //lấy data từ databoundItem 
            row = ((DataRowView)seletedRow.DataBoundItem).Row;
        }
        private void ShowChiTietXuatChieuForm(DataRow row)
        {
            // Kiểm tra xem trạng thái click đã được set thành true hay không
            if (checkClick== true)
            {
                // Tạo một thể hiện của form chi tiết và truyền đối tượng DataRow
                DetailShow chiTietXuatChieuForm = new DetailShow(row);
                chiTietXuatChieuForm.FormClosed += Form2_FormClosed;
                // Hiển thị form chi tiết
                chiTietXuatChieuForm.Show();
            }
        }
    }
}
