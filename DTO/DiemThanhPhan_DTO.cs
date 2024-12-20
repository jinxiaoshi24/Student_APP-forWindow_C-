using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemThanhPhan_DTO
    {
        private string mamh;
        private string masv;
        private string diemthuongxuyen;
        private string diemkt1;
        private string diemkt2;
        private string diemkt3;
        private string diemkt4;
        private string diemkt5;

        public DiemThanhPhan_DTO(string mamh, string masv, string diemthuongxuyen, string diemkt1, string diemkt2, string diemkt3, string diemkt4, string diemkt5)
        {
            this.Mamh = mamh;
            this.Masv = masv;
            this.Diemthuongxuyen = diemthuongxuyen;
            this.Diemkt1 = diemkt1;
            this.Diemkt2 = diemkt2;
            this.Diemkt3 = diemkt3;
            this.Diemkt4 = diemkt4;
            this.Diemkt5 = diemkt5;
        }

        public string Mamh { get => mamh; set => mamh = value; }
        public string Masv { get => masv; set => masv = value; }
        public string Diemthuongxuyen { get => diemthuongxuyen; set => diemthuongxuyen = value; }
        public string Diemkt1 { get => diemkt1; set => diemkt1 = value; }
        public string Diemkt2 { get => diemkt2; set => diemkt2 = value; }
        public string Diemkt3 { get => diemkt3; set => diemkt3 = value; }
        public string Diemkt4 { get => diemkt4; set => diemkt4 = value; }
        public string Diemkt5 { get => diemkt5; set => diemkt5 = value; }
    }
}
