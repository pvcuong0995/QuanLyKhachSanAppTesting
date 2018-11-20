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
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.GUI
{
    public partial class Admin_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        Admin_BLL adbl = new Admin_BLL();
        
        User_BLL userBLL = new User_BLL();
        DBAccess db = new DBAccess();
        string id = "";

        public Admin_GUI()
        {
            InitializeComponent();
        }
        private User_DTO getDataQuyen()
        {
            User_DTO user = new User_DTO();
            user.Manv = cbMaNV.SelectedValue.ToString();
            user.Id = id;
            user.Mk = txtMatKhau.Text;
            return user;
        }
        private void bindDataAd()
        {
            DataRow r = adbl.infoAdmin(frmLogin.mnv);
            txtMaNV.Text = r[0].ToString();
            txtChucVu.Text = r[1].ToString();
            txtHoTen.Text = r[2].ToString();
            txtNgaySinh.Text = r[3].ToString();
            txtGioiTinh.Text = r[4].ToString();
            txtSdt.Text = r[5].ToString();
            txtCmnd.Text = r[6].ToString();
            txtEmail.Text = r[7].ToString();
            txtDiaChi.Text = r[8].ToString();
            txtqqt.Text = r[9].ToString();
            txtmkqt.Text = r[10].ToString();
        }

        private void bindDataCbNV()
        {
            DataTable dtb = adbl.dsNhanVienPhanQuyen();
            cbMaNV.DataSource = dtb;
            cbMaNV.ValueMember = "manv";
            cbMaNV.DisplayMember = "manv";
        }

        private void Admin_GUI_Load(object sender, EventArgs e)
        {
            bindDataAd();
            bindDataCbNV();
            if (db.checkExist("quyennv", "manv", cbMaNV.SelectedValue.ToString()))
            {
                txtQuyen.Text = adbl.quyennv(cbMaNV.SelectedValue.ToString());
            }
            else
            {
                txtQuyen.Text = "Chưa phân quyền";
            }
        }

        private void cbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (db.checkExist("quyennv", "manv", cbMaNV.SelectedValue.ToString()))
            {
                txtQuyen.Text = adbl.quyennv(cbMaNV.SelectedValue.ToString());
            }
            else
            {
                txtQuyen.Text = "Chưa phân quyền";
            }
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            panelpq.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            //string sql = "Insert Into quyennv Values('"+cbMaNV.SelectedValue.ToString()+"','"+id+"','"+txtMatKhau.Text+"')";
            //string sql2 = "Update quyennv set id='" + id + "',matkhau='" + txtMatKhau.Text + "' where manv = '" + cbMaNV.SelectedValue.ToString() + "'";
            if (txtMatKhau.Text.Length == 3)
            {
                thongbao.Text = "";
                if (!db.checkExist("quyennv", "manv", cbMaNV.SelectedValue.ToString()))
                {
                    User_DTO user = getDataQuyen();
                    if (userBLL.addQuyen(user))
                    {
                        rdbQuanTri.Checked = false;
                        rdbNhanVien.Checked = false;
                        rdbKhachHang.Checked = false;
                        txtMatKhau.Text = "";
                        panelpq.Enabled = false;
                        thongbao.Text = "";
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }
                else
                {
                    User_DTO user = getDataQuyen();
                    if (userBLL.editQuyen(user))
                    {
                        rdbQuanTri.Checked = false;
                        rdbNhanVien.Checked = false;
                        rdbKhachHang.Checked = false;
                        txtMatKhau.Text = "";
                        panelpq.Enabled = false;
                        thongbao.Text = "";
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }
            }
            else
            {
                thongbao.Text = "Mật khẩu gồm 3 ký tự!";
            }
        }

        private void rdbqt_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Text == "Quản trị")
                id = "A";
            else
                if (rdb.Text == "Nhân viên")
                    id = "B";
                else
                    id = "C";
        }

        private void txtmknv_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length != 3)
            {
                thongbao.Text = "Mật khẩu gồm 3 ký tự!";
            }
            else
            {
                thongbao.Text = "";
            }

        }

        private void panelQuyen_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
