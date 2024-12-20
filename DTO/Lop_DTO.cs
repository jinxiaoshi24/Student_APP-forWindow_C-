using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop_DTO
    {
        private string malop;
        private string tenlop;
        private string makhoa;
        private string magv;

        public Lop_DTO(string malop, string tenlop, string makhoa, string magv)
        {
            this.Malop = malop;
            this.Tenlop = tenlop;
            this.Makhoa = makhoa;
            this.Magv = magv;
        }

        public string Malop { get => malop; set => malop = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public string Makhoa { get => makhoa; set => makhoa = value; }
        public string Magv { get => magv; set => magv = value; }
    }
}
