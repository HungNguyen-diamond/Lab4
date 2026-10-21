using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void chkGhiNho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (tenDN == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thiếu thông tin");
                return;
            }

            if (tenDN == "admin" && matKhau == "123456")
            {
                string ghiNho = chkGhiNho.Checked ? "Có" : "Không";
                MessageBox.Show("Đăng nhập thành công!\nGhi nhớ đăng nhập: " + ghiNho, "Thông báo");
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi");
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
