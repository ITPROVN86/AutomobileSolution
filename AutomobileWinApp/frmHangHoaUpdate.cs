using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class frmHangHoaUpdate : Form
    {
        private OpenFileDialog openFileDialog;
        public frmHangHoaUpdate()
        {
            InitializeComponent();

            // Khởi tạo đối tượng OpenFileDialog
            openFileDialog = new OpenFileDialog();

            // Cấu hình các thuộc tính của OpenFileDialog
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
            openFileDialog.Multiselect = false;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tệp ảnh đã chọn
                string imagePath = openFileDialog.FileName;

                // Hiển thị ảnh lên PictureBox
                picAvatar.Image = Image.FromFile(imagePath);
                // Lấy đường dẫn thư mục để lưu tệp ảnh
                string directoryPath = Application.StartupPath+"/Avatar";
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                File.Copy(openFileDialog.FileName, Path.Combine(directoryPath, Path.GetFileName(openFileDialog.FileName)));
            }

        }
    }
}
