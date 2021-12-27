using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAO da = new SanPhamDAO();
        public List<SanPhamDTO> View() {return da.View(); }
        public bool AddSP(SanPhamDTO inf) { return da.AddSP(inf); }
        public bool EditSP(SanPhamDTO inf) { return da.EditSP(inf); }
        public bool DeleteSP(SanPhamDTO inf) { return da.DeleteSP(inf); }

      


    }
}
