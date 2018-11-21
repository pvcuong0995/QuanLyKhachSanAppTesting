using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyKhachSan.BLL;
using QuanLyKhachSan.DTO;

namespace TestDataProject
{
    [TestClass]
    public class TestQuanLyNhanVien
    {
        //        public NhanVien_DTO(string manv,string hoten,DateTime ngaysinh, string gioitinh,string sdt,string cmnd,string diachi,string email)


        NhanVien_DTO nv1, nv2, nv3, nv4, nv5;
        NhanVien_BLL nhanVienBLL = new NhanVien_BLL();
        [TestInitialize]
        public void setUp()
        {
            DateTime ngaySinh = Convert.ToDateTime("08/11/2001");
            nv1 = new NhanVien_DTO("NV014", "BV", "Lê Văn A", ngaySinh, "Nam", "0164212400", "111111123", "bà rịa", "vana@gmail.com");
            nv2 = new NhanVien_DTO("NV012", "BV", "Lê Văn A", ngaySinh, "Nam", "01642124732", "123456789", "bà rịa", "nhathoang@gmail.com");
            nv3 = new NhanVien_DTO("NV014", "PV", "Lê Văn C", ngaySinh, "Nam", "01642124732", "123456222", "bà rịa", "lfkfd@gmail.com");
            nv4 = new NhanVien_DTO(null, "BV", "Lê Văn A", ngaySinh, "Nam", "01642124732", "123456789", "bà rịa", "nhathoang@gmail.com");
            nv5 = new NhanVien_DTO("NV014", "PD", "Lê Văn D", ngaySinh, "Nam", "01642124999", "123456789", "Hà nội", "dfdf@gmail.com");
           

        }
        [TestMethod]
        public void TestAddNhanVien()
        {
            var test = nhanVienBLL.addnv(nv1);
            Assert.AreEqual(true, test);
        }
        [TestMethod]
        public void TestAddNhanVienWithIdDuplicate()
        {
            var test = nhanVienBLL.addnv(nv3);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestAddNhanVienWithCmndDuplicate()
        {
            var test = nhanVienBLL.addnv(nv2);
            Assert.AreEqual(false, test);
        }
        [TestMethod]
        public void TestAddNhanVienWithIdNull()
        {
            var test = nhanVienBLL.addnv(nv4);
            Assert.AreEqual(false, test);
        }

       
        [TestMethod]
        public void TestUpdateNhanVien()
        {
            var test = nhanVienBLL.editnv(nv3);
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void TestUpdateNhanVienWithCmnđuplicate()
        {
            var test = nhanVienBLL.editnv(nv5);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestDeleteNhanVien()
        {
            var test = nhanVienBLL.deletenv(nv1);
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void TestDeleteNhanVienIdNotFound()
        {
            var test = nhanVienBLL.deletenv(nv4);
            Assert.AreEqual(false, test);
        }

        [TestMethod]
        public void TestCheckExistNhanVien()
        {
            var test = nhanVienBLL.checknv(nv2.Manv);
            Assert.AreEqual(true, test);
        }

        [TestMethod]
        public void TestCheckExistNhanVienNotFound()
        {
            var test = nhanVienBLL.checknv(nv4.Manv);
            Assert.AreEqual(false, test);
        }




        
    }
}
