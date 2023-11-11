using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public UserControl4()
        {
            InitializeComponent();
            this.Click += Ghe_Click;
        }
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
       
        private void Ghe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ghee dda duoc chon");
        }
        
        private void gunacheckbChair_Valid_Click(object sender, EventArgs e)
        {

        }

        private void gunacheckbChair_Valid_CheckedChanged(object sender, EventArgs e)
        {

            if(this.TrangThai == 0) {

				if (gunacheckbChair_Valid.Checked)
				{
					lblMaGhe.BackColor = Color.Lime;
				}
				else
				{
					lblMaGhe.BackColor = Color.Transparent;
				}
            }
           
        }
    }
}
