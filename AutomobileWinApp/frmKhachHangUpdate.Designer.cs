namespace AutomobileWinApp
{
    partial class frmKhachHangUpdate
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
            label1 = new System.Windows.Forms.Label();
            txtDienThoai = new System.Windows.Forms.MaskedTextBox();
            txtDiaChi = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtTenKhach = new System.Windows.Forms.TextBox();
            txtMaKhach = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnCapNhat = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Purple;
            label1.Location = new System.Drawing.Point(67, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(305, 32);
            label1.TabIndex = 2;
            label1.Text = "CẬP NHẬT KHÁCH HÀNG";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new System.Drawing.Point(182, 231);
            txtDienThoai.Mask = "(00)000.000.000";
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new System.Drawing.Size(207, 27);
            txtDienThoai.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new System.Drawing.Point(182, 181);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new System.Drawing.Size(207, 27);
            txtDiaChi.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(35, 234);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 20);
            label5.TabIndex = 15;
            label5.Text = "Điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(35, 188);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 20);
            label4.TabIndex = 14;
            label4.Text = "Địa chỉ";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new System.Drawing.Point(182, 138);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new System.Drawing.Size(207, 27);
            txtTenKhach.TabIndex = 13;
            // 
            // txtMaKhach
            // 
            txtMaKhach.Enabled = false;
            txtMaKhach.Location = new System.Drawing.Point(182, 88);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.ReadOnly = true;
            txtMaKhach.Size = new System.Drawing.Size(207, 27);
            txtMaKhach.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(35, 141);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 20);
            label3.TabIndex = 11;
            label3.Text = "Tên Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 20);
            label2.TabIndex = 10;
            label2.Text = "Mã Khách hàng";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(192, 0, 192);
            btnCapNhat.Location = new System.Drawing.Point(182, 299);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new System.Drawing.Size(107, 41);
            btnCapNhat.TabIndex = 18;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThoat.ForeColor = System.Drawing.Color.FromArgb(192, 0, 192);
            btnThoat.Location = new System.Drawing.Point(295, 299);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(94, 41);
            btnThoat.TabIndex = 19;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmKhachHangUpdate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            ClientSize = new System.Drawing.Size(436, 361);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(txtDienThoai);
            Controls.Add(txtDiaChi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTenKhach);
            Controls.Add(txtMaKhach);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKhachHangUpdate";
            Text = "frmKhachHangUpdate";
            Load += frmKhachHangUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
    }
}