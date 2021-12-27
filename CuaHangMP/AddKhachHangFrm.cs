using DTO;
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
    public partial class AddKhachHangFrm : Form
    {
        KhachHangBUS bus = new KhachHangBUS();
        KhachHangDTO dto = new KhachHangDTO();
        public AddKhachHangFrm()
        {
            InitializeComponent();
        }
        public void View()
        {
            dgvKhachHang.DataSource = bus.View();
        }
        public void Lockout()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtdiachi.Enabled = false;
            mtbsdt.Enabled = false;
            cmbGtinh.Enabled = false;
            dtpngsinh.Enabled = false;
        }
        public void Unlock()
        {
            txtten.Enabled = true;
            txtdiachi.Enabled = true;
            mtbsdt.Enabled = true;
            dtpngsinh.Enabled = true;
            cmbGtinh.Enabled = true;
        }
        public void ClearFull()
        {
            txtma.Clear();
            txtten.Clear();
            txtdiachi.Clear();
            mtbsdt.Clear();
            cmbGtinh.SelectedIndex = -1;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            dto.TenKH = txtten.Text;
            dto.NgSinh = dtpngsinh.Value;
            dto.DiaChi = txtdiachi.Text;
            
            dto.GTinh = cmbGtinh.Text;
            dto.SDT = mtbsdt.Text;
            if (bus.AddKH(dto))
            {
                MessageBox.Show("Thêm thành công!");
                View();
                ClearFull();
            }
            else MessageBox.Show("Thêm thất bại!");
            return;
        }

        private void AddKhachHangFrm_Load(object sender, EventArgs e)
        {
            View();
            Lockout();
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            HoaDonFrm hd = new HoaDonFrm();
            hd.Show();
            this.Hide();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) //click bất kỳ hk lỗi
            {
                dto.MaKH = Convert.ToString(dgvKhachHang[0, e.RowIndex].Value.ToString());
                txtma.Text = dto.MaKH.ToString();
                dto.TenKH = Convert.ToString(dgvKhachHang[1, e.RowIndex].Value.ToString());
                txtten.Text = dto.TenKH.ToString();
                dto.NgSinh = Convert.ToDateTime(dgvKhachHang[2, e.RowIndex].Value);
                dtpngsinh.Value = dto.NgSinh.Date;
                dto.DiaChi = Convert.ToString(dgvKhachHang[3, e.RowIndex].Value.ToString());
                txtdiachi.Text = dto.DiaChi.ToString();

                dto.SDT = Convert.ToString(dgvKhachHang[4, e.RowIndex].Value.ToString());
                mtbsdt.Text = dto.SDT.ToString();
                dto.GTinh = Convert.ToString(dgvKhachHang[5, e.RowIndex].Value.ToString());
                cmbGtinh.Text = dto.GTinh.ToString();
                btndelete.Enabled = true;
                btnupdate.Enabled = true;
                Unlock();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            dto.TenKH = txtten.Text;
            dto.NgSinh = dtpngsinh.Value;
            dto.DiaChi = txtdiachi.Text;
            dto.SDT = mtbsdt.Text;
            dto.GTinh = cmbGtinh.Text;
            if (bus.EditKH(dto))
            {
                MessageBox.Show("Sửa thành công!");
                View();
                ClearFull();
            }
            else MessageBox.Show("Sửa thất bại!");
            return;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus.DeleteKH(dto))
                {
                    MessageBox.Show("Xóa thành công!");
                    View();
                    ClearFull();
                }
                else MessageBox.Show("Xóa thất bại");
            }
            return;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Unlock();
            btnsave.Enabled = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
