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
    public partial class frmHangHoa : Form
    {
        IHangHoaRepository hangHoaRepository = new HangHoaRepository();
        BindingSource source;
        HangHoa hh;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            var hangHoas = hangHoaRepository.GetHangHoaByKeyword(txtTuKhoa.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = hangHoas;

                dgvHangHoa.DataSource = null;
                dgvHangHoa.DataSource = source;
                if (hangHoas.Count() == 0)
                {
                    btnXoa.Enabled = false;
                    btnChinhSua.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnChinhSua.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTuKhoa_TextChanged(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmHangHoaUpdate frmHangHoaUpdate = new frmHangHoaUpdate()
            {
                Text = "Cập nhật Hàng hoá",
                InsertOrUpdate = false,
                HangHoaInfo = hh,
                HangHoaRepository = hangHoaRepository
            };
            frmHangHoaUpdate.Owner = this;
            if (frmHangHoaUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadHangHoaList();
                source.Position = source.Count - 1;
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            frmHangHoaUpdate frmHangHoaUpdate = new frmHangHoaUpdate()
            {
                Text = "Cập nhật Hàng hoá",
                InsertOrUpdate = true,
                HangHoaInfo = hh,
                HangHoaRepository = hangHoaRepository
            };
            frmHangHoaUpdate.Owner = this;
            if (frmHangHoaUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadHangHoaList();
                source.Position = source.Count - 1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                hangHoaRepository.DeleteHangHoa(hh.MaHangHoa);
                LoadHangHoaList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            LoadHangHoaList();
        }

        public void LoadHangHoaList()
        {
            var hangHoas = hangHoaRepository.GetHangHoas();
            try
            {
                source = new BindingSource();
                source.DataSource = hangHoas;

                dgvHangHoa.DataSource = null;
                dgvHangHoa.DataSource = source;
                if (hangHoas.Count() == 0)
                {
                    btnXoa.Enabled = false;
                    btnChinhSua.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnChinhSua.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvHangHoa.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
                hh = new HangHoa()
                {
                    MaHangHoa = Convert.ToInt32(row.Cells[0].Value),
                    TenHangHoa = row.Cells[1].Value.ToString(),
                    SoLuong = Convert.ToInt32(row.Cells[2].Value.ToString()),
                    DonGiaNhap = Convert.ToDecimal(row.Cells[3].Value.ToString()),
                    DonGiaBan = Convert.ToDecimal(row.Cells[4].Value.ToString()),
                    Anh = row.Cells[5].Value.ToString(),
                    GhiChu = row.Cells[5].Value.ToString()
                };
            }
        }

        private void dgvHangHoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChinhSua_Click(sender, e);
        }
    }
}
