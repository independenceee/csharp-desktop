using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.Classes
{
    internal class Mail
    {
        public static readonly string EMAIL_PARTTEN = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
        public static readonly string MAIL_METHOD = "smtp";
        public static readonly string MAIL_HOST = "smtp.gmail.com";
        public static readonly int MAIL_PORT = 587;
        public static readonly string MAIL_FROM = "nguyenkhanh17112003@gmail.com";
        public static readonly string MAIL_PASSWORD = "jtreofpwxawtqolx";
    }
}
