using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc_DTO
    {
        private string mamh;
        private string tenmh;
        private string sotiet;
        private string sodaudiemkt;
        private string sotinchi;

        public MonHoc_DTO(string mamh, string tenmh, string sotiet, string sodaudiemkt, string sotinchi)
        {
            this.Mamh = mamh;
            this.Tenmh = tenmh;
            this.Sotiet = sotiet;
            this.Sodaudiemkt = sodaudiemkt;
            this.Sotinchi = sotinchi;
        }

        public string Mamh { get => mamh; set => mamh = value; }
        public string Tenmh { get => tenmh; set => tenmh = value; }
        public string Sotiet { get => sotiet; set => sotiet = value; }
        public string Sodaudiemkt { get => sodaudiemkt; set => sodaudiemkt = value; }
        public string Sotinchi { get => sotinchi; set => sotinchi = value; }
    }
}
