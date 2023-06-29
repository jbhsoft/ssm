using BH_Library.Utils;
using BH_Library.Utils.SystemInfo;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.XtraEditors.Internal;
using SimpleStockManager.core;
using SimpleStockManager.core.Session;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStockManager.Product
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
    item_cd, 
    item_name, 
    item_um, 
    case when item_status = 1 then '사용' else '사용불가' end as item_status,
    created_at, 
    created_by,
    updated_at,
    updated_by
FROM item;"; 
                result.Load(cmd.ExecuteReader());

            }
            return result;
        }

        public static bool CheckItemCd(string item_cd)
        {
            bool exists = true;
            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"select count(*) from item where item_cd = @item_cd;";
                cmd.Parameters.Add(new SQLiteParameter("@item_cd", item_cd));
                exists = cmd.ExecuteScalar().ToIntEx() > 0 ? true : false;
            }
            return exists;
        }

        public static bool InsertRow(string item_cd, string name, decimal item_um)
        {
            bool result = false;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into item (item_cd, item_name, item_um, item_status, created_by, created_at) values (@item_cd, @item_name, @item_um, @item_status, @created_by, @created_at);";
                    cmd.Parameters.Add(new SQLiteParameter("@item_cd", item_cd));
                    cmd.Parameters.Add(new SQLiteParameter("@item_name", name));
                    cmd.Parameters.Add(new SQLiteParameter("@item_um", item_um));
                    cmd.Parameters.Add(new SQLiteParameter("@item_status", 1));
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

        public static void DeleteRow(string item_cd)
        {
            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"delete from item where item_cd = @item_cd;";
                cmd.Parameters.Add(new SQLiteParameter("@item_cd", item_cd));
                cmd.ExecuteNonQuery();
            }
        }

        public static bool CheckDelete(string item_cd)
        {
            bool exists = true;
            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"select count(*) from teansation where item_cd = @item_cd;";
                cmd.Parameters.Add(new SQLiteParameter("@item_cd", item_cd));
                exists = cmd.ExecuteScalar().ToIntEx() > 0 ? true : false;
            }
            return exists;
        }

        public static bool InsertUpdateRow(DataRow row)
        {
            bool result = false;
            //상품코드(문자)	상품명(문자)	 단가(숫자) 	사용상태( [가능/불가능] 중 선택)
            if (CheckItemCd(row[0].ToStringEx()))
                result = UpdateRow(row[0].ToStringEx(), row[1].ToStringEx(), row[2].ToDecimalEx(), row[3].ToStringEx() == "사용" ? 0 : -1);
            else
                result = InsertRow(row[0].ToStringEx(), row[1].ToStringEx(), row[2].ToDecimalEx());
            return result;
        }

        public static bool UpdateRow(string item_cd, string name, decimal item_um, int status)
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
    item
set
    item_name = @item_name, 
    item_um = @item_um, 
    item_status = @item_status, 
    updated_by = @updated_by, 
    updated_at = @updated_at
where
    item_cd = @item_cd;";
                    cmd.Parameters.Add(new SQLiteParameter("@item_cd", item_cd));
                    cmd.Parameters.Add(new SQLiteParameter("@item_name", name));
                    cmd.Parameters.Add(new SQLiteParameter("@item_um", item_um));
                    cmd.Parameters.Add(new SQLiteParameter("@item_status", status + 1));
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
    }
}
