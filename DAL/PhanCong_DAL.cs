using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class PhanCong_DAL
    {
        public static DataTable load_DsPhanCong()
        {
            string sql = "select  * from PhanCong";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Load_MaGV()
        {
            string sql = $"select Distinct magv from GiaoVien";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Load_MaMH()
        {
            string sql = $"select Distinct mamh from PhanCong";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Load_MaLop()
        {
            string sql = $"select Distinct malop from PhanCong";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_MaGV(string magv)
        {
            string sql = $"select  * from PhanCong where magv='{magv}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_MaMH(string mamh)
        {
            string sql = $"select  * from PhanCong where mamh='{mamh}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_MaLop(string malop)
        {
            string sql = $"select  * from PhanCong where malop='{malop}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static void them_PhanCong(PhanCong_DTO pc)
        {
            string sql = $"insert into PhanCong values(N'{pc.Magv}',N'{pc.Mamh}','{pc.Malop}','{pc.Namhoc}','{pc.Hocky}')";
            KetNoi.thucthi(sql);
        }
        public static void sua_PhanCong(PhanCong_DTO pc)
        {
            string sql = $"update PhanCong set magv=N'{pc.Magv}',mamh='{pc.Mamh}',malop='{pc.Malop}',namhoc='{pc.Namhoc}' ,hocky='{pc.Hocky}' where magv=N'{pc.Magv}'and mamh='{pc.Mamh}'and malop='{pc.Malop}'";
            KetNoi.thucthi(sql);
        }
        public static void xoa_PhanCong(string magv, string mamh , string malop)
        {
            string sql = $"delete from PhanCong where magv='{magv}' and mamh='{mamh}'and malop='{malop}'";
            KetNoi.thucthi(sql);
        }
        public bool check_PhanCong(PhanCong_DTO pc1)
        {
            string sql = $"select magv, mamh, malop from PhanCong where mamh='{pc1.Mamh}'and malop='{pc1.Malop}'";
            DataTable dt = KetNoi.truyvan(sql);
            if (dt.Rows.Count == 1) return true;
            return false;
        }
    }
}
