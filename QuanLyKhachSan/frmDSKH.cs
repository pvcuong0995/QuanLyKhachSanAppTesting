using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKhachSan.DAL;
using Microsoft.Reporting.WinForms;

namespace QuanLyKhachSan
{
    public partial class frmDSKH : DevExpress.XtraEditors.XtraForm
    {
        DBAccess db = new DBAccess();
        public frmDSKH()
        {
            InitializeComponent();
        }
        private DataTable getdata()
        {
            string sql = "select * from khachhang";
            DataTable dtb = db.getDS(sql);
            return dtb;
        }

        private void bind()
        {
            rpvDSKH.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.ReportDSKH.rdlc";
            rpvDSKH.LocalReport.DataSources.Clear();
            ReportDataSource rpDataSource = new ReportDataSource("DataSetKhachHang", getdata());
            rpvDSKH.LocalReport.DataSources.Add(rpDataSource);
            rpvDSKH.RefreshReport();
        }
        private void frmDSKH_Load(object sender, EventArgs e)
        {
            bind();
            this.rpvDSKH.RefreshReport();
        }
    }
}