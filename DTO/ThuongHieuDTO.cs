using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuongHieuDTO
    {
        public string MaTH { get; set; }
        public string TenTH { get; set; }

        public ThuongHieuDTO()
        {
            MaTH = "";
            TenTH = "";
        }
        public ThuongHieuDTO(string ma, string ten)
        {
            this.MaTH = ma;
            this.TenTH = ten;
        }
    }
}
