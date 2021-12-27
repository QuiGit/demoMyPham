
namespace CuaHangMP
{
    partial class BCKhachHangFrm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BCKhachHangFrm));
            this.KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CHMPDataSet1 = new CuaHangMP.CHMPDataSet1();
            this.rpvKhachHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KhachHangTableAdapter = new CuaHangMP.CHMPDataSet1TableAdapters.KhachHangTableAdapter();
            this.btnTrolai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHMPDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // KhachHangBindingSource
            // 
            this.KhachHangBindingSource.DataMember = "KhachHang";
            this.KhachHangBindingSource.DataSource = this.CHMPDataSet1;
            // 
            // CHMPDataSet1
            // 
            this.CHMPDataSet1.DataSetName = "CHMPDataSet1";
            this.CHMPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvKhachHang
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KhachHangBindingSource;
            this.rpvKhachHang.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvKhachHang.LocalReport.ReportEmbeddedResource = "CuaHangMP.ReportKhachHang.rdlc";
            this.rpvKhachHang.Location = new System.Drawing.Point(48, 50);
            this.rpvKhachHang.Name = "rpvKhachHang";
            this.rpvKhachHang.ServerReport.BearerToken = null;
            this.rpvKhachHang.Size = new System.Drawing.Size(670, 364);
            this.rpvKhachHang.TabIndex = 0;
            // 
            // KhachHangTableAdapter
            // 
            this.KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // btnTrolai
            // 
            this.btnTrolai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrolai.ForeColor = System.Drawing.Color.Crimson;
            this.btnTrolai.Image = ((System.Drawing.Image)(resources.GetObject("btnTrolai.Image")));
            this.btnTrolai.Location = new System.Drawing.Point(48, 12);
            this.btnTrolai.Name = "btnTrolai";
            this.btnTrolai.Size = new System.Drawing.Size(75, 32);
            this.btnTrolai.TabIndex = 2;
            this.btnTrolai.Text = "Trở lại";
            this.btnTrolai.UseVisualStyleBackColor = true;
            this.btnTrolai.Click += new System.EventHandler(this.btnTrolai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Crimson;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(643, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // BCKhachHangFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(769, 436);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTrolai);
            this.Controls.Add(this.rpvKhachHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BCKhachHangFrm";
            this.Text = "Báo cáo danh sách khách hàng";
            this.Load += new System.EventHandler(this.BCKhachHangFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHMPDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvKhachHang;
        private System.Windows.Forms.BindingSource KhachHangBindingSource;
        private CHMPDataSet1 CHMPDataSet1;
        private CHMPDataSet1TableAdapters.KhachHangTableAdapter KhachHangTableAdapter;
        private System.Windows.Forms.Button btnTrolai;
        private System.Windows.Forms.Button btnThoat;
    }
}