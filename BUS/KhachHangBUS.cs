using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAO da = new KhachHangDAO();
        public List<KhachHangDTO> View() { return da.View(); }
        public bool AddKH(KhachHangDTO inf) { return da.AddKH(inf); }
        public bool EditKH(KhachHangDTO inf) { return da.EditKH(inf); }
        public bool DeleteKH(KhachHangDTO inf) { return da.DeleteKH(inf); }
    }
}
