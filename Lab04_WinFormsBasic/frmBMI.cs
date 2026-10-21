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
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void btnTinhBMI_Click(object sender, EventArgs e)
        {
            double chieuCao, canNang;

            if (!double.TryParse(txtChieuCao.Text, out chieuCao) || chieuCao <= 0)
            {
                MessageBox.Show("Chiều cao không hợp lệ!", "Lỗi");
                txtChieuCao.Focus();
                return;
            }
            if (!double.TryParse(txtCanNang.Text, out canNang) || canNang <= 0)
            {
                MessageBox.Show("Cân nặng không hợp lệ!", "Lỗi");
                txtCanNang.Focus();
                return;
            }

            double m = chieuCao / 100;
            double bmi = canNang / (m * m);

            string phanLoai;
            if (bmi < 18.5) phanLoai = "Gầy";
            else if (bmi < 23) phanLoai = "Bình thường";
            else if (bmi < 25) phanLoai = "Thừa cân";
            else phanLoai = "Béo phì";

            lblBMI.Text = "Chỉ số BMI: " + bmi.ToString("0.0");
            lblPhanLoai.Text = "Phân loại: " + phanLoai;
            lblPhanLoai.ForeColor = (phanLoai == "Bình thường") ? Color.Green : Color.Red;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtChieuCao.Clear();
            txtCanNang.Clear();
            lblBMI.Text = "Chỉ số BMI:";
            lblPhanLoai.Text = "Phân loại:";
            txtChieuCao.Focus();
        }

        private void lblBMI_Click(object sender, EventArgs e)
        {

        }
    }
}
