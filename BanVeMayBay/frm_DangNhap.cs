using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeMayBay
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            //abc
        }

        private void btn_Minimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_Forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_ResetPassword.Visible = true;
            pnl_Login.Visible = false;
        }
        private void btn_ExitReset_Click(object sender, EventArgs e)
        {
            pnl_ResetPassword.Visible = false;
            pnl_Login.Visible = true;
        }
    }
}
