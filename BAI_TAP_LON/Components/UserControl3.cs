using BAI_TAP_LON.Views.Staff.MovieScheduleWindow;
using BAI_TAP_LON.Views.Staff.ShowtimePage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace BAI_TAP_LON
{
    public partial class UserControl3 : UserControl
    {
       
        public UserControl3()
        {
            InitializeComponent();
        }
        public string MaPhim
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        public string TenPhim 
        {
            get { return gunalblTenPhim.Text; }
            set { gunalblTenPhim.Text = value; }
        }
        public string MaTheLoai { get; set; }
        //public string NgayChieu { get; set; }
        public void setAnhPhim(string imgPath)
        {
            if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
            {
                gunaPicPhim.Image = Image.FromFile(imgPath);
                //MessageBox.Show("Hình ảnh đã được tải thành công");
            }
            else
            {
                gunaPicPhim.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resource", "Image", "Movies", "Oppenheimer.jpg"));
            }
        }
       
      
        private void gunaPicPhim_Click(object sender, EventArgs e)
        {
            MovieSchedule form = new MovieSchedule(this.Name);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void gunaPicPhim_MouseHover(object sender, EventArgs e)
        {
            gunaPanelTenPhim.FillColor = Color.IndianRed;
            gunaPanelTenPhim.FillColor2 = Color.Yellow;
            gunaPanelTenPhim.FillColor3 = Color.Silver;
            gunaPanelTenPhim.FillColor4 = Color.LightSkyBlue;
            gunalblTenPhim.ForeColor = Color.DarkRed;
        }

        private void gunaPicPhim_MouseLeave(object sender, EventArgs e)
        {
            gunaPanelTenPhim.FillColor = Color.Gainsboro;
            gunaPanelTenPhim.FillColor2 = Color.Gainsboro;
            gunaPanelTenPhim.FillColor3 = Color.Gainsboro;
            gunaPanelTenPhim.FillColor4 = Color.Gainsboro;
            gunalblTenPhim.ForeColor = Color.Black;
        }
    }
}
