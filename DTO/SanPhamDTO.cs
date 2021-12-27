using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
      
        public string GiaSP { get; set; }
        public DateTime HanSD { get; set; }
        public string MaTH { get; set; }

        public SanPhamDTO()
        {
            
            TenSP = "";
            GiaSP = "";
            HanSD = DateTime.Now;
            MaTH = "";
        }
        public SanPhamDTO(string ma,string ten, string gia, DateTime hsd, string math)
        {
           
            this.TenSP = ten;
            this.GiaSP = gia;
            this.HanSD = hsd;
            this.MaTH = math;
        }
    }
}
