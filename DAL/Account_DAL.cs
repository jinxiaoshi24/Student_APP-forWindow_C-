using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;


namespace DAL
{
    public class Account_DAL
    {
        public static DataTable ListAccount()
        {
            string sql = "select  * from Account";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable Load_MaTK()
        {
            string sql = $"select taikhoan from Account";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable AllTypeUser()
        {
            string sql = $"select DISTINCT type_user from Account";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable tang_TaiKhoanGV()
        {
            string sql = $"SELECT MAX(SUBSTRING(taikhoan, 3, 10)+1) FROM Account where left(taikhoan, 2)='GV'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable tang_TaiKhoanSV()
        {
            string sql = $"SELECT MAX(SUBSTRING(taikhoan, 3, 10)+1) FROM Account where left(taikhoan, 2)='SV'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable tang_TaiKhoanAdmin()
        {
            string sql = $"SELECT MAX(SUBSTRING(taikhoan, 6, 10)+1) AS cut_string FROM Account where left(taikhoan, 5)='admin'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable Timkiem_TaiKhoan(string taikhoan)
        {
            DataTable dt = KetNoi.truyvan($"Select *from Account where taikhoan ='{taikhoan}'");
            return dt;
        }
        public static DataTable Timkiem_TypeUser(string type_user)
        {
            string sql = $"select  * from Account where type_user='{type_user}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable LayThongTinTaiKhoan(string taikhoan,string matkhau)
        {
            DataTable dt = KetNoi.truyvan($"Select * from Account where taikhoan ='{taikhoan}' and pass='{matkhau}'");
            return dt;
        }

        public static DataTable Type_User(string taikhoan, string matkhau)
        {
            DataTable dt = KetNoi.truyvan($"Select type_user from Account where taikhoan ='{taikhoan}' and pass='{matkhau}'");
            return dt;
        }
        public static void them_Account(Account_DTO tk)
        {
            string sql = $"insert into Account values(N'{tk.Taikhoan}',N'{tk.Pass}',N'{tk.Type_user}')";
            //string sql = $"insert into Khoa values(N'{mk.Makhoa}',N'{mk.Tenkhoa}')";
            KetNoi.thucthi(sql);
        }
        public static void sua_Account(Account_DTO tk)
        {
            string sql = $"update Account set taikhoan=N'{tk.Taikhoan}',pass=N'{tk.Pass}',type_user=N'{tk.Type_user}' where taikhoan=N'{tk.Taikhoan}'";
            KetNoi.thucthi(sql);
        }
        public static void xoa_Account(string taikhoan)
        {
            string sql = $"delete from Account where taikhoan='{taikhoan}'";
            KetNoi.thucthi(sql);
        }

        public static DataTable ThongTinCaNhan(string loaiTK,string taikhoan)
        {
            string sql = $"select  * from {loaiTK} where taikhoan='{taikhoan}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static void Doi_Mai_Khau(Account_DTO mk)
        {
            string sql = $"update Account set pass=N'{mk.Pass}' where taikhoan=N'{mk.Taikhoan}'";
            KetNoi.thucthi(sql);
        }
        public static void Update_TaiKhoan_Bang_SV(string taikhoan)
        {
            string sql = $"UPDATE SinhVien SET taikhoan = NULL WHERE taikhoan ='{taikhoan}'";
            KetNoi.thucthi(sql);
        }
        public static void Update_TaiKhoan_Bang_GV(string taikhoan)
        {
            string sql = $"UPDATE GiaoVien SET taikhoan = NULL WHERE taikhoan ='{taikhoan}'";
            KetNoi.thucthi(sql);
        }
    }
}
