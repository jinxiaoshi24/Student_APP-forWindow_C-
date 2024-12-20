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
    public class GiaoVien_BLL
    {
        public static DataTable load_DsGV()
        {
            return GiaoVien_DAL.load_DsGV();
        }
        public static DataTable Load_TaiKhoan()
        {
            return GiaoVien_DAL.Load_TaiKhoan();
        }

        public static DataTable load_MaKhoa()
        {
            return GiaoVien_DAL.Load_Makhoa();
        }
        public static DataTable tang_MaGV()
        {
            return GiaoVien_DAL.tang_MaGV();
        }
        public static DataTable Show_Name_GV(string taikhoan)
        {
            return GiaoVien_DAL.Show_Name_GV(taikhoan);
        }
        public static DataTable Load_MaGV()
        {
            return GiaoVien_DAL.Load_MaGV();
        }

        public static DataTable Timkiem_MaGV(string magv)
        {
            return GiaoVien_DAL.Timkiem_MaGV(magv);
        }

        public static DataTable Timkiem_HoTenGV(string hotengv)
        {
            return GiaoVien_DAL.Timkiem_HoTenGV(hotengv);
        }
        public static void them_GV(GiaoVien_DTO gv)
        {
            GiaoVien_DAL.them_GV(gv);
        }
        public static void sua_GV(GiaoVien_DTO gv)
        {
            GiaoVien_DAL.sua_GV(gv);
        }
        public static void xoa_GV(string magv)
        {
            GiaoVien_DAL.xoa_GV(magv);
        }

        public static void Update_magv_Bang_Lop(string magv)
        {
            GiaoVien_DAL.Update_magv_Bang_Lop(magv);
        }
        public static void Update_magv_Bang_PhanCong(string magv)
        {
            GiaoVien_DAL.Update_magv_Bang_PhanCong(magv);

        }
    }
}
