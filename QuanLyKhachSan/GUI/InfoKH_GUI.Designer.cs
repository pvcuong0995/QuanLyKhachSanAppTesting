namespace QuanLyKhachSan.GUI
{
    partial class InfoKH_GUI
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCoBan = new DevExpress.XtraEditors.SimpleButton();
            this.txtCoBan = new DevExpress.XtraEditors.TextEdit();
            this.cbDkDG = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dgvkh = new System.Windows.Forms.DataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCoBan);
            this.panelControl1.Controls.Add(this.txtCoBan);
            this.panelControl1.Controls.Add(this.cbDkDG);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(10, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(771, 61);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCoBan
            // 
            this.btnCoBan.Location = new System.Drawing.Point(677, 15);
            this.btnCoBan.Name = "btnCoBan";
            this.btnCoBan.Size = new System.Drawing.Size(74, 26);
            this.btnCoBan.TabIndex = 3;
            this.btnCoBan.Text = "Tìm kiếm";
            this.btnCoBan.Click += new System.EventHandler(this.btnCoBan_Click);
            // 
            // txtCoBan
            // 
            this.txtCoBan.Location = new System.Drawing.Point(219, 21);
            this.txtCoBan.Name = "txtCoBan";
            this.txtCoBan.Size = new System.Drawing.Size(440, 20);
            this.txtCoBan.TabIndex = 2;
            // 
            // cbDkDG
            // 
            this.cbDkDG.FormattingEnabled = true;
            this.cbDkDG.Items.AddRange(new object[] {
            "makh",
            "hoten",
            "cmnd",
            "sdt",
            "email",
            "diachi"});
            this.cbDkDG.Location = new System.Drawing.Point(66, 20);
            this.cbDkDG.Name = "cbDkDG";
            this.cbDkDG.Size = new System.Drawing.Size(144, 21);
            this.cbDkDG.TabIndex = 1;
            this.cbDkDG.SelectedIndexChanged += new System.EventHandler(this.cbDkDG_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tìm theo:";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.dgvkh);
            this.panelControl3.Location = new System.Drawing.Point(11, 72);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(769, 402);
            this.panelControl3.TabIndex = 5;
            // 
            // dgvkh
            // 
            this.dgvkh.AllowUserToAddRows = false;
            this.dgvkh.AllowUserToDeleteRows = false;
            this.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.hoten,
            this.cmnd,
            this.sdt,
            this.email,
            this.diachi});
            this.dgvkh.Location = new System.Drawing.Point(13, 8);
            this.dgvkh.Name = "dgvkh";
            this.dgvkh.ReadOnly = true;
            this.dgvkh.Size = new System.Drawing.Size(745, 389);
            this.dgvkh.TabIndex = 1;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            this.makh.Width = 105;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 130;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số ĐT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 130;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 137;
            // 
            // InfoKH_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "InfoKH_GUI";
            this.Size = new System.Drawing.Size(797, 518);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbDkDG;
        private DevExpress.XtraEditors.TextEdit txtCoBan;
        private DevExpress.XtraEditors.SimpleButton btnCoBan;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.DataGridView dgvkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}
