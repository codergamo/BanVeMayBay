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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }
        private void EditButtonColor(Button btn, String topname)
        {
            btn_Home.Visible = true;
            btn_BanVe.BackColor = Color.FromArgb(102, 165, 173);
            btn_DanhSachVe.BackColor = Color.FromArgb(102, 165, 173);
            btn_ChuyenBay.BackColor = Color.FromArgb(102, 165, 173);
            btn_NhanVien.BackColor = Color.FromArgb(102, 165, 173);
            btn_KhachHang.BackColor = Color.FromArgb(102, 165, 173);
            btn_ThongKe.BackColor = Color.FromArgb(102, 165, 173);
            btn_DoiMatKhau.BackColor = Color.FromArgb(102, 165, 173);
            btn_Thoat.BackColor = Color.FromArgb(102, 165, 173);

            if (topname == "TRANG CHỦ")
            {
                btn.BackColor = Color.FromArgb(102, 165, 173);
                pnl_Top.BackColor = Color.FromArgb(102, 165, 173);
            }
            else
            {
                btn.BackColor = Color.FromArgb(196, 223, 230);
                pnl_Top.BackColor = Color.FromArgb(196, 223, 230);       
            }
            lb_TopName.Text = topname;
        }
        void AddForm(Form f)
        {
            this.pnl_Main.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(f);
            f.Show();
        }
        private void btn_BanVe_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_BanVe, "BÁN VÉ");
        }

        private void btn_DanhSachVe_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_DanhSachVe, "DANH SÁCH VÉ");
        }

        private void btn_ChuyenBay_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_ChuyenBay, "CHUYẾN BAY");
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_NhanVien, "NHÂN VIÊN");
            frm_NhanVien frmNV = new frm_NhanVien();
            AddForm(frmNV);
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_KhachHang, "KHÁCH HÀNG");
            frm_KhachHang frmKH = new frm_KhachHang();
            AddForm(frmKH);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_ThongKe, "THỐNG KÊ");
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_DoiMatKhau, "ĐỔI MẬT KHẨU");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_Thoat, "THOÁT");
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            EditButtonColor(btn_Home, "TRANG CHỦ");
            btn_Home.Visible = false;
            this.pnl_Main.Controls.Clear();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            btn_Home.Visible = false;
        }

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
