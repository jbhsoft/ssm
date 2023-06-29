using SimpleStockManager.core;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH_Library.Utils;
using SimpleStockManager.core.Session;

namespace SimpleStockManager.Staff
{
    internal class SqlManager
    {
        public static DataTable LoadList()
        {
            DataTable result = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"
SELECT 
    staff_no,
    staff_name, 
    case when staff_status = 1 then '재직' else '퇴직' end as staff_status,
    staff_id,
    created_at, 
    created_by,
    updated_at,
    updated_by
FROM user;";
                //cmd.Parameters.Add(new SQLiteParameter("@staff_id", id));
                //cmd.Parameters.Add(new SQLiteParameter("@staff_pw", pw));
                //result = cmd.ExecuteScalar().ToIntEx() == 1 ? true : false;

                //cmd.CommandText = "SELECT * FROM user";
                //cmd.Parameters.Add(new SQLiteParameter("@staff_id", id));


                result.Load(cmd.ExecuteReader());

            }
            return result;
        }

        public static void DeleteRow(string staff_no)
        {
            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"delete from user where staff_no = @staff_no;";
                cmd.Parameters.Add(new SQLiteParameter("@staff_no", staff_no));
                cmd.ExecuteNonQuery();
            }
        }

        public static bool CheckDelete(string staff_no)
        {
            bool exists = true;
            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"select count(*) from transation where created_by = @staff_no or updated_by = @staff_no;";
                cmd.Parameters.Add(new SQLiteParameter("@staff_no", staff_no));
                exists = cmd.ExecuteScalar().ToIntEx() > 0 ? true : false;
                if(exists == false)
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = @"select count(*) from item where created_by = @staff_no or updated_by = @staff_no;";
                    cmd.Parameters.Add(new SQLiteParameter("@staff_no", staff_no));
                    exists = cmd.ExecuteScalar().ToIntEx() > 0 ? true : false;
                }
            }
            return exists;
        }

        public static bool InsertUpdateRow(DataRow row)
        {
            bool result = false;
            if (CheckStaff_no(row[0].ToStringEx()))
            {
                if (CheckStaff_id(row[0].ToStringEx(), row[0].ToStringEx()))
                {
                    //public static bool UpdateRow(string no, string id, string name, string status, string staff_pw)
                    result = UpdateRow(
                        row[0].ToStringEx(),
                        row[2].ToStringEx(),
                        row[1].ToStringEx(),
                        row[3].ToStringEx(),
                        "bh1234!") ;
                }
                else
                    result = false;
            }
            else
                result = InsertRow(row[0].ToStringEx(), row[2].ToStringEx(), row[1].ToStringEx(), "bh1234!");
            return result;
        }

        public static bool InsertRow(string no, string id, string name, string pw)
        {
            bool result = false;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into user (staff_no, staff_name, staff_status, staff_id, staff_pw, created_by, created_at) values (@staff_no, @staff_name, @staff_status, @staff_id, @staff_pw, @created_by, @created_at)";

                    cmd.Parameters.Add(new SQLiteParameter("@staff_no", no));
                    cmd.Parameters.Add(new SQLiteParameter("@staff_name", name));
                    cmd.Parameters.Add(new SQLiteParameter("@staff_status", 1));
                    cmd.Parameters.Add(new SQLiteParameter("@staff_id", id));
                    cmd.Parameters.Add(new SQLiteParameter("@staff_pw", pw));
                    cmd.Parameters.Add(new SQLiteParameter("@created_by", SessionManager.UserId));
                    cmd.Parameters.Add(new SQLiteParameter("@created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")));
                    cmd.ExecuteNonQuery();
                }
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        public static bool UpdateRow(string no, string id, string name, string status, string staff_pw)
        {
            bool result = false;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"
update 
    user
set
    staff_id = @staff_id, 
    staff_name = @staff_name, 
    staff_pw = @staff_pw, 
    updated_by = @updated_by, 
    updated_at = @updated_at
where
    staff_no = @staff_no;";
                    cmd.Parameters.Add(new SQLiteParameter("@staff_no", no));
                    cmd.Parameters.Add(new SQLiteParameter("@staff_name", name));
                    cmd.Parameters.Add(new SQLiteParameter("@staff_id", id));
                    cmd.Parameters.Add(new SQLiteParameter("@staff_status", status == "재직" ? 1 : 0));
                    cmd.Parameters.Add(new SQLiteParameter("@staff_pw", staff_pw));
                    cmd.Parameters.Add(new SQLiteParameter("@updated_by", SessionManager.UserId));
                    cmd.Parameters.Add(new SQLiteParameter("@updated_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")));
                    cmd.ExecuteNonQuery();
                }
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public static bool CheckStaff_id(string staff_no, string staff_id)
        {
            bool exists = true;
            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                 
                cmd.CommandText = @"select count(*) from user where staff_no <> @staff_no and staff_id = @staff_id;";
                cmd.Parameters.Add(new SQLiteParameter("@staff_no", staff_no));
                cmd.Parameters.Add(new SQLiteParameter("@staff_id", staff_id));
                exists = cmd.ExecuteScalar().ToIntEx() == 0 ? true : false;
            }
            return exists;
        }

        public static bool CheckStaff_no(string staff_no)
        {
            bool exists = true;
            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"select count(*) from user where staff_no = @staff_no;";
                cmd.Parameters.Add(new SQLiteParameter("@staff_no", staff_no));
                exists = cmd.ExecuteScalar().ToIntEx() > 0 ? true : false;
            }
            return exists;
        }
    }
}
