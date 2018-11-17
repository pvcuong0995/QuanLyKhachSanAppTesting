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
using QuanLyKhachSan.BLL;

namespace QuanLyKhachSan.GUI
{
    public partial class Superio_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        Phong_BLL pbl = new Phong_BLL();
        public Superio_GUI()
        {
            InitializeComponent();
            setImg();
        }
        public void setImg()
        {
            foreach (SimpleButton c in this.Controls)
            {
                if (pbl.checkTinhTrang(c.Text.ToString()))
                {
                    c.Image = Image.FromFile("../../Resources/dskh.png");
                }
                else
                {
                    c.Image = Image.FromFile("../../Resources/themphong.png");
                }
            }
        }
        private void Superio_GUI_Load(object sender, EventArgs e)
        {
            setImg();
        }

        private string settooltip(DevExpress.XtraEditors.SimpleButton btn, bool b)
        {
            string info = "";
            if (b)
            {
                DataTable dtb = new DataTable();
                dtb = pbl.thongtinphong(btn.Name.ToString());
                DataRow r = dtb.Rows[0];
                info = "Khách hàng: " + r[0].ToString() + " - " + r[1].ToString() + System.Environment.NewLine + "Ngày đến: " + r[2].ToString() + System.Environment.NewLine + "Ngày đi: " + r[3].ToString();
            }
            else
            {
                
                info = "Phòng trống";
            }
            return info;
        }
       
        private void btn_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (DevExpress.XtraEditors.SimpleButton)sender;
            if (pbl.checkTinhTrang(btn.Text))
            {
                MessageBox.Show(settooltip(btn, true), "Thông tin phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(settooltip(btn, false), "Thông tin phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            setImg();
        }
    }
}
