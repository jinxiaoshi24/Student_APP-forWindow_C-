using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanCong_DTO
    {
        private string magv;
        private string mamh;
        private string malop;
        private string namhoc;
        private string hocky;

        public PhanCong_DTO(string magv, string mamh, string malop, string namhoc, string hocky)
        {
            this.Magv = magv;
            this.Mamh = mamh;
            this.Malop = malop;
            this.Namhoc = namhoc;
            this.Hocky = hocky;
        }

        public string Magv { get => magv; set => magv = value; }
        public string Mamh { get => mamh; set => mamh = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Namhoc { get => namhoc; set => namhoc = value; }
        public string Hocky { get => hocky; set => hocky = value; }
    }
}
