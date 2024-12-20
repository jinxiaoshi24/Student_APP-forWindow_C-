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
    public class PhanCong_BLL
    {
        public static DataTable load_DsPhanCong()
        {
            return PhanCong_DAL.load_DsPhanCong();
        }
        public static DataTable Load_MaGV()
        {
            return PhanCong_DAL.Load_MaGV();
        }
        public static DataTable Load_MaMH()
        {
            return PhanCong_DAL.Load_MaMH();
        }
        public static DataTable Load_MaLop()
        {
            return PhanCong_DAL.Load_MaLop();
        }

        public static DataTable Timkiem_MaGV(string magv)
        {
            return PhanCong_DAL.Timkiem_MaGV(magv);
        }
        public static DataTable Timkiem_MaMH(string mamh)
        {
            return PhanCong_DAL.Timkiem_MaMH(mamh);
        }
        public static DataTable Timkiem_MaLop(string malop)
        {
            return PhanCong_DAL.Timkiem_MaLop(malop);
        }

        public static void them_PhanCong(PhanCong_DTO pc)
        {
            PhanCong_DAL.them_PhanCong(pc);
        }
        public static void sua_PhanCong(PhanCong_DTO pc)
        {
            PhanCong_DAL.sua_PhanCong(pc);
        }
        public static void xoa_PhanCong(string magv, string mamh, string malop)
        {
            PhanCong_DAL.xoa_PhanCong(magv, mamh, malop);
        }
        public bool check_PhanCong(PhanCong_DTO pc1)
        {
            PhanCong_DAL phanCongDAL = new PhanCong_DAL();
            return phanCongDAL.check_PhanCong(pc1);
        }
    }
}
