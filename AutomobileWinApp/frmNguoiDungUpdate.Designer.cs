namespace AutomobileWinApp
{
    partial class frmNguoiDungUpdate
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
            txtMaNguoiDung = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtMatKhau = new System.Windows.Forms.TextBox();
            txtTenDangNhap = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cboLoaiNguoiDung = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThoat.ForeColor = System.Drawing.Color.FromArgb(192, 0, 192);
            btnThoat.Location = new System.Drawing.Point(313, 319);
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
            btnCapNhat.Location = new System.Drawing.Point(200, 319);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new System.Drawing.Size(107, 41);
            btnCapNhat.TabIndex = 29;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtMaNguoiDung
            // 
            txtMaNguoiDung.Location = new System.Drawing.Point(200, 201);
            txtMaNguoiDung.Name = "txtMaNguoiDung";
            txtMaNguoiDung.Size = new System.Drawing.Size(207, 27);
            txtMaNguoiDung.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(53, 254);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(121, 20);
            label5.TabIndex = 26;
            label5.Text = "Loại Người dùng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(53, 208);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(114, 20);
            label4.TabIndex = 25;
            label4.Text = "Mã Người dùng";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new System.Drawing.Point(200, 158);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new System.Drawing.Size(207, 27);
            txtMatKhau.TabIndex = 24;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new System.Drawing.Point(200, 108);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new System.Drawing.Size(207, 27);
            txtTenDangNhap.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(53, 161);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 20);
            label3.TabIndex = 22;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(53, 115);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(107, 20);
            label2.TabIndex = 21;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Purple;
            label1.Location = new System.Drawing.Point(85, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(303, 32);
            label1.TabIndex = 20;
            label1.Text = "CẬP NHẬT NGƯỜI DÙNG";
            // 
            // cboLoaiNguoiDung
            // 
            cboLoaiNguoiDung.FormattingEnabled = true;
            cboLoaiNguoiDung.Location = new System.Drawing.Point(200, 251);
            cboLoaiNguoiDung.Name = "cboLoaiNguoiDung";
            cboLoaiNguoiDung.Size = new System.Drawing.Size(207, 28);
            cboLoaiNguoiDung.TabIndex = 31;
            // 
            // frmNguoiDungUpdate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            ClientSize = new System.Drawing.Size(472, 390);
            Controls.Add(cboLoaiNguoiDung);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(txtMaNguoiDung);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNguoiDungUpdate";
            Text = "frmNguoiDungUpdate";
            Load += frmNguoiDungUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMaNguoiDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiNguoiDung;
    }
}