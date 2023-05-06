using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entities;
using Newtonsoft.Json;

namespace DAL
{
    public class LuuTruHangHoa : ILuuTruHangHoa
    {
        string LUU_HANG_HOA = "C:\\Users\\Minh\\VB2 CNTT\\PP Lap trinh huong doi tuong\\OOP_QuanLyCuaHang\\HangHoa.json";
        public List<HangHoa> DocDanhSachHangHoa()
        {
            StreamReader file = new StreamReader(LUU_HANG_HOA);
            string jsonString = file.ReadToEnd();
            file.Close();
            var result = JsonConvert.DeserializeObject<List<HangHoa>>(jsonString);
            return result;
        }
        public void LuuTruDanhSachHangHoa(List<HangHoa> l)
        {
            StreamWriter writer = new StreamWriter(LUU_HANG_HOA);
            string jsonString = JsonConvert.SerializeObject(l);
            writer.Write(jsonString);
            writer.Close();
        }
        public void LuuHangHoa(HangHoa hh)
        {
            var ds = DocDanhSachHangHoa();
            ds.Add(hh);
            LuuTruDanhSachHangHoa(ds);
        }

        public void SuaHangHoa(HangHoa hhSua)
        {
            var ds = DocDanhSachHangHoa();
            foreach (var hh in ds)
            {
                if (hh.MaHang == hhSua.MaHang)
                {
                    hh.TenHang = hhSua.TenHang;
                    hh.GiaBan = hhSua.GiaBan;
                }
            }
            LuuTruDanhSachHangHoa(ds);
        }
        public List<HangHoa> TimKiemHang(string tuKhoa)
        {
            var dshh = DocDanhSachHangHoa();
            var kq = new List<HangHoa>();
            foreach (var hh in dshh)
            {
                if (hh.TenHang.Contains(tuKhoa))
                {
                    kq.Add(hh);
                }
            }
            return kq;
        }
        public HangHoa DocHangHoa(string mahh)
        {
            var dshh = DocDanhSachHangHoa();
            foreach (var hh in dshh)
            {
                if (hh.MaHang == mahh)
                {
                    return hh;
                }
            }
            return null;
        }
        public HangHoa TimHangHoaBangTen(string ten)
        {
            var ds = DocDanhSachHangHoa();
            foreach (var hh in ds)
            {
                if (hh.TenHang == ten)
                {
                    return hh;
                }
            }
            return null;
        }
    }
}
