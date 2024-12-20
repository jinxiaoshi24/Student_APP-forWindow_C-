using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public class Function
    {

        public static class FormManager
        {
            /// <summary>
            /// Kiểm tra và quản lý việc mở hoặc kích hoạt một form con trong MDI Parent.
            /// </summary>
            /// <typeparam name="T">Kiểu của form cần mở.</typeparam>
            /// <param name="mdiParent">Form MDI Parent.</param>
            public static void OpenOrSwitchForm<T>(Form mdiParent) where T : Form, new()
            {
                if (mdiParent == null)
                {
                    throw new ArgumentNullException(nameof(mdiParent), "MDI Parent cannot be null.");
                }

                // Kiểm tra nếu form T đã mở
                bool isFormAlreadyOpen = false;
                Form openForm = null;

                foreach (Form frm in mdiParent.MdiChildren)
                {
                    if (frm is T)
                    {
                        isFormAlreadyOpen = true;
                        openForm = frm;
                        break;
                    }
                }

                // Nếu form đã mở, chỉ kích hoạt form đó và đóng các form khác
                if (isFormAlreadyOpen)
                {
                    foreach (Form frm in mdiParent.MdiChildren)
                    {
                        if (frm != openForm) // Không đóng form đang mở
                        {
                            frm.Close();
                        }
                    }
                    openForm.Activate(); // Kích hoạt form đang mở
                }
                else
                {
                    // Nếu form chưa mở, tạo mới form và đóng các form khác
                    T newForm = new T
                    {
                        MdiParent = mdiParent
                    };
                    newForm.Show();

                    newForm.Size = mdiParent.ClientSize;

                    foreach (Form frm in mdiParent.MdiChildren)
                    {
                        if (frm != newForm) // Không đóng form mới
                        {
                            frm.Close();
                        }
                    }
                }
            }
        }


        public static void Close_taskBar(Form fr)
        {
            // Tắt nút thu nhỏ
            fr.MinimizeBox = false;
            // Tắt nút thoát (Đóng cửa sổ)
            fr.ControlBox = false;
        }
        public static void Open_taskBar(Form fr)
        {
            // Tắt nút thu nhỏ
            fr.MinimizeBox = true ;
            // Tắt nút thoát (Đóng cửa sổ)
            fr.ControlBox = true;
        }
        public static bool Ktrasonguyen(string st)
        {
            try
            {
                int.Parse(st);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Ktrasofloat(string st)
        {
            try
            {
                float.Parse(st);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
