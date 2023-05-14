using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace Services
{
    public class XuLyHangHoa : IXuLyHangHoa
    {
        private ILuuTruHangHoa luuTruHangHoa;
        public XuLyHangHoa()
        {
            luuTruHangHoa = new LuuTruHangHoa();
        }
        public ServiceResult<bool> ThemHangHoa(HangHoa h)
        {
            try
            {
                // Kiem tra tinh hop le cua du lieu
                // dam bao ma hang hoa la duy nhat
                var hh = luuTruHangHoa.TimHangHoaBangMa(h.MaHang);
                /*if (hh != null)
                {
                    var error = new ServiceError()
                    {
                        ErrorMessage = "Ton tai hang hoa trung ma.",
                        ErrorCode = "DUPLICATED_ERROR"
                    };
                }*/
                if (hh == null)
                {
                    luuTruHangHoa.LuuHangHoa(h);
                }
                if (hh != null)
                {
                    var error = new ServiceError()
                    {
                        ErrorMessage = "Ton tai hang hoa trung ma.",
                        //ErrorCode = "DUPLICATED_ERROR"
                    };
                }
                return new ServiceResult<bool>(true, true, string.Empty);
            }
            catch (Exception ex)
            {
                var error = new ServiceError()
                {
                    ErrorMessage = ex.Message,
                    //ErrorCode = "GENERAL_ERROR"
                };
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        public ServiceResult<bool> SuaHangHoa(HangHoa hh)
        {
            try
            {
                luuTruHangHoa.SuaHangHoa(hh);
                return new ServiceResult<bool>(true, true, string.Empty);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        public ServiceResult<HangHoa> DocHangHoa(string maHH)
        {
            try
            {
                var hh = luuTruHangHoa.DocHangHoa(maHH);
                if (hh != null)
                {
                    return new ServiceResult<HangHoa>(true, hh, string.Empty);
                }
                else
                {
                    return new ServiceResult<HangHoa>(false, null, "San pham khong ton tai.");
                }
            }
            catch (Exception ex)
            {
                return new ServiceResult<HangHoa>(false, null, ex.Message);
            }
        }
        public ServiceResult<HangHoa> DocLoaiHang(string loaiHang)
        {
            try
            {
                var lh = luuTruHangHoa.DocLoaiHang(loaiHang);
                if (lh != null)
                {
                    return new ServiceResult<HangHoa>(true, lh, string.Empty);
                }
                else
                {
                    return new ServiceResult<HangHoa>(false, null, "Loai hang khong ton tai.");
                }
            }
            catch (Exception ex)
            {
                return new ServiceResult<HangHoa>(false, null, ex.Message);
            }
        }
        public List<HangHoa> TimKiemHang(string tuKhoa)
        {
            try
            {
                if (tuKhoa == null)
                {
                    tuKhoa = string.Empty;
                }
                return luuTruHangHoa.TimKiemHang(tuKhoa);
            }
            catch (Exception ex)
            {
                // Khi log exception
                return new List<HangHoa>();
            }
        }
        public ServiceResult<bool> XoaHangHoa(string hh)
        {
            try
            {
                luuTruHangHoa.XoaHangHoa(hh);
                return new ServiceResult<bool>(true, true, string.Empty);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        
        public ServiceResult<bool> XoaLoaiHang(string lh)
        {
            try
            {
                luuTruHangHoa.XoaLoaiHang(lh);
                return new ServiceResult<bool>(true, true, string.Empty);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
    }
}
