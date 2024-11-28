using ASM2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class bai6TestThem
    {
        private SinhVienPoly _sinhvien = new SinhVienPoly();
        [Test]
        public void ThemSinhVien_DuLieuHople()
        {
            var sinhVien = new SinhVien("1", "Nguyen A", "L01", "LapTrinh", "SV001");
            Assert.DoesNotThrow(() => _sinhvien.ThemSinhVien(sinhVien));
        }
        [Test]
        public void ThemSinhVien_Tenlopkhonghople()
        {
            var sinhVien = new SinhVien("1", "Nguyen B", "L02", "Lap_Trinh@", "SV002");
            Assert.Throws<ArgumentException>(() => _sinhvien.ThemSinhVien(sinhVien));
        }
        [Test]
        public void ThemSinhVien_TenLopRong()
        {
            var sinhVien = new SinhVien("1", "Nguyen D", "L04", "", "SV004");
            Assert.Throws<ArgumentException>(() => _sinhvien.ThemSinhVien(sinhVien));
        }
        [Test]
        [TestCase("Lop123")]
        [TestCase("Lop A")] 
        [TestCase("")] 
        [TestCase("Lop12345678901234567890")] 
        [TestCase("Lop*123")] 
        [TestCase("Lop+123")] 
        public void ThemSinhVien_TenLopValidation(string tenLop)
        {
            var sv = new SinhVien("1", "Nguyen Van A", "ML001", tenLop, "SV001");

            if (System.Text.RegularExpressions.Regex.IsMatch(tenLop, "^[a-zA-Z0-9 ]+$"))
            {
                Assert.DoesNotThrow(() => _sinhvien.ThemSinhVien(sv));
            }
            else
            {
                Assert.Throws<ArgumentException>(() => _sinhvien.ThemSinhVien(sv));
            }
        }
    }
}