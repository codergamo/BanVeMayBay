using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuDatChoBUS
    {
        private PhieuDatChoDAO pdcDAO;
        public PhieuDatChoBUS()
        {
            pdcDAO = new PhieuDatChoDAO();
        }
        public void XemPhieuDatCho(DataTable dt)
        {
            pdcDAO.XemPhieuDaDat(dt);
        }
    }
}
