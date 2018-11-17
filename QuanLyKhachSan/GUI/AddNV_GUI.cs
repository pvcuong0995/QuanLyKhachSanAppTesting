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
    public partial class AddNV_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        NhanVien_BLL nvbl = new NhanVien_BLL();
        ChucVu_BLL cvbl = new ChucVu_BLL();
        DBAccess db = new DBAccess();
        string macv = "";
        int t = 0;

        public AddNV_GUI()
        {
            InitializeComponent();
        }
        private NhanVien_DTO getdatanv()
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = txtMaNV.Text;
            nv.Macv = cbChucVu.SelectedValue.ToString();
            nv.Hoten = txtHoTen.Text;
            nv.Ngaysinh = dtNgaySinh.Value;
            nv.Gioitinh = txtGioiTinh.Text;
            nv.Sdt = txtSdt.Text;
            nv.Cmnd = txtCmnd.Text;
            nv.Email = txtEmail.Text;
            nv.Diachi = txtdc.Text;
            return nv;
        }

        private void showtxtnv()
        {
            txtHoTen.Enabled = true;
            dtNgaySinh.Enabled = true;
            txtGioiTinh.Enabled = true;
            txtCmnd.Enabled = true;
            txtSdt.Enabled = true;
            txtEmail.Enabled = true;
            txtdc.Enabled = true;
        }

        private void hidetxtnv()
        {
            txtHoTen.Enabled = false;
            dtNgaySinh.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtCmnd.Enabled = false;
            txtSdt.Enabled = false;
            txtEmail.Enabled = false;
            txtdc.Enabled = false;
        }

        private void cleartxtnv()
        {
            txtHoTen.Text = "";
            dtNgaySinh.Value = DateTime.Today;
            txtGioiTinh.Text = "";
            txtCmnd.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtdc.Text = "";
            cbChucVu.Focus();
        }

        private void clearbindnv()
        {
            txtMaNV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            dtNgaySinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Clear();
            txtSdt.DataBindings.Clear();
            txtCmnd.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtdc.DataBindings.Clear();
            dgvNhanVien.DataBindings.Clear();
        }

        private void bindatanv()
        {
            BindingSource bindSourceNV = new BindingSource();
            macv = cbChucVu.SelectedValue.ToString();
            bindSourceNV.DataSource = nvbl.dsnv(macv);
            clearbindnv();
            txtMaNV.DataBindings.Add("Text", bindSourceNV, "manv");
            txtHoTen.DataBindings.Add("Text", bindSourceNV, "hoten");
            dtNgaySinh.DataBindings.Add("Value", bindSourceNV, "ngaysinh");
            txtGioiTinh.DataBindings.Add("Text", bindSourceNV, "gioitinh");
            txtSdt.DataBindings.Add("Text", bindSourceNV, "sdt");
            txtCmnd.DataBindings.Add("Text", bindSourceNV, "cmnd");
            txtEmail.DataBindings.Add("Text", bindSourceNV, "email");
            txtdc.DataBindings.Add("Text", bindSourceNV, "diachi");
            dgvNhanVien.DataSource = bindSourceNV;
        }
        private string setmanv()
        {
            int id;
            id = int.Parse(db.GetLastID("nhanvien", "manv").Substring(2, 3));
            if (id < 9)
                return "NV00" + (id + 1).ToString();
            else
                if (id < 99)
                    return "NV0" + (id + 1).ToString();
                else
                    return "NV" + (id + 1).ToString();
        }
        private void AddNV_GUI_Load(object sender, EventArgs e)
        {
            DataTable dtbcv = new DataTable();
            dtbcv = cvbl.dscv();
            cbChucVu.DataSource = dtbcv;
            cbChucVu.DisplayMember = "tencv";
            cbChucVu.ValueMember = "macv";

            cbChucVu.SelectedIndex = 0;
            string macv01 = cbChucVu.SelectedValue.ToString();
            DataTable dtbnv = new DataTable();
            dtbnv = nvbl.dsnv(macv01);
            dgvNhanVien.DataSource = dtbnv;
            txtMaNV.Text = dgvNhanVien.Rows[0].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[0].Cells[1].Value.ToString();
            dtNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.Rows[0].Cells[2].Value);
            txtGioiTinh.Text = dgvNhanVien.Rows[0].Cells[3].Value.ToString();
            txtSdt.Text = dgvNhanVien.Rows[0].Cells[4].Value.ToString();
            txtCmnd.Text = dgvNhanVien.Rows[0].Cells[5].Value.ToString();
            txtdc.Text = dgvNhanVien.Rows[0].Cells[6].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[0].Cells[7].Value.ToString();
        }

        private void cbChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Text != "Hủy bỏ" && btnSua.Text != "Hủy bỏ")
            {
                bindatanv();
            }
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.CurrentRow.Cells[2].Value);
            txtGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtSdt.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtCmnd.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtdc.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.ClearSelection();
            t = 1;
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy bỏ";
                showtxtnv();
                cleartxtnv();
                txtMaNV.Text = setmanv();
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                dgvNhanVien.Enabled = false;
            }
            else
            {
                btnThem.Text = "Thêm";
                hidetxtnv();
                bindatanv();
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                dgvNhanVien.Enabled = true;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            dgvNhanVien.ClearSelection();
            t = 2;
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Hủy bỏ";
                showtxtnv();
                txtHoTen.Focus();
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                dgvNhanVien.Enabled = false;
            }
            else
            {
                btnSua.Text = "Sửa";
                hidetxtnv();
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                dgvNhanVien.Enabled = true;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (t == 1)
            {
                NhanVien_DTO nv = getdatanv();
                if (nvbl.addnv(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    bindatanv();
                    hidetxtnv();
                    btnThem.Text = "Thêm";
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    dgvNhanVien.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Thêm nhân viên thất bại!");
                }
            }
            if (t == 2)
            {
                NhanVien_DTO nv = getdatanv();
                if (nvbl.editnv(nv))
                {
                    MessageBox.Show("Chỉnh sửa nhân viên thành công!");
                    bindatanv();
                    hidetxtnv();
                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    dgvNhanVien.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa nhân viên thất bại!");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhân viên: " + txtMaNV.Text + " - " + txtHoTen.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVien_DTO nv = getdatanv();
                if (db.checkExist("quyennv", "manv", txtMaNV.Text))
                {
                    MessageBox.Show("Chỉ có thể xóa nhân viên chưa phân quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (nvbl.deletenv(nv))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        bindatanv();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!");
                    }
                }
            }
        }
    }
}
