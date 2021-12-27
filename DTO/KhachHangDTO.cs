using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public DateTime NgSinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string GTinh { get; set; }
       
        public KhachHangDTO()
        {
            MaKH = "";
            TenKH = "";
            NgSinh = DateTime.Now;
            DiaChi = "";
            SDT = "";
            GTinh = "";
        }
            
        public KhachHangDTO(string ma, string ten, DateTime ngsinh, string diachi, string sdt,string gt)
        {
            this.MaKH = ma;
            this.TenKH = ten;
            this.NgSinh = ngsinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.GTinh = gt;
        }
       
    }
}
