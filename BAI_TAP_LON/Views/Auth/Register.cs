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
    public partial class Register : Form
    {
        Classes.UUID uuid = new Classes.UUID();
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sqlInsert;
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập tên.");
                txtEmail.Focus();
                return;
            }

            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập email.");
                txtEmail.Focus();
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập password.");
                txtPassword.Focus();
                return;
            }

            dt = dtBase.ReadData("select * from b_NHANVIEN where Email = N'" + txtEmail.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Email đã tồi lại.");
                txtEmail.Focus();
                return;
            }

            sqlInsert = "INSERT INTO b_NHANVIEN (MaNV, UserName, MatKhau, VaiTro, Email) VALUES (";
            sqlInsert += "N'" + uuid.getUUID() + "', ";
            sqlInsert += "N'" + txtName.Text + "', ";
            sqlInsert += "N'" + txtPassword.Text + "', ";
            sqlInsert += "N'" + "Nhân Viên" + "', ";
            sqlInsert += "N'" + txtEmail.Text + "')";

            dtBase.ChangeData(sqlInsert);
            MessageBox.Show("Bạn đã đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Login login = new Login();

            login.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

    }
}
