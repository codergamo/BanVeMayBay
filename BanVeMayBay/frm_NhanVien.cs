﻿using BUS;
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

namespace BanVeMayBay
{
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        public void XemNhanVien()
        {
            NhanVienBUS nvBUS = new NhanVienBUS();
            DataTable dt = new DataTable();
            dt = nvBUS.HienThi();
            dgvNV.DataSource = dt;
            dgvNV.Columns[0].HeaderText = "Mã nhân viên";
            dgvNV.Columns[1].HeaderText = "CMND";
            dgvNV.Columns[2].HeaderText = "Tên nhân viên";
            dgvNV.Columns[3].HeaderText = "Giới tính";
            dgvNV.Columns[4].HeaderText = "Ngày sinh";
            dgvNV.Columns[5].HeaderText = "Số điện thoại";
            dgvNV.Columns[6].HeaderText = "Địa chỉ";

            dgvNV.Columns[0].Width = 150;
            dgvNV.Columns[1].Width = 150;
            dgvNV.Columns[2].Width = 250;
            dgvNV.Columns[3].Width = 100;
            dgvNV.Columns[4].Width = 100;
            dgvNV.Columns[5].Width = 150;
            dgvNV.Columns[6].Width = 250;
            dgvNV.AllowUserToAddRows = false;
            dgvNV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            XemNhanVien();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            NhanVienBUS nvBUS = new NhanVienBUS();
            NhanVien nv = new NhanVien(txt_MaNV.Text, txt_CMND.Text, txt_TenNV.Text, cb_GioiTinh.Text, txt_SDT.Text, txt_DiaChi.Text, dtp_NgaySinh.Value);
            nvBUS.ThemNV(nv);
            XemNhanVien();
        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}