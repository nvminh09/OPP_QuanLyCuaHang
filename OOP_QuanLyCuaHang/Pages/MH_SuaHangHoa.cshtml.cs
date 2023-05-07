using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace OOP_QuanLyCuaHang.Pages
{
    public class MH_SuaHangHoaModel : PageModel
    {
        public string Chuoi { get; set; }
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
        public HangHoa HangHoa;
        public void OnGet()
        {
            if (string.IsNullOrEmpty(MaHH))
            {
                Chuoi = "Ma hang hoa khong phu hop.";
            }
            else
            {
                var kq = xuLyHangHoa.DocHangHoa(MaHH);
                if (kq.IsSuccess)
                {
                    HangHoa = kq.Data;
                }
                else
                {
                    HangHoa = null;
                    Chuoi = kq.ErrorMessage;
                }
            }
        }
        public void OnPost()
        {
            try
            {
                HangHoa hh = new HangHoa(MaHH, Ten, Loai, Han, CongTy, Nam, Gia);
                var kq = xuLyHangHoa.SuaHangHoa(hh);
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
        public MH_SuaHangHoaModel()
        {
            xuLyHangHoa = new XuLyHangHoa();
        }
    }
}
