using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO da = new HoaDonDAO();
        public List<HoaDonDTO> View() { return da.View(); }
        public bool AddHD(HoaDonDTO inf) { return da.AddHD(inf); }
        public bool EditHD(HoaDonDTO inf) { return da.EditHD(inf); }
        public bool DeleteHD(HoaDonDTO inf) { return da.DeleteHD(inf); }
        
    }
}
