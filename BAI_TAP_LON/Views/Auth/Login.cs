using BAI_TAP_LON.Views.Admin;
using BAI_TAP_LON.Views.Staff;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.Views.Auth
{
    public partial class Login : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        public Login()
        {
            InitializeComponent();
        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword(txtEmail.Text);
            forgotPassword.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập Email");
                txtEmail.Focus();
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập Mật Khẩu");
                txtPassword.Focus();
                return;
            }


            DataTable dt = new DataTable();
            dt = dtBase.ReadData("select * from b_NHANVIEN where Email = N'" + txtEmail.Text + "' and MatKhau = N'" + txtPassword.Text + "'");

            if (dt.Rows.Count > 0)
            {
                string vaiTro = dt.Rows[0]["VaiTro"].ToString();
                if (vaiTro == "Quản lý")
                {
                    this.Hide();
                    MainAdmin mainAdmin = new MainAdmin();
                    mainAdmin.ShowDialog();
                    return;
                }
                else
                {
                    this.Hide();
                    MainStaff mainStaff = new MainStaff();
                    mainStaff.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Bạn nhập sai Mật Khẩu");
            txtPassword.Focus();
            return;

        }
    }
}
