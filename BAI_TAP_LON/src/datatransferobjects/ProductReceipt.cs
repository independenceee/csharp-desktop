using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class ProductReceipt
    {
        public ProductReceipt()
        {
        }

        public string Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ImportPrice { get; set; }
        public string ImportPriceStr
        {
            get
            {
                return Utils.Helpers.FormatVietNameMoney(ImportPrice);
            }
        }
        public int Quantity { get; set; }
        public string StaffId { get; set; }
        public string StaffName { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }

    }
}
