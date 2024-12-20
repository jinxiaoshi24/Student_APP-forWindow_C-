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
    public class Khoa_BLL
    {
        public static DataTable load_dsKhoa()
        {
            return Khoa_DAL.load_DsKhoa();
        }
        public static DataTable tang_MaKhoa()
        {
            return Khoa_DAL.tang_MaKhoa();
        }
        public static DataTable load_MaKhoa()
        {
            return Khoa_DAL.Load_Makhoa();
        }

        public static DataTable Timkiem_MaKhoa(string makhoa)
        {
            return Khoa_DAL.Timkiem_MaKhoa(makhoa);
        }

        public static DataTable Timkiem_TenKhoa(string tenkhoa)
        {
            return Khoa_DAL.Timkiem_TenKhoa(tenkhoa);
        }
        public static void them_Khoa(Khoa_DTO mk)
        {
            Khoa_DAL.them_Khoa(mk);
        }
        public static void sua_Khoa(Khoa_DTO mk)
        {
            Khoa_DAL.sua_Khoa(mk);
        }
        public static void xoa_Khoa(string makhoa)
        {
            Khoa_DAL.xoa_Khoa(makhoa);
        }

        public static void Update_MK_Bang_GiaoVien(string makhoa)
        {
            Khoa_DAL.Update_MK_Bang_GiaoVien(makhoa);
        }

        public static void Update_MK_Bang_Lop(string makhoa)
        {
            Khoa_DAL.Update_MK_Bang_Lop(makhoa);

        }
    }
}
