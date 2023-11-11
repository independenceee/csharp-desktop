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
    public partial class AddShow : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.CommonFunctions func = new Classes.CommonFunctions();
        public AddShow()
        {
            InitializeComponent();
            func.FillKryptonComboBox(cbPhim, dtBase.ReadData("select * from b_PHIM"), "TenPhim", "MaPhim");
            func.FillKryptonComboBox(cbPhong, dtBase.ReadData("select * from b_PHONG"), "TenPhong", "MaPhong");

        }

        private void cbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTenPhim.Text = cbPhim.Text;
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPhongChieu.Text = cbPhong.Text;  
        }

       

        private void timeStart_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;

            if (dateTimePicker != null)
            {
                lblTimeStart.Text = dateTimePicker.Value.ToString("HH:mm");
                timeEnd.Value = timeStart.Value.AddHours(2);
            }
        }

        private void timeEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;

            if (dateTimePicker != null)
            {
                lblTimeEnd.Text = dateTimePicker.Value.ToString("HH:mm");
            }
        }

        private void dateNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = sender as DateTimePicker;

            if (dateTimePicker != null)
            {
                lblNgayChieu.Text = dateTimePicker.Value.ToString("dd/MM/yyyy");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime ngayChieu;
            TimeSpan gioBatDau;
            string sqlInsert;

            if (lblTenPhim.Text == "")
            {
                errorThemPhim.SetError(cbPhim,"Bạn phải chọn phim");
                return;
            }
            else
            {
                errorThemPhim.Clear();
            }
            if (lblPhongChieu.Text == "")
            {
                errorThemPhim.SetError(cbPhong, "Bạn phải chọn phòng ");
                return;
            }
            else
            {
                errorThemPhim.Clear();
            }
            if(lblNgayChieu.Text == "")
            {
                errorThemPhim.SetError(dateNgayChieu, "Bạn phải chọn ngày");
                return;
            }
            else
            {
                errorThemPhim.Clear();
                ngayChieu = dateNgayChieu.Value.Date;
            }
            if(lblTimeStart.Text == "")
            {
                errorThemPhim.SetError(timeStart, "Bạn phải chọn thời gian bắt đầu chiếu");
                return;
            }
            else
            {
                errorThemPhim.Clear();
                gioBatDau = timeStart.Value.TimeOfDay;
            }
           

            if (CanScheduleShow(cbPhong.SelectedValue.ToString(), ngayChieu, gioBatDau)==true)
            {

                string maLichChieu = ngayChieu.ToString("yyMMdd")+cbPhong.SelectedValue.ToString()+gioBatDau.ToString(@"hh")+ gioBatDau.ToString(@"mm");
                //MessageBox.Show(maLichChieu);
                sqlInsert = "insert into b_LICHCHIEU(MaLichChieu,MaPhong, MaPhim, NgayChieu, TGBatDauChieu, TGKetThucChieu) values (";
                sqlInsert += "'" + maLichChieu + "',";
                sqlInsert += "'" + cbPhong.SelectedValue.ToString() + "',";
                sqlInsert += "'" + cbPhim.SelectedValue.ToString() + "',";
                sqlInsert += "'" + ngayChieu.ToString("yyyy-MM-dd") + "',";
                sqlInsert += "'" + gioBatDau.ToString(@"hh\:mm\:ss") + "',";
                sqlInsert += "'" + gioBatDau.Add(new TimeSpan(2, 0, 0)).ToString() + "')";
                //MessageBox.Show(sqlInsert);
                dtBase.ChangeData(sqlInsert);
                MessageBox.Show("Thêm lịch chiếu thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lịch chiếu đã tồn tại, vui lòng chọn lịch chiếu khác");
            }
        }

        //check xem có lịch chiếu nào trùng không và thoi gian đã hợp lí giữa các lịch chưa 
        private bool CanScheduleShow(string maPhong, DateTime ngayChieu, TimeSpan gioBatDau)
        {
            
            
            string sqlLichChieu = $"SELECT * " +
                              $"FROM b_LICHCHIEU " +
                              $"WHERE MaPhong = '{maPhong}' AND NgayChieu = '{ngayChieu:yyyy-MM-dd}' " +
                              $"AND ((TGBatDauChieu < '{gioBatDau}' AND TGKetThucChieu > '{gioBatDau}') " +
                              $"OR (TGBatDauChieu < '{gioBatDau.Add(new TimeSpan(2, 0, 0))}' AND TGKetThucChieu > '{gioBatDau.Add(new TimeSpan(2, 0, 0))}'))";
            //MessageBox.Show(sqlLichChieu);
            // Thực hiện truy vấn và kiểm tra kết quả
            DataTable dtLC = dtBase.ReadData(sqlLichChieu);

            // Kiểm tra nếu có bản ghi thỏa mãn điều kiện
            if (dtLC.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
