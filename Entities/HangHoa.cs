using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HangHoa
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string LoaiHang { get; set; }
        public int HanDung { get; set; }
        public string CongTy { get; set; }
        public int NamSanXuat { get; set; }
        public int GiaBan { get; set; }
        public HangHoa()
        {
        }
        public HangHoa(string ma, string ten, string loai, int han, 
                        string cty, int nam, int gia)
        {
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) ||
                string.IsNullOrEmpty(loai) || string.IsNullOrEmpty(cty) ||
                han <= 0 || nam < 0 || gia < 0)
            {
                throw new Exception("Hang hoa da nhap khong hop le.");
            }

            MaHang = ma;
            TenHang = ten;
            LoaiHang = loai;
            HanDung = han;
            CongTy = cty;
            NamSanXuat = nam;
            GiaBan = gia;
        }
    }
}