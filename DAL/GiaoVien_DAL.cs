using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class GiaoVien_DAL
    {
        public static DataTable load_DsGV()
        {
            string sql = $"select  * from GiaoVien";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable Load_MaGV()
        {
            string sql = $"select  magv from GiaoVien";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Load_TaiKhoan()
        {
            string sql = $"SELECT t1.taikhoan FROM Account t1 LEFT JOIN GiaoVien t2 ON t1.taikhoan = t2.taikhoan  WHERE t2.taikhoan IS NULL and t1.type_user='GV';";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Load_Makhoa()
        {
            string sql = $"select  makhoa from Khoa";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable tang_MaGV()
        {
            string sql = $"SELECT max(SUBSTRING(magv,3,10)+1) FROM GiaoVien";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable Show_Name_GV(string taikhoan)
        {
            string sql = $"select  hotengv from GiaoVien where taikhoan='{taikhoan}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_MaGV(string magv)
        {
            string sql = $"select  * from GiaoVien where magv='{magv}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_HoTenGV(string hotengv)
        {
            DataTable dt = KetNoi.truyvan($"Select *from GiaoVien where hotengv like N'%{hotengv}%'");
            return dt;
        }

        public static void them_GV(GiaoVien_DTO gv)
        {
            string sql = $"insert into GiaoVien values(N'{gv.Magv}',N'{gv.Hotengv}',N'{gv.Ngaysinh}',N'{gv.Gioitinh}',N'{gv.Diachi}',N'{gv.Sdt}',N'{gv.Taikhoan}',N'{gv.Makhoa}')";
            KetNoi.thucthi(sql);
        }
        public static void sua_GV(GiaoVien_DTO gv)
        {
            string sql = $"update GiaoVien set hotengv=N'{gv.Hotengv}',ngaysinh=N'{gv.Ngaysinh}',gioitinh=N'{gv.Gioitinh}',diachi=N'{gv.Diachi}',sdt=N'{gv.Sdt}',taikhoan=N'{gv.Taikhoan}',makhoa=N'{gv.Makhoa}' where magv='{gv.Magv}'";
            KetNoi.thucthi(sql);
        }
        public static void xoa_GV(string magv)
        {
            string sql = $"delete from GiaoVien where magv='{magv}'";
            KetNoi.thucthi(sql);
        }

        public static void Update_magv_Bang_Lop(string magv)
        {
            string sql = $"UPDATE Lop SET magv = NULL WHERE magv = '{magv}'";
            KetNoi.thucthi(sql);
        }
        public static void Update_magv_Bang_PhanCong(string magv)
        {
            string sql = $"UPDATE PhanCong SET magv = NULL WHERE magv = '{magv}'";
            KetNoi.thucthi(sql);
        }
    }
}
