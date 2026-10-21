namespace Lab04_WinFormsBasic
{
    partial class frmSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lblSoThichTitle = new System.Windows.Forms.Label();
            this.chkDocSach = new System.Windows.Forms.CheckBox();
            this.chkTheThao = new System.Windows.Forms.CheckBox();
            this.chkLapTrinh = new System.Windows.Forms.CheckBox();
            this.btnSoThich = new System.Windows.Forms.Button();
            this.lblSoThich = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtDuongDanAnh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(6, 11);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(84, 16);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã sinh viên:";
            this.lblMaSV.Click += new System.EventHandler(this.lblMaSV_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(96, 11);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(6, 42);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(96, 42);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(6, 74);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(96, 74);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 5;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(312, 77);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(40, 16);
            this.lblTuoi.TabIndex = 6;
            this.lblTuoi.Text = "Tuổi: ";
            this.lblTuoi.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(6, 111);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(57, 16);
            this.lblGioiTinh.TabIndex = 7;
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Click += new System.EventHandler(this.lblGioiTinh_Click);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(93, 107);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 8;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(156, 107);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 9;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(6, 141);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(41, 16);
            this.lblKhoa.TabIndex = 10;
            this.lblKhoa.Text = "Khoa:";
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(93, 138);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(203, 24);
            this.cboKhoa.TabIndex = 11;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(93, 177);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 12;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lblSoThichTitle
            // 
            this.lblSoThichTitle.AutoSize = true;
            this.lblSoThichTitle.Location = new System.Drawing.Point(6, 222);
            this.lblSoThichTitle.Name = "lblSoThichTitle";
            this.lblSoThichTitle.Size = new System.Drawing.Size(57, 16);
            this.lblSoThichTitle.TabIndex = 13;
            this.lblSoThichTitle.Text = "Sở thích:";
            this.lblSoThichTitle.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // chkDocSach
            // 
            this.chkDocSach.AutoSize = true;
            this.chkDocSach.Location = new System.Drawing.Point(89, 221);
            this.chkDocSach.Name = "chkDocSach";
            this.chkDocSach.Size = new System.Drawing.Size(85, 20);
            this.chkDocSach.TabIndex = 14;
            this.chkDocSach.Text = "Đọc sách";
            this.chkDocSach.UseVisualStyleBackColor = true;
            // 
            // chkTheThao
            // 
            this.chkTheThao.AutoSize = true;
            this.chkTheThao.Location = new System.Drawing.Point(184, 220);
            this.chkTheThao.Name = "chkTheThao";
            this.chkTheThao.Size = new System.Drawing.Size(82, 20);
            this.chkTheThao.TabIndex = 15;
            this.chkTheThao.Text = "Thể thao";
            this.chkTheThao.UseVisualStyleBackColor = true;
            // 
            // chkLapTrinh
            // 
            this.chkLapTrinh.AutoSize = true;
            this.chkLapTrinh.Location = new System.Drawing.Point(277, 220);
            this.chkLapTrinh.Name = "chkLapTrinh";
            this.chkLapTrinh.Size = new System.Drawing.Size(79, 20);
            this.chkLapTrinh.TabIndex = 16;
            this.chkLapTrinh.Text = "Lập trình";
            this.chkLapTrinh.UseVisualStyleBackColor = true;
            // 
            // btnSoThich
            // 
            this.btnSoThich.Location = new System.Drawing.Point(91, 257);
            this.btnSoThich.Name = "btnSoThich";
            this.btnSoThich.Size = new System.Drawing.Size(105, 23);
            this.btnSoThich.TabIndex = 17;
            this.btnSoThich.Text = "Xem sở thích";
            this.btnSoThich.UseVisualStyleBackColor = true;
            this.btnSoThich.Click += new System.EventHandler(this.btnSoThich_Click);
            // 
            // lblSoThich
            // 
            this.lblSoThich.AutoSize = true;
            this.lblSoThich.Location = new System.Drawing.Point(226, 260);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(70, 16);
            this.lblSoThich.TabIndex = 18;
            this.lblSoThich.Text = "Chưa chọn";
            this.lblSoThich.Click += new System.EventHandler(this.lblSoThich_Click);
            // 
            // picAnh
            // 
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(487, 11);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(120, 150);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 19;
            this.picAnh.TabStop = false;
            this.picAnh.Click += new System.EventHandler(this.picAnh_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(510, 177);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(75, 23);
            this.btnChonAnh.TabIndex = 20;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtDuongDanAnh
            // 
            this.txtDuongDanAnh.Location = new System.Drawing.Point(449, 216);
            this.txtDuongDanAnh.Name = "txtDuongDanAnh";
            this.txtDuongDanAnh.ReadOnly = true;
            this.txtDuongDanAnh.Size = new System.Drawing.Size(204, 22);
            this.txtDuongDanAnh.TabIndex = 21;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDuongDanAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.lblSoThich);
            this.Controls.Add(this.btnSoThich);
            this.Controls.Add(this.chkLapTrinh);
            this.Controls.Add(this.chkTheThao);
            this.Controls.Add(this.chkDocSach);
            this.Controls.Add(this.lblSoThichTitle);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblMaSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lblSoThichTitle;
        private System.Windows.Forms.CheckBox chkDocSach;
        private System.Windows.Forms.CheckBox chkTheThao;
        private System.Windows.Forms.CheckBox chkLapTrinh;
        private System.Windows.Forms.Button btnSoThich;
        private System.Windows.Forms.Label lblSoThich;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.TextBox txtDuongDanAnh;
    }
}

