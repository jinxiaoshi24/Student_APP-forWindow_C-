using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class MonHoc_DAL
    {
        public static DataTable load_DsMonHoc()
        {
            string sql = "select  * from MonHoc";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable Load_MaMH()
        {
            string sql = $"select  mamh from MonHoc";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_MaMH(string mamh)
        {
            string sql = $"select  * from MonHoc where mamh='{mamh}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
            //Tìm kiếm theo tên khách hàng

        }
        public static DataTable tang_MaMH()
        {
            string sql = $"SELECT max(SUBSTRING(mamh, 3, 5)+1)  FROM MonHoc";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_TenMH(string tenmh)
        {
            DataTable dt = KetNoi.truyvan($"Select *from MonHoc where tenmh like N'%{tenmh}%'");
            return dt;
            //Tìm kiếm theo tên khách hàng
        }
        public static DataTable Load_MH_Theo_GV(string magv)
        {
            DataTable dt = KetNoi.truyvan($"select MonHoc.mamh from MonHoc,PhanCong,GiaoVien  where MonHoc.mamh=PhanCong.mamh and PhanCong.magv=GiaoVien.magv and GiaoVien.magv='{magv}'");
            return dt;
            //Tìm kiếm theo tên khách hàng
        }

        public static void them_MH(MonHoc_DTO mh)
        {
            string sql = $"insert into MonHoc values(N'{mh.Mamh}',N'{mh.Tenmh}','{mh.Sotiet}','{mh.Sodaudiemkt}','{mh.Sotinchi}')";
            KetNoi.thucthi(sql);
        }
        public static void sua_MH(MonHoc_DTO mh)
        {
            string sql = $"update MonHoc set tenMH=N'{mh.Tenmh}',sotiet='{mh.Sotiet}',sodaudiemkt='{mh.Sodaudiemkt}',sotinchi='{mh.Sotinchi}' where mamh='{mh.Mamh}'";
            KetNoi.thucthi(sql);
        }
        public static void xoa_MH(string mamh)
        {
            string sql = $"delete from MonHoc where mamh='{mamh}'";
            KetNoi.thucthi(sql);
        }

        public static void Update_MH_Bang_PhanCong(string mamh)
        {
            string sql = $"UPDATE PhanCong SET mamh = NULL WHERE mamh = '{mamh}'";
            KetNoi.thucthi(sql);
        }
        public static void Update_MH_Bang_Diem(string mamh)
        {
            string sql = $"UPDATE Diem SET mamh = NULL WHERE mamh ='{mamh}'";
            KetNoi.thucthi(sql);
        }
    }
}
