using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class Trouble
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }
        public string Status { get; set; }
        public decimal RepairCost { get; set; }
        public DateTime SubmittedAt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Image { get; set; }
        public string RepairCostString
        {
            get
            {
                return Utils.Helpers.FormatVietNameMoney(RepairCost);

            }
        }

        public string StaffId { get; set; }
        public string StaffName { get; set; };
    }
}
