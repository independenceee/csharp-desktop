using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON.src.Views.Auth
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string from, to, password, content;
            from = "nguyenkhanh17112003@gmail.com";
            password = "jtreofpwxawtqolx";
            to = kryptonTextBox1.Text.Trim();

            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Subject = "Test send email";
            mail.Body = "Nguyen Khanh";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, password);


            try
            {
                smtp.Send(mail);
                MessageBox.Show("Email send successfully");
            } catch (Exception ex)
            {
                MessageBox.Show("Email send fail");
            }
        }
    }
}
