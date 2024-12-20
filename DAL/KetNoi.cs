using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class KetNoi
    {
        static SqlConnection conn;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        public static SqlConnection taoketnoi()
        {
            String chuoikn = Properties.Settings.Default.ConnectionString;
            conn = new SqlConnection(chuoikn);
            conn.Open();
            return conn;
        }
        public static DataTable truyvan(string sql)  
        {
            DataTable dt = new DataTable();
            conn = taoketnoi();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static void thucthi(string sql)
        {
            conn = taoketnoi();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}