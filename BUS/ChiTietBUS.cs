using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietBUS
    {
        ChiTietDAO da = new ChiTietDAO();
        public List<ChiTietDTO> View(){ return da.View(); }
        public bool AddCT(ChiTietDTO inf) { return da.AddCT(inf); }
        public bool EditCT(ChiTietDTO inf) { return da.EditCT(inf); }
        public bool DeleteCT(ChiTietDTO inf) { return da.DeleteCT(inf); }
        
    }
}
