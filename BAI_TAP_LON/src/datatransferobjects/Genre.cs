using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class Genre
    {
        public Genre()
        {

        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public IList<Movie> Movies { get; set; }
    }
}
