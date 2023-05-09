using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace OOP_QuanLyCuaHang.Pages
{
    public class MH_XoaHangHoaModel : PageModel
    {
        public string Chuoi;
        public HangHoa HangHoa;
        public bool CoHangHoa;
        [BindProperty(SupportsGet = true)]
        public string MaHH { get; set; }
        [BindProperty]
        public string Ten { get; set; }
        [BindProperty]
        public string Loai { get; set; }
        [BindProperty]
        public int Han { get; set; }
        [BindProperty]
        public string CongTy { get; set; }
        [BindProperty]
        public int Nam { get; set; }
        [BindProperty]
        public int Gia { get; set; }

        private IXuLyHangHoa xuLyHangHoa;
        public void OnGet()
        {
            var hh = xuLyHangHoa.DocHangHoa(MaHH);
            if (hh != null)
            {
                HangHoa = hh.Data;
            }
            else
            {
                Chuoi = "Khong ton tai thong tin hang hoa";
            }
            CoHangHoa = (hh != null);
        }
        public void OnPost()
        {
            ServiceResult<bool> kq = xuLyHangHoa.XoaHangHoa(MaHH);
            Chuoi = $"Ket qua la {kq}";
            Response.Redirect("/MH_DanhSachHangHoa");
        }
        public MH_XoaHangHoaModel()
        {
            xuLyHangHoa = new XuLyHangHoa();
        }
    }
}