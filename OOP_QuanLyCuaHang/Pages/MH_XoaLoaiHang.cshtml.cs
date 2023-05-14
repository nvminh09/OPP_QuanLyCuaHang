using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace OOP_QuanLyCuaHang.Pages
{
    public class MH_XoaLoaiHangModel : PageModel
    {
        public string Chuoi;
        public HangHoa HangHoa;
        public bool CoLoaiHang;
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
            var lh = xuLyHangHoa.DocLoaiHang(Loai);
            if (lh != null)
            {
                HangHoa = lh.Data;
            }
            else
            {
                Chuoi = "Khong ton tai thong tin loai hang";
            }
            CoLoaiHang = (lh != null);
        }
        public void OnPost()
        {
            ServiceResult<bool> kq = xuLyHangHoa.XoaLoaiHang(Loai);
            Chuoi = $"Ket qua la {kq}";
            Response.Redirect("/MH_DanhSachHangHoa");
        }
        public MH_XoaLoaiHangModel()
        {
            xuLyHangHoa = new XuLyHangHoa();
        }
    }
}