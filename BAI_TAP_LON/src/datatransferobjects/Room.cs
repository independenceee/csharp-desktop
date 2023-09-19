using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class Room
    {
        public Room ()
        {
            this.Seats = new List<Seat>();
        }

        public int Id { get; set; }
        public int SeatQuantity { get; set; }
        public IList<Seat> Seats { get; set; }
    }
}
