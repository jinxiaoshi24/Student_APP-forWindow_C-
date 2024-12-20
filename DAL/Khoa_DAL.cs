using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Khoa_DAL
    {
        public static DataTable load_DsKhoa()
        {
            string sql = $"select  * from Khoa";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable Load_Makhoa()
        {
            string sql = $"select  makhoa from Khoa";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable tang_MaKhoa()
        {
            string sql = $"SELECT max(SUBSTRING(makhoa,3,10)+1) FROM Khoa";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_MaKhoa(string makhoa)
        {
            string sql = $"select  * from Khoa where makhoa='{makhoa}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_TenKhoa(string tenkhoa)
        {
            DataTable dt = KetNoi.truyvan($"Select *from Khoa where tenkhoa like N'%{tenkhoa}%'");
            return dt;
        }

        public static void them_Khoa(Khoa_DTO mk)
        {
            string sql = $"insert into Khoa values(N'{mk.Makhoa}',N'{mk.Tenkhoa}')";
            KetNoi.thucthi(sql);
        }
        public static void sua_Khoa(Khoa_DTO mk)
        {
            string sql = $"update Khoa set tenkhoa=N'{mk.Tenkhoa}' where makhoa='{mk.Makhoa}'";
            KetNoi.thucthi(sql);
        }
        public static void xoa_Khoa(string makhoa)
        {
            string sql = $"delete from Khoa where makhoa='{makhoa}'";
            KetNoi.thucthi(sql);
        }
        public static void Update_MK_Bang_GiaoVien(string makhoa)
        {
            string sql = $"UPDATE GiaoVien SET makhoa = NULL WHERE makhoa = '{makhoa}'";
            KetNoi.thucthi(sql);
        }

        public static void Update_MK_Bang_Lop(string makhoa)
        {
            string sql = $"UPDATE Lop SET makhoa = NULL WHERE makhoa = '{makhoa}'";
            KetNoi.thucthi(sql);
        }

    }
}
