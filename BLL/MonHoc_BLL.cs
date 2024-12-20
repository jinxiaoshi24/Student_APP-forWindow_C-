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
    public class MonHoc_BLL
    {
        public static DataTable load_dsMonHoc()
        {
            return MonHoc_DAL.load_DsMonHoc();
        }
        public static DataTable tang_MaMonHoc()
        {
            return MonHoc_DAL.tang_MaMH();
        }
        public static DataTable load_MaMH()
        {
            return MonHoc_DAL.Load_MaMH();
        }

        public static DataTable Timkiem_MaMH(string mamh)
        {
            return MonHoc_DAL.Timkiem_MaMH(mamh);
        }

        public static DataTable Timkiem_TenMH(string tenmh)
        {
            return MonHoc_DAL.Timkiem_TenMH(tenmh);
        }
        public static void them_MonHoc(MonHoc_DTO mmh)
        {
            MonHoc_DAL.them_MH(mmh);
        }
        public static void sua_MonHoc(MonHoc_DTO mmh)
        {
            MonHoc_DAL.sua_MH(mmh);
        }
        public static void xoa_MonHoc(string mamh)
        {
            MonHoc_DAL.xoa_MH(mamh);
        }
        public static void Update_MH_Bang_PhanCong(string mamh)
        {
            MonHoc_DAL.Update_MH_Bang_PhanCong(mamh);
        }
        public static void Update_MH_Bang_Diem(string mamh)
        {
            MonHoc_DAL.Update_MH_Bang_Diem(mamh);
        }
        public static DataTable Load_MH_Theo_GV(string magv)
        {
            return MonHoc_DAL.Load_MH_Theo_GV(magv);
        }

    }
}
