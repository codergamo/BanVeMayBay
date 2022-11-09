using BanVeMayBay.DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay.DAO
{
    internal class KhachHangDAO : DBConnection
    {
        public KhachHangDAO() : base()  { }

        public DataTable HienThi()
        {
            const string sql = "select * from HienThiKH";
            return executeDisplayQuery(sql);
        }
        public void ThemKH(KhachHang kh)
        {
            string sql = "ThemKH";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@CMND", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kh.cMND);
            sqlParameters[1] = new SqlParameter("@TenKH", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(kh.tenKH);
            sqlParameters[2] = new SqlParameter("@SDT", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(kh.sDT);
            sqlParameters[3] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(kh.gioiTinh);
            sqlParameters[4] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(kh.diaChi);
            sqlParameters[5] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            sqlParameters[5].Value = Convert.ToString(kh.ngaySinh);
            executeInsertQuery(sql, sqlParameters);
        }
        public void XoaKH(KhachHang kh)
        {
            string sql = "XoaKH";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@CMND", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kh.cMND);
            executeUpdateOrDeleteQuery(sql, sqlParameters);
        }
    }
}
