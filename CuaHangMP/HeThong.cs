using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMP
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void mnHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonFrm hd = new HoaDonFrm();
            hd.Show();
            this.Hide();
        }

        private void HeThong_Load(object sender, EventArgs e)
        {

        }

       

        private void mnsanpham_Click(object sender, EventArgs e)
        {
            SanPhamFrm sp = new SanPhamFrm();
            sp.Show();
            this.Hide();
        }

        private void mnthuonghieu_Click(object sender, EventArgs e)
        {
            ThuongHieuFrm th = new ThuongHieuFrm();
            th.Show();
            this.Hide();
        }

        private void mnkhachhang_Click(object sender, EventArgs e)
        {
            KhacHangFrm kh = new KhacHangFrm();
            kh.Show();
            this.Hide();
        }

        private void mndoimatkhau_Click(object sender, EventArgs e)
        {
            DoiPassFrm dp = new DoiPassFrm();
            dp.Show();
            this.Hide();
        }

        private void mnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
