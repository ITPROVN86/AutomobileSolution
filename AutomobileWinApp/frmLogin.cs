using AutoMobileLibrary.App_Code;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutomobileWinApp
{
    public partial class frmLogin : Form
    {
        public INguoiDungRepository NguoiDungRepository { get; set; }
        INguoiDungRepository nguoiDungRepository = new NguoiDungRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenDangNhap.Text))
                {
                    errorProvider1.SetError(txtTenDangNhap, "Vui lòng nhập tên đăng nhập");
                    return;
                }
                if (string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                    // Thực hiện xử lý đăng nhập ở đây
                    var nguoiDung = GetNguoiDungObject();
                    var user = nguoiDungRepository.GetNguoiDungLogin(nguoiDung.TenDangNhap, Common.EncryptMD5(nguoiDung.MatKhau));
                    if (user != null)
                    {
                        this.Visible = false;
                        if (MessageBox.Show("Bạn đã đăng nhập thành công", "Thông tin") == DialogResult.OK)
                        {
                            Common.WriteLog("Login", "btnDangNhap_Click", nguoiDung.TenDangNhap+ " đăng nhập hệ thống");
                            frmMain f_main = new frmMain();
                            f_main.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã đăng nhập thất bại", "Thông tin");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private NguoiDung GetNguoiDungObject()
        {
            NguoiDung nguoiDung = null;
            try
            {
                nguoiDung = new NguoiDung()
                {
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return nguoiDung;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
                txtTenDangNhap.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
                txtMatKhau.Focus();
            }
        }

    }
}
