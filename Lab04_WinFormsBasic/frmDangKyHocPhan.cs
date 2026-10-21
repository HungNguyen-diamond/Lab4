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
    public partial class frmDangKyHocPhan : Form
    {
        public frmDangKyHocPhan()
        {
            InitializeComponent();
        }

        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSoMon_Click(object sender, EventArgs e)
        {

        }
        public class MonHoc
        {
            public string Ten { get; set; }
            public int TinChi { get; set; }

            public MonHoc(string ten, int tinChi)
            {
                Ten = ten;
                TinChi = tinChi;
            }

            public override string ToString()
            {
                return Ten + " (" + TinChi + " tín chỉ)";
            }
        }

        private void frmDangKyHocPhan_Load(object sender, EventArgs e)
        {
            clbMonHoc.Items.Add(new MonHoc("Lập trình .NET", 3));
            clbMonHoc.Items.Add(new MonHoc("Cơ sở dữ liệu", 3));
            clbMonHoc.Items.Add(new MonHoc("Mạng máy tính", 3));
            clbMonHoc.Items.Add(new MonHoc("Cấu trúc dữ liệu và giải thuật", 4));
            clbMonHoc.Items.Add(new MonHoc("Tiếng Anh chuyên ngành", 2));
            clbMonHoc.Items.Add(new MonHoc("Triết học Mác - Lênin", 3));
            CapNhatTongTinChi();
        }

        private void CapNhatTongTinChi()
        {
            int tong = 0;
            foreach (object item in clbMonHoc.CheckedItems)
            {
                tong += ((MonHoc)item).TinChi;
            }
            lblTongTinChi.Text = "Tổng số tín chỉ: " + tong;
            lblSoMon.Text = "Số môn đã chọn: " + clbMonHoc.CheckedItems.Count;
        }

        private void clbMonHoc_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)CapNhatTongTinChi);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (clbMonHoc.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn môn học nào!", "Thông báo");
                return;
            }

            int tong = 0;
            string ds = "";
            foreach (object item in clbMonHoc.CheckedItems)
            {
                MonHoc mh = (MonHoc)item;
                tong += mh.TinChi;
                ds += "- " + mh.Ten + " (" + mh.TinChi + " tín chỉ)\n";
            }

            MessageBox.Show(
                "Các môn đã đăng ký:\n" + ds + "\nTổng số tín chỉ: " + tong,
                "Kết quả đăng ký");
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                clbMonHoc.SetItemChecked(i, false);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
