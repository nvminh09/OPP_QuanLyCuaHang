﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public interface ILuuTruHangHoa
    {
        void LuuHangHoa(HangHoa hang);
        List<HangHoa> TimKiemHang(string tuKhoa);
        HangHoa DocHangHoa(string maHH);
        void SuaHangHoa(HangHoa hh);
        HangHoa TimHangHoaBangTen(string tenHH);
        HangHoa TimHangHoaBangMa(string maHH);
        bool XoaHangHoa(string MaHH);
        HangHoa DocLoaiHang(string loaiHang);
        bool XoaLoaiHang(string loaiHang);
    }
}
