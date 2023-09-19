using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class Movie
    {
        public Movie()
        {

        }

        public int Id { get; set; }
        public string DisplayName { get; set; };
        public int RunningTime { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public Nullable<int> ReleaseYear { get; set; }
        public string MovieType { get; set; }
        public string Director { get; set; }
        public string Image { get; set; }
        public int TicketCount { get; set; }
        public decimal Revenue { get; set; }
        public string RevenueString
        {
            get
            {
                return Utils.Helpers.FormatVietNameMoney(Revenue);
            }
        }

        public IList<Genre> Genres { get; set; }
    }
}
