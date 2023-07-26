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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnu_NhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f_NV = new frmNhanVien();
            f_NV.MdiParent = this;
            f_NV.Show();
        }
    }
}
