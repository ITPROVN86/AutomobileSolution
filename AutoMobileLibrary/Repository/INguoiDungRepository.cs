using AutoMobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLibrary.Repository
{
    public interface INguoiDungRepository
    {
        NguoiDung GetNguoiDungLogin(string TenDangNhap, string MatKhau);
    }
}
