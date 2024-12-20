using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class SinhVien_BLL
    {
        public static DataTable load_DsSV()
        {
            return SinhVien_DAL.load_DsSV();
        }
        public static DataTable Load_TaiKhoan()
        {
            return SinhVien_DAL.Load_TaiKhoan();
        }
        public static DataTable load_Malop()
        {
            return SinhVien_DAL.Load_Malop();
        }
        public static DataTable tang_MaSV()
        {
            return SinhVien_DAL.tang_MaSV();
        }
        public static DataTable Load_MaSV()
        {
            return SinhVien_DAL.Load_MaSV();
        }
        public static DataTable Show_Name_SV(string taikhoan)
        {
            return SinhVien_DAL.Show_Name_SV(taikhoan);
        }

        public static DataTable Timkiem_MaSV(string masv)
        {
            return SinhVien_DAL.Timkiem_MaSV(masv);
        }

        public static DataTable Timkiem_HoTenSV(string hotensv)
        {
            return SinhVien_DAL.Timkiem_HoTenSV(hotensv);
        }
        public static void them_SV(SinhVien_DTO sv)
        {
            SinhVien_DAL.them_SV(sv);
        }
        public static void sua_SV(SinhVien_DTO sv)
        {
            SinhVien_DAL.sua_SV(sv);
        }
        public static void xoa_SV(string masv)
        {
            SinhVien_DAL.xoa_SV(masv);
        }
        public static void xoa_SV_Bang_Diem(string masv)
        {
            SinhVien_DAL.xoa_SV_Bang_Diem(masv);

        }
        public static DataTable Load_SV_Theo_GV(string magv)
        {
            return SinhVien_DAL.Load_SV_Theo_GV(magv);
        }
        public static DataTable Load_DS_SV_Theo_GV(string malop)
        {
            return SinhVien_DAL.Load_DS_SV_Theo_GV(malop);
        }
    }
}