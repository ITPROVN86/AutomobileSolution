using AutoMobileLibrary.BussinessObject;
using AutoMobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class frmKhachHangUpdate : Form
    {
        public IKhachHangRepository KhachHangRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//True Update
        public KhachHang KhachHangInfo { get; set; }
        public frmKhachHangUpdate()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = new KhachHang
                {
                    MaKhachHang = Convert.ToInt32(txtMaKhach.Text == "" ? 0 : txtMaKhach.Text),
                    TenKhachHang = txtTenKhach.Text,
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtDienThoai.Text
                };
                if (InsertOrUpdate == false)
                {
                    KhachHangRepository.InsertKhachHang(kh);
                    
                    if(MessageBox.Show("Bạn đã tạo mới thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((frmKhachHang)this.Owner).LoadKhachHangList();
                    }
                }
                else
                {
                    KhachHangRepository.UpdateKhachHang(kh);
                    if (MessageBox.Show("Bạn đã cập nhật thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((frmKhachHang)this.Owner).LoadKhachHangList();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmKhachHangUpdate_Load(object sender, EventArgs e)
        {
            //If Update is true then fill data into form
            if (InsertOrUpdate == true)
            {
                txtMaKhach.Text = KhachHangInfo.MaKhachHang.ToString();
                txtTenKhach.Text = KhachHangInfo.TenKhachHang.ToString();
                txtDiaChi.Text = KhachHangInfo.DiaChi.ToString();
                txtDienThoai.Text = KhachHangInfo.DienThoai.ToString();
            }
        }
    }
}
