using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class Customer
    {
        public Customer()
        {

        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Expense { get; set; }

        public string ExpenseString
        {
            get
            {
                return Utils.Helpers.FormatVietNameMoney(Expense);
            }
        }
    }
}
