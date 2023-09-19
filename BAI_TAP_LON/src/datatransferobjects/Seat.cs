using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class Seat
    {
        public Seat()
        {

        }

        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public string Row { get; set; }

        public Nullable<int> RoomId { get; set; }
        public Room Room { get; set; }
    }
}
