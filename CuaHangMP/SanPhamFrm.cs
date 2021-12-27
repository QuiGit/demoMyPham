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
using DTO;

namespace CuaHangMP
{
    public partial class SanPhamFrm : Form
    {
        ModelCuaHangDataContext db = new ModelCuaHangDataContext();
        private SanPhamBUS bus = new SanPhamBUS();
        private SanPhamDTO dto = new SanPhamDTO();
        private ThuongHieuBUS busth = new ThuongHieuBUS();
        private ThuongHieuDTO dtoth = new ThuongHieuDTO();
        public SanPhamFrm()
        {
            InitializeComponent();
        }
        public void View()
        {
            dgvSanPham.DataSource = bus.View();
            
        }
        public void Lockout()
        {
            txtMaSp.Enabled = false;
            txtTen.Enabled = false;
            txtGia.Enabled = false;
            dtpHanSD.Enabled = false;
            cmbtenTH.Enabled = false;
            txtmaTH.Enabled = false;
        }
        public void UnLock()
        {
            txtGia.Enabled = true;
            txtTen.Enabled = true;
            dtpHanSD.Enabled = true;
            cmbtenTH.Enabled = true;
        }
        public void ClearFull()
        {
            txtMaSp.Clear();
            txtTen.Clear();
            txtGia.Clear();
            cmbtenTH.SelectedIndex = -1;
            txtmaTH.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            View();
            Lockout();
            cmbtenTH.DataSource = busth.View();
            cmbtenTH.DisplayMember = "TenTH";
            cmbtenTH.SelectedIndex = -1;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtmaTH.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
           
           dto.TenSP = txtTen.Text;
           dto.GiaSP = txtGia.Text;
           dto.MaTH = txtmaTH.Text;
           dto.MaSP = txtMaSp.Text;
           if (bus.AddSP(dto))
           {
                MessageBox.Show("Thêm thành công!");
                View();
                ClearFull();
           }
           else MessageBox.Show("Thêm thất bại!");
            return;
        }

      
        private void btnSua_Click(object sender, EventArgs e)
        {
            dto.MaSP = txtMaSp.Text;
            dto.TenSP = txtTen.Text;
            dto.HanSD = dtpHanSD.Value;
            dto.GiaSP = txtGia.Text;
            dto.MaTH = txtmaTH.Text;
            if (bus.EditSP(dto))
            {
                MessageBox.Show("Sửa thành công!");
                View();
                ClearFull();
            }
            else
                MessageBox.Show("Sửa thất bại!");

            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus.DeleteSP(dto))
                {
                    MessageBox.Show("Xóa thành công!");
                    View();
                    ClearFull();
                }
                else MessageBox.Show("Xóa thất bại");

            }   
            return;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var name = from h in db.SanPhams where h.TenSP.Contains(txtTimKiem.Text) select h;
            dgvSanPham.DataSource = name;
            dgvSanPham.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            UnLock();
            btnThem.Enabled = true;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFull();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HeThong ht = new HeThong();
            ht.Show();
            this.Hide();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) //click bất kỳ hk lỗi
            {
                dto.MaSP = Convert.ToString(dgvSanPham[0, e.RowIndex].Value.ToString());
                txtMaSp.Text = dto.MaSP.ToString();
                dto.TenSP = Convert.ToString(dgvSanPham[1, e.RowIndex].Value.ToString());
                txtTen.Text = dto.TenSP.ToString();
                dto.GiaSP = Convert.ToString(dgvSanPham[2, e.RowIndex].Value.ToString());
                txtGia.Text = dto.GiaSP.ToString();
                dto.HanSD = Convert.ToDateTime(dgvSanPham[3, e.RowIndex].Value);
                dtpHanSD.Value = dto.HanSD.Date;
                dto.MaTH = Convert.ToString(dgvSanPham[4, e.RowIndex].Value.ToString());
                txtmaTH.Text = dto.MaTH.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                UnLock();
            }
        }

        private void cmbTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                ThuongHieuDTO th = cb.SelectedValue as ThuongHieuDTO;
                txtmaTH.Text = th.MaTH.ToString();
            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            // khởi tạo workbook
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            // khởi tạo workshet
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            worksheet.Name = "Sản Phẩm Cửa Hàng Mỹ Phẩm";
            // lấy tên cột dữ liệu
            for (int j = 0; j < dgvSanPham.ColumnCount; j++)
            {
                worksheet.Cells[1, j + 1] = dgvSanPham.Columns[j].HeaderText;
            }
            // đổ dữ liệu vào sheet
            for (int i = 0; i < dgvSanPham.RowCount; i++)
            {
                for (int j = 0; j < dgvSanPham.ColumnCount; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvSanPham.Rows[i].Cells[j].Value;
                }
            }
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            BCSanPhamFrm sp = new BCSanPhamFrm();
            sp.Show();
            this.Hide();
        }

        public bool KiemTra()
        {
            if(txtTen.Text == "")
            {
                MessageBox.Show("Tên chưa nhập");
            }
            
            return true;
        }
    }
}
