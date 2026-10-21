namespace Lab04_WinFormsBasic
{
    partial class frmDangKyHocPhan
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.lblTongTinChi = new System.Windows.Forms.Label();
            this.lblSoMon = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(30, 25);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(95, 16);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Chọn môn học:";
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.CheckOnClick = true;
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Location = new System.Drawing.Point(33, 53);
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(120, 140);
            this.clbMonHoc.TabIndex = 1;
            this.clbMonHoc.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbMonHoc_ItemCheck);
            this.clbMonHoc.SelectedIndexChanged += new System.EventHandler(this.clbMonHoc_SelectedIndexChanged);
            // 
            // lblTongTinChi
            // 
            this.lblTongTinChi.AutoSize = true;
            this.lblTongTinChi.Location = new System.Drawing.Point(159, 53);
            this.lblTongTinChi.Name = "lblTongTinChi";
            this.lblTongTinChi.Size = new System.Drawing.Size(106, 16);
            this.lblTongTinChi.TabIndex = 2;
            this.lblTongTinChi.Text = "Tổng số tín chỉ: 0";
            // 
            // lblSoMon
            // 
            this.lblSoMon.AutoSize = true;
            this.lblSoMon.Location = new System.Drawing.Point(159, 78);
            this.lblSoMon.Name = "lblSoMon";
            this.lblSoMon.Size = new System.Drawing.Size(117, 16);
            this.lblSoMon.TabIndex = 3;
            this.lblSoMon.Text = "Số môn đã chọn: 0";
            this.lblSoMon.Click += new System.EventHandler(this.lblSoMon_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(33, 217);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnBoChon
            // 
            this.btnBoChon.Location = new System.Drawing.Point(159, 109);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(124, 23);
            this.btnBoChon.TabIndex = 5;
            this.btnBoChon.Text = "Bỏ chọn tất cả";
            this.btnBoChon.UseVisualStyleBackColor = true;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(136, 217);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoChon);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lblSoMon);
            this.Controls.Add(this.lblTongTinChi);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmDangKyHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký học phần";
            this.Load += new System.EventHandler(this.frmDangKyHocPhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.Label lblTongTinChi;
        private System.Windows.Forms.Label lblSoMon;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.Button btnThoat;
    }
}