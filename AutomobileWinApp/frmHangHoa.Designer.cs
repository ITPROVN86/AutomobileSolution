﻿namespace AutomobileWinApp
{
    partial class frmHangHoa
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
            btnXoa = new System.Windows.Forms.Button();
            btnChinhSua = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            dgvHangHoa = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            txtTuKhoa = new System.Windows.Forms.TextBox();
            txtTimKiem = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThoat.ForeColor = System.Drawing.Color.Purple;
            btnThoat.Location = new System.Drawing.Point(645, 388);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(113, 40);
            btnThoat.TabIndex = 32;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoa.ForeColor = System.Drawing.Color.Purple;
            btnXoa.Location = new System.Drawing.Point(448, 388);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(117, 40);
            btnXoa.TabIndex = 31;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnChinhSua
            // 
            btnChinhSua.Enabled = false;
            btnChinhSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnChinhSua.ForeColor = System.Drawing.Color.Purple;
            btnChinhSua.Location = new System.Drawing.Point(236, 388);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new System.Drawing.Size(130, 40);
            btnChinhSua.TabIndex = 30;
            btnChinhSua.Text = "Chỉnh sửa";
            btnChinhSua.UseVisualStyleBackColor = true;
            btnChinhSua.Click += btnChinhSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThem.ForeColor = System.Drawing.Color.Purple;
            btnThem.Location = new System.Drawing.Point(42, 388);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(123, 40);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Location = new System.Drawing.Point(42, 134);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.RowTemplate.Height = 29;
            dgvHangHoa.Size = new System.Drawing.Size(716, 230);
            dgvHangHoa.TabIndex = 28;
            dgvHangHoa.CellClick += dgvHangHoa_CellClick;
            dgvHangHoa.CellDoubleClick += dgvHangHoa_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(154, 20);
            label2.TabIndex = 27;
            label2.Text = "Từ khoá cần tìm kiếm:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new System.Drawing.Point(236, 86);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new System.Drawing.Size(368, 27);
            txtTuKhoa.TabIndex = 26;
            txtTuKhoa.TextChanged += txtTuKhoa_TextChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTimKiem.ForeColor = System.Drawing.Color.Purple;
            txtTimKiem.Location = new System.Drawing.Point(641, 83);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(117, 29);
            txtTimKiem.TabIndex = 25;
            txtTimKiem.Text = "Tìm kiếm";
            txtTimKiem.UseVisualStyleBackColor = true;
            txtTimKiem.Click += txtTimKiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Purple;
            label1.Location = new System.Drawing.Point(236, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(256, 32);
            label1.TabIndex = 24;
            label1.Text = "QUẢN LÝ HÀNG HOÁ";
            // 
            // frmHangHoa
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnChinhSua);
            Controls.Add(btnThem);
            Controls.Add(dgvHangHoa);
            Controls.Add(label2);
            Controls.Add(txtTuKhoa);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Name = "frmHangHoa";
            Text = "frmHangHoa";
            Load += frmHangHoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button txtTimKiem;
        private System.Windows.Forms.Label label1;
    }
}