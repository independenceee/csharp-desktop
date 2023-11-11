using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Components
{
    public partial class PhimControl : UserControl
    {
        public PhimControl()
        {
            InitializeComponent();
        }
        public PhimControl(string tenPhim, string daoDien, string nsx, string theLoai, DateTime ngayKhoiChieu)
        {
            lblTenPhim.Text = tenPhim;
            lblDaoDien.Text = daoDien;
            lblNuocSX.Text = nsx;
            lblTheLoai.Text = theLoai;
            lblNgayKhoiChieu.Text = Convert.ToString(ngayKhoiChieu);

        }

        public string TenPhim
        {
            get { return lblTenPhim.Text; }
            set { lblTenPhim.Text = value;  }
        }

        public string DaoDien
        {
            get { return lblDaoDien.Text; }
            set { lblDaoDien.Text = value; }
        }

        public string TheLoai
        {
            get { return lblTheLoai.Text;}
            set { lblTheLoai.Text = value;}
        }

   

        private void PhimControl_Load(object sender, EventArgs e)
        {

        }

     
    }
}
