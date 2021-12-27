using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class ThuongHieuBUS
    {
        private ThuongHieuDAO da = new ThuongHieuDAO();
        public List<ThuongHieuDTO> View() { return da.View(); }
        public bool AddTH(ThuongHieuDTO inf) { return da.AddTH(inf); }
        public bool EditTH(ThuongHieuDTO inf) { return da.EditTH(inf); }
        public bool DeleteTH(ThuongHieuDTO inf) { return da.DeleteTH(inf); }
    }
}
