using BAI_TAP_LON.Components;
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
    public partial class DetailShow : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.CommonFunctions func = new Classes.CommonFunctions();
        DataTable dtDSGhe = new DataTable();
        string maLichChieu;
        public DetailShow()
        {
            InitializeComponent();
        }
        public DetailShow(DataRow rowData)
        {
            InitializeComponent();
            // hiển thị các ghế trong xuất chiếu này 
            string ngayChieu= ((DateTime)rowData[2]).ToString("yyyy-MM-dd");
            string startTime = rowData[3].ToString();
            //MessageBox.Show(ngayChieu+startTime);
           
            DataTable dtLichChieu= dtBase.ReadData("select MaLichChieu from b_LICHCHIEU where NgayChieu='"+ngayChieu+"' and TGBatDauChieu ='"+startTime+"'");
            maLichChieu = dtLichChieu.Rows[0]["MaLichChieu"].ToString();

            DisplayGhe(maLichChieu);
          
            // Xử lý thông tin từ DataRow (rowData) và hiển thị lên form
            DisplayData(rowData);
        }
        // Thêm phương thức để hiển thị dữ liệu lên form
        private void DisplayData(DataRow rowData)
        {
            // Xử lý và hiển thị dữ liệu từ DataRow lên form
            lblPhongChieu.Text = rowData[0].ToString();
            lblTenPhim.Text = rowData[1].ToString();
            lblNgayChieu.Text = ((DateTime)rowData[2]).ToString("dd/MM/yyyy");
            lblTimeStart.Text = rowData[3].ToString();
            lblTimeEnd.Text = rowData[4].ToString();
           

            // Giả sử dateFromDatabase là giá trị ngày tháng từ cơ sở dữ liệu


        }
        //thêm phương thức hiển thị ghế
        private void DisplayGhe(string maLichChieu)
        {
            dtDSGhe = dtBase.ReadData("select TenGhe, b_CT_LICHCHIEU_GHE.MaGhe, TrangThai, b_CT_LICHCHIEU_GHE.DonGia,MaLichChieu " +
                "from b_CT_LICHCHIEU_GHE inner join b_GHE on b_CT_LICHCHIEU_GHE.MaGhe= b_GHE.MaGhe " +
                "where MaLichChieu='" + maLichChieu + "'");
            int sl= dtDSGhe.Rows.Count; 
            if(sl > 0) 
            {
                UserControl4[] listGhe = new UserControl4[sl];

                for (int i = 0; i < sl; i++)
                {
                    listGhe[i] = new UserControl4();
                    DataRow row = dtDSGhe.Rows[i];

                    listGhe[i].MaLichChieu = maLichChieu;
                    listGhe[i].MaGhe = row["MaGhe"].ToString();
                    listGhe[i].TenGhe = row["TenGhe"].ToString();
                    listGhe[i].DonGia = double.Parse(row["DonGia"].ToString());
                    listGhe[i].TrangThai = int.Parse(row["TrangThai"].ToString());
                    listGhe[i].setTrangThai(listGhe[i].TrangThai);
                    //listGhe[i].Enabled = false;

                    flDanhSachGhe.Controls.Add(listGhe[i]);
                }
            }
            DataTable dtSL = dtBase.ReadData("select COUNT(MaGhe) as SL from b_CT_LICHCHIEU_GHE where MaLichChieu='"+maLichChieu+"' and TrangThai=1");
            lblDaDat.Text = dtSL.Rows[0]["SL"].ToString();
            lblConTrong.Text = (72 - int.Parse(dtSL.Rows[0]["SL"].ToString())).ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(int.Parse(lblDaDat.Text) > 0)
            {
                MessageBox.Show("Lịch chiếu không được phép xóa(Đã có ghế được đặt)");
            }
            else
            {
               
                if (MessageBox.Show("Bạn có muốn xóa phim không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sqlDelete = "delete b_LichChieu where MaLichChieu='" + maLichChieu + "'";
                    dtBase.ChangeData(sqlDelete);
                    MessageBox.Show("Xóa dữ liệu thành công");
                    this.Close();
                }

            }
        }
    }
}
