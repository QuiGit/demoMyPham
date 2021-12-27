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
    public partial class BCSanPhamFrm : Form
    {
        public BCSanPhamFrm()
        {
            InitializeComponent();
        }

        private void BCSanPhamFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CHMPDataSet2.SanPham' table. You can move, or remove it, as needed.
            this.SanPhamTableAdapter.Fill(this.CHMPDataSet2.SanPham);

            this.reportViewer1.RefreshReport();
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            SanPhamFrm sp = new SanPhamFrm();
            sp.Show();
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
