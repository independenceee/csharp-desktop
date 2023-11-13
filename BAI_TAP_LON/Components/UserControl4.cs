using BAI_TAP_LON.Model;
using BAI_TAP_LON.Views.Staff.MovieScheduleWindow;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Components
{
    public partial class UserControl4 : UserControl
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.CommonFunctions func =  new Classes.CommonFunctions();
        string lblDSGhe = "";
       
        public UserControl4()
        {
            InitializeComponent();

            
        }
        public event EventHandler CheckBoxStateChanged;

        public string MaGhe
        {
            get; set;
        }
        public string TenGhe
        {
            get { return lblMaGhe.Text; }
            set { lblMaGhe.Text = value; }
        }
        public string MaLichChieu
        {
            get; set;
        }

        public int TrangThai { get; set; }
        public double DonGia { get; set; }   

        public Guna2CustomCheckBox Guna2CustomCheckBox 
        {   get { return gunacheckbChair_Valid; }
           
        }
        public void setTrangThai(int trangThai)
        {
            if(trangThai == 1 )
            {
                lblMaGhe.BackColor = Color.Red;
                gunacheckbChair_Valid.UncheckedState.FillColor = Color.Red;
                gunacheckbChair_Valid.UncheckedState.BorderColor = Color.Red;
                gunacheckbChair_Valid.CheckedState.FillColor = Color.Red;
                gunacheckbChair_Valid.CheckedState.BorderColor = Color.Red;

            }
            
        } 
        
        
        private void gunacheckbChair_Valid_Click(object sender, EventArgs e)
        {
            
            
        }

        private void gunacheckbChair_Valid_CheckedChanged(object sender, EventArgs e)
        {
            string maHD = ScreenPage.GetStaticMaHD();

            if (gunacheckbChair_Valid.Checked)
            {
                string maBatDau = "VE00";
                string maVe = func.MaTuSinh("b_VE", "MaVe", maBatDau);

                string sqlInsertVe = "INSERT INTO b_VE(MaVe, MaLichChieu, MaGhe, MaHD) VALUES ('" + maVe + "', '" + MaLichChieu + "', '" + MaGhe + "', '" + maHD + "')";
                Model.Ve ve = new Model.Ve(maVe, MaLichChieu, MaGhe, TenGhe);

                // Thêm vé vào danh sách
                ScreenPage.AddVe(ve);
                lblMaGhe.BackColor = Color.Lime;
                // Thực hiện thêm vé vào database
                dtBase.ChangeData(sqlInsertVe);
                

            }
            else
            {
                // Truy vấn để lấy mã vé
                string maVe = dtBase.ReadData("SELECT MaVe FROM b_VE WHERE MaLichChieu=N'" + MaLichChieu + "' AND MaGhe=N'" + MaGhe + "'").Rows[0]["MaVe"].ToString();
                string sqlDeleteVe = "DELETE FROM b_VE WHERE MaVe='" + maVe + "'";
                List<Model.Ve> lv = ScreenPage.GetListVe();
                // Loại bỏ vé khỏi danh sách
                for(int i=0; i< lv.Count; i++) 
                {
                    if (lv[i].maVe == maVe)
                    {
                        ScreenPage.RemoveVe(lv[i]);
                       
                    }                 
                }
                lblMaGhe.BackColor = Color.Transparent;
               

                // Thực hiện xoá vé khỏi database
                dtBase.ChangeData(sqlDeleteVe);
            }

            // Gửi thông báo về sự kiện rằng trạng thái của checkbox đã thay đổi
            CheckBoxStateChanged?.Invoke(this, EventArgs.Empty);
        }


    }
}
