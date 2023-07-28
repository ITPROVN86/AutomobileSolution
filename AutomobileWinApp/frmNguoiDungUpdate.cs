﻿using AutoMobileLibrary.App_Code;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace AutomobileWinApp
{
    public partial class frmNguoiDungUpdate : Form
    {
        public INguoiDungRepository NguoiDungRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//True Update
        public NguoiDung NguoiDungInfo { get; set; }

        List<LoaiNguoiDung> loaiNguoiDung;
        public frmNguoiDungUpdate()
        {
            InitializeComponent();

            loaiNguoiDung = new List<LoaiNguoiDung>()
            {
                new LoaiNguoiDung(){Id= 1 ,Name = "Quản trị"},
                new LoaiNguoiDung(){Id= 2 ,Name = "Khách hàng"},
                new LoaiNguoiDung(){Id= 3 ,Name = "Nhân viên"}
            };
            cboLoaiNguoiDung.DataSource = loaiNguoiDung;
            cboLoaiNguoiDung.DisplayMember = "Name";
            cboLoaiNguoiDung.ValueMember = "Id";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = new NguoiDung
                {
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = Common.EncryptMD5(txtMatKhau.Text),
                    LoaiNguoiDung = Convert.ToInt32(cboLoaiNguoiDung.SelectedValue),
                    MaNguoiDung = Convert.ToInt32(txtMaNguoiDung.Text)
                };
                if (InsertOrUpdate == false)
                {
                    NguoiDungRepository.InsertNguoiDung(kh);

                    if (MessageBox.Show("Bạn đã tạo mới thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((frmNguoiDung)this.Owner).LoadNguoiDungList();
                    }
                }
                else
                {
                    NguoiDungRepository.UpdateNguoiDung(kh);
                    if (MessageBox.Show("Bạn đã cập nhật thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((frmNguoiDung)this.Owner).LoadNguoiDungList();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmNguoiDungUpdate_Load(object sender, EventArgs e)
        {
            //If Update is true then fill data into form
            if (InsertOrUpdate == true)
            {
                txtTenDangNhap.Text = NguoiDungInfo.TenDangNhap.ToString();
                //txtMatKhau.Text = NguoiDungInfo.TenKhachHang.ToString();
                txtMaNguoiDung.Text = NguoiDungInfo.MaNguoiDung.ToString();
                cboLoaiNguoiDung.SelectedValue = NguoiDungInfo.LoaiNguoiDung;
            }
        }
    }
}
