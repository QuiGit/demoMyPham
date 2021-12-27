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
    public partial class ThuongHieuFrm : Form
    {
        ThuongHieuBUS bus = new ThuongHieuBUS();
        ThuongHieuDTO dto = new ThuongHieuDTO();
        public ThuongHieuFrm()
        {
            InitializeComponent();
        }
        public void View()
        {
            dgvTH.DataSource = bus.View();
        }
        public void Lockout()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
        }
        public void Unlock()
        {
            txtten.Enabled = true;
        }
        public void ClearFull()
        {
            txtma.Clear();
            txtten.Clear();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Lockout();
            View();
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Unlock();
            btnSave.Enabled = true;
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) //click bất kỳ hk lỗi
            {
                dto.MaTH = Convert.ToString(dgvTH[0, e.RowIndex].Value.ToString());
                txtma.Text = dto.MaTH.ToString();
                dto.TenTH = Convert.ToString(dgvTH[1, e.RowIndex].Value.ToString());
                txtten.Text = dto.TenTH.ToString();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                Unlock();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dto.MaTH = txtma.Text;
            dto.TenTH = txtten.Text;
            if (bus.EditTH(dto))
            {
                MessageBox.Show("Sửa thành công!");
                View();
                ClearFull();
            }
            else
                MessageBox.Show("Sửa thất bại!");
            return;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus.DeleteTH(dto))
                {
                    MessageBox.Show("Xóa thành công!");
                    View();
                    ClearFull();
                }
                else MessageBox.Show("Xóa thất bại");
            }
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HeThong th = new HeThong();
            th.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dto.MaTH = txtma.Text;
            dto.TenTH = txtten.Text;
            if (bus.AddTH(dto))
            {
                MessageBox.Show("Thêm thành công!");
                View();
                ClearFull();
            }
            else
                MessageBox.Show("Thêm thất bại!");
            return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFull();    
        }

        private void txtma_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
