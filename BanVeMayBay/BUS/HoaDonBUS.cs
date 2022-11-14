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
    public class HoaDonBUS
    {
        private HoaDonDAO hdDAO;

        public HoaDonBUS()
        {
            hdDAO = new HoaDonDAO();
        }
    }
}
