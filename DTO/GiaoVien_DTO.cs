using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVien_DTO
    {
        private string magv;
        private string hotengv;
        private string ngaysinh;
        private string gioitinh;
        private string diachi;
        private string sdt;
        private string taikhoan;
        private string makhoa;

        public GiaoVien_DTO(string magv, string hotengv, string ngaysinh, string gioitinh, string diachi, string sdt, string taikhoan, string makhoa)
        {
            this.Magv = magv;
            this.Hotengv = hotengv;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Sdt = sdt;
            this.Taikhoan = taikhoan;
            this.Makhoa = makhoa;
        }

        public string Magv { get => magv; set => magv = value; }
        public string Hotengv { get => hotengv; set => hotengv = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Makhoa { get => makhoa; set => makhoa = value; }
    }
}
