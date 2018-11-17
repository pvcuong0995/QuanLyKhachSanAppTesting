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
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.GUI;

namespace QuanLyKhachSan.GUI
{
    public partial class Phong_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        AddTab at = new AddTab();
        LoaiPhong_BLL lpbl = new LoaiPhong_BLL();
        public Phong_GUI()
        {
            InitializeComponent();
        }

        private void xtraTabPhong_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabPhong.TabPages.RemoveAt(xtraTabPhong.SelectedTabPageIndex);
        }

        private void xtraTabPhong_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabPhong.SelectedTabPageIndex = xtraTabPhong.TabPages.Count - 1;
        }

        private void xtraTabPhong_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {

        }

        private void Phong_GUI_Load(object sender, EventArgs e)
        {
            
            txtSoLuong.Text = lpbl.soLuongPhong("Standard");
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabPhong.TabPages)
            {
                if (tab.Text == "Standard")
                {
                    xtraTabPhong.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                at.setTab(xtraTabPhong, "Standard", new Standard_GUI());
            }
        }

        private void Room_CheckedChanged(object sender, EventArgs e)
        {
            
            RadioButton rdb = (RadioButton)sender;
            txtSoLuong.Text = lpbl.soLuongPhong(rdb.Text);
            if (rdb.Text == "Standard")
            {
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabPhong.TabPages)
                {
                    if (tab.Text == "Standard")
                    {
                        xtraTabPhong.SelectedTabPage = tab;
                        t = 1;
                        xtraTabPhong.Refresh();
                    }
                }
                if (t != 1)
                {
                    at.setTab(xtraTabPhong, "Standard", new Standard_GUI());
                }
            }
            if (rdb.Text == "Deluxe")
            {
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabPhong.TabPages)
                {
                    if (tab.Text == "Deluxe")
                    {
                        xtraTabPhong.SelectedTabPage = tab;
                        t = 1;
                        xtraTabPhong.Refresh();
                    }
                }
                if (t != 1)
                {
                    at.setTab(xtraTabPhong, "Deluxe", new Deluxe_GUI());
                }
            }
            if (rdb.Text == "Suite")
            {
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabPhong.TabPages)
                {
                    if (tab.Text == "Suite")
                    {
                        xtraTabPhong.SelectedTabPage = tab;
                        t = 1;
                        xtraTabPhong.Refresh();
                    }
                }
                if (t != 1)
                {
                    at.setTab(xtraTabPhong, "Suite", new Suite_GUI());
                }
            }
            if (rdb.Text == "Superio")
            {
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabPhong.TabPages)
                {
                    if (tab.Text == "Superio")
                    {
                        xtraTabPhong.SelectedTabPage = tab;
                        t = 1;
                        xtraTabPhong.Refresh();
                    }
                }
                if (t != 1)
                {
                    at.setTab(xtraTabPhong, "Superio", new Superio_GUI());
                }
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            Deluxe_GUI deluxe = new Deluxe_GUI();
           
            Suite_GUI sui = new Suite_GUI();
            
            Standard_GUI stand = new Standard_GUI();
           
            Superio_GUI super = new Superio_GUI();
            
        }
    }
}
