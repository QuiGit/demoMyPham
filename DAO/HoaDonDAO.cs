using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HoaDonDAO 
    {
        ModelCuaHangDataContext db = new ModelCuaHangDataContext();
       
        public List<HoaDonDTO> View()
        {
            return db.HoaDons.Select(hd => new HoaDonDTO
            {   
                MaHD = hd.MaHD,
                NgLapHD = (DateTime)hd.NgLapHD,
                MaKH = hd.MaKH,
                TongTien=(float)hd.TongTien
            }).OrderByDescending(x=>x.MaHD).ToList();
            
        }
        
        public bool AddHD(HoaDonDTO inf)
        {
            HoaDon hd = new HoaDon();
            var count = db.HoaDons.Count();
            string count1 = "";
            int countma = 0;
            count1 = Convert.ToString(count);
            countma = Convert.ToInt32(count1);
            countma += 1;
            if (countma + 1 < 10)
            {
                hd.MaHD = "HD0" + (countma + 1).ToString();

            }
            else if (countma + 1 < 1000)
            {
                hd.MaHD = "HD" + (countma + 1).ToString();

            }

            hd.MaKH = inf.MaKH;
            hd.NgLapHD = inf.NgLapHD;
            hd.TongTien = inf.TongTien;
            db.HoaDons.InsertOnSubmit(hd);
            db.SubmitChanges();
            return true;
        }
        public bool EditHD(HoaDonDTO inf)
        {
            HoaDon hd = db.HoaDons.Where(h => h.MaHD == inf.MaHD).SingleOrDefault();
            hd.MaHD = inf.MaHD;
            hd.MaKH = inf.MaKH;
            hd.NgLapHD = inf.NgLapHD;
            db.SubmitChanges();
            return true;
        }
        public bool DeleteHD(HoaDonDTO inf)
        {
            HoaDon hd = db.HoaDons.Where(h => h.MaHD == inf.MaHD).SingleOrDefault();
            db.HoaDons.DeleteOnSubmit(hd);
            db.SubmitChanges();
            return true;
        }
        
    }
}
