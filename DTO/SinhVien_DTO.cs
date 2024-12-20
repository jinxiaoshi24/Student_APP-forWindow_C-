using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien_DTO
    {
        private string masv;
        private string hotensv;
        private string ngaysinh;
        private string gioitinh;
        private string diachi;
        private string sdt;
        private string taikhoan;
        private string malop;

        public SinhVien_DTO(string masv, string hotensv, string ngaysinh, string gioitinh, string diachi, string sdt, string taikhoan, string malop)
        {
            this.Masv = masv;
            this.Hotensv = hotensv;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Sdt = sdt;
            this.Taikhoan = taikhoan;
            this.Malop = malop;
        }

        public string Masv { get => masv; set => masv = value; }
        public string Hotensv { get => hotensv; set => hotensv = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Malop { get => malop; set => malop = value; }
    }
}
