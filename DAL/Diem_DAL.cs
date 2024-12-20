using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Diem_DAL
    {
        public static DataTable load_DsDiem()
        {
            //string sql = $"select  * from Diem";
            string sql = $"SELECT Diem.mamh, Diem.masv,SinhVien.hotensv, Diem.Diemthuongxuyen, Diem.Diemkt1, Diem.Diemkt2, Diem.Diemkt3, Diem.Diemkt4, Diem.Diemkt5, Diem.tbDiemthanhphan, Diem.Diemthi, Diem.Diemtongket, Diem.quamon, Diem.ghichu FROM Diem,SinhVien WHERE Diem.masv=SinhVien.masv";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable Load_MaMH()
        {
            string sql = $"select mamh from MonHoc";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Load_MaSV()
        {
            string sql = $"select  masv from SinhVien";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable Timkiem_MaMH(string mamh)
        {
            string sql = $"SELECT Distinct Diem.mamh, Diem.masv,SinhVien.hotensv, Diem.Diemthuongxuyen, Diem.Diemkt1, Diem.Diemkt2, Diem.Diemkt3, Diem.Diemkt4, Diem.Diemkt5, Diem.tbDiemthanhphan, Diem.Diemthi, Diem.Diemtongket, Diem.quamon, Diem.ghichu FROM Diem,SinhVien where Diem.masv =SinhVien.masv and Diem.mamh='{mamh}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable Timkiem_MaSV(string masv)
        {
            string sql = $"SELECT Distinct Diem.mamh, Diem.masv,SinhVien.hotensv, Diem.Diemthuongxuyen, Diem.Diemkt1, Diem.Diemkt2, Diem.Diemkt3, Diem.Diemkt4, Diem.Diemkt5, Diem.tbDiemthanhphan, Diem.Diemthi, Diem.Diemtongket, Diem.quamon, Diem.ghichu FROM Diem,SinhVien where Diem.masv =SinhVien.masv and SinhVien.masv='{masv}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable load_ds_DiemSV_theo_magv(string magv,string mamh)
        {
            string sql = $"SELECT Distinct Diem.mamh, Diem.masv,SinhVien.hotensv, Diem.Diemthuongxuyen, Diem.Diemkt1, Diem.Diemkt2, Diem.Diemkt3, Diem.Diemkt4, Diem.Diemkt5, Diem.tbDiemthanhphan, Diem.Diemthi, Diem.Diemtongket, Diem.quamon, Diem.ghichu FROM Diem,SinhVien,Lop,PhanCong,GiaoVien WHERE Diem.masv=SinhVien.masv and SinhVien.malop=Lop.malop and Lop.malop=PhanCong.malop and  PhanCong.magv=GiaoVien.magv and GiaoVien.magv='{magv}' and Diem.mamh = '{mamh}' ";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static void them_DiemThanhPhan(DiemThanhPhan_DTO Dm)
        {
            string sql = $"insert into Diem(mamh, masv, diemthuongxuyen, diemkt1,diemkt2,diemkt3,diemkt4,diemkt5) values(N'{Dm.Mamh}',N'{Dm.Masv}',N'{Dm.Diemthuongxuyen}',N'{Dm.Diemkt1}',N'{Dm.Diemkt2}',N'{Dm.Diemkt3}',N'{Dm.Diemkt4}',N'{Dm.Diemkt5}')";
            KetNoi.thucthi(sql);
        }
        public static void them_sua_DiemThi(DiemThi_DTO Dm)
        {
            string sql = $"update Diem set diemthi=N'{Dm.Diemthi}'where mamh=N'{Dm.Mamh}' and masv=N'{Dm.Masv}'";
            KetNoi.thucthi(sql);
        }
        public static void Xoa_DiemThi(DiemThi_DTO Dm)
        {
            string sql = $"update Diem set diemthi= '0',diemtongket=NULL,quamon='0',ghichu=NULL where mamh=N'{Dm.Mamh}' and masv=N'{Dm.Masv}'";
            KetNoi.thucthi(sql);
        }
        public static void sua_DiemThanhPhan(DiemThanhPhan_DTO Dm)
        {
            string sql = $"update Diem set diemthuongxuyen=N'{Dm.Diemthuongxuyen}',diemkt1=N'{Dm.Diemkt1}',diemkt2=N'{Dm.Diemkt2}',diemkt3=N'{Dm.Diemkt3}',diemkt4=N'{Dm.Diemkt4}',diemkt5=N'{Dm.Diemkt5}'where mamh=N'{Dm.Mamh}' and masv=N'{Dm.Masv}'";
            KetNoi.thucthi(sql);
        }
        public static void xoa_Diem(string mamh, string masv)
        {
            string sql = $"delete from Diem where mamh='{mamh}' and masv='{masv}'";
            KetNoi.thucthi(sql);
        }

        public static void CapNhat_DiemThanhPhan()
        {
            string sql = $"exec SP_Update_tbdiemthanhphan_QuaMon_GhiChu";
            KetNoi.thucthi(sql);
        }

        public static void CapNhat_DiemTongKet()
        {
            string sql = $"exec SP_Update_diemtongket_QuaMon_GhiChu";
            KetNoi.thucthi(sql);
        }

        public bool check_TrungThemDiem(DiemThanhPhan_DTO Dm1)
        {
            string sql = $"select mamh, masv from Diem where mamh=N'{Dm1.Mamh}' and masv='{Dm1.Masv}'";
            DataTable dt = KetNoi.truyvan(sql);
            if (dt.Rows.Count == 1) return true;
            return false;
        }

        public static DataTable check_Hoc_Lai(string mamh,string masv)
        {
            string sql = $"select ghichu from Diem where mamh='{mamh}' and masv='{masv}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable In_DiemSV(string masv)
        {
            string sql = $"select MonHoc.tenmh,Diem.diemthuongxuyen, Diem.diemkt1, Diem.diemkt2, Diem.diemkt3, Diem.diemkt4, Diem.diemkt5, Diem.tbdiemthanhphan, Diem.diemthi, Diem.diemtongket, Diem.quamon, Diem.ghichu from Diem,MonHoc where MonHoc.mamh=Diem.mamh and Diem.masv='{masv}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }

        public static DataTable load_ds_DiemSV_theo_magv_ChuNhiem(string magv, string mamh)
        {
            string sql = $"SELECT Distinct Diem.mamh, Diem.masv,SinhVien.HoTenSV, Diem.Diemthuongxuyen, Diem.Diemkt1, Diem.Diemkt2, Diem.Diemkt3, Diem.Diemkt4, Diem.Diemkt5, Diem.tbDiemthanhphan, Diem.Diemthi, Diem.Diemtongket, Diem.quamon, Diem.ghichu  FROM Diem,SinhVien,Lop,PhanCong,GiaoVien WHERE Diem.masv=SinhVien.masv and SinhVien.malop=Lop.malop and Lop.magv=GiaoVien.magv and GiaoVien.magv='{magv}' and Diem.mamh='{mamh}'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable load_ds_DiemSV_theo_magv_ChuNhiem_HL(string magv)
        {
            string sql = $"SELECT Distinct Diem.mamh, Diem.masv,SinhVien.HoTenSV, Diem.Diemthuongxuyen, Diem.Diemkt1, Diem.Diemkt2, Diem.Diemkt3, Diem.Diemkt4, Diem.Diemkt5, Diem.tbDiemthanhphan, Diem.Diemthi, Diem.Diemtongket, Diem.quamon, Diem.ghichu FROM Diem,SinhVien,Lop,PhanCong,GiaoVien WHERE Diem.masv=SinhVien.masv and SinhVien.malop=Lop.malop and Lop.magv=GiaoVien.magv and GiaoVien.magv='{magv}' and Diem.ghichu='HL'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
        public static DataTable load_ds_DiemSV_theo_magv_ChuNhiem_TL(string magv)
        {
            string sql = $"SELECT Distinct Diem.mamh, Diem.masv,SinhVien.HoTenSV, Diem.Diemthuongxuyen, Diem.Diemkt1, Diem.Diemkt2, Diem.Diemkt3, Diem.Diemkt4, Diem.Diemkt5, Diem.tbDiemthanhphan, Diem.Diemthi, Diem.Diemtongket, Diem.quamon, Diem.ghichu FROM Diem,SinhVien,Lop,PhanCong,GiaoVien WHERE Diem.masv=SinhVien.masv and SinhVien.malop=Lop.malop and Lop.magv=GiaoVien.magv and GiaoVien.magv='{magv}' and Diem.ghichu='TL'";
            DataTable dt = KetNoi.truyvan(sql);
            return dt;
        }
    }
}
