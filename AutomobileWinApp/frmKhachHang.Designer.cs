namespace AutomobileWinApp
{
    partial class frmKhachHang
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
            dgvKhachHang = new System.Windows.Forms.DataGridView();
            txtTimKiem = new System.Windows.Forms.Button();
            txtTuKhoa = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnThem = new System.Windows.Forms.Button();
            btnChinhSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Purple;
            label1.Location = new System.Drawing.Point(228, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(287, 32);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new System.Drawing.Point(34, 146);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 29;
            dgvKhachHang.Size = new System.Drawing.Size(716, 230);
            dgvKhachHang.TabIndex = 10;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTimKiem.ForeColor = System.Drawing.Color.Purple;
            txtTimKiem.Location = new System.Drawing.Point(633, 87);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(117, 38);
            txtTimKiem.TabIndex = 11;
            txtTimKiem.Text = "Tìm kiếm";
            txtTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new System.Drawing.Point(228, 90);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new System.Drawing.Size(368, 27);
            txtTuKhoa.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(34, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(154, 20);
            label2.TabIndex = 13;
            label2.Text = "Từ khoá cần tìm kiếm:";
            // 
            // btnThem
            // 
            btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThem.ForeColor = System.Drawing.Color.Purple;
            btnThem.Location = new System.Drawing.Point(34, 398);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(123, 40);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            btnChinhSua.Enabled = false;
            btnChinhSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnChinhSua.ForeColor = System.Drawing.Color.Purple;
            btnChinhSua.Location = new System.Drawing.Point(228, 398);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new System.Drawing.Size(130, 40);
            btnChinhSua.TabIndex = 15;
            btnChinhSua.Text = "Chỉnh sửa";
            btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoa.ForeColor = System.Drawing.Color.Purple;
            btnXoa.Location = new System.Drawing.Point(434, 398);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(117, 40);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThoat.ForeColor = System.Drawing.Color.Purple;
            btnThoat.Location = new System.Drawing.Point(637, 398);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(113, 40);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            ClientSize = new System.Drawing.Size(779, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnChinhSua);
            Controls.Add(btnThem);
            Controls.Add(label2);
            Controls.Add(txtTuKhoa);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvKhachHang);
            Controls.Add(label1);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}