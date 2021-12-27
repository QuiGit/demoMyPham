using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DTO;
using BUS;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;

namespace CuaHangMP
{
    public partial class HoaDonFrm : Form
    {
      
        ModelCuaHangDataContext db = new ModelCuaHangDataContext();
        HoaDonBUS bus = new HoaDonBUS();
        HoaDonDTO dto = new HoaDonDTO();

        SanPhamBUS bussp = new SanPhamBUS();
        KhachHangBUS buskh = new KhachHangBUS();

        ChiTietBUS busct = new ChiTietBUS();

        ChiTietDTO dtoct = new ChiTietDTO();
        KhachHangDTO dtokh =  new KhachHangDTO();
        KhachHangBUS busqlkh = new KhachHangBUS();
        public HoaDonFrm()
        {
            InitializeComponent();
        }
        public void View()
        {
            dgvHoaDon.DataSource = busct.View();
        }
        public void Lockout()
        {
            txtmahd.Enabled = false;
            dudsoluong.Enabled = false;
            cmbmakh.Enabled = false;
            cmbtensp.Enabled = false;
            dtpngay.Enabled = false;
            txtdiachi.Enabled = false;
            txtsdt.Enabled = false;
            txttenkh.Enabled = false;
            txtgtinh.Enabled = false;
            txtgia.Enabled = false;
            txtmasp.Enabled = false;
            txtgia.Text = "";
            txtmasp.Text = "";
            dtpngay.Enabled = false;
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            dtpngsinh.Enabled = false;
        }
        public void Unlock()
        {
            dudsoluong.Enabled = true;
            cmbtensp.Enabled = true;
            cmbmakh.Enabled = true;
            dtpngay.Enabled = true;
        }
        public void ClearFull()
        {
            txtmahd.Text = "";
            dudsoluong.Text = "";
            cmbmakh.Text="";
            cmbtensp.Text="";
            dtpngay.Value = DateTime.Now;
            txtgia.Text = "";
            txtthanhtien.Text = "";
            txtmasp.Text = "";
            txttimkiem.Text = "";
            txtgtinh.Text = "";
            txtsdt.Text = "";
        }
        private void HoaDonFrm_Load(object sender, EventArgs e)
        {

            cmbtensp.DataSource = bussp.View();
            cmbtensp.DisplayMember = "TenSP";
            cmbtensp.SelectedIndex = -1;
            View();
            Lockout();
            /*dgvHoaDon.Columns["MaHD"].Visible = false;//ẩn cột MAHD*/
            btnsave.Enabled = false;
            txtthanhtien.Enabled = false;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Unlock();
           
            cmbmakh.DataSource = buskh.View();
            cmbmakh.DisplayMember = "MaKH";
            btnsave.Enabled = true;
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            float gia, soluong, tt, tong, tongtien;
            
            dtoct.MaHD = txtmahd.Text;
            dtoct.MaSP = txtmasp.Text;
            dtoct.SoLuong = (float)Convert.ToDouble(dudsoluong.Text);
            dtoct.Gia = (float)Convert.ToDouble(txtgia.Text);
            if (txtgia.Text == "")
            {
                gia = 0;
            }
            else
                gia = (float)Convert.ToDouble(txtgia.Text);
            if (dudsoluong.Text == "")
            {
                soluong = 0;
            }
            else
                soluong = (float)Convert.ToDouble(dudsoluong.Text);
            tt = gia * soluong;
            txtthanhtien.Text = tt.ToString();
            dtoct.ThanhTien = (float)Convert.ToDouble(txtthanhtien.Text);
            if (busct.AddCT(dtoct))
            {
                MessageBox.Show("Thêm thành công!");
                View();
                ClearFull();
            }
            else MessageBox.Show("Thêm thất bại!");

            dto.MaHD = txtmahd.Text;
           /* dto.MaKH = txtmakh.Text;*/
            dto.MaKH = cmbmakh.Text;
            dto.NgLapHD = dtpngay.Value;
            tongtien = dtoct.ThanhTien.Value;
            dto.TongTien = (float)Convert.ToDouble(tongtien);
            if (!bus.AddHD(dto))
            {
                View();
                ClearFull();
            }
            
            return;
        }
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) //click bất kỳ hk lỗi
            {

                dtoct.MaHD = Convert.ToString(dgvHoaDon[0, e.RowIndex].Value.ToString());
                txtmahd.Text = dtoct.MaHD.ToString();

                dtoct.MaSP = Convert.ToString(dgvHoaDon[1, e.RowIndex].Value.ToString());
                txtmasp.Text = dtoct.MaSP.ToString();
                dtoct.SoLuong = (float)Convert.ToDouble(dgvHoaDon[2, e.RowIndex].Value.ToString());
                dudsoluong.Text = dtoct.SoLuong.ToString();
                dtoct.Gia = (float)Convert.ToDouble(dgvHoaDon[3, e.RowIndex].Value.ToString());
                txtgia.Text = dtoct.Gia.ToString();
                dtoct.ThanhTien = (float)Convert.ToDouble(dgvHoaDon[4, e.RowIndex].Value.ToString());
                txtthanhtien.Text = dtoct.ThanhTien.ToString();
                btndelete.Enabled = true;
                btnupdate.Enabled = true;
                cmbtensp.Enabled = true;
                dudsoluong.Enabled = true;

            }
           
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            ClearFull();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busct.DeleteCT(dtoct))
                {
                    MessageBox.Show("Xóa thành công!");
                    ClearFull();
                    View();
                }
                else MessageBox.Show("Xóa thất bại");

            }
            return;

        }
    

        private void btnin_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            // khởi tạo workbook
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            // khởi tạo workshet
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            worksheet.Name = "Hóa Đơn Cửa Hàng Mỹ Phẩm";
                // lấy tên cột dữ liệu
            for (int j = 0; j < dgvHoaDon.ColumnCount; j++)
            {
                worksheet.Cells[1, j + 1] = dgvHoaDon.Columns[j].HeaderText;
            }
                // đổ dữ liệu vào sheet
            for (int i = 0; i < dgvHoaDon.RowCount; i++)
            {
                for (int j = 0; j < dgvHoaDon.ColumnCount; j++)
                {
                        worksheet.Cells[i + 2, j + 1] = dgvHoaDon.Rows[i].Cells[j].Value;
                }
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            HeThong ht = new HeThong();
            ht.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cmbmakh_SelectedValueChanged(object sender, EventArgs e)
        {
            
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                KhachHangDTO kh = cb.SelectedValue as KhachHangDTO;
                txttenkh.Text = kh.TenKH.ToString();
                txtdiachi.Text = kh.DiaChi.ToString();
                txtsdt.Text = kh.SDT.ToString();
                txtgtinh.Text = kh.GTinh.ToString();
                dtpngsinh.Value = kh.NgSinh.Date;
            }
        }

        private void cmbmasp_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                SanPhamDTO sp = cb.SelectedValue as SanPhamDTO;
                txtgia.Text = sp.GiaSP.ToString();
                txtmasp.Text = sp.MaSP.ToString();
            }
        }

        private void btndshd_Click(object sender, EventArgs e)
        {
            DsHoaDonFrm ds = new DsHoaDonFrm();
            ds.Show();
            this.Hide();
        }

       

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            AddKhachHangFrm kh = new AddKhachHangFrm();
            kh.Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            dtoct.MaHD = txtmahd.Text;
            dtoct.MaSP = txtmasp.Text;
            dtoct.SoLuong = (float)Convert.ToDouble(dudsoluong.Text);
            dtoct.Gia = (float)Convert.ToDouble(txtgia.Text);
            dtoct.ThanhTien = (float)Convert.ToDouble(txtthanhtien.Text);
            if (busct.EditCT(dtoct))
            {
                MessageBox.Show("Sửa thành công!");
                View();
                ClearFull();
            }
            else MessageBox.Show("Sửa thất bại!");
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            BCHoaDonFrm bc = new BCHoaDonFrm();
            bc.Show();
            this.Hide();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            var name = from h in db.ChiTietHDs where h.MaHD.Contains(txttimkiem.Text) select h;
            dgvHoaDon.DataSource = name;
            dgvHoaDon.Refresh();
        }
    }
}
