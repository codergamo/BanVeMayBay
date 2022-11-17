using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BanVeMayBay
{
    public partial class frm_DSPhieuDatCho : Form
    {
        public frm_DSPhieuDatCho()
        {
            InitializeComponent();
        }

        private void frm_DSPhieuDatCho_Load(object sender, EventArgs e)
        {
            PhieuDatChoBUS pdcBUS=new PhieuDatChoBUS();
            DataTable dt=new DataTable();
            pdcBUS.XemPhieuDatCho(dt);
            dgvDanhSachPDC.DataSource = dt;

        }
    }
}
