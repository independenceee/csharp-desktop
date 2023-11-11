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

namespace BAI_TAP_LON
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            gunaPanel_Valid.Visible = false;
            gunaBtnClick_Valid.Visible = false;
        }
        public UserControl1(string tenSP, string soLuong, string donGia, string imgPath)
        {
            lblTenSP.Text = tenSP;
            lblSoLuong.Text = soLuong;
            lblDonGia.Text = donGia;
            if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
            {
                BackgroundImage = Image.FromFile(imgPath);
            }
            else
            {
                BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Resource", "Image", "Product", "Cheese_Popcorn.jpg"));
            }
        }
        public string TenSP
        {
            get { return lblTenSP.Text; }
            set { lblTenSP.Text = value; }
        }
        public string SoLuong
        {
            get { return lblSoLuong.Text; }
            set { lblSoLuong.Text = value; }
        }
        public string DonGia
        {
            get { return lblDonGia.Text; }
            set { lblDonGia.Text = value; }
        }
        public string DuongDan
        {
            get { return BackgroundImage.ToString(); }
            set { BackgroundImage = Image.FromFile(value); }
        }
        public void setAnhSP(string imgPath)
        {
            if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
            {
                this.BackgroundImage = Image.FromFile(imgPath);
                //MessageBox.Show("Hình ảnh đã được tải thành công");
            }
            else
            {
                this.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Resource", "Image", "Product", "Cheese_Popcorn.jpg"));
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void gunaControl_Click(object sender, EventArgs e)
        {
            if (gunaBtnClick_Valid.Visible == false)
            {
                gunaBtnClick_Valid.Visible = true;
                gunaPanel_Valid.Visible = true;
            }

        }

        private void gunaPanel_Valid_Click(object sender, EventArgs e)
        {
            gunaBtnClick_Valid.Visible = false;
            gunaPanel_Valid.Visible = false;
        }
    }
}
