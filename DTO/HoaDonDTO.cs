using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public string MaHD { get; set; }
        public DateTime NgLapHD { get; set; }
        public string MaKH { get; set; }
        public float TongTien { get; set; }
        public HoaDonDTO()
        {
            MaHD = "";
            MaKH = "";
            TongTien = 0;
            NgLapHD = DateTime.Now;
            
        }

        public HoaDonDTO(string mahd, string makh, DateTime ng, float tt)
        {
            this.MaHD = mahd;
            this.MaKH = makh;
            this.NgLapHD = ng;
            this.TongTien = tt;
        }
    }
}
