using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    public  class Class1
    {
        public  void  close_taskBar(Form fr)
        {
        // Tắt nút thu nhỏ
            fr.MinimizeBox = false;
            // Tắt nút thoát (Đóng cửa sổ)
            fr.ControlBox = false;            
        }
    }
}
