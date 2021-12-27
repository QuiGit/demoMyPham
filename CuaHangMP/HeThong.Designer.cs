
namespace CuaHangMP
{
    partial class HeThong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnhh = new System.Windows.Forms.ToolStripMenuItem();
            this.mndoimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mndddd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnthuonghieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnhh,
            this.mndddd,
            this.mnHoaDon});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnhh
            // 
            this.mnhh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mndoimatkhau,
            this.mnthoat});
            this.mnhh.ForeColor = System.Drawing.Color.Crimson;
            this.mnhh.Name = "mnhh";
            this.mnhh.Size = new System.Drawing.Size(98, 32);
            this.mnhh.Text = "Hệ thống";
            // 
            // mndoimatkhau
            // 
            this.mndoimatkhau.ForeColor = System.Drawing.Color.Crimson;
            this.mndoimatkhau.Name = "mndoimatkhau";
            this.mndoimatkhau.Size = new System.Drawing.Size(193, 28);
            this.mndoimatkhau.Text = "Đổi mật khẩu";
            this.mndoimatkhau.Click += new System.EventHandler(this.mndoimatkhau_Click);
            // 
            // mnthoat
            // 
            this.mnthoat.ForeColor = System.Drawing.Color.Crimson;
            this.mnthoat.Name = "mnthoat";
            this.mnthoat.Size = new System.Drawing.Size(193, 28);
            this.mnthoat.Text = "Thoát";
            this.mnthoat.Click += new System.EventHandler(this.mnthoat_Click);
            // 
            // mndddd
            // 
            this.mndddd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsanpham,
            this.mnthuonghieu,
            this.mnkhachhang});
            this.mndddd.ForeColor = System.Drawing.Color.Crimson;
            this.mndddd.Name = "mndddd";
            this.mndddd.Size = new System.Drawing.Size(107, 32);
            this.mndddd.Text = "Danh mục";
            // 
            // mnsanpham
            // 
            this.mnsanpham.ForeColor = System.Drawing.Color.Crimson;
            this.mnsanpham.Name = "mnsanpham";
            this.mnsanpham.Size = new System.Drawing.Size(185, 28);
            this.mnsanpham.Text = "Sản phẩm";
            this.mnsanpham.Click += new System.EventHandler(this.mnsanpham_Click);
            // 
            // mnthuonghieu
            // 
            this.mnthuonghieu.ForeColor = System.Drawing.Color.Crimson;
            this.mnthuonghieu.Name = "mnthuonghieu";
            this.mnthuonghieu.Size = new System.Drawing.Size(185, 28);
            this.mnthuonghieu.Text = "Thương hiệu";
            this.mnthuonghieu.Click += new System.EventHandler(this.mnthuonghieu_Click);
            // 
            // mnkhachhang
            // 
            this.mnkhachhang.ForeColor = System.Drawing.Color.Crimson;
            this.mnkhachhang.Name = "mnkhachhang";
            this.mnkhachhang.Size = new System.Drawing.Size(185, 28);
            this.mnkhachhang.Text = "Khách hàng";
            this.mnkhachhang.Click += new System.EventHandler(this.mnkhachhang_Click);
            // 
            // mnHoaDon
            // 
            this.mnHoaDon.ForeColor = System.Drawing.Color.Crimson;
            this.mnHoaDon.Name = "mnHoaDon";
            this.mnHoaDon.Size = new System.Drawing.Size(98, 32);
            this.mnHoaDon.Text = "Hóa Đơn";
            this.mnHoaDon.Click += new System.EventHandler(this.mnHoaDon_Click);
            // 
            // HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CuaHangMP.Properties.Resources.shop_my_pham;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HeThong";
            this.Text = "Hệ Thống Quản Lý Cửa Hàng";
            this.Load += new System.EventHandler(this.HeThong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnhh;
        private System.Windows.Forms.ToolStripMenuItem mndddd;
        private System.Windows.Forms.ToolStripMenuItem mnHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mndoimatkhau;
        private System.Windows.Forms.ToolStripMenuItem mnthoat;
        private System.Windows.Forms.ToolStripMenuItem mnsanpham;
        private System.Windows.Forms.ToolStripMenuItem mnthuonghieu;
        private System.Windows.Forms.ToolStripMenuItem mnkhachhang;
    }
}