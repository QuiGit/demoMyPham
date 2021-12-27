using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMP
{
    public partial class DoiPassFrm : Form
    {
        public DoiPassFrm()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-RPNTHEA\SQLEXPRESS;Initial Catalog=CHMP;Integrated Security=True");
        private void btndoipass_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select count (*) from TaiKhoan where UserName = N'" + txtuser.Text + "' and PassWord = N'" + txtpass.Text + "'", cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        if (txtpassnew.Text == txtpassnews.Text)
                        {
                            if (txtpassnew.Text.Length > 6)
                            {
                                SqlDataAdapter da1 = new SqlDataAdapter("Update TaiKhoan set PassWord = N'" + txtpassnew.Text + "' where UserName = N'" + txtuser.Text + "' and PassWord = N'" + txtpass.Text + "'", cn);
                                DataTable dt1 = new DataTable();
                                da1.Fill(dt1);
                                MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DangNhapFrm dn = new DangNhapFrm();
                                dn.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Độ dài mật khẩu không đủ !");
                            }
                        }

                    }
                }
                catch
                {

                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Hệ thống thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked)
            {
                txtpass.PasswordChar = (char)0;
                txtpassnew.PasswordChar = (char)0;
                txtpassnews.PasswordChar = (char)0;
            }
            else
            {
                txtpass.PasswordChar = '*';
                txtpassnew.PasswordChar = '*';
                txtpassnews.PasswordChar = '*';
            }
        }
        public bool KiemTra()
        {
            if(txtuser.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên tài khoản!");
            }
            else if(txtpass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ!");
            }
            else if (txtpassnew.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới!");
            }else if (txtpassnews.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập xác nhận mật khẩu mới!");
            }
            return true;
        }

        private void btntrolai_Click(object sender, EventArgs e)
        {
            HeThong ht = new HeThong();
            ht.Show();
            this.Hide();
        }
    }
}
