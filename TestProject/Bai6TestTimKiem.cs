using ASM2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestFixture]
    public class TimKiemTheoMaSvTests
    {
        private SinhVienPoly _sinhVienPoly;

        [SetUp]
        public void SetUp()
        {
            _sinhVienPoly = new SinhVienPoly();
            _sinhVienPoly.ThemSinhVien(new SinhVien("1", "Nguyen Van A", "ML001", "Lop A", "SV001"));
            _sinhVienPoly.ThemSinhVien(new SinhVien("2", "Nguyen Van B", "ML002", "Lop B", "SV002"));
            _sinhVienPoly.ThemSinhVien(new SinhVien("3", "Nguyen Van C", "ML003", "Lop C", "SV003"));
        }

        [Test]
        [TestCase("SV001", "Nguyen Van A")] 
        [TestCase("SV002", "Nguyen Van B")] 
        [TestCase("SV003", "Nguyen Van C")]
        [TestCase("", "A")]
        [TestCase("", "")]

        public void TimKiemTheoMaSv(string maSv, string expectedName)
        {
            if (string.IsNullOrWhiteSpace(maSv))
            {
                Assert.Throws<ArgumentException>(() => _sinhVienPoly.TimTheoMaSv(maSv));
            }
            else
            {
                var result = _sinhVienPoly.TimTheoMaSv(maSv);
                if (expectedName != null)
                {
                    Assert.IsNotNull(result);
                    Assert.AreEqual(expectedName, result.HoTen);
                }
                else
                {
                    Assert.IsNull(result);
                }
            }
        }
    }

}
