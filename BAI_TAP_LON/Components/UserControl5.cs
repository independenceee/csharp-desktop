using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Components
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }
        public string TenSP
        {
            get => lblTenSP.Text;
            set => lblTenSP.Text = value;
        }
        public int SoLuong
        {
            get => (int)numSL.Value;
            set => numSL.Value = value;

        }
        public long ThanhTien
        {
            get => long.Parse(lblTien.Text);
            set => lblTien.Text = value.ToString();
        }


        private void UserControl5_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //xóa mặt hàng khỏi hóa đơn đang order

        }
    }
}
