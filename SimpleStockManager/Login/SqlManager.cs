using BH_Library.Database.Sql;
using BH_Library.Utils;
using SimpleStockManager.core;
using System.Data;
using System.Windows.Forms;
using System;
using System.Data.SQLite;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using SimpleStockManager.core.Session;

namespace SimpleStockManager.Login
{
    internal class SqlManager
    {
        public static bool USER_CHECK(string id, string pw)
        {
            bool result = false;

            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM user WHERE staff_id = @staff_id AND staff_pw = @staff_pw and staff_status = 1;";
                cmd.Parameters.Add(new SQLiteParameter("@staff_id", id));
                cmd.Parameters.Add(new SQLiteParameter("@staff_pw", pw));
                result = cmd.ExecuteScalar().ToIntEx() == 1 ? true : false;

                //cmd.CommandText = "SELECT * FROM user";
                //cmd.Parameters.Add(new SQLiteParameter("@staff_id", id));

                //DataTable dt = new DataTable();
                //dt.Load(cmd.ExecuteReader());

            }
            return result;
        }

        public static bool UpdatePassword(string pw)
        {
            bool result = false;

            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"
update
    user
set
    staff_pw = @staff_pw
where 
    staff_id = @staff_id
";
                cmd.Parameters.Add(new SQLiteParameter("@staff_id", SessionManager.UserId));
                cmd.Parameters.Add(new SQLiteParameter("@staff_pw", pw));
                cmd.ExecuteNonQuery();
                result = true;
            }
            return result;
        }

        public static bool CheckPassword(string pw)
        {
            bool result = false;

            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"select count(*) from user where staff_id = @staff_id and staff_pw = @staff_pw";
                cmd.Parameters.Add(new SQLiteParameter("@staff_id", SessionManager.UserId));
                cmd.Parameters.Add(new SQLiteParameter("@staff_pw", pw));
                result = cmd.ExecuteScalar().ToIntEx() == 1 ? true : false;
            }
            return result;
        }
    }
}