using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class TaiKhoan
    {
        private String tenTaiKhoan, matKhau, idNhanVien, phanLoai;
        public TaiKhoan() { }

        public TaiKhoan(string tenTaiKhoan, string matKhau, string idNhanVien, string phanLoai)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.idNhanVien = idNhanVien;
            this.phanLoai = phanLoai;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public string PhanLoai { get => phanLoai; set => phanLoai = value; }
    }
}
