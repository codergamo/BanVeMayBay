using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class TaiKhoan
    {
        private string TenTK, MatKhau, LoaiTK, IDNhanVien;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenTK, string matKhau, string loaiTK, string iDNhanVien, string tenTK1, string matKhau1, string loaiTK1, string iDNhanVien1)
        {
            TenTK = tenTK;
            MatKhau = matKhau;
            LoaiTK = loaiTK;
            IDNhanVien = iDNhanVien;
            TenTK1 = tenTK1;
            MatKhau1 = matKhau1;
            LoaiTK1 = loaiTK1;
            IDNhanVien1 = iDNhanVien1;
        }

        public string TenTK1 { get => TenTK; set => TenTK = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public string LoaiTK1 { get => LoaiTK; set => LoaiTK = value; }
        public string IDNhanVien1 { get => IDNhanVien; set => IDNhanVien = value; }
    }
}
