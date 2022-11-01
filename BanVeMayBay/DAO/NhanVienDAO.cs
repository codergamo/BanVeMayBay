using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class NhanVienDAO : DBConnection
    {
        public NhanVienDAO() : base() { }
        public void ThemNV(NhanVien nv)
        {
            const string sql = "insert into NHANVIEN values(@MaNV, @CMND, @TenNV, @GioiTinh, @NgaySinh, @SDT, @DiaChi)";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(nv.Manv);
            sqlParameters[1] = new SqlParameter("@CMND", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(nv.Cmnd);
            sqlParameters[2] = new SqlParameter("@TenNV", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(nv.Tennv);
            sqlParameters[3] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(nv.Gioitinh);
            sqlParameters[4] = new SqlParameter("@NgaySinh", SqlDbType.DateTime);
            sqlParameters[4].Value = Convert.ToString(nv.Ngaysinh);
            sqlParameters[5] = new SqlParameter("@SDT", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(nv.Sdt);
            sqlParameters[6] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(nv.Diachi);
            executeInsertQuery(sql, sqlParameters);
        }
        public void XoaNV(String maNV)
        {
            const string sql = "delete from NHAN_VIEN where MaNV = @MaNV";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(maNV);
            executeUpdateOrDeleteQuery(sql, sqlParameters);
        }
        public void SuaNV(NhanVien nv)
        {
            //const string sql = "update NHAN_VIEN set TenNV = @TenNV, Phai = @Phai, NgaySinh = @NgaySinh, SDT = @SDT, DiaChi = @DiaChi, MatKhau = @MatKhau, LoaiTK = @LoaiTK where MaNV = @MaNV";
            //SqlParameter[] sqlParameters = new SqlParameter[8];
            //sqlParameters[0] = new SqlParameter("@MaNV", SqlDbType.NVarChar);
            //sqlParameters[0].Value = Convert.ToString(nv.MaNV);
            //sqlParameters[1] = new SqlParameter("@TenNV", SqlDbType.NVarChar);
            //sqlParameters[1].Value = Convert.ToString(nv.TenNV);
            //sqlParameters[2] = new SqlParameter("@Phai", SqlDbType.NVarChar);
            //sqlParameters[2].Value = Convert.ToString(nv.Phai);
            //sqlParameters[3] = new SqlParameter("@NgaySinh", SqlDbType.DateTime);
            //sqlParameters[3].Value = Convert.ToString(nv.NgaySinh);
            //sqlParameters[4] = new SqlParameter("@SDT", SqlDbType.NVarChar);
            //sqlParameters[4].Value = Convert.ToString(nv.SDT);
            //sqlParameters[5] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            //sqlParameters[5].Value = Convert.ToString(nv.DiaChi);
            //sqlParameters[6] = new SqlParameter("@MatKhau", SqlDbType.NVarChar);
            //sqlParameters[6].Value = Convert.ToString(nv.MatKhau);
            //sqlParameters[7] = new SqlParameter("@LoaiTK", SqlDbType.NVarChar);
            //sqlParameters[7].Value = Convert.ToString(nv.LoaiTK);
            //executeUpdateOrDeleteQuery(sql, sqlParameters);
        }
        public DataTable HienThi()
        {
            const string sql = "select * from NHANVIEN";
            return executeDisplayQuery(sql);
        }
    }
}