using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemThi_DTO
    {
        private string mamh;
        private string masv;
        private string diemthi;

        public DiemThi_DTO(string mamh, string masv, string diemthi)
        {
            this.Mamh = mamh;
            this.Masv = masv;
            this.Diemthi = diemthi;
        }

        public string Mamh { get => mamh; set => mamh = value; }
        public string Masv { get => masv; set => masv = value; }
        public string Diemthi { get => diemthi; set => diemthi = value; }
    }
}
