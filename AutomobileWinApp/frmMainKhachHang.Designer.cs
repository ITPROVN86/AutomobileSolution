namespace AutomobileWinApp
{
    partial class frmMainKhachHang
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            tệpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnu_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            mnu_SanPham = new System.Windows.Forms.ToolStripMenuItem();
            mnu_Chao = new System.Windows.Forms.ToolStripMenuItem();
            mnu_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tệpTinToolStripMenuItem, mnu_SanPham, mnu_Chao });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpTinToolStripMenuItem
            // 
            tệpTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnu_Thoat });
            tệpTinToolStripMenuItem.Name = "tệpTinToolStripMenuItem";
            tệpTinToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
            tệpTinToolStripMenuItem.Text = "Tệp tin";
            // 
            // mnu_Thoat
            // 
            mnu_Thoat.Name = "mnu_Thoat";
            mnu_Thoat.Size = new System.Drawing.Size(130, 26);
            mnu_Thoat.Text = "Thoát";
            mnu_Thoat.Click += mnu_Thoat_Click;
            // 
            // mnu_SanPham
            // 
            mnu_SanPham.Name = "mnu_SanPham";
            mnu_SanPham.Size = new System.Drawing.Size(89, 27);
            mnu_SanPham.Text = "Sản phẩm";
            mnu_SanPham.Click += mnu_SanPham_Click;
            // 
            // mnu_Chao
            // 
            mnu_Chao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnu_DangXuat });
            mnu_Chao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mnu_Chao.ForeColor = System.Drawing.Color.FromArgb(192, 0, 192);
            mnu_Chao.Name = "mnu_Chao";
            mnu_Chao.Size = new System.Drawing.Size(64, 27);
            mnu_Chao.Text = "Chào";
            // 
            // mnu_DangXuat
            // 
            mnu_DangXuat.Name = "mnu_DangXuat";
            mnu_DangXuat.Size = new System.Drawing.Size(224, 28);
            mnu_DangXuat.Text = "Đăng xuất";
            mnu_DangXuat.Click += mnu_DangXuat_Click;
            // 
            // frmMainKhachHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMainKhachHang";
            Text = "frmMainKhachHang";
            Load += frmMainKhachHang_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tệpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnu_SanPham;
        private System.Windows.Forms.ToolStripMenuItem mnu_Chao;
        private System.Windows.Forms.ToolStripMenuItem mnu_DangXuat;
    }
}