using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public interface IXuLyHangHoa
    {
        List<HangHoa> TimKiemHang(string tuKhoa);
        ServiceResult<bool> ThemHangHoa(HangHoa hh);       
        ServiceResult<HangHoa> DocHangHoa(string maHH);
        ServiceResult<bool> SuaHangHoa(HangHoa hh);
    }
}