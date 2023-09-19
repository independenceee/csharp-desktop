using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class ShowTime
    {
        public ShowTime()
        {

        }


        public int Id { get; set; }
        public int MovieId { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime ShowDate { get; set; }
        public int RoomId { get; set; }
        public decimal TicketPrice { get; set; }
        public string TicketPriceStr { 
            get { 
                return Utils.Helpers.FormatVietNameMoney(TicketPrice); 
            } 
        }

        public Movie Movie { get; set; }
        public IList<Ticket> Tickets { get; set; }
    }
}
