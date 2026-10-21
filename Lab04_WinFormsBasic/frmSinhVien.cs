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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Công nghệ kỹ thuật ô tô");
            cboKhoa.Items.Add("Kinh tế");
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cboKhoa.Items.Count > 0) cboKhoa.SelectedIndex = 0;
            radNam.Checked = true;
            lblTuoi.Text = "Tuổi: " + TinhTuoi(dtpNgaySinh.Value);
        }

        private int TinhTuoi(DateTime ngaySinh)
        {
            int tuoi = DateTime.Today.Year - ngaySinh.Year;
            if (ngaySinh.Date > DateTime.Today.AddYears(-tuoi)) tuoi--;
            return tuoi;
        }
        private void lblMaSV_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            lblTuoi.Text = "Tuổi: " + TinhTuoi(dtpNgaySinh.Value);
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string thongTin = string.Format(
                "Mã: {0}\nHọ tên: {1}\nNgày sinh: {2:dd/MM/yyyy}\nKhoa: {3}\nGiới tính: {4}",
                txtMaSV.Text, txtHoTen.Text, dtpNgaySinh.Value,
                cboKhoa.Text, gioiTinh);
            MessageBox.Show(thongTin, "Thông tin sinh viên");
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnSoThich_Click(object sender, EventArgs e)
        {
            List<string> ds = new List<string>();
            if (chkDocSach.Checked) ds.Add("Đọc sách");
            if (chkTheThao.Checked) ds.Add("Thể thao");
            if (chkLapTrinh.Checked) ds.Add("Lập trình");
            lblSoThich.Text = ds.Count == 0 ? "Chưa chọn" : string.Join(", ", ds);
        }

        private void lblSoThich_Click(object sender, EventArgs e)
        {

        }

        private void picAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    picAnh.ImageLocation = dlg.FileName;
                    txtDuongDanAnh.Text = dlg.FileName;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tệp ảnh!", "Lỗi");
                }
            }
        }
    }
}