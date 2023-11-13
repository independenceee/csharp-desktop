using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        public string MaSP
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public string TenSP
        {
            get => lblTenSP.Text;
            set => lblTenSP.Text = value;
        }
        public int SoLuong
        {
            get => (int)numSoLuongSP.Value;
            set => numSoLuongSP.Value = value;
        }

        public string ThanhTien
        {
            get => lblThanhTien.Text;
            set => lblThanhTien.Text = value;
        }

        public event EventHandler SanPham_Leave;
        public event EventHandler SoLuongSP_ValueChanged;

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //hủy CT_SP: delete CT_HOADON_SP
            SanPham_Leave?.Invoke(this, EventArgs.Empty);
        }

        private void numSoLuongSP_ValueChanged(object sender, EventArgs e)
        {
            //thay đổi số lượng sản phẩm : update 

            SoLuongSP_ValueChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
