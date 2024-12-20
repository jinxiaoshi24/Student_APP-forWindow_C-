using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class SinhVien_DAL
    {
        public static DataTable load_DsSV()
        {
            string sql = $"select  * from SinhVien";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable Load_MaSV()
        {
            string sql = $"select  masv from SinhVien";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Load_TaiKhoan()
        {
            string sql = $"SELECT t1.* FROM Account t1 LEFT JOIN SinhVien t2 ON t1.taikhoan = t2.taikhoan  WHERE t2.taikhoan IS NULL and t1.type_user='SV'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Load_Malop()
        {
            string sql = $"select  malop from Lop";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable tang_MaSV()
        {
            string sql = $"SELECT max(SUBSTRING(masv,3,10)+1) FROM SinhVien";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Show_Name_SV(string taikhoan)
        {
            string sql = $"select  hotensv from SinhVien where taikhoan='{taikhoan}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_MaSV(string masv)
        {
            string sql = $"select  * from SinhVien where masv='{masv}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_HoTenSV(string hotensv)
        {
            DataTable dt = KetNoi.truyvan($"Select *from SinhVien where hotensv like N'%{hotensv}%'");
            return dt;
        }

        public static void them_SV(SinhVien_DTO sv)
        {
            string sql = $"insert into SinhVien values(N'{sv.Masv}',N'{sv.Hotensv}',N'{sv.Ngaysinh}',N'{sv.Gioitinh}',N'{sv.Diachi}',N'{sv.Sdt}',N'{sv.Taikhoan}',N'{sv.Malop}')";
            KetNoi.thucthi(sql);
        }
        public static void sua_SV(SinhVien_DTO sv)
        {
            string sql = $"update SinhVien set hotensv=N'{sv.Hotensv}',ngaysinh=N'{sv.Ngaysinh}',gioitinh=N'{sv.Gioitinh}',diachi=N'{sv.Diachi}',sdt=N'{sv.Sdt}',taikhoan=N'{sv.Taikhoan}',malop=N'{sv.Malop}' where masv='{sv.Masv}'";
            KetNoi.thucthi(sql);
        }
        public static void xoa_SV(string masv)
        {
            string sql = $"delete from SinhVien where masv='{masv}'";
            KetNoi.thucthi(sql);
        }
        public static void xoa_SV_Bang_Diem(string masv)
        {
            string sql = $"Delete from Diem where Diem.masv='{masv}'";
            KetNoi.thucthi(sql);
        }
        public static DataTable Load_SV_Theo_GV(string magv)
        {
            DataTable dt = KetNoi.truyvan($"select SinhVien.masv from SinhVien,Lop,GiaoVien  where SinhVien.malop=Lop.malop and Lop.magv =GiaoVien.magv and GiaoVien.magv='{magv}'");
            return dt;
            //Tìm kiếm theo tên khách hàng
        }
        public static DataTable Load_DS_SV_Theo_GV(string malop)
        {
            DataTable dt = KetNoi.truyvan($"select SinhVien.masv,SinhVien.hotensv,SinhVien.ngaysinh,SinhVien.gioitinh,SinhVien.diachi,SinhVien.sdt,SinhVien.taikhoan,SinhVien.MaLop from SinhVien,Lop where SinhVien.malop=Lop.malop and Lop.malop='{malop}'");
            return dt;
            //Tìm kiếm theo tên khách hàng
        }
    }
}
