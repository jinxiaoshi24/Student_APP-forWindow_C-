using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class Lop_BLL
    {
        public static DataTable load_dsLop()
        {
            return Lop_DAL.load_DsLop();
        }
        public static DataTable tang_MaLop()
        {
            return Lop_DAL.tang_MaLop();
        }
        public static DataTable load_MaLop()
        {
            return Lop_DAL.Load_Malop();
        }
        public static DataTable load_MaKhoa()
        {
            return Lop_DAL.Load_Makhoa();
        }

        public static DataTable Load_Magv()
        {
            return Lop_DAL.Load_Magv();

        }
        public static DataTable Timkiem_MaLop(string malop)
        {
            return Lop_DAL.Timkiem_MaLop(malop);
        }

        public static DataTable Timkiem_TenKhoa(string tenlop)
        {
            return Lop_DAL.Timkiem_TenLop(tenlop);
        }
        public static void them_Lop(Lop_DTO ml)
        {
            Lop_DAL.them_Lop(ml);
        }
        public static void sua_Lop(Lop_DTO ml)
        {
            Lop_DAL.sua_Lop(ml);
        }
        public static void xoa_Lop(string malop)
        {
            Lop_DAL.xoa_Lop(malop);
        }

        public static void Update_ML_Bang_PhanCong(string malop)
        {
            Lop_DAL.Update_ML_Bang_PhanCong(malop);
        }
        public static void Update_ML_Bang_SinhVien(string malop)
        {
            Lop_DAL.Update_ML_Bang_SinhVien(malop);
        }
        public static DataTable Timkiem_LopChuNhiem(string magv)
        {
            return Lop_DAL.Timkiem_LopChuNhiem(magv);
        }
    }
}