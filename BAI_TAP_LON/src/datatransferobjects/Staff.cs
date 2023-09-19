using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class Staff
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<DateTime> BirthDate { set; get; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> StartingDate { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }

        public virtual IList<Bill> Bills { get; set; }


        public Staff()
        {
            this.Role = Constants.Role.Staff;
        }

        public Staff(string id, string name, string gender, DateTime birthday, string phoneNumber, string role, DateTime startingDate) 
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.BirthDate = birthday;
            this.PhoneNumber = phoneNumber;
            this.Role = role;
            this.StartingDate = startingDate;
        }

        private int GetAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.DayOfYear > today.DayOfYear)
            {
                age--;
            }
            return age;
        }



        //Statistic
        public decimal BenefitContribution { get; set; }
        public string BenefitContributionStr
        {
            get
            {
                return Helper.FormatVNMoney(BenefitContribution);
            }
        }
    }
}
