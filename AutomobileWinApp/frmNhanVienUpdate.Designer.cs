namespace AutomobileWinApp
{
    partial class frmNhanVienUpdate
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
            btnThoat = new System.Windows.Forms.Button();
            btnCapNhat = new System.Windows.Forms.Button();
            txtDienThoai = new System.Windows.Forms.MaskedTextBox();
            txtDiaChi = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtTenNhanVien = new System.Windows.Forms.TextBox();
            txtMaNhanVien = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            chkGioiTinh = new System.Windows.Forms.CheckBox();
            label7 = new System.Windows.Forms.Label();
            txtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThoat.ForeColor = System.Drawing.Color.FromArgb(192, 0, 192);
            btnThoat.Location = new System.Drawing.Point(369, 322);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(94, 41);
            btnThoat.TabIndex = 30;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(192, 0, 192);
            btnCapNhat.Location = new System.Drawing.Point(256, 322);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new System.Drawing.Size(107, 41);
            btnCapNhat.TabIndex = 29;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new System.Drawing.Point(256, 233);
            txtDienThoai.Mask = "(00)000.000.000";
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new System.Drawing.Size(207, 27);
            txtDienThoai.TabIndex = 28;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new System.Drawing.Point(256, 183);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new System.Drawing.Size(207, 27);
            txtDiaChi.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(39, 236);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 20);
            label5.TabIndex = 26;
            label5.Text = "Điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(39, 190);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 20);
            label4.TabIndex = 25;
            label4.Text = "Địa chỉ";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new System.Drawing.Point(256, 140);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new System.Drawing.Size(207, 27);
            txtTenNhanVien.TabIndex = 24;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Enabled = false;
            txtMaNhanVien.Location = new System.Drawing.Point(256, 90);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Size = new System.Drawing.Size(207, 27);
            txtMaNhanVien.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(39, 143);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 20);
            label3.TabIndex = 22;
            label3.Text = "Tên Nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(39, 97);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 20);
            label2.TabIndex = 21;
            label2.Text = "Mã Nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Purple;
            label1.Location = new System.Drawing.Point(112, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(279, 32);
            label1.TabIndex = 20;
            label1.Text = "CẬP NHẬT NHÂN VIÊN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(44, 333);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 20);
            label6.TabIndex = 31;
            label6.Text = "Giới tính";
            // 
            // chkGioiTinh
            // 
            chkGioiTinh.AutoSize = true;
            chkGioiTinh.Location = new System.Drawing.Point(128, 329);
            chkGioiTinh.Name = "chkGioiTinh";
            chkGioiTinh.Size = new System.Drawing.Size(63, 24);
            chkGioiTinh.TabIndex = 32;
            chkGioiTinh.Text = "Nam";
            chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(44, 284);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 20);
            label7.TabIndex = 33;
            label7.Text = "Ngày sinh";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new System.Drawing.Point(256, 277);
            txtNgaySinh.Mask = "00/00/0000";
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new System.Drawing.Size(207, 27);
            txtNgaySinh.TabIndex = 34;
            txtNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // frmNhanVienUpdate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            ClientSize = new System.Drawing.Size(496, 392);
            Controls.Add(txtNgaySinh);
            Controls.Add(label7);
            Controls.Add(chkGioiTinh);
            Controls.Add(label6);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(txtDienThoai);
            Controls.Add(txtDiaChi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtMaNhanVien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNhanVienUpdate";
            Text = "frmNhanVienUpdate";
            Load += frmNhanVienUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.MaskedTextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkGioiTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtNgaySinh;
    }
}