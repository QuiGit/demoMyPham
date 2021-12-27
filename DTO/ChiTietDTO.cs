using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDTO
    {
        
        public string MaHD { get; set; }
        public string MaSP { get; set; }
        public float? SoLuong { get; set; }
        public float? Gia { get; set; }
        public float? ThanhTien { get; set; }

        public ChiTietDTO()
        {
            MaHD = "";
            MaSP = "";
            SoLuong = 0;
            Gia = 0;
            ThanhTien = 0;
        }
        public ChiTietDTO(string mahd,string masp,float sluong,float gia,float ttien)
        {
            this.MaHD = mahd;
            this.MaSP = masp;
            this.SoLuong = sluong;
            this.Gia = gia;
            this.ThanhTien = ttien;
        }
    }
}
