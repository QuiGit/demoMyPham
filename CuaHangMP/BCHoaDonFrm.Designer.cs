
namespace CuaHangMP
{
    partial class BCHoaDonFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BCHoaDonFrm));
            this.ChiTietHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CHMPDataSet = new CuaHangMP.CHMPDataSet();
            this.rpvReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChiTietHDTableAdapter = new CuaHangMP.CHMPDataSetTableAdapters.ChiTietHDTableAdapter();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btntrolai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHMPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ChiTietHDBindingSource
            // 
            this.ChiTietHDBindingSource.DataMember = "ChiTietHD";
            this.ChiTietHDBindingSource.DataSource = this.CHMPDataSet;
            // 
            // CHMPDataSet
            // 
            this.CHMPDataSet.DataSetName = "CHMPDataSet";
            this.CHMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvReport
            // 
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.ChiTietHDBindingSource;
            this.rpvReport.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvReport.LocalReport.ReportEmbeddedResource = "CuaHangMP.ReportHoadon.rdlc";
            this.rpvReport.Location = new System.Drawing.Point(42, 49);
            this.rpvReport.Name = "rpvReport";
            this.rpvReport.ServerReport.BearerToken = null;
            this.rpvReport.Size = new System.Drawing.Size(626, 326);
            this.rpvReport.TabIndex = 0;
            // 
            // ChiTietHDTableAdapter
            // 
            this.ChiTietHDTableAdapter.ClearBeforeFill = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Crimson;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(593, 11);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btntrolai
            // 
            this.btntrolai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrolai.ForeColor = System.Drawing.Color.Crimson;
            this.btntrolai.Image = ((System.Drawing.Image)(resources.GetObject("btntrolai.Image")));
            this.btntrolai.Location = new System.Drawing.Point(42, 11);
            this.btntrolai.Name = "btntrolai";
            this.btntrolai.Size = new System.Drawing.Size(75, 32);
            this.btntrolai.TabIndex = 2;
            this.btntrolai.Text = "Trở lại";
            this.btntrolai.UseVisualStyleBackColor = true;
            this.btntrolai.Click += new System.EventHandler(this.btntrolai_Click);
            // 
            // BCHoaDonFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(721, 417);
            this.Controls.Add(this.btntrolai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.rpvReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BCHoaDonFrm";
            this.Text = "Báo cáo danh sách hóa đơn";
            this.Load += new System.EventHandler(this.BaoCaoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHMPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rpvReport;
        private System.Windows.Forms.BindingSource ChiTietHDBindingSource;
        private CHMPDataSet CHMPDataSet;
        private CHMPDataSetTableAdapters.ChiTietHDTableAdapter ChiTietHDTableAdapter;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btntrolai;
    }
}