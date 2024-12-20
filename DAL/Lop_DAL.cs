using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Lop_DAL
    {
        public static DataTable load_DsLop()
        {
            string sql = "select  * from Lop";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable tang_MaLop()
        {
            string sql = $"SELECT max(SUBSTRING(malop, 3, 5)+1)  FROM Lop";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Load_Malop()
        {
            string sql = $"select  malop from Lop";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_MaLop(string malop)
        {
            string sql = $"select  * from Lop where malop='{malop}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
            //Tìm kiếm theo tên khách hàng

        }
        public static DataTable Timkiem_TenLop(string tenlop)
        {
            DataTable dt = KetNoi.truyvan($"Select *from Lop where tenlop like N'%{tenlop}%'");
            return dt;
            //Tìm kiếm theo tên khách hàng
        }

        public static void them_Lop(Lop_DTO ml)
        {
            string sql = $"insert into Lop values(N'{ml.Malop}',N'{ml.Tenlop}','{ml.Makhoa}','{ml.Magv}')";
            KetNoi.thucthi(sql);
        }
        public static void sua_Lop(Lop_DTO ml)
        {
            string sql = $"update Lop set tenlop=N'{ml.Tenlop}',makhoa=N'{ml.Makhoa}',magv='{ml.Magv}' where malop='{ml.Malop}'";
            KetNoi.thucthi(sql);
        }
        public static void xoa_Lop(string malop)
        {
            string sql = $"delete from Lop where malop='{malop}'";
            KetNoi.thucthi(sql);
        }
        public static void Update_ML_Bang_PhanCong(string malop)
        {
            string sql = $"UPDATE PhanCong SET malop = NULL WHERE malop = '{malop}'";
            KetNoi.thucthi(sql);
        }
        public static void Update_ML_Bang_SinhVien(string malop)
        {
            string sql = $"UPDATE SinhVien SET malop = NULL WHERE malop = '{malop}'";
            KetNoi.thucthi(sql);
        }

        public static DataTable Load_Makhoa()
        {
            string sql = $"select  makhoa from Khoa";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Load_Magv()
        {
            string sql = $"select  magv from GiaoVien";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable Timkiem_LopChuNhiem(string magv)
        {
            string sql = $"select Lop.malop from Lop,GiaoVien where Lop.magv =GiaoVien.magv and GiaoVien.magv='{magv}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

    }
}
