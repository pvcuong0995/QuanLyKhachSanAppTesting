using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.BLL;

namespace QuanLyKhachSan.GUI
{
    public partial class InfoKH_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        KhachHang_BLL khachHangBL = new KhachHang_BLL();
        DBAccess db = new DBAccess();
        string dieuKien = "";
        string input = "";

        public InfoKH_GUI()
        {
            InitializeComponent();
        }

        private void gettxtcb()
        {
            input = txtCoBan.Text;
        }

      

        private void getData(string dk, string txt)
        {
            dgvkh.DataBindings.Clear();

            DataTable dtb = khachHangBL.traCuu(dk, txt);
            dgvkh.DataSource = dtb;
        }


        private void btnCoBan_Click(object sender, EventArgs e)
        {
            gettxtcb();
            if (dieuKien == "")
            {
                MessageBox.Show("Chưa chọn điều kiện!");
            }
            else
            {
                getData(dieuKien, input);
            }

        }

       

        private void cbDkDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            dieuKien = cbDkDG.SelectedItem.ToString();
        }
       
    }
}
