using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace CuaHangMP
{
    public partial class DsHoaDonFrm : Form
    {
        HoaDonBUS bus = new HoaDonBUS();
        HoaDonDTO dto = new HoaDonDTO();
        public DsHoaDonFrm()
        {
            InitializeComponent();
        }
        public void View()
        {
            dgvdshoadon.DataSource = bus.View();
            txten.Enabled = false;
            txtma.Enabled = false;
            dtpngay.Enabled = false;
            txttongtien.Enabled = false;
        }
        public void ClearFull()
        {
            txten.Text = "";
            txtma.Text = "";
            txttongtien.Text = "";
        }
        private void DsHoaDonFrm_Load(object sender, EventArgs e)
        {
            View();
        }

        private void dgvdshoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) //click bất kỳ hk lỗi
            {

                dto.MaHD = Convert.ToString(dgvdshoadon[0, e.RowIndex].Value.ToString());
                txtma.Text = dto.MaHD.ToString();
                dto.NgLapHD = Convert.ToDateTime(dgvdshoadon[1, e.RowIndex].Value);
                dtpngay.Value = dto.NgLapHD.Date;
                dto.MaKH = Convert.ToString(dgvdshoadon[2, e.RowIndex].Value.ToString());
                txten.Text = dto.MaKH.ToString();
               
                dto.TongTien =(float)Convert.ToDouble(dgvdshoadon[3, e.RowIndex].Value.ToString());
                txttongtien.Text = dto.TongTien.ToString();

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus.DeleteHD(dto))
                {
                    MessageBox.Show("Xóa thành công!");
                    View();
                    ClearFull();
                }
                else MessageBox.Show("Xóa thất bại");
            }
            return;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            HoaDonFrm hd = new HoaDonFrm();
            hd.Show();
            this.Hide();
        }
       
    }
}
