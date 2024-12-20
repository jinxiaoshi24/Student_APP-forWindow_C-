using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account_DTO
    {
        private string taikhoan;
        private string pass;
        private string type_user;
        public Account_DTO(string taikhoan, string pass, string type_user)
        {
            this.Taikhoan = taikhoan;
            this.Pass = pass;
            this.Type_user = type_user;
        }

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Type_user { get => type_user; set => type_user = value; }
    }
}
