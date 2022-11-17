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
    public class PhieuDatChoDAO : DBConnection
    {
        public void XemPhieuDaDat(DataTable dt)
        {
            const string sql = "XemPhieuDatCho";
            executeXemPhieuDatChoQuery(sql,dt);
        }
    }
}
