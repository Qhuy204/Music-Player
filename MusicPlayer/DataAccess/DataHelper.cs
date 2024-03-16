using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class DataHelper
    {
        static SqlDataAdapter sqlAdap;
        static DataTable dt;
        static string strConnect = @"Data Source=QHUY\SQLEXPRESS;Initial Catalog=MusicPlayer;Integrated Security=True";

        public static DataTable GetDataTable(string strSelect)
        {
            //B1
            sqlAdap = new SqlDataAdapter(strSelect, strConnect);
            //B2
            dt = new DataTable();
            sqlAdap.Fill(dt);
            //B3
            return dt;
        }

        public static void ThucThiSQL(string strSQL)
        {
            //B1
            sqlAdap = new SqlDataAdapter(strSQL, strConnect);
            //B2
            dt = new DataTable();
            sqlAdap.Fill(dt);
        }
    }
}
