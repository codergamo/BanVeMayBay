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
    public partial class frm_DoiMatKhau : Form
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TaiKhoan TK = new TaiKhoan();
<<<<<<< HEAD
            TK.tenTK = guna2TextBox1.Text;
            TK.matKhau = guna2TextBox2.Text;
=======
            TK.TenTaiKhoan = guna2TextBox1.Text;
            TK.MatKhau = guna2TextBox2.Text;
>>>>>>> 1910f1c8d4a8633c8c58e1dd8ad77b483575a56e
            TaiKhoanBUS tkbus=new TaiKhoanBUS();
            tkbus.DMK(TK, guna2TextBox3.Text, guna2TextBox4.Text);
            resettextbox();

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void resettextbox()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
        }
        private void showInformation()
        {
            TaiKhoan TK =new TaiKhoan();
<<<<<<< HEAD
            TK.tenTK=guna2TextBox1.Text;
=======
            TK.TenTaiKhoan=guna2TextBox1.Text;
>>>>>>> 1910f1c8d4a8633c8c58e1dd8ad77b483575a56e
            TaiKhoanBUS TKBUS=new TaiKhoanBUS();
            DataTable dt=new DataTable();
            TKBUS.SI(TK,dt);
            guna2HtmlLabel10.Text = Convert.ToString(dt.Rows[0].ItemArray[0]);
            guna2HtmlLabel11.Text = Convert.ToString(dt.Rows[0].ItemArray[1]);
            guna2HtmlLabel13.Text = Convert.ToString(dt.Rows[0].ItemArray[2]);
            guna2HtmlLabel12.Text = Convert.ToString(dt.Rows[0].ItemArray[3]);

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
