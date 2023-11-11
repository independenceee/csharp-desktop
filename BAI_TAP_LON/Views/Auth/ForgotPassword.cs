using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BAI_TAP_LON.Views.Auth
{
    public partial class ForgotPassword : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();

        private int OTP;
        private string email;
        Classes.MailUtil mail = new Classes.MailUtil();
        Random random = new Random();
        public ForgotPassword()
        {
            InitializeComponent();
        }
        public ForgotPassword(string email)
        {
            InitializeComponent();
            txtEmail.Text = email;
        }
        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dtBase.ReadData("select * from b_NHANVIEN where Email = N'" + txtEmail.Text + "'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Email không tồn tại.");
                txtEmail.Focus();
                return;
            }
            this.email = txtEmail.Text;
            this.OTP = random.Next(1, 100000);
            mail.SendEmail(email, "Mã xác nhận của email " + email + " là: " + OTP.ToString(), "Khôi phục mật khẩu.");
            MessageBox.Show("Gửi OTP thành công vui lòng vào email liên kết với tài khoản trên để kiểm tra");
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtOtp.Text.Trim() == "")
            {
                MessageBox.Show("Nhập OTP bị sai vui lòng kiểm tra lại");
                txtOtp.Focus();
                return;
            }

            if (txtOtp.Text.Trim() != this.OTP.ToString())
            {
                MessageBox.Show("Nhập OTP bị sai vui lòng kiểm tra lại");
                txtOtp.Focus();
                return;
            }



            this.Hide();
            ChangePassword changePassword = new ChangePassword(txtEmail.Text);
            changePassword.ShowDialog();

        }
    }
}
