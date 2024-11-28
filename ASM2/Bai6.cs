using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    
        public class SinhVien
        {

            public string Id { get; set; }
            public string HoTen { get; set; }
            public string MaLop { get; set; }
            public string TenLop { get; set; }
            public string MaSv { get; set; }

            public SinhVien(string id, string hoTen, string maLop, string tenLop, string maSv)
            {
                Id = id;
                HoTen = hoTen;
                MaLop = maLop;
                TenLop = tenLop;
                MaSv = maSv;
            }
        }
        public class SinhVienPoly
        {
            private readonly List<SinhVien> _sinhVienList = new();

            public void ThemSinhVien(SinhVien sv)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(sv.TenLop, "^[a-zA-Z0-9 ]+$"))
                {
                    throw new ArgumentException("Tên lớp chứa ký tự đặc biệt.");
                }
                _sinhVienList.Add(sv);
            }

            public List<SinhVien> TimTheoTen(string hoTen)
            {
                return _sinhVienList.Where(sv => sv.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            public SinhVien TimTheoMaSv(string maSv)
            {
            if (string.IsNullOrWhiteSpace(maSv))
                throw new ArgumentException("Mã sinh viên không được để trống.");

            return _sinhVienList.FirstOrDefault(sv => sv.MaSv.Equals(maSv, StringComparison.OrdinalIgnoreCase));
            }
        }
    }

