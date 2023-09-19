using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class Bill
    {
        public Bill() { }

        public string Id { get; set; }

        /*
         * Customer
         */

        private string _CustomerId;
        public string CustomnerId
        {
            get
            {
                if (_CustomerId is null)
                {
                    return "KH0000";
                }
                return _CustomerId;
            }

            set
            {
                _CustomerId = value;
            }
        }

        private string _CustomerName;

        public string CustomerName
        {
            get
            {
                if (_CustomerName is null)
                {
                    return "Khách vãng lai";
                }
                return _CustomerName;
            }
            set
            {
                _CustomerName = value;
            }
        }
        private string _PhoneNumber;
        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = value;
            }
        }

        /**
         * Staff
         */

        public string StaffId { get; set; }
        public string StaffName { get; set; }

        /**
         * Price
         */

        public string OriginalTotalPriceStr 
        { 
            get => Utils.Helpers.FormatVietNameMoney(TotalPrice - DiscountPrice); 
        }

        public decimal TotalPrice { get; set; }
        public string TotalPriceStr
        {
            get
            {
                return Utils.Helpers.FormatVietNameMoney(TotalPrice);
            }
        }
        public decimal DiscountPrice { get; set; }
        public string DiscountPriceStr
        {
            get
            {
                return Utils.Helpers.FormatVietNameMoney(DiscountPrice);
            }
        }
        public DateTime CreatedAt { get; set; }
        public List<int> VoucherIdList { get; set; }






    }
}
