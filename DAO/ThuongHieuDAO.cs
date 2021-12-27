using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThuongHieuDAO
    {
        private ModelCuaHangDataContext db = new ModelCuaHangDataContext();
        public List<ThuongHieuDTO> View()
        {
            return db.ThuongHieus.Select(n => new ThuongHieuDTO
            {
                MaTH = n.MaTH,
                TenTH = n.TenTH
            }).ToList();
        }
        public bool AddTH(ThuongHieuDTO inf)
        {
            ThuongHieu nc = new ThuongHieu();
            var count = db.ThuongHieus.Count();
            string count1 = "";
            int countma = 0;
            count1 = Convert.ToString(count);
            countma = Convert.ToInt32(count1);
            countma += 1;
            if (countma + 1 < 10)
            {
                nc.MaTH = "TH0" + (countma + 1).ToString();
            }
            else if (countma + 1 < 1000)
            {
                nc.MaTH = "TH" + (countma + 1).ToString();
            }
            
            nc.TenTH = inf.TenTH;
            db.ThuongHieus.InsertOnSubmit(nc);
            db.SubmitChanges();
            return true;
        }

        public bool EditTH(ThuongHieuDTO inf)
        {
            ThuongHieu nc = db.ThuongHieus.Where(n => n.MaTH == inf.MaTH).SingleOrDefault();
            nc.MaTH = inf.MaTH;
            nc.TenTH = inf.TenTH;
            db.SubmitChanges();
            return true;
        }
        public bool DeleteTH(ThuongHieuDTO inf)
        {
            ThuongHieu nc = db.ThuongHieus.Where(n => n.MaTH == inf.MaTH).SingleOrDefault();
            db.ThuongHieus.DeleteOnSubmit(nc);
            db.SubmitChanges();
            return true;
        }
    }
}
