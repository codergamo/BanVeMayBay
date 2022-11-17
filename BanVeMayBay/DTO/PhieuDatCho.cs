using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDatCho
    {
        private string maPhieu, soGhe, hangGhe, KH_CMND, maCB, maHV;
        private DateTime thoiGianDat;

        public PhieuDatCho()
        {
        }

        public PhieuDatCho(string maPhieu, string soGhe, string hangGhe, string kH_CMND, string maCB, string maHV, DateTime thoiGianDat)
        {
            this.maPhieu = maPhieu;
            this.soGhe = soGhe;
            this.hangGhe = hangGhe;
            KH_CMND = kH_CMND;
            this.maCB = maCB;
            this.maHV = maHV;
            this.thoiGianDat = thoiGianDat;
        }

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string SoGhe { get => soGhe; set => soGhe = value; }
        public string HangGhe { get => hangGhe; set => hangGhe = value; }
        public string KH_CMND1 { get => KH_CMND; set => KH_CMND = value; }
        public string MaCB { get => maCB; set => maCB = value; }
        public string MaHV { get => maHV; set => maHV = value; }
        public DateTime ThoiGianDat { get => thoiGianDat; set => thoiGianDat = value; }
    }
}
