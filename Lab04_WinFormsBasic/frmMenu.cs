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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            this.Text = "Lab 4 - Chọn bài";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.ClientSize = new Size(360, 420);

            Label lblTieuDe = new Label();
            lblTieuDe.Text = "LAB 4 - THIẾT KẾ WINFORMS";
            lblTieuDe.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblTieuDe.AutoSize = false;
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.SetBounds(10, 10, 340, 36);
            this.Controls.Add(lblTieuDe);

            ThemNut("Bài 1-5: Thông tin sinh viên", 56, () => new frmSinhVien());
            ThemNut("Bài 6: Máy tính bốn phép toán", 104, () => new frmMayTinh());
            ThemNut("Bài 7: Form đăng nhập", 152, () => new frmDangNhap());
            ThemNut("Bài 8: Tính chỉ số BMI", 200, () => new frmBMI());
            ThemNut("Bài 9: Đăng ký học phần", 248, () => new frmDangKyHocPhan());
            ThemNut("Bài 10: Phiếu nhập sản phẩm", 296, () => new frmPhieuNhap());

            Button btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.SetBounds(60, 354, 240, 40);
            btnThoat.Click += (s, e) => this.Close();
            this.Controls.Add(btnThoat);
        }

        private void ThemNut(string text, int top, Func<Form> taoForm)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.SetBounds(60, top, 240, 40);
            btn.Click += (s, e) =>
            {
                using (Form f = taoForm())
                {
                    f.ShowDialog(this);
                }
            };
            this.Controls.Add(btn);
        }
    }
}
