using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace OOP_QuanLyCuaHang.Pages
{
    public class MH_ThemHangHoaModel : PageModel
    {
        public string Chuoi { get; set; }
        [BindProperty]
        public string MaHang { get; set; }
        [BindProperty]
        public string TenHang { get; set; }
        [BindProperty]
        public string LoaiHang { get; set; }
        [BindProperty]
        public int HanDung { get; set; }
        [BindProperty]
        public string CongTy { get; set; }
        [BindProperty]
        public int NamSanXuat { get; set; }
        [BindProperty]
        public int GiaBan { get; set; }

        private IXuLyHangHoa xuLyHangHoa;
        public void OnGet()
        {
        }
        public void OnPost()
        {
            try
            {
                HangHoa hh = new HangHoa(MaHang, TenHang, LoaiHang, HanDung, CongTy, NamSanXuat, GiaBan);
                var kq = xuLyHangHoa.ThemHangHoa(hh);
                if (kq.IsSuccess)
                {
                    Chuoi = "Luu tru thanh cong.";
                }
                else
                {
                    Chuoi = kq.ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }
        }
        public MH_ThemHangHoaModel()
        {
            xuLyHangHoa = new XuLyHangHoa();
        }
    }
}
