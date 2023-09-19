using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.Utils
{
    public class Helpers
    {
        public static bool IsValidEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                                     RegexOptions.None, TimeSpan.FromMilliseconds(200));
                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }

            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if(phoneNumber is null )
            {
                return false;
            }


            return  Regex.Match(phoneNumber, @"(([03+[2-9]|05+[6|8|9]|07+[0|6|7|8|9]|08+[1-9]|09+[1-4|6-9]]){3})+[0-9]{7}\b").Success;
        }


        public static string FormatVietNameMoney(decimal money)
        {
            if(money == 0)
            {
                return "0 ₫";
            }

            return String.Format(CultureInfo.InvariantCulture, "{0:#,#} ₫", money);
        }

        public static string FormatDecimal(decimal number)
        {
            if(number == 0)
            {
                return "0";
            }

            return string.Format(CultureInfo.InvariantCulture, "{0:#,#}", number);
        }
    }
}
