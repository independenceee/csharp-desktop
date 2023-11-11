using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Auth
{
    public partial class ChangePassword : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(string email)
        {
            InitializeComponent();
            txtEmail.Text = email;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string sqlUpdate;
            DataTable dt = new DataTable();
            dt = dtBase.ReadData("select * from b_NHANVIEN where Email = N'" + txtEmail.Text + "'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Email không tồn tại");
                txtEmail.Focus();
                return;
            }

            sqlUpdate = "UPDATE b_NHANVIEN SET MatKhau = N'" + txtChangePassword.Text + "' WHERE Email = N'+" + txtEmail.Text + "+';";
            dtBase.ChangeData(sqlUpdate);
            MessageBox.Show("Bạn đã đổi mật khẩu  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
