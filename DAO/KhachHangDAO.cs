using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        ModelCuaHangDataContext db = new ModelCuaHangDataContext();
        public List<KhachHangDTO> View()
        {
            return db.KhachHangs.Select(kh => new KhachHangDTO
            {
                MaKH = kh.MaKH,
                TenKH = kh.TenKH,
                NgSinh = (DateTime)kh.NgSinh,
                DiaChi = kh.DiaChi,
                SDT = kh.SDT,
                GTinh =kh.GTinh
            }).OrderByDescending(x=>x.MaKH).ToList();
        }
        public bool AddKH(KhachHangDTO inf)
        {
            KhachHang kh = new KhachHang();
            var count = db.KhachHangs.Count();
            string count1 = "";
            int countma = 0;
            count1 = Convert.ToString(count);
            countma = Convert.ToInt32(count1);
            countma += 1;
            if (countma + 1 < 10)
            {
                kh.MaKH = "KH0" + (countma + 1).ToString();
            }
            else if (countma + 1 < 1000)
            {
                kh.MaKH = "KH" + (countma + 1).ToString();
            }
            /*kh.MaKH = inf.MaKH;*/
            kh.TenKH = inf.TenKH;
            kh.NgSinh = inf.NgSinh;
            kh.DiaChi = inf.DiaChi;
            kh.SDT = inf.SDT;
            kh.GTinh = inf.GTinh;
            db.KhachHangs.InsertOnSubmit(kh);
            db.SubmitChanges();
            return true;
        }

        public bool EditKH(KhachHangDTO inf)
        {
            KhachHang kh = db.KhachHangs.Where(n => n.MaKH == inf.MaKH).SingleOrDefault();
            kh.MaKH = inf.MaKH;
            kh.TenKH = inf.TenKH;
            kh.NgSinh = inf.NgSinh;
            kh.DiaChi = inf.DiaChi;
            kh.SDT = inf.SDT;
            kh.GTinh = inf.GTinh;
            db.SubmitChanges();
            return true;
        }
        public bool DeleteKH(KhachHangDTO inf)
        {
            KhachHang kh = db.KhachHangs.Where(n => n.MaKH == inf.MaKH).SingleOrDefault();
            db.KhachHangs.DeleteOnSubmit(kh);
            db.SubmitChanges();
            return true;
        }
    }
}
