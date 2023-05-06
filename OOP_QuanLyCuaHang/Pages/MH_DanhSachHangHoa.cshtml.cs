using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace OOP_QuanLyCuaHang.Pages
{
    public class MH_DanhSachHangHoaModel : PageModel
    {
        [BindProperty]
        public string TuKhoa { get; set; }
        public List<HangHoa> DanhSachHangHoa;
        private IXuLyHangHoa xuLyHangHoa;
        public void OnGet()
        {
            DanhSachHangHoa = xuLyHangHoa.TimKiemHang(string.Empty);
        }
        public void OnPost()
        {
            DanhSachHangHoa = xuLyHangHoa.TimKiemHang(TuKhoa);
        }
        public MH_DanhSachHangHoaModel()
        {
            xuLyHangHoa = new XuLyHangHoa();
            DanhSachHangHoa = new List<HangHoa>();
        }
    }
}