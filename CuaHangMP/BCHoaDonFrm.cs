using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace CuaHangMP
{
    public partial class BCHoaDonFrm : Form
    {
        ChiTietBUS busct = new ChiTietBUS();
        public BCHoaDonFrm()
        {
            InitializeComponent();
        }

        private void BaoCaoFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CHMPDataSet.ChiTietHD' table. You can move, or remove it, as needed.

            this.ChiTietHDTableAdapter.Fill(this.CHMPDataSet.ChiTietHD);

            this.rpvReport.RefreshReport();
        }
       
    

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btntrolai_Click(object sender, EventArgs e)
        {
            HoaDonFrm hd = new HoaDonFrm();
            hd.Show();
            this.Hide();
        }

      
    }
}
