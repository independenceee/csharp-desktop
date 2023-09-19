using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int id, string displayname, string category, decimal price, string image, int quantity)
        {
            this.Id = id;
            this.DisplayName = displayname;
            this.Category = category;
            this.Price = price;
            this.Image = image;
            this.Quantity = quantity;
        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string PriceStr
        {
            get
            {
                return Utils.Helpers.FormatVietNameMoney(Price);
            }
        }
        public int Quantity { get; set; }
        public string Image
        {
            get; set;
        }
        public decimal Revenue { get; set; }
        public string RevenueStr
        {
            get
            {
                return Utils.Helpers.FormatVietNameMoney(Revenue);
            }
        }
        public int SalesQuantity { get; set; }
    }
}
