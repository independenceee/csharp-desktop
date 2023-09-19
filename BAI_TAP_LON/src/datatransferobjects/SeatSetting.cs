using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class SeatSetting
    {
        public SeatSetting()
        {

        }

        public int SeatId { get; set; }
        public int ShowTimeId { get; set; }
        public bool Status { get; set; }
        public Seat Seat { get; set; }
        
        public string SeatPosition
        {
            get
            {
                return $"{Seat.Row}{Seat.SeatNumber}";
            }
        }
    }
}
