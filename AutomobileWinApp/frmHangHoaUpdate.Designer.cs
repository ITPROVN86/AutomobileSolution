namespace AutomobileWinApp
{
    partial class frmHangHoaUpdate
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
            label7 = new System.Windows.Forms.Label();
            btnThoat = new System.Windows.Forms.Button();
            btnCapNhat = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtTenHangHoa = new System.Windows.Forms.TextBox();
            txtMaHangHoa = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtDonGiaNhap = new System.Windows.Forms.TextBox();
            txtDonGiaBan = new System.Windows.Forms.TextBox();
            picAvatar = new System.Windows.Forms.PictureBox();
            btnUpload = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            txtGhiChu = new System.Windows.Forms.TextBox();
            txtSoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(403, 243);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(91, 20);
            label7.TabIndex = 48;
            label7.Text = "Đơn giá bán";
            // 
            // btnThoat
            // 
            btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThoat.ForeColor = System.Drawing.Color.FromArgb(192, 0, 192);
            btnThoat.Location = new System.Drawing.Point(625, 351);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(94, 41);
            btnThoat.TabIndex = 45;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(192, 0, 192);
            btnCapNhat.Location = new System.Drawing.Point(512, 351);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new System.Drawing.Size(107, 41);
            btnCapNhat.TabIndex = 44;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(33, 239);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(99, 20);
            label5.TabIndex = 41;
            label5.Text = "Đơn giá nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(33, 193);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 40;
            label4.Text = "Số lượng";
            // 
            // txtTenHangHoa
            // 
            txtTenHangHoa.Location = new System.Drawing.Point(161, 147);
            txtTenHangHoa.Name = "txtTenHangHoa";
            txtTenHangHoa.Size = new System.Drawing.Size(207, 27);
            txtTenHangHoa.TabIndex = 39;
            // 
            // txtMaHangHoa
            // 
            txtMaHangHoa.Enabled = false;
            txtMaHangHoa.Location = new System.Drawing.Point(161, 97);
            txtMaHangHoa.Name = "txtMaHangHoa";
            txtMaHangHoa.ReadOnly = true;
            txtMaHangHoa.Size = new System.Drawing.Size(207, 27);
            txtMaHangHoa.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(33, 146);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 20);
            label3.TabIndex = 37;
            label3.Text = "Tên Hàng hoá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(33, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 20);
            label2.TabIndex = 36;
            label2.Text = "Mã Hàng hoá";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Purple;
            label1.Location = new System.Drawing.Point(257, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(274, 32);
            label1.TabIndex = 35;
            label1.Text = "CẬP NHẬT HÀNG HOÁ";
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new System.Drawing.Point(161, 240);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new System.Drawing.Size(207, 27);
            txtDonGiaNhap.TabIndex = 49;
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new System.Drawing.Point(512, 240);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.Size = new System.Drawing.Size(207, 27);
            txtDonGiaBan.TabIndex = 50;
            // 
            // picAvatar
            // 
            picAvatar.Location = new System.Drawing.Point(404, 93);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new System.Drawing.Size(199, 127);
            picAvatar.TabIndex = 51;
            picAvatar.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpload.ForeColor = System.Drawing.Color.Purple;
            btnUpload.Location = new System.Drawing.Point(625, 91);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new System.Drawing.Size(94, 29);
            btnUpload.TabIndex = 52;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(33, 299);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 20);
            label6.TabIndex = 53;
            label6.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new System.Drawing.Point(161, 299);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new System.Drawing.Size(333, 93);
            txtGhiChu.TabIndex = 54;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new System.Drawing.Point(161, 191);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new System.Drawing.Size(207, 27);
            txtSoLuong.TabIndex = 55;
            // 
            // frmHangHoaUpdate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            ClientSize = new System.Drawing.Size(760, 413);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGhiChu);
            Controls.Add(label6);
            Controls.Add(btnUpload);
            Controls.Add(picAvatar);
            Controls.Add(txtDonGiaBan);
            Controls.Add(txtDonGiaNhap);
            Controls.Add(label7);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTenHangHoa);
            Controls.Add(txtMaHangHoa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmHangHoaUpdate";
            Text = "frmHangHoaUpdate";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.TextBox txtMaHangHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
    }
}