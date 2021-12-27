
namespace CuaHangMP
{
    partial class HoaDonFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonFrm));
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.cmbmakh = new System.Windows.Forms.ComboBox();
            this.dtpngay = new System.Windows.Forms.DateTimePicker();
            this.tblThongtinHD = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgtinh = new System.Windows.Forms.TextBox();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.dtpngsinh = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbtensp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dudsoluong = new System.Windows.Forms.DomainUpDown();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndshd = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.tblThongtinHD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column1});
            this.dgvHoaDon.GridColor = System.Drawing.Color.Green;
            this.dgvHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvHoaDon.Location = new System.Drawing.Point(16, 25);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(433, 202);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaHD";
            this.Column2.HeaderText = "Mã Hóa Đơn";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaSP";
            this.Column3.HeaderText = "Mã Sản Phẩm";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuong";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Gia";
            this.Column6.HeaderText = "Giá";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ThanhTien";
            this.Column1.HeaderText = "Thành Tiền";
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã HĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(196, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày Lập";
            // 
            // txtmahd
            // 
            this.txtmahd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahd.ForeColor = System.Drawing.Color.Crimson;
            this.txtmahd.Location = new System.Drawing.Point(86, 24);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(100, 26);
            this.txtmahd.TabIndex = 8;
            // 
            // cmbmakh
            // 
            this.cmbmakh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmakh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmakh.ForeColor = System.Drawing.Color.Crimson;
            this.cmbmakh.FormattingEnabled = true;
            this.cmbmakh.Location = new System.Drawing.Point(270, 23);
            this.cmbmakh.Name = "cmbmakh";
            this.cmbmakh.Size = new System.Drawing.Size(121, 27);
            this.cmbmakh.TabIndex = 10;
            this.cmbmakh.SelectedValueChanged += new System.EventHandler(this.cmbmakh_SelectedValueChanged);
            // 
            // dtpngay
            // 
            this.dtpngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngay.Location = new System.Drawing.Point(88, 61);
            this.dtpngay.Name = "dtpngay";
            this.dtpngay.Size = new System.Drawing.Size(98, 26);
            this.dtpngay.TabIndex = 20;
            this.dtpngay.Value = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            // 
            // tblThongtinHD
            // 
            this.tblThongtinHD.Controls.Add(this.label15);
            this.tblThongtinHD.Controls.Add(this.label7);
            this.tblThongtinHD.Controls.Add(this.txtgtinh);
            this.tblThongtinHD.Controls.Add(this.btnAddKH);
            this.tblThongtinHD.Controls.Add(this.dtpngsinh);
            this.tblThongtinHD.Controls.Add(this.label12);
            this.tblThongtinHD.Controls.Add(this.txtsdt);
            this.tblThongtinHD.Controls.Add(this.txtdiachi);
            this.tblThongtinHD.Controls.Add(this.label11);
            this.tblThongtinHD.Controls.Add(this.label9);
            this.tblThongtinHD.Controls.Add(this.txttenkh);
            this.tblThongtinHD.Controls.Add(this.cmbmakh);
            this.tblThongtinHD.Controls.Add(this.label2);
            this.tblThongtinHD.Controls.Add(this.label3);
            this.tblThongtinHD.Controls.Add(this.dtpngay);
            this.tblThongtinHD.Controls.Add(this.label6);
            this.tblThongtinHD.Controls.Add(this.txtmahd);
            this.tblThongtinHD.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblThongtinHD.ForeColor = System.Drawing.Color.Green;
            this.tblThongtinHD.Location = new System.Drawing.Point(30, 43);
            this.tblThongtinHD.Name = "tblThongtinHD";
            this.tblThongtinHD.Size = new System.Drawing.Size(669, 134);
            this.tblThongtinHD.TabIndex = 23;
            this.tblThongtinHD.TabStop = false;
            this.tblThongtinHD.Text = "Thông tin chung";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(434, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 19);
            this.label15.TabIndex = 32;
            this.label15.Text = "Ngày Sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(196, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Giới Tính";
            // 
            // txtgtinh
            // 
            this.txtgtinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgtinh.ForeColor = System.Drawing.Color.Crimson;
            this.txtgtinh.Location = new System.Drawing.Point(270, 96);
            this.txtgtinh.Name = "txtgtinh";
            this.txtgtinh.Size = new System.Drawing.Size(121, 26);
            this.txtgtinh.TabIndex = 30;
            // 
            // btnAddKH
            // 
            this.btnAddKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKH.ForeColor = System.Drawing.Color.Crimson;
            this.btnAddKH.Location = new System.Drawing.Point(397, 22);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(36, 27);
            this.btnAddKH.TabIndex = 29;
            this.btnAddKH.Text = "+";
            this.btnAddKH.UseVisualStyleBackColor = true;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // dtpngsinh
            // 
            this.dtpngsinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngsinh.Location = new System.Drawing.Point(512, 96);
            this.dtpngsinh.Name = "dtpngsinh";
            this.dtpngsinh.Size = new System.Drawing.Size(145, 26);
            this.dtpngsinh.TabIndex = 28;
            this.dtpngsinh.Value = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(196, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "SĐT";
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.ForeColor = System.Drawing.Color.Crimson;
            this.txtsdt.Location = new System.Drawing.Point(270, 60);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(121, 26);
            this.txtsdt.TabIndex = 25;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.ForeColor = System.Drawing.Color.Crimson;
            this.txtdiachi.Location = new System.Drawing.Point(512, 60);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(145, 26);
            this.txtdiachi.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(451, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Địa Chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(447, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tên KH";
            // 
            // txttenkh
            // 
            this.txttenkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkh.ForeColor = System.Drawing.Color.Crimson;
            this.txttenkh.Location = new System.Drawing.Point(512, 23);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(145, 26);
            this.txttenkh.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(206, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên SP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Lượng";
            // 
            // cmbtensp
            // 
            this.cmbtensp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbtensp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbtensp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtensp.ForeColor = System.Drawing.Color.Crimson;
            this.cmbtensp.FormattingEnabled = true;
            this.cmbtensp.Location = new System.Drawing.Point(270, 24);
            this.cmbtensp.Name = "cmbtensp";
            this.cmbtensp.Size = new System.Drawing.Size(121, 27);
            this.cmbtensp.TabIndex = 11;
            this.cmbtensp.SelectedValueChanged += new System.EventHandler(this.cmbmasp_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(202, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Giá";
            // 
            // txtgia
            // 
            this.txtgia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgia.ForeColor = System.Drawing.Color.Crimson;
            this.txtgia.Location = new System.Drawing.Point(270, 66);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(121, 26);
            this.txtgia.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.dudsoluong);
            this.groupBox2.Controls.Add(this.txtmasp);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtthanhtien);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtgia);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbtensp);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(30, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 104);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // txttimkiem
            // 
            this.txttimkiem.ForeColor = System.Drawing.Color.Crimson;
            this.txttimkiem.Location = new System.Drawing.Point(536, 65);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(121, 26);
            this.txttimkiem.TabIndex = 28;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // dudsoluong
            // 
            this.dudsoluong.ForeColor = System.Drawing.Color.Crimson;
            this.dudsoluong.Items.Add("1");
            this.dudsoluong.Items.Add("2");
            this.dudsoluong.Items.Add("3");
            this.dudsoluong.Items.Add("4");
            this.dudsoluong.Items.Add("5");
            this.dudsoluong.Items.Add("6");
            this.dudsoluong.Items.Add("7");
            this.dudsoluong.Items.Add("8");
            this.dudsoluong.Items.Add("9");
            this.dudsoluong.Items.Add("10");
            this.dudsoluong.Items.Add("11");
            this.dudsoluong.Items.Add("12");
            this.dudsoluong.Items.Add("13");
            this.dudsoluong.Items.Add("14");
            this.dudsoluong.Items.Add("15");
            this.dudsoluong.Items.Add("16");
            this.dudsoluong.Items.Add("17");
            this.dudsoluong.Items.Add("18");
            this.dudsoluong.Items.Add("19");
            this.dudsoluong.Items.Add("20");
            this.dudsoluong.Items.Add("21");
            this.dudsoluong.Items.Add("22");
            this.dudsoluong.Items.Add("23");
            this.dudsoluong.Items.Add("24");
            this.dudsoluong.Items.Add("25");
            this.dudsoluong.Items.Add("26");
            this.dudsoluong.Items.Add("27");
            this.dudsoluong.Items.Add("28");
            this.dudsoluong.Items.Add("29");
            this.dudsoluong.Items.Add("30");
            this.dudsoluong.Location = new System.Drawing.Point(86, 66);
            this.dudsoluong.Name = "dudsoluong";
            this.dudsoluong.Size = new System.Drawing.Size(98, 26);
            this.dudsoluong.TabIndex = 27;
            // 
            // txtmasp
            // 
            this.txtmasp.ForeColor = System.Drawing.Color.Crimson;
            this.txtmasp.Location = new System.Drawing.Point(86, 25);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(100, 26);
            this.txtmasp.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(12, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "Mã SP";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthanhtien.ForeColor = System.Drawing.Color.Crimson;
            this.txtthanhtien.Location = new System.Drawing.Point(536, 21);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(121, 26);
            this.txtthanhtien.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(442, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Thành Tiền";
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Crimson;
            this.btnupdate.Image = global::CuaHangMP.Properties.Resources.backgroud;
            this.btnupdate.Location = new System.Drawing.Point(20, 103);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 33);
            this.btnupdate.TabIndex = 31;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndshd
            // 
            this.btndshd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndshd.ForeColor = System.Drawing.Color.Crimson;
            this.btndshd.Image = global::CuaHangMP.Properties.Resources.backgroud;
            this.btndshd.Location = new System.Drawing.Point(20, 23);
            this.btndshd.Name = "btndshd";
            this.btndshd.Size = new System.Drawing.Size(75, 33);
            this.btndshd.TabIndex = 27;
            this.btndshd.Text = "Hóa đơn";
            this.btndshd.UseVisualStyleBackColor = true;
            this.btndshd.Click += new System.EventHandler(this.btndshd_Click);
            // 
            // btnin
            // 
            this.btnin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.ForeColor = System.Drawing.Color.Crimson;
            this.btnin.Image = global::CuaHangMP.Properties.Resources.backgroud;
            this.btnin.Location = new System.Drawing.Point(117, 142);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 34);
            this.btnin.TabIndex = 26;
            this.btnin.Text = "Xuất";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Crimson;
            this.btnback.Image = global::CuaHangMP.Properties.Resources.backgroud;
            this.btnback.Location = new System.Drawing.Point(20, 182);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 33);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "Trở lại";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Crimson;
            this.btnexit.Image = global::CuaHangMP.Properties.Resources.backgroud;
            this.btnexit.Location = new System.Drawing.Point(117, 182);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 33);
            this.btnexit.TabIndex = 18;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Crimson;
            this.btndelete.Image = global::CuaHangMP.Properties.Resources.backgroud;
            this.btndelete.Location = new System.Drawing.Point(117, 103);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 33);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Crimson;
            this.btncancel.Image = global::CuaHangMP.Properties.Resources.backgroud;
            this.btncancel.Location = new System.Drawing.Point(117, 23);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 34);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "Hủy";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Crimson;
            this.btnsave.Image = global::CuaHangMP.Properties.Resources.backgroud;
            this.btnsave.Location = new System.Drawing.Point(117, 63);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 33);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.Color.Crimson;
            this.btninsert.Image = global::CuaHangMP.Properties.Resources.backgroud;
            this.btninsert.Location = new System.Drawing.Point(20, 63);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 34);
            this.btninsert.TabIndex = 13;
            this.btninsert.Text = "Thêm";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnreport
            // 
            this.btnreport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.Crimson;
            this.btnreport.Image = global::CuaHangMP.Properties.Resources.backgroud;
            this.btnreport.Location = new System.Drawing.Point(20, 142);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(75, 34);
            this.btnreport.TabIndex = 32;
            this.btnreport.Text = "Báo Cáo";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(30, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 235);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btninsert);
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Controls.Add(this.btndshd);
            this.groupBox3.Controls.Add(this.btnreport);
            this.groupBox3.Controls.Add(this.btnin);
            this.groupBox3.Controls.Add(this.btnupdate);
            this.groupBox3.Controls.Add(this.btncancel);
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Controls.Add(this.btnback);
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(495, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 235);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử lý";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(448, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "Từ khóa";
            // 
            // HoaDonFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(726, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tblThongtinHD);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoaDonFrm";
            this.Text = "Hệ Thống Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.HoaDonFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.tblThongtinHD.ResumeLayout(false);
            this.tblThongtinHD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.ComboBox cmbmakh;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DateTimePicker dtpngay;
        private System.Windows.Forms.GroupBox tblThongtinHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbtensp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btndshd;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DomainUpDown dudsoluong;
        private System.Windows.Forms.DateTimePicker dtpngsinh;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.TextBox txtgtinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label14;
    }
}