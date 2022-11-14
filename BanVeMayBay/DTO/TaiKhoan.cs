using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class TaiKhoan
    {
<<<<<<< HEAD
        private string TenTK, MatKhau, LoaiTK, IDNhanVien;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenTK, string matKhau, string loaiTK, string iDNhanVien)
        {
            TenTK = tenTK;
            MatKhau = matKhau;
            LoaiTK = loaiTK;
            IDNhanVien = iDNhanVien;
        }

        public string tenTK { get => TenTK; set => TenTK = value; }
        public string matKhau { get => MatKhau; set => MatKhau = value; }
        public string loaiTK { get => LoaiTK; set => LoaiTK = value; }
        public string iDNhanVien { get => IDNhanVien; set => IDNhanVien = value; }
=======
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
>>>>>>> 1910f1c8d4a8633c8c58e1dd8ad77b483575a56e
    }
}
