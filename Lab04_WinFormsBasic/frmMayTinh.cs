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
    public partial class frmMayTinh : Form
    {
        public frmMayTinh()
        {
            InitializeComponent();
        }

        private bool DocHaiSo(out double a, out double b)
        {
            a = 0; b = 0;
            if (!double.TryParse(txtSo1.Text, out a))
            {
                MessageBox.Show("Số thứ nhất không hợp lệ!", "Lỗi");
                txtSo1.Focus();
                return false;
            }
            if (!double.TryParse(txtSo2.Text, out b))
            {
                MessageBox.Show("Số thứ hai không hợp lệ!", "Lỗi");
                txtSo2.Focus();
                return false;
            }
            return true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DocHaiSo(out a, out b)) lblKetQua.Text = "Kết quả: " + (a + b);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DocHaiSo(out a, out b)) lblKetQua.Text = "Kết quả: " + (a - b);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DocHaiSo(out a, out b)) lblKetQua.Text = "Kết quả: " + (a * b);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!DocHaiSo(out a, out b)) return;
            if (b == 0)
            {
                MessageBox.Show("Không thể chia cho 0!", "Lỗi");
                return;
            }
            lblKetQua.Text = "Kết quả: " + (a / b);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            lblKetQua.Text = "Kết quả:";
            txtSo1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
