using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Admin.MovieManagement
{
    public partial class SearchFilm : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Boolean checkClick = false;
        DataRow row; // để lưu thông tin phim khi cel click
        public SearchFilm()
        {
            InitializeComponent();
        }
        private void SearchFilm_Load(object sender, EventArgs e)
        {
          
            load_Data();
        }


        // THÊM phim mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            MovieAdd movieAdd = new MovieAdd();
            movieAdd.FormClosed += Form2_FormClosed;
            movieAdd.ShowDialog();
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
            DataTable dtDSPhim = dtBase.ReadData("Select * from b_PHIM");
            dgvDanhSachPhim.DataSource = dtDSPhim;
            // Reset trạng thái click 
            checkClick = false;
        }

        //SỬA phim
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkClick == false)
            {
                MessageBox.Show("Bạn phải chọn phim muốn sửa");
            }
            else
            {
                ShowChiTietPhimForm(row);
            }
            //goij phuowng thuc de hien thi chi tiet va truyen datarow
           

        }
        // khi cclick vao sự kiện này sẽ lấy dữ liệu ra và lưu vào row
        private void dgvDanhSachPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkClick = true;
            // lấy hàng được chọn tuef datagridview
            DataGridViewRow seletedRow = dgvDanhSachPhim.Rows[e.RowIndex];
            //lấy data từ databoundItem 
             row = ((DataRowView)seletedRow.DataBoundItem).Row;

            
            

        }
        private void ShowChiTietPhimForm(DataRow row)
        {
            // Kiểm tra xem trạng thái click đã được set thành true hay không
            if (checkClick)
            {
                // Tạo một thể hiện của form chi tiết và truyền đối tượng DataRow
                EditMovie chiTietPhimForm = new EditMovie(row);
                chiTietPhimForm.FormClosed += Form2_FormClosed;
                // Hiển thị form chi tiết
                chiTietPhimForm.Show();
            }
        }

        //XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkClick == false)
            {
                MessageBox.Show("Bạn phải chọn phim muốn xóa");

            }
            else
            {
                ShowChiTietXoaPhim(row);
            }
        }

        private void ShowChiTietXoaPhim(DataRow row)
        {
            // Kiểm tra xem trạng thái click đã được set thành true hay không
            if (checkClick)
            {
                // Tạo một thể hiện của form chi tiết và truyền đối tượng DataRow
                DeleteMovie chiTietPhimForm = new DeleteMovie(row);
                chiTietPhimForm.FormClosed += Form2_FormClosed;
                // Hiển thị form chi tiết
                chiTietPhimForm.Show();
            }
        }
        //TÌM KIẾM 
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sqlSearch = "Select * from b_PHIM where TenPhim like '%" + txtFind.Text + "%'";
            dt = dtBase.ReadData(sqlSearch);
            dgvDanhSachPhim.DataSource = dt;

        }

        //không dùng đên ấn nhầm lát xóa sau
        private void dgvDanhSachPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {

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
    }
}
