using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class SanPhamDAO
    {
        private ModelCuaHangDataContext db = new ModelCuaHangDataContext();
        public List<SanPhamDTO> View()
        {
            return db.SanPhams.Select(sp => new SanPhamDTO
            {
                MaSP = sp.MaSP,
                TenSP = sp.TenSP,
                GiaSP = sp.GiaSP,
                HanSD = (DateTime)sp.HanSD,
                MaTH = sp.MaTH

            }).OrderByDescending(x=>x.MaSP).ToList();

           /* var res = from sp in db.SanPhams
                      join th in db.ThuongHieus on sp.MaTH equals th.MaTH
                      select new SanPhamDTO
                      {
                          MaSP = sp.MaSP,
                          TenSP = sp.TenSP,
                          GiaSP = sp.GiaSP,
                          HanSD = (DateTime)sp.HanSD,
                          MaTH = th.TenTH
                      };
            res.OrderBy(x => x.TenSP);
            return res.ToList();*/
        }
        public bool AddSP(SanPhamDTO inf)
        {  
            SanPham sp = new SanPham();
            var count = db.SanPhams.Count();
            string count1 = "";
            int countma = 0;
            count1 = Convert.ToString(count);
            countma = Convert.ToInt32(count1);
            countma += 1;
            if (countma + 1 < 10)
            {
                sp.MaSP = "SP0" + (countma + 1).ToString();
            }
            else if (countma + 1 < 1000)
            {
                sp.MaSP = "SP" + (countma + 1).ToString();
            }
            
            sp.TenSP = inf.TenSP;
            sp.GiaSP = inf.GiaSP;
            sp.HanSD = inf.HanSD;
            sp.MaTH = inf.MaTH;
            db.SanPhams.InsertOnSubmit(sp);
            db.SubmitChanges();
            return true;
        }

        public bool EditSP(SanPhamDTO inf)
        {
            SanPham sp = db.SanPhams.Where(s => s.MaSP == inf.MaSP).SingleOrDefault();
            sp.MaSP = inf.MaSP;
            sp.TenSP = inf.TenSP;
            sp.GiaSP = inf.GiaSP;
            sp.HanSD = inf.HanSD;
            sp.MaTH = inf.MaTH;
            db.SubmitChanges();
            return true;

        }
        public bool DeleteSP(SanPhamDTO inf)
        {
            SanPham sp = db.SanPhams.Where(s => s.MaSP == inf.MaSP).SingleOrDefault();
            db.SanPhams.DeleteOnSubmit(sp);
            db.SubmitChanges();
            return true;
        }

        
        
    }
}
