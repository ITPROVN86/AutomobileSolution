using AutoMobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLibrary.Repository
{
    public interface IKhachHangRepository
    {
        IEnumerable<KhachHang> GetKhachHangs();
        IEnumerable<KhachHang> GetKhachHangByKeyword(string keyword);
        KhachHang GetKhachHangByID(int khachHangId);
        void InsertKhachHang(KhachHang khachHang);
        void UpdateKhachHang(KhachHang khachHang);
        void DeleteKhachHang(int khachHangId);
    }
}
