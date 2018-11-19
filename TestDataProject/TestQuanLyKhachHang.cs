using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.BLL;

namespace TestDataProject
{
    /// <summary>
    /// Summary description for TestQuanLyKhachHang
    /// </summary>
    [TestClass]
    public class TestQuanLyKhachHang
    {
        KhachHang_DTO kh1, kh2, kh3, kh4, kh5, kh6, kh22;
        KhachHang_BLL khachHangBLL = new KhachHang_BLL();
        [TestInitialize]
        public void setUp()
        {
                    //public KhachHang_DTO(string makh, string hoten, string cmnd, string sdt, string email, string diaChi)
             kh1 = new KhachHang_DTO("KH001", "Minh Nhat", "273456789", "01234567889", "nhathoang@gmail.com", "Ba ria");
             kh2 = new KhachHang_DTO("KH100", "Minh Tuan", "273456789", "01234567889", "nhathoang@gmail.com", "Ba ria");
             kh3 = new KhachHang_DTO("KH101", "Minh Quynh", "273900900", "01234567880", "nhathoang.th10a4@gmail.com", "Ba ria");
             kh4 = new KhachHang_DTO("KH102", "Minh Duy", "273900900", "01234567889", "nhathoang@gmail.com", "Ba ria");
             kh5 = new KhachHang_DTO("", "Minh Nang", "273456789", "01234567889", "nhathoang@gmail.com", "Ba ria");

             kh22 = new KhachHang_DTO("KH100", "New Name", "273456678", "01234567456", "name@gmail.com", "Tphcm");

             kh6 = new KhachHang_DTO("KH103", "Le Van", "273456222", "01234567444", "levan@gmail.com", "Ha noi");
        }
        [TestMethod]
        public void TestAddCustomerWithCustomerIdDuplicate()
        {
            var test = khachHangBLL.addkh(kh1);
            Assert.AreEqual(false, false);
        }
        [TestMethod]
        public void TestAddCustomerWithInfoTrue1()
        {
            var test = khachHangBLL.addkh(kh2);
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestAddCustomerWithInfoTrue2()
        {
            var test = khachHangBLL.addkh(kh3);
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestAddCustomerWithCmndDuplicate()
        {
            var test = khachHangBLL.addkh(kh4);
            Assert.AreEqual(false, false);
        }
        [TestMethod]
        public void TestAddCustomerWithCustomerIdNull()
        {
            var test = khachHangBLL.addkh(kh5);
            Assert.AreEqual(false, false);
        }

        [TestMethod]
        public void TestAddCustomerIdKH103()
        {
            var test = khachHangBLL.addkh(kh6);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestUpdateCustomer()
        {
            var test = khachHangBLL.editkh(kh22);
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestDeleteCustomerIdKH103()
        {
            var test = khachHangBLL.deletekh(kh6);
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestDeleteCustomerIdNull()
        {
            var test = khachHangBLL.deletekh(kh5);
            Assert.AreEqual(true, true);
        }
       
    }
}
