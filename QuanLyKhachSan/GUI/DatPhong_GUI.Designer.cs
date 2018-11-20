namespace QuanLyKhachSan.GUI
{
    partial class DatPhong_GUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgvdp = new System.Windows.Forms.DataGridView();
            this.madp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiendatcoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtNgayDen = new System.Windows.Forms.DateTimePicker();
            this.txtTienCoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaDP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ckbtrangtrai = new System.Windows.Forms.CheckBox();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtLoaiPhongDat = new DevExpress.XtraEditors.TextEdit();
            this.txtsoluong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnClearAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearOne = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddOne = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddAll = new DevExpress.XtraEditors.SimpleButton();
            this.listDatPhong = new System.Windows.Forms.ListBox();
            this.listPhong = new System.Windows.Forms.ListBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.qlkscDataSet1 = new QuanLyKhachSan.QLKSCDataSet();
            this.txtSoNgay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienCoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiPhongDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlkscDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgvdp);
            this.groupControl3.Location = new System.Drawing.Point(13, 230);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(771, 253);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Bảng danh sách";
            // 
            // dgvdp
            // 
            this.dgvdp.AllowUserToAddRows = false;
            this.dgvdp.AllowUserToDeleteRows = false;
            this.dgvdp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madp,
            this.manv,
            this.makh,
            this.loaiphong,
            this.ngaydat,
            this.ngayden,
            this.ngaydi,
            this.tiendatcoc,
            this.soluong,
            this.trangthai});
            this.dgvdp.Location = new System.Drawing.Point(12, 23);
            this.dgvdp.Name = "dgvdp";
            this.dgvdp.ReadOnly = true;
            this.dgvdp.Size = new System.Drawing.Size(745, 215);
            this.dgvdp.TabIndex = 0;
            this.dgvdp.SelectionChanged += new System.EventHandler(this.dgvdp_SelectionChanged);
            // 
            // madp
            // 
            this.madp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.madp.DataPropertyName = "madp";
            this.madp.HeaderText = "Mã DP";
            this.madp.Name = "madp";
            this.madp.ReadOnly = true;
            this.madp.Width = 62;
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã NV";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.Width = 62;
            // 
            // makh
            // 
            this.makh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã KH";
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            this.makh.Width = 62;
            // 
            // loaiphong
            // 
            this.loaiphong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loaiphong.DataPropertyName = "tenloaiphong";
            this.loaiphong.HeaderText = "Loại phòng";
            this.loaiphong.Name = "loaiphong";
            this.loaiphong.ReadOnly = true;
            this.loaiphong.Width = 84;
            // 
            // ngaydat
            // 
            this.ngaydat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngaydat.DataPropertyName = "ngaydat";
            this.ngaydat.HeaderText = "Ngày đặt";
            this.ngaydat.Name = "ngaydat";
            this.ngaydat.ReadOnly = true;
            this.ngaydat.Width = 76;
            // 
            // ngayden
            // 
            this.ngayden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngayden.DataPropertyName = "ngayden";
            this.ngayden.HeaderText = "Ngày đến";
            this.ngayden.Name = "ngayden";
            this.ngayden.ReadOnly = true;
            this.ngayden.Width = 78;
            // 
            // ngaydi
            // 
            this.ngaydi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngaydi.DataPropertyName = "ngaydi";
            this.ngaydi.HeaderText = "Ngày đi";
            this.ngaydi.Name = "ngaydi";
            this.ngaydi.ReadOnly = true;
            this.ngaydi.Width = 68;
            // 
            // tiendatcoc
            // 
            this.tiendatcoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tiendatcoc.DataPropertyName = "tiendatcoc";
            this.tiendatcoc.HeaderText = "Đặt cọc";
            this.tiendatcoc.Name = "tiendatcoc";
            this.tiendatcoc.ReadOnly = true;
            this.tiendatcoc.Width = 69;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 74;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Tr.Thái";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            this.trangthai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangthai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.trangthai.Width = 67;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnThanhToan);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Controls.Add(this.btnSua);
            this.groupControl2.Controls.Add(this.btnThem);
            this.groupControl2.Location = new System.Drawing.Point(641, 6);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(143, 218);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Tác vụ";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(26, 166);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(91, 30);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(26, 120);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 30);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(26, 76);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(26, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMaKH);
            this.groupControl1.Controls.Add(this.dtNgayDat);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.dtNgayDi);
            this.groupControl1.Controls.Add(this.dtNgayDen);
            this.groupControl1.Controls.Add(this.txtTienCoc);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtMaNV);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMaDP);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(13, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(258, 218);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin đặt phòng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(96, 76);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(137, 21);
            this.txtMaKH.TabIndex = 3;
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Enabled = false;
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDat.Location = new System.Drawing.Point(96, 104);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(138, 21);
            this.dtNgayDat.TabIndex = 11;
            this.dtNgayDat.Value = new System.DateTime(2014, 12, 17, 15, 43, 37, 0);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(28, 110);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Ngày đặt:";
            // 
            // dtNgayDi
            // 
            this.dtNgayDi.Enabled = false;
            this.dtNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDi.Location = new System.Drawing.Point(96, 162);
            this.dtNgayDi.Name = "dtNgayDi";
            this.dtNgayDi.Size = new System.Drawing.Size(138, 21);
            this.dtNgayDi.TabIndex = 5;
            // 
            // dtNgayDen
            // 
            this.dtNgayDen.Enabled = false;
            this.dtNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDen.Location = new System.Drawing.Point(96, 133);
            this.dtNgayDen.Name = "dtNgayDen";
            this.dtNgayDen.Size = new System.Drawing.Size(138, 21);
            this.dtNgayDen.TabIndex = 4;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Enabled = false;
            this.txtTienCoc.Location = new System.Drawing.Point(96, 190);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.Properties.Appearance.Options.UseFont = true;
            this.txtTienCoc.Size = new System.Drawing.Size(138, 20);
            this.txtTienCoc.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(27, 195);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Tiền đặt cọc:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(28, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Ngày đi:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(28, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Ngày đến:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(28, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mã KH:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(96, 50);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(138, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(28, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mã NV:";
            // 
            // txtMaDP
            // 
            this.txtMaDP.Enabled = false;
            this.txtMaDP.Location = new System.Drawing.Point(96, 22);
            this.txtMaDP.Name = "txtMaDP";
            this.txtMaDP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDP.Properties.Appearance.Options.UseFont = true;
            this.txtMaDP.Size = new System.Drawing.Size(138, 20);
            this.txtMaDP.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(28, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã DP:";
            // 
            // ckbtrangtrai
            // 
            this.ckbtrangtrai.AutoSize = true;
            this.ckbtrangtrai.Enabled = false;
            this.ckbtrangtrai.Location = new System.Drawing.Point(17, 180);
            this.ckbtrangtrai.Name = "ckbtrangtrai";
            this.ckbtrangtrai.Size = new System.Drawing.Size(148, 17);
            this.ckbtrangtrai.TabIndex = 7;
            this.ckbtrangtrai.Text = "Trạng thái (đã trả phòng)";
            this.ckbtrangtrai.UseVisualStyleBackColor = true;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.txtSoNgay);
            this.groupControl4.Controls.Add(this.labelControl7);
            this.groupControl4.Controls.Add(this.txtLoaiPhongDat);
            this.groupControl4.Controls.Add(this.txtsoluong);
            this.groupControl4.Controls.Add(this.labelControl8);
            this.groupControl4.Controls.Add(this.btnClearAll);
            this.groupControl4.Controls.Add(this.btnClearOne);
            this.groupControl4.Controls.Add(this.btnAddOne);
            this.groupControl4.Controls.Add(this.btnAddAll);
            this.groupControl4.Controls.Add(this.listDatPhong);
            this.groupControl4.Controls.Add(this.listPhong);
            this.groupControl4.Controls.Add(this.cbLoaiPhong);
            this.groupControl4.Controls.Add(this.ckbtrangtrai);
            this.groupControl4.Location = new System.Drawing.Point(277, 6);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(358, 218);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "Chi tiết đặt phòng";
            // 
            // txtLoaiPhongDat
            // 
            this.txtLoaiPhongDat.Enabled = false;
            this.txtLoaiPhongDat.Location = new System.Drawing.Point(208, 31);
            this.txtLoaiPhongDat.Name = "txtLoaiPhongDat";
            this.txtLoaiPhongDat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhongDat.Properties.Appearance.Options.UseFont = true;
            this.txtLoaiPhongDat.Size = new System.Drawing.Size(136, 20);
            this.txtLoaiPhongDat.TabIndex = 18;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Enabled = false;
            this.txtsoluong.Location = new System.Drawing.Point(286, 177);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Properties.Appearance.Options.UseFont = true;
            this.txtsoluong.Size = new System.Drawing.Size(58, 20);
            this.txtsoluong.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(208, 181);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Tổng số lượng:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Appearance.Options.UseFont = true;
            this.btnClearAll.Enabled = false;
            this.btnClearAll.Location = new System.Drawing.Point(164, 149);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(35, 20);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "|<";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearOne
            // 
            this.btnClearOne.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOne.Appearance.Options.UseFont = true;
            this.btnClearOne.Enabled = false;
            this.btnClearOne.Location = new System.Drawing.Point(164, 120);
            this.btnClearOne.Name = "btnClearOne";
            this.btnClearOne.Size = new System.Drawing.Size(35, 20);
            this.btnClearOne.TabIndex = 14;
            this.btnClearOne.Text = "<";
            this.btnClearOne.Click += new System.EventHandler(this.btnClearOne_Click);
            // 
            // btnAddOne
            // 
            this.btnAddOne.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOne.Appearance.Options.UseFont = true;
            this.btnAddOne.Enabled = false;
            this.btnAddOne.Location = new System.Drawing.Point(164, 90);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(35, 20);
            this.btnAddOne.TabIndex = 13;
            this.btnAddOne.Text = ">";
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.Appearance.Options.UseFont = true;
            this.btnAddAll.Enabled = false;
            this.btnAddAll.Location = new System.Drawing.Point(164, 61);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(35, 20);
            this.btnAddAll.TabIndex = 12;
            this.btnAddAll.Text = ">|";
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // listDatPhong
            // 
            this.listDatPhong.FormattingEnabled = true;
            this.listDatPhong.Location = new System.Drawing.Point(208, 61);
            this.listDatPhong.Name = "listDatPhong";
            this.listDatPhong.Size = new System.Drawing.Size(136, 108);
            this.listDatPhong.TabIndex = 11;
            this.listDatPhong.DataSourceChanged += new System.EventHandler(this.listDatphong_DataSourceChanged);
            // 
            // listPhong
            // 
            this.listPhong.FormattingEnabled = true;
            this.listPhong.Location = new System.Drawing.Point(17, 61);
            this.listPhong.Name = "listPhong";
            this.listPhong.Size = new System.Drawing.Size(136, 108);
            this.listPhong.TabIndex = 10;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(17, 31);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(136, 21);
            this.cbLoaiPhong.TabIndex = 9;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbloaiphong_SelectedIndexChanged);
            // 
            // qlkscDataSet1
            // 
            this.qlkscDataSet1.DataSetName = "QLKSCDataSet";
            this.qlkscDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Enabled = false;
            this.txtSoNgay.Location = new System.Drawing.Point(149, 196);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgay.Properties.Appearance.Options.UseFont = true;
            this.txtSoNgay.Size = new System.Drawing.Size(58, 20);
            this.txtSoNgay.TabIndex = 19;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(71, 200);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 13);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Số ngày ở: ";
            // 
            // DatPhong_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "DatPhong_GUI";
            this.Size = new System.Drawing.Size(797, 518);
            this.Load += new System.EventHandler(this.DatPhong_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienCoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiPhongDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlkscDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgvdp;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTienCoc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaDP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.CheckBox ckbtrangtrai;
        private System.Windows.Forms.DateTimePicker dtNgayDi;
        private System.Windows.Forms.DateTimePicker dtNgayDen;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ListBox listPhong;
        private System.Windows.Forms.ListBox listDatPhong;
        private DevExpress.XtraEditors.SimpleButton btnClearAll;
        private DevExpress.XtraEditors.SimpleButton btnClearOne;
        private DevExpress.XtraEditors.SimpleButton btnAddOne;
        private DevExpress.XtraEditors.SimpleButton btnAddAll;
        private DevExpress.XtraEditors.TextEdit txtsoluong;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtLoaiPhongDat;
        private System.Windows.Forms.TextBox txtMaKH;
        private QLKSCDataSet qlkscDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn madp;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiendatcoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangthai;
        private DevExpress.XtraEditors.TextEdit txtSoNgay;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}
