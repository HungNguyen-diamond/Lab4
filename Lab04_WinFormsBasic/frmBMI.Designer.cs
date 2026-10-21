namespace Lab04_WinFormsBasic
{
    partial class frmBMI
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
            this.lblChieuCao = new System.Windows.Forms.Label();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.lblCanNang = new System.Windows.Forms.Label();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.btnTinhBMI = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChieuCao
            // 
            this.lblChieuCao.AutoSize = true;
            this.lblChieuCao.Location = new System.Drawing.Point(31, 33);
            this.lblChieuCao.Name = "lblChieuCao";
            this.lblChieuCao.Size = new System.Drawing.Size(99, 16);
            this.lblChieuCao.TabIndex = 0;
            this.lblChieuCao.Text = "Chiều cao (cm):";
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Location = new System.Drawing.Point(136, 30);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(100, 22);
            this.txtChieuCao.TabIndex = 1;
            // 
            // lblCanNang
            // 
            this.lblCanNang.AutoSize = true;
            this.lblCanNang.Location = new System.Drawing.Point(31, 82);
            this.lblCanNang.Name = "lblCanNang";
            this.lblCanNang.Size = new System.Drawing.Size(93, 16);
            this.lblCanNang.TabIndex = 2;
            this.lblCanNang.Text = "Cân nặng (kg):";
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(136, 79);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(100, 22);
            this.txtCanNang.TabIndex = 3;
            // 
            // btnTinhBMI
            // 
            this.btnTinhBMI.Location = new System.Drawing.Point(34, 134);
            this.btnTinhBMI.Name = "btnTinhBMI";
            this.btnTinhBMI.Size = new System.Drawing.Size(90, 23);
            this.btnTinhBMI.TabIndex = 4;
            this.btnTinhBMI.Text = "Tính BMI";
            this.btnTinhBMI.UseVisualStyleBackColor = true;
            this.btnTinhBMI.Click += new System.EventHandler(this.btnTinhBMI_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(161, 134);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(31, 181);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(73, 16);
            this.lblBMI.TabIndex = 6;
            this.lblBMI.Text = "Chỉ số BMI:";
            this.lblBMI.Click += new System.EventHandler(this.lblBMI_Click);
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Location = new System.Drawing.Point(31, 219);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(66, 16);
            this.lblPhanLoai.TabIndex = 7;
            this.lblPhanLoai.Text = "Phân loại:";
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPhanLoai);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTinhBMI);
            this.Controls.Add(this.txtCanNang);
            this.Controls.Add(this.lblCanNang);
            this.Controls.Add(this.txtChieuCao);
            this.Controls.Add(this.lblChieuCao);
            this.Name = "frmBMI";
            this.Text = "Tính chỉ số BMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChieuCao;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.Label lblCanNang;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.Button btnTinhBMI;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblPhanLoai;
    }
}