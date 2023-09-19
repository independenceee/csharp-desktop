using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class ProductBillInformation
    {
        public ProductBillInformation()
        {

        }
        public string BillId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public decimal PricePerItem { get; set; }
        public string PricePerItemStr
        {
            get
            {
                return Utils.Helpers.FormatDecimal(PricePerItem);
            }
        }
        public string TotalPriceStr
        {
            get
            {
                return Utils.Helpers.FormatVietNameMoney(Quantity * PricePerItem);
            }
        }
    }
}
