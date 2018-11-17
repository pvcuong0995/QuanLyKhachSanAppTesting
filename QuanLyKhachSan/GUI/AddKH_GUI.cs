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
using QuanLyKhachSan.DAL;

namespace QuanLyKhachSan.GUI
{
    public partial class AddKH_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        KhachHang_BLL khbl = new KhachHang_BLL();
        DBAccess db = new DBAccess();
        int t = 0;

        public AddKH_GUI()
        {
            InitializeComponent();
        }

        private KhachHang_DTO getdatakh()
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.Makh = txtMaKH.Text;
            kh.Hoten = txtHoTen.Text;
            kh.Cmnd = txtCmnd.Text;
            kh.Sdt = txtSdt.Text;
            kh.Email = txtEmail.Text;
            kh.Diachi = txtDiaChi.Text;
            return kh;
        }

        private void showtxtkh()
        {
            txtHoTen.Enabled = true;
            txtCmnd.Enabled = true;
            txtSdt.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
        }

        private void hidetxtkh()
        {
            txtHoTen.Enabled = false;
            txtCmnd.Enabled = false;
            txtSdt.Enabled = false;
            txtEmail.Enabled = false;
            txtDiaChi.Enabled = false;
        }

        private void cleartxtkh()
        {
            txtHoTen.Text = "";
            txtCmnd.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtHoTen.Focus();
        }

        private void clearbindkh()
        {
            txtMaKH.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtSdt.DataBindings.Clear();
            txtCmnd.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            dgvKhachHang.DataBindings.Clear();
        }

        private void bindatakh()
        {
            BindingSource bskh = new BindingSource();
            bskh.DataSource = khbl.dskh();
            clearbindkh();
            txtMaKH.DataBindings.Add("Text", bskh, "makh");
            txtHoTen.DataBindings.Add("Text", bskh, "hoten");
            txtCmnd.DataBindings.Add("Text", bskh, "cmnd");
            txtSdt.DataBindings.Add("Text", bskh, "sdt");
            txtEmail.DataBindings.Add("Text", bskh, "email");
            txtDiaChi.DataBindings.Add("Text", bskh, "diachi");
            dgvKhachHang.DataSource = bskh;
        }

        private string setmakh()
        {
            int id;
            id = int.Parse(db.GetLastID("khachhang", "makh").Substring(2,3));
            if (id < 9)
                return "KH00" + (id + 1).ToString();
            else
                if(id < 99)
                    return "KH0" + (id + 1).ToString();
                else
                    return "KH" + (id + 1).ToString();
        }

        private void AddKH_GUI_Load(object sender, EventArgs e)
        {
            DataTable dtbkh = new DataTable();
            dtbkh = khbl.dskh();
            dgvKhachHang.DataSource = dtbkh;
            txtMaKH.Text = dgvKhachHang.Rows[0].Cells[0].Value.ToString();
            txtHoTen.Text = dgvKhachHang.Rows[0].Cells[1].Value.ToString();
            txtCmnd.Text = dgvKhachHang.Rows[0].Cells[2].Value.ToString();
            txtSdt.Text = dgvKhachHang.Rows[0].Cells[3].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[0].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[0].Cells[5].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            t = 1;
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy bỏ";
                showtxtkh();
                cleartxtkh();
                txtMaKH.Text = setmakh();
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                dgvKhachHang.Enabled = false;
            }
            else
            {
                btnThem.Text = "Thêm";
                hidetxtkh();
                bindatakh();
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                dgvKhachHang.Enabled = true;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            t = 2;
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Hủy bỏ";
                showtxtkh();
                txtHoTen.Focus();
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                dgvKhachHang.Enabled = false;
            }
            else
            {
                btnSua.Text = "Sửa";
                hidetxtkh();
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                dgvKhachHang.Enabled = true;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (t == 1)
            {
                KhachHang_DTO kh = getdatakh();
                if (khbl.addkh(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    bindatakh();
                    hidetxtkh();
                    btnThem.Text = "Thêm";
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    dgvKhachHang.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Thêm khách hàng thất bại!");
                }
            }
            if (t == 2)
            {
                KhachHang_DTO kh = getdatakh();
                if (khbl.editkh(kh))
                {
                    MessageBox.Show("Chỉnh sửa khách hàng thành công!");
                    bindatakh();
                    hidetxtkh();
                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    dgvKhachHang.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa khách hàng thất bại!");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa khách hàng: " + txtMaKH.Text + " - " + txtHoTen.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KhachHang_DTO kh = getdatakh();
                if (db.checkExist("datphong", "makh", txtMaKH.Text))
                {
                    MessageBox.Show("Chỉ có thể xóa khách hàng với số lần đặt phòng là 0!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                else
                {
                    if (khbl.deletekh(kh))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        bindatakh();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại!");
                    }
                }
            }
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtCmnd.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtSdt.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
