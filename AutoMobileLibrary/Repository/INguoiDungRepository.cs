﻿using AutoMobileLibrary.BussinessObject;
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
        IEnumerable<NguoiDung> GetNguoiDungs();
        IEnumerable<NguoiDung> GetNguoiDungByKeyword(string keyword);
        NguoiDung GetNguoiDungByTenDangNhap(string tenDangNhap);
        void InsertNguoiDung(NguoiDung nguoiDung);
        void UpdateNguoiDung(NguoiDung nguoiDung);
        void DeleteNguoiDung(string tenDangNhap);
    }
}
