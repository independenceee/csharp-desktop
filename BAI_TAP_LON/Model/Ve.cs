using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.Model
{
    internal class Ve
    {
        public string maVe { get; set; }
        public string maLichChieu { get; set; }
        public string maGhe { get; set; }

        public string TenGhe { get; set; }  
        public Ve() { }
        public Ve(string _maVe, string _maLichChieu, string _maGhe, string _tenGhe)
        {
            maVe = _maVe;
            maLichChieu = _maLichChieu;
            maGhe = _maGhe;
            TenGhe = _tenGhe;
        }
        public string searchVe(string _maLichChieu, string _maGhe)
        {
            if(maLichChieu == _maLichChieu && maGhe == _maGhe) 
            {
                return maVe;
            }
            return "";
        }
    }
}
