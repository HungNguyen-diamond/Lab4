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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            cboLoai.Items.Add("Điện tử");
            cboLoai.Items.Add("Gia dụng");
            cboLoai.Items.Add("Văn phòng phẩm");
            cboLoai.Items.Add("Thực phẩm");
            cboLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoai.SelectedIndex = 0;
            dtpNgayNhap.MaxDate = DateTime.Today;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(dlg.FileName))
                    {
                        picAnhSP.SizeMode = PictureBoxSizeMode.Zoom;
                        picAnhSP.ImageLocation = dlg.FileName;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tệp ảnh!", "Lỗi");
                    }
                }
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm!", "Thiếu thông tin");
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thiếu thông tin");
                txtTenSP.Focus();
                return;
            }

            decimal donGia;
            if (!decimal.TryParse(txtDonGia.Text, out donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi");
                txtDonGia.Focus();
                return;
            }

            int soLuong = (int)nudSoLuong.Value;
            decimal thanhTien = soLuong * donGia;
            lblThanhTien.Text = "Thành tiền: " + thanhTien.ToString("N0") + " VNĐ";

            string thongTin = string.Format(
                "Mã SP: {0}\nTên SP: {1}\nLoại: {2}\nSố lượng: {3}\nĐơn giá: {4:N0} VNĐ\nNgày nhập: {5:dd/MM/yyyy}\nThành tiền: {6:N0} VNĐ",
                txtMaSP.Text.Trim(), txtTenSP.Text.Trim(), cboLoai.Text,
                soLuong, donGia, dtpNgayNhap.Value, thanhTien);
            MessageBox.Show(thongTin, "Phiếu nhập sản phẩm");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            cboLoai.SelectedIndex = 0;
            nudSoLuong.Value = 1;
            dtpNgayNhap.Value = DateTime.Today;
            picAnhSP.Image = null;
            picAnhSP.ImageLocation = null;
            lblThanhTien.Text = "Thành tiền: 0 VNĐ";
            txtMaSP.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
