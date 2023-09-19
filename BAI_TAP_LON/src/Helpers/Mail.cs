using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.Helpers
{
    public class Mail
    {
        public void SendMail(string address, string subject, string body)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(address);
            mail.From = new MailAddress(Constants.Constants.MAIL_USERNAME);
            mail.Subject = subject;
            mail.Body = body;


            SmtpClient smtp = new SmtpClient(Constants.Constants.MAIL_HOST);
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(Constants.Constants.MAIL_USERNAME, Constants.Constants.MAIL_PASSWORD);
            try
            {
                smtp.Send(mail);
            } catch(Exception ex)
            {

            }

        }
    }
}
