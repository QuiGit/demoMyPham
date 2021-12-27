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
    public partial class BCKhachHangFrm : Form
    {
        public BCKhachHangFrm()
        {
            InitializeComponent();
        }

        private void BCKhachHangFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CHMPDataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.KhachHangTableAdapter.Fill(this.CHMPDataSet1.KhachHang);

            this.rpvKhachHang.RefreshReport();
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            KhacHangFrm kh = new KhacHangFrm();
            kh.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
