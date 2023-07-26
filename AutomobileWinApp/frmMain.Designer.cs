namespace AutomobileWinApp
{
    partial class frmMain
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
            danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnu_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            hoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnu_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tệpTinToolStripMenuItem, danhMụcToolStripMenuItem, hoáĐơnToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpTinToolStripMenuItem
            // 
            tệpTinToolStripMenuItem.Name = "tệpTinToolStripMenuItem";
            tệpTinToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            tệpTinToolStripMenuItem.Text = "Tệp tin";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnu_NhanVien, mnu_KhachHang });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            danhMụcToolStripMenuItem.Text = "Quản lý";
            // 
            // mnu_NhanVien
            // 
            mnu_NhanVien.Name = "mnu_NhanVien";
            mnu_NhanVien.Size = new System.Drawing.Size(224, 26);
            mnu_NhanVien.Text = "QL Nhân viên";
            mnu_NhanVien.Click += mnu_NhanVien_Click;
            // 
            // hoáĐơnToolStripMenuItem
            // 
            hoáĐơnToolStripMenuItem.Name = "hoáĐơnToolStripMenuItem";
            hoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            hoáĐơnToolStripMenuItem.Text = "Hoá đơn";
            // 
            // mnu_KhachHang
            // 
            mnu_KhachHang.Name = "mnu_KhachHang";
            mnu_KhachHang.Size = new System.Drawing.Size(224, 26);
            mnu_KhachHang.Text = "QL Khách hàng";
            mnu_KhachHang.Click += mnu_KhachHang_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tệpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem hoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_KhachHang;
    }
}