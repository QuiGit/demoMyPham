using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChiTietDAO
    {
        ModelCuaHangDataContext db = new ModelCuaHangDataContext();
        public List<ChiTietDTO> View()
        {
            return db.ChiTietHDs.Select(hd => new ChiTietDTO
            {
                MaHD = hd.MaHD,
                MaSP = hd.MaSP,
                SoLuong = (float)hd.SoLuong,
                Gia = (float)hd.Gia,
                ThanhTien = (float)hd.ThanhTien
            }).OrderByDescending(x => x.MaHD).ToList();
           
        }
        public bool AddCT(ChiTietDTO inf)
        {
            ChiTietHD hd = new ChiTietHD();

            var count = db.ChiTietHDs.Count();
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
           /* hd.MaHD = inf.MaHD;*/
            hd.MaSP = inf.MaSP;
            hd.SoLuong = inf.SoLuong;
            hd.Gia = inf.Gia;
            hd.ThanhTien = inf.ThanhTien;
            db.ChiTietHDs.InsertOnSubmit(hd);
            db.SubmitChanges();

            return true;

        }
        public bool EditCT(ChiTietDTO inf)
        {
            ChiTietHD hd = db.ChiTietHDs.Where(h => h.MaHD == inf.MaHD).SingleOrDefault();
            hd.MaHD = inf.MaHD;
            hd.MaSP = inf.MaSP;
            hd.SoLuong = inf.SoLuong;
            hd.Gia = inf.Gia;
            hd.ThanhTien = inf.ThanhTien;
            db.SubmitChanges();
            return true;
        }
        public bool DeleteCT(ChiTietDTO inf)
        {
            ChiTietHD hd = db.ChiTietHDs.Where(h => h.MaHD == inf.MaHD).SingleOrDefault();
            db.ChiTietHDs.DeleteOnSubmit(hd);
            db.SubmitChanges();
            return true;
        }
      
    }
}
