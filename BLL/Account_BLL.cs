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
    public class Account_BLL
    {
        public static DataTable GetListAccount()
        {
            return Account_DAL.ListAccount();
        }
        public static DataTable Get_MaTK()
        {
            return Account_DAL.Load_MaTK();
        }
        public static DataTable GetAllTypeUser()
        {
            return Account_DAL.AllTypeUser();
        }
        public static DataTable GetTaiKhoanGV()
        {
            return Account_DAL.tang_TaiKhoanGV();
        }
        public static DataTable tang_TaiKhoanSV()
        {
            return Account_DAL.tang_TaiKhoanSV();
        }
        public static DataTable tang_TaiKhoanAdmin()
        {
            return Account_DAL.tang_TaiKhoanAdmin();
        }

        public static DataTable Timkiem_TaiKhoan(string taikhoan)
        {
            return Account_DAL.Timkiem_TaiKhoan(taikhoan);
        }
        public static DataTable Timkiem_TypeUser(string type_user)
        {
            return Account_DAL.Timkiem_TypeUser(type_user);
        }
        public static DataTable LayThongTinDangNhap(string taikhoan, string matkhau)
        {
            return Account_DAL.LayThongTinTaiKhoan(taikhoan, matkhau);
        }
        public static DataTable Lay_Type_User(string taikhoan, string matkhau)
        {
            return Account_DAL.Type_User(taikhoan, matkhau);
        }
        public static DataTable Get_ThongTinCaNhan(string loaiTK, string taikhoan)
        {
            return Account_DAL.ThongTinCaNhan(loaiTK, taikhoan);
        }
        public static void them_Account(Account_DTO tk)
        {
            Account_DAL.them_Account(tk);
        }
        public static void sua_Account(Account_DTO tk)
        {
            Account_DAL.sua_Account(tk);
        }

        public static void Doi_Mai_Khau(Account_DTO mk)
        {
            Account_DAL.Doi_Mai_Khau(mk);
        }
        public static void xoa_Account(string matk)
        {
            Account_DAL.xoa_Account(matk);
        }
        public static void Update_TaiKhoan_Bang_SV(string taikhoan)
        {
            Account_DAL.Update_TaiKhoan_Bang_SV(taikhoan);
        }
        public static void Update_TaiKhoan_Bang_GV(string taikhoan)
        {
            Account_DAL.Update_TaiKhoan_Bang_GV(taikhoan);

        }
        public bool check_PhanCong(PhanCong_DTO pc1)
        {
            PhanCong_DAL phanCongDAL = new PhanCong_DAL();
            return phanCongDAL.check_PhanCong(pc1);
        }
    }
}
