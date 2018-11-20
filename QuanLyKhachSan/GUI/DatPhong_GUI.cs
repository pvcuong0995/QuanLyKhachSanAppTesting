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
using System.Collections;
using System.Globalization;

namespace QuanLyKhachSan.GUI
{
    public partial class DatPhong_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        LoaiPhong_BLL loaiPhongBL = new LoaiPhong_BLL();
        Phong_BLL phongBL = new Phong_BLL();
        DatPhong_BLL datPhongBL = new DatPhong_BLL();
        ChiTietDatPhong_BLL chiTietDatPhongBL = new ChiTietDatPhong_BLL();
        HoaDon_BLL hoaDonBL = new HoaDon_BLL();
        HoaDon_DTO hd = null;
        DBAccess db = new DBAccess();
        string tenLoaiPhong = "";
        public static string maDatPhong = "";
        int t = 0;
        ArrayList arr = new ArrayList();
        ArrayList arr1 = new ArrayList();
        
        public DatPhong_GUI()
        {
            InitializeComponent();
            
        }

        private DatPhong_DTO getDataDatPhong()
        {
            DatPhong_DTO dp = new DatPhong_DTO();
            dp.Madp = txtMaDP.Text;
            dp.Manv = txtMaNV.Text;
            dp.Makh = txtMaKH.Text;
            dp.Tenlp = cbLoaiPhong.SelectedValue.ToString();
            dp.Ngaydat = dtNgayDat.Value;
            dp.Ngayden = dtNgayDen.Value;
            dp.Ngaydi = dtNgayDi.Value;
            dp.Tiendatcoc = int.Parse(txtTienCoc.Text);
            dp.Soluong = int.Parse(txtsoluong.Text);
            dp.Trangthai = ckbtrangtrai.Checked;
            return dp;
        }

        private CTDP_DTO getDataChiTietDatPhong(ArrayList arr, int i)
        {
            CTDP_DTO ctdp = new CTDP_DTO();
            ctdp.Madp = txtMaDP.Text;
            ctdp.Maphong = arr[i].ToString();
            return ctdp;
        }

        private void showText()
        {
            txtMaKH.Enabled = true;
            dtNgayDen.Enabled = true;
            dtNgayDi.Enabled = true;
        }

        private void hideText()
        {
            txtMaKH.Enabled = false;
            dtNgayDen.Enabled = false;
            dtNgayDi.Enabled = false;
        }

        private void clearText()
        {
            txtMaKH.Text = "";
            dtNgayDat.Value = DateTime.Today;
            dtNgayDen.Value = DateTime.Today;
            dtNgayDi.Value = DateTime.Today;
            ckbtrangtrai.Checked = false;
            txtTienCoc.Text = "";
            txtLoaiPhongDat.Text = "";
            txtsoluong.Text = "";
            txtMaKH.Focus();
        }
        /*
        private void limitdate()
        {
            //dtNgayDen.MinDate = DateTime.Today;
            //dtNgayDi.MinDate = DateTime.Today;
        }
         * */
        /*
        private void nolimitdate()
        {
            DateTimeFormatInfo usDtfi = new CultureInfo("en-US", false).DateTimeFormat;
            dtNgayDen.MinDate = Convert.ToDateTime("12/01/2011", usDtfi);
            dtNgayDi.MinDate = Convert.ToDateTime("12/01/2011", usDtfi);
            //dtpngaydi.MinDate = Convert.ToDateTime("01/01/1753");
        }
        */
        private void clearBindingDatPhong()
        {
            txtMaDP.DataBindings.Clear();
            txtMaNV.DataBindings.Clear();
            txtMaKH.DataBindings.Clear();
            txtLoaiPhongDat.DataBindings.Clear();
            dtNgayDat.DataBindings.Clear();
            dtNgayDen.DataBindings.Clear();
            dtNgayDi.DataBindings.Clear();
            txtTienCoc.DataBindings.Clear();
            txtsoluong.DataBindings.Clear();
            ckbtrangtrai.DataBindings.Clear();
            listDatPhong.DataBindings.Clear();
            dgvdp.DataBindings.Clear();
        }

        private void bindSourceDatPhong()
        {
            try
            {


                BindingSource bsDatPhong = new BindingSource();
                bsDatPhong.DataSource = datPhongBL.dsDatPhong();
                clearBindingDatPhong();
                dgvdp.DataSource = bsDatPhong;
                txtMaDP.DataBindings.Add("Text", bsDatPhong, "madp");
                txtMaNV.DataBindings.Add("Text", bsDatPhong, "manv");
                txtMaKH.DataBindings.Add("Text", bsDatPhong, "makh");
                txtLoaiPhongDat.DataBindings.Add("Text", bsDatPhong, "tenloaiphong");
                dtNgayDat.DataBindings.Add("Value", bsDatPhong, "ngaydat");
                dtNgayDen.DataBindings.Add("Value", bsDatPhong, "ngayden");
                dtNgayDi.DataBindings.Add("Value", bsDatPhong, "ngaydi");
                txtTienCoc.DataBindings.Add("Text", bsDatPhong, "tiendatcoc");
                txtsoluong.DataBindings.Add("Text", bsDatPhong, "soluong");
                ckbtrangtrai.DataBindings.Add("Checked", bsDatPhong, "trangthai");
                bindSourceListDatPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.ToString());
            }
        }

        private void DatPhong_GUI_Load(object sender, EventArgs e)
        {
            DataTable dtLoaiPhong = new DataTable();
            dtLoaiPhong = loaiPhongBL.getDSLoaiPhong();
            cbLoaiPhong.DataSource = dtLoaiPhong;
            cbLoaiPhong.DisplayMember = "tenloaiphong";
            cbLoaiPhong.ValueMember = "tenloaiphong";
            bindSourceListPhong();
            bindSourceDatPhong();
        }

        private void bindSourceListPhong()
        {
            BindingSource bsp = new BindingSource();
            tenLoaiPhong = cbLoaiPhong.SelectedValue.ToString();
            bsp.DataSource = phongBL.dsph(tenLoaiPhong);
            listPhong.DataBindings.Clear();
            listPhong.DataSource = bsp;
            listPhong.DisplayMember = "maphong";
            listPhong.ValueMember = "maphong";
        }

        private void bindSourceListDatPhong()
        {
            BindingSource bsChiTietDatPhong = new BindingSource();
            bsChiTietDatPhong.DataSource = chiTietDatPhongBL.getDSMaDatPhong(txtMaDP.Text);
            listDatPhong.DataSource = bsChiTietDatPhong;
            listDatPhong.DisplayMember = "maphong";
            listDatPhong.ValueMember = "maphong";
        }

        private void cbloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnThem.Text == "Hủy bỏ")
            {
                txtLoaiPhongDat.Text = cbLoaiPhong.SelectedValue.ToString();
                txtTienCoc.Text = loaiPhongBL.getTienDatCoc(cbLoaiPhong.SelectedValue.ToString(), int.Parse(txtsoluong.Text)).ToString();
            }
            bindSourceListPhong();
        }
       
        private string setMaDP()
        {
            int id;
            id = int.Parse(db.GetLastID("datphong", "madp").Substring(2, 3));
            if (id < 9)
                return "DP00" + (id + 1).ToString();
            else
                if (id < 99)
                    return "DP0" + (id + 1).ToString();
                else
                    return "DP" + (id + 1).ToString();
        }

        private void enableBtnNext()
        {
            btnAddAll.Enabled = true;
            btnAddOne.Enabled = true;
            btnClearOne.Enabled = true;
            btnClearAll.Enabled = true;
        }

        private void disablemove()
        {
            btnAddAll.Enabled = false;
            btnAddOne.Enabled = false;
            btnClearOne.Enabled = false;
            btnClearAll.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            t = 1;
            if (btnThem.Text == "Thêm")
            {
                //limitdate();
                btnThem.Text = "Hủy bỏ";
                enableBtnNext();
                showText();
                clearText();
                listDatPhong.DataSource = null;
                listDatPhong.DataBindings.Clear();
                txtMaDP.Text = setMaDP();
                txtMaNV.Text = frmLogin.mnv;
                txtLoaiPhongDat.Text = cbLoaiPhong.SelectedValue.ToString();
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnThanhToan.Enabled = false;
                dgvdp.Enabled = false;
            }
            else
            {
                //nolimitdate();
                btnThem.Text = "Thêm";
                arr.Clear();
                arr1.Clear();
                disablemove();
                hideText();
                bindSourceDatPhong();
                bindSourceListPhong();
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnThanhToan.Enabled = true;
                dgvdp.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            t = 2;
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Hủy bỏ";
                showText();
                txtMaKH.Focus();
                btnThem.Enabled = false;
                btnThanhToan.Enabled = false;
                btnLuu.Enabled = true;
                dgvdp.Enabled = false;
            }
            else
            {
                btnSua.Text = "Sửa";
                hideText();
                btnThem.Enabled = true;
                btnThanhToan.Enabled = true;
                btnLuu.Enabled = false;
                dgvdp.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (db.checkExist("khachhang", "makh", txtMaKH.Text))
            {
                if (t == 1)
                {
                    DatPhong_DTO dp = getDataDatPhong();
                    if (datPhongBL.addDatPhong(dp))
                    {
                        int d = 0;
                        if (arr.Count == 0)
                        {
                            setarr1();
                            for (int i = 0; i < arr1.Count; i++)
                            {
                                if (chiTietDatPhongBL.addChiTietDatPhong(getDataChiTietDatPhong(arr1, i)))
                                {
                                    phongBL.capnhatphong(arr1[i].ToString());
                                    loaiPhongBL.giamSoLuongPhong(cbLoaiPhong.SelectedValue.ToString());
                                    d++;
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (chiTietDatPhongBL.addChiTietDatPhong(getDataChiTietDatPhong(arr, i)))
                                {
                                    phongBL.capnhatphong(arr[i].ToString());
                                    loaiPhongBL.giamSoLuongPhong(cbLoaiPhong.SelectedValue.ToString());
                                    d++;
                                }
                            }
                        }
                        if (d != 0)
                        {
                            MessageBox.Show("Đặt phòng thành công!");

                        }
                        else
                            MessageBox.Show("Đặt phòng thất bại!");
                        bindSourceDatPhong();
                        hideText();
                        arr.Clear();
                        arr1.Clear();
                        disablemove();
                        bindSourceListPhong();
                        btnThem.Text = "Thêm";
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnThanhToan.Enabled = true;
                        btnLuu.Enabled = false;
                        dgvdp.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra. Đặt phòng thất bại!");
                    }
                }
                if (t == 2)
                {
                    DatPhong_DTO dp = getDataDatPhong();
                    if (datPhongBL.editDatPhong(dp))
                    {
                        //DataTable dtb = (ctdpbl.dsdpct(txtmadp.Text));
                        //for (int i = 0; i < dtb.Rows.Count; i++)
                        //{
                        //    DataRow r = dtb.Rows[i];
                        //    pbl.traphong(r[0].ToString());
                        //    lpbl.congslph(txtLpDat.Text);
                        //}
                        MessageBox.Show("Chỉnh sửa thành công!");
                        bindSourceDatPhong();
                        hideText();
                        btnSua.Text = "Sửa";
                        btnThem.Enabled = true;
                        btnThanhToan.Enabled = true;
                        btnLuu.Enabled = false;
                        dgvdp.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mã khách hàng không đúng! Vui lòng nhập lại.");
            }
        }
        public int getSoNgay(string madp)
        {

            DataTable tbl = datPhongBL.dsDatPhongMadp(madp);
            DateTime ngayDen = Convert.ToDateTime(tbl.Rows[0]["ngayden"].ToString());
            DateTime ngayDi = Convert.ToDateTime(tbl.Rows[0]["ngaydi"].ToString());

            int soNgay = 0;
            if (ngayDen.Year == ngayDi.Year)
                soNgay = ngayDi.DayOfYear - ngayDen.DayOfYear;
            else
            {
                int soNam = ngayDi.Year - ngayDen.Year;
                if (soNam == 1)
                {
                    if ((ngayDen.Year % 400 == 0) || (ngayDen.Year % 4 == 0 && ngayDen.Year % 100 == 0))
                        soNgay = (366 - ngayDen.DayOfYear) + ngayDi.DayOfYear;
                    else
                        soNgay = (365 - ngayDen.DayOfYear) + ngayDi.DayOfYear;
                }
                else
                {
                    for (int i = 0; i < soNam - 1; i++)
                    {
                        if (((ngayDen.Year + i) % 400 == 0) || ((ngayDen.Year + i) % 4 == 0 && (ngayDen.Year + i) % 100 == 0))
                            soNgay = soNgay + 366;
                        else
                            soNgay = soNgay + 365;
                    }
                    if ((ngayDen.Year % 400 == 0) || (ngayDen.Year % 4 == 0 && ngayDen.Year % 100 == 0))
                        soNgay = (366 - ngayDen.DayOfYear) + ngayDi.DayOfYear;
                    else
                        soNgay = (365 - ngayDen.DayOfYear) + ngayDi.DayOfYear;

                }
            }
            if (soNgay == 0)
                soNgay = 1;

            //txtSoNgay.Text = soNgay.ToString();
            return soNgay;
        }
        private int getTongtien()
        {
            int tong = 0;
            tong = loaiPhongBL.getGiaPhong(txtLoaiPhongDat.Text) * int.Parse(txtsoluong.Text) * getSoNgay(txtMaDP.Text);
            return tong;
        }

        private string getmahd()
        {
            int id;
            id = int.Parse(db.GetLastID("hoadon", "mahd").Substring(2, 3));
            if (id < 9)
                return "HD00" + (id + 1).ToString();
            else
                if (id < 99)
                    return "HD0" + (id + 1).ToString();
                else
                    return "HD" + (id + 1).ToString();
        }

        private HoaDon_DTO getdatahd()
        {
            HoaDon_DTO hd = new HoaDon_DTO();
            hd.Mahd = getmahd();
            hd.Madp = txtMaDP.Text;
            hd.Ngaylap = DateTime.Today;
            hd.Tongtien = getTongtien();
            return hd;
        }

        public ArrayList getDSPhongDat()
        {
            ArrayList a = new ArrayList();
            DataTable dtb = chiTietDatPhongBL.getDSMaDatPhong(txtMaDP.Text);
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                DataRow r = dtb.Rows[i];
                a.Add(r[0].ToString());
            }
            return a;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hd = getdatahd();
            hoaDonBL.updateHoaDon(hd);
            if (ckbtrangtrai.Checked == false)
            {
                if (MessageBox.Show("Phòng chưa trả!"+System.Environment.NewLine+"Bạn có muốn cập nhật trạng thái phòng và thanh toán?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    maDatPhong = txtMaDP.Text;
                    if (datPhongBL.updateTrangThai(txtMaDP.Text, true))
                    {
                        for (int i = 0; i < getDSPhongDat().Count; i++)
                        {
                            phongBL.traphong(getDSPhongDat()[i].ToString());
                            loaiPhongBL.tangSoLuongPhong(txtLoaiPhongDat.Text);
                        }

                        //hd = getdatahd();
                        
                        if (hoaDonBL.lapHoaDon(hd))
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            bindSourceDatPhong();
                            new frmReportHD().Show();
                        }
                    }
                }
            }
            else
            {
                //if (hoaDonBL.updateHoaDon(hd))
                //{
                //    bindSourceDatPhong();
                    maDatPhong = txtMaDP.Text;
                    new frmReportHD().Show();
               // }
                //else MessageBox.Show("err");
                
               
            }
        }

        private void setarr1()
        {
            DataTable dtb = new DataTable();
            tenLoaiPhong = cbLoaiPhong.SelectedValue.ToString();
            dtb = phongBL.dsph(tenLoaiPhong);

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                DataRow r = dtb.Rows[i];
                arr1.Add(r[0]);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            arr.Clear();
            arr1.Clear();
            btnClearOne.Enabled = false;
            btnAddOne.Enabled = false;
            BindingSource bsp = new BindingSource();
            tenLoaiPhong = cbLoaiPhong.SelectedValue.ToString();
            bsp.DataSource = phongBL.dsph(tenLoaiPhong);
            listDatPhong.DataBindings.Clear();
            listDatPhong.DataSource = bsp;
            listDatPhong.DisplayMember = "maphong";
            listDatPhong.ValueMember = "maphong";
            listPhong.DataSource = null;
            listPhong.DataBindings.Clear();
            txtsoluong.Text = phongBL.dsph(tenLoaiPhong).Rows.Count.ToString();
            txtTienCoc.Text = loaiPhongBL.getTienDatCoc(cbLoaiPhong.SelectedValue.ToString(), int.Parse(txtsoluong.Text)).ToString();
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            if (arr1.Count == 0)
            {
                setarr1();
            }

            listDatPhong.DataSource = null;
            listDatPhong.DataBindings.Clear();
            if (listPhong.SelectedIndex > -1)
            {
                arr.Add(listPhong.SelectedValue);
                arr1.RemoveAt(listPhong.SelectedIndex);
            }
            listPhong.ClearSelected();
            BindingSource bsOne = new BindingSource();
            bsOne.DataSource = arr;
            listDatPhong.DataSource = bsOne;

            listPhong.DataSource = null;
            listPhong.DataBindings.Clear();
            listPhong.DataSource = arr1;

            if (arr.Count != 0)
                btnClearOne.Enabled = true;

            if (arr1.Count == 0)
                btnAddOne.Enabled = false;
            else
                btnAddOne.Enabled = true;
        }

        private void btnClearOne_Click(object sender, EventArgs e)
        {
            string tmp = arr[listDatPhong.SelectedIndex].ToString();
            arr.RemoveAt(listDatPhong.SelectedIndex);
            arr1.Add(tmp);
            listPhong.DataSource = null;
            listPhong.DataBindings.Clear();
            listPhong.DataSource = arr1;
            listDatPhong.DataSource = null;
            listDatPhong.DataBindings.Clear();
            listDatPhong.DataSource = arr;
            btnAddOne.Enabled = true;
            if (arr.Count == 0)
                btnClearOne.Enabled = false;
            else
                btnClearOne.Enabled = true;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            arr.Clear();
            arr1.Clear();
            btnAddOne.Enabled = true;
            btnClearOne.Enabled = false;
            bindSourceListPhong();
            listDatPhong.DataSource = null;
            listDatPhong.DataBindings.Clear();
            txtsoluong.Text = "0";
        }

        private void listDatphong_DataSourceChanged(object sender, EventArgs e)
        {
            txtsoluong.Text = arr.Count.ToString();
            txtTienCoc.Text = loaiPhongBL.getTienDatCoc(cbLoaiPhong.SelectedValue.ToString(), int.Parse(txtsoluong.Text)).ToString();
        }

        private void dgvdp_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                bindSourceListDatPhong();
                int index = dgvdp.CurrentCell.RowIndex;
                txtMaDP.Text = dgvdp.Rows[index].Cells[0].Value.ToString();
                txtMaNV.Text = dgvdp.Rows[index].Cells[1].Value.ToString();
                txtMaKH.Text = dgvdp.Rows[index].Cells[2].Value.ToString();
                txtLoaiPhongDat.Text = dgvdp.Rows[index].Cells[3].Value.ToString();
                dtNgayDat.Value = Convert.ToDateTime(dgvdp.Rows[index].Cells[4].Value);
                dtNgayDen.Value = Convert.ToDateTime(dgvdp.Rows[index].Cells[5].Value);
                dtNgayDi.Value = Convert.ToDateTime(dgvdp.Rows[index].Cells[6].Value);
                txtTienCoc.Text = dgvdp.Rows[index].Cells[7].Value.ToString();
                txtsoluong.Text = dgvdp.Rows[index].Cells[8].Value.ToString();
                ckbtrangtrai.Checked = Convert.ToBoolean(dgvdp.Rows[index].Cells[9].Value);
                txtSoNgay.Text = getSoNgay(txtMaDP.Text).ToString();
                //txtSoNgay.Text = getTongtien().ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Có lối xảy ra");
            }
        }

        
        //private void gvDatPhong_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
            

        //    bindatalistdatphong();
        //    int index = e.RowIndex;
        //    txtmadp.Text = dgvdp.Rows[index].Cells[0].Value.ToString();
        //    txtmanv.Text = dgvdp.Rows[index].Cells[1].Value.ToString();
        //    txtmakh.Text = dgvdp.Rows[index].Cells[2].Value.ToString();
        //    txtLpDat.Text = dgvdp.Rows[index].Cells[3].Value.ToString();
        //    dtpngaydat.Value = Convert.ToDateTime(dgvdp.Rows[index].Cells[4].Value);
        //    dtpngayden.Value = Convert.ToDateTime(dgvdp.Rows[index].Cells[5].Value);
        //    dtpngaydi.Value = Convert.ToDateTime(dgvdp.Rows[index].Cells[6].Value);
        //    txttiencoc.Text = dgvdp.Rows[index].Cells[7].Value.ToString();
        //    txtsoluong.Text = dgvdp.Rows[index].Cells[8].Value.ToString();
        //    ckbtrangtrai.Checked = Convert.ToBoolean(dgvdp.Rows[index].Cells[9].Value);
        //}
    }
}
