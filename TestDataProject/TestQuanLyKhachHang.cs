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
        KhachHang_DTO kh1, kh2, kh3, kh4, kh5, kh6, kh7;
        string dieuKien1, input1;
        string dieuKien2, input2;
        string dieuKien3, input3;
        KhachHang_BLL khachHangBLL = new KhachHang_BLL();
        [TestInitialize]
        public void setUp()
        {
                    
             kh1 = new KhachHang_DTO("KH106", "Le A", "111111111", "01234567889", "lea@gmail.com", "Sóc Trăng");
             kh2 = new KhachHang_DTO("KH106", "Minh Tuan", "273451111", "01234567889", "minhtuan@gmail.com", "Tây Ninh");
             kh3 = new KhachHang_DTO("KH101", "Minh Quynh", "273900900", "01234567880", "minhquynh.th10a4@gmail.com", "Ba ria");
             kh4 = new KhachHang_DTO("KH102", "Minh Duy", "273900900", "01234567889", "nhathoang@gmail.com", "Ba ria");
             kh5 = new KhachHang_DTO(null, "Minh Nang", "273456789", "01234567889", "nhathoang@gmail.com", "Ba ria");
             kh6 = new KhachHang_DTO("KH105", "Nguyen Trai", "273456345", "01234567444", "nguyentrai@gmail.com", "Hai phong");
             kh7 = new KhachHang_DTO("", "Nguyen Trai", "273456345", "01234567444", "nguyentrai@gmail.com", "Hai phong");
             dieuKien1 = "makh"; input1 = kh1.Makh;
             dieuKien2 = "hoten"; input2 = kh5.Hoten;
             dieuKien3 = "cmnd"; input3 = "273";

        }
        [TestMethod]
        public void TestAddCustomer()
        {
            var test = khachHangBLL.addkh(kh1);
            Assert.AreEqual(true, test);
        }
        [TestMethod]
        public void TestAddCustomerWithIdDuplicate()
        {
            var test = khachHangBLL.addkh(kh2);
            Assert.AreEqual(false, test);
        }
        
        [TestMethod]
        public void TestAddCustomerWithCmndDuplicate()
        {
            var test = khachHangBLL.addkh(kh4);
            Assert.AreEqual(false, test);
        }
        [TestMethod]
        public void TestAddCustomerWithCustomerIdNull()
        {
            var test = khachHangBLL.addkh(kh5);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestAddCustomerWithCustomerIdEmpty()
        {
            var test = khachHangBLL.addkh(kh7);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestUpdateCustomer()
        {
            var test = khachHangBLL.editkh(kh3);
            Assert.AreEqual(true, test);
        }
        [TestMethod]
        public void TestUpdateCustomerWithCustomerIdNull()
        {
            var test = khachHangBLL.editkh(kh5);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestTraCuuCustomer()
        {
            var test = khachHangBLL.traCuu(dieuKien1, input1);
            Assert.AreEqual(1, test.Rows.Count);
        }
        [TestMethod]
        public void TestTraCuuCustomerWithNameNotFound()
        {
            var test = khachHangBLL.traCuu(dieuKien2, input2);
            Assert.AreEqual(0, test.Rows.Count);
        }

        [TestMethod]
        public void TestTraCuuCmnd()
        {
            var test = khachHangBLL.traCuu(dieuKien3, input3);
            Assert.AreEqual(3, test.Rows.Count);
        }
        [TestMethod]
        public void TestDeleteCustomerIdKH106()
        {
            var test = khachHangBLL.deletekh(kh2);
            Assert.AreEqual(true, test);
        }
        [TestMethod]
        public void TestDeleteCustomerIdNull()
        {
            var test = khachHangBLL.deletekh(kh5);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestDeleteCustomerIdKH105()
        {
            var test = khachHangBLL.deletekh(kh6);
            Assert.AreEqual(false, test);
        }
       
    }
}
