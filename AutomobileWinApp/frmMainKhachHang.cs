using AutoMobileLibrary.BussinessObject;
using AutoMobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class frmMainKhachHang : Form
    {
        public NguoiDung NguoiDungInfo { get; set; }
        public IKhachHangRepository khachHangRepository = new KhachHangRepository();
        public frmMainKhachHang()
        {
            InitializeComponent();

        }

        private void mnu_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnu_SanPham_Click(object sender, EventArgs e)
        {
            frmSanPham f_SP = new frmSanPham();
            f_SP.MdiParent = this;
            f_SP.Show();
        }

        private void frmMainKhachHang_Load(object sender, EventArgs e)
        {
            mnu_Chao.Text = "Chào: " + khachHangRepository.GetKhachHangByID(Convert.ToInt32(NguoiDungInfo.MaNguoiDung)).TenKhachHang;
        }
    }
}
