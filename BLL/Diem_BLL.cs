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
    public class Diem_BLL
    {
        public static DataTable load_DsDiem()
        {
            return Diem_DAL.load_DsDiem();
        }

        public static DataTable Load_MaMH()
        {
            return Diem_DAL.Load_MaMH();
        }
        public static DataTable Load_MaSV()
        {
            return Diem_DAL.Load_MaSV();

        }
        public static DataTable Timkiem_MaMH(string mamh)
        {
            return Diem_DAL.Timkiem_MaMH(mamh);
        }
        public static DataTable Timkiem_MaSV(string masv)
        {
            return Diem_DAL.Timkiem_MaSV(masv);
        }
        public static void them_DiemThanhPhan(DiemThanhPhan_DTO Dm)
        {
            Diem_DAL.them_DiemThanhPhan(Dm);
        }
        public static void them_sua_DiemThi(DiemThi_DTO Dm)
        {
            Diem_DAL.them_sua_DiemThi(Dm);
        }
        public static void Xoa_DiemThi(DiemThi_DTO Dm)
        {
            Diem_DAL.Xoa_DiemThi(Dm);
        }
        public static void sua_DiemThanhPhan(DiemThanhPhan_DTO Dm)
        {
            Diem_DAL.sua_DiemThanhPhan(Dm);
        }
        public static void xoa_Diem(string mamh, string masv)
        {
            Diem_DAL.xoa_Diem(mamh, masv);
        }
        public static void CapNhat_DiemThanhPhan()
        {
            Diem_DAL.CapNhat_DiemThanhPhan();
        }
        public static void CapNhat_DiemTongKet()
        {
            Diem_DAL.CapNhat_DiemTongKet();
        }
        public bool check_TrungThemDiem(DiemThanhPhan_DTO Dm1)
        {
            Diem_DAL DiemDAL = new Diem_DAL();
            return DiemDAL.check_TrungThemDiem(Dm1);
        }
        public static DataTable check_Hoc_Lai(string mamh, string masv)
        {
            return Diem_DAL.check_Hoc_Lai(mamh, masv);
        }
        //public static DataTable load_ds_DiemSV_theo_magv(string mamh, string masv)
        //{
        //    return Diem_DAL.load_ds_DiemSV_theo_magv(mamh, masv);

        //}

        public static DataTable load_ds_DiemSV_theo_magv(string magv, string mamh)
        {
            return Diem_DAL.load_ds_DiemSV_theo_magv(magv, mamh);

        }

        public static DataTable In_DiemSV(string masv)
        {
            return Diem_DAL.In_DiemSV(masv);
        }

        public static DataTable load_ds_DiemSV_theo_magv_ChuNhiem(string magv, string mamh)
        {
            return Diem_DAL.load_ds_DiemSV_theo_magv_ChuNhiem(magv, mamh);
        }
        public static DataTable load_ds_DiemSV_theo_magv_ChuNhiem_HL(string magv)
        {
            return Diem_DAL.load_ds_DiemSV_theo_magv_ChuNhiem_HL(magv);
        }
        public static DataTable load_ds_DiemSV_theo_magv_ChuNhiem_TL(string magv)
        {
            return Diem_DAL.load_ds_DiemSV_theo_magv_ChuNhiem_TL(magv);
        }
    }
}
