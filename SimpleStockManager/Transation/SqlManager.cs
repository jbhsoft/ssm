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
using System.Xml.Linq;

namespace SimpleStockManager.Transation
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
    t.seq,
    case when t.type = 1 then '입고' else '출고' end as type,
    t.item_cd, 
    i.item_name, 
    t.qty,
    t.date,
    t.created_at, 
    t.created_by,
    t.updated_at, 
    t.updated_by
FROM
    transation as t
    left join 
    item as i
    on t.item_cd = i.item_cd
ORDER BY
    t.date;";

                result.Load(cmd.ExecuteReader());

            }
            return result;
        }

        public static DataTable FindRow(int seq)
        {
            DataTable result = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"
SELECT 
    t.seq,
    case when t.type = 1 then '입고' else '출고' end as type,
    t.item_cd, 
    i.item_name, 
    i.item_um,
    t.qty
FROM
    transation as t
    left join 
    item as i
    on t.item_cd = i.item_cd
where 
    t.seq = @seq";

                cmd.Parameters.Add(new SQLiteParameter("@seq", seq));
                result.Load(cmd.ExecuteReader());

            }
            return result;
        }

        public static DataTable FindData(string item_code)
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
FROM 
    item
WHERE
    item_cd = @item_cd;"; 
                cmd.Parameters.Add(new SQLiteParameter("@item_cd", item_code));
                result.Load(cmd.ExecuteReader());
            }
            return result;
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

        public static void DeleteRow(int seq)
        {
            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"delete from transation where seq = @seq;";
                cmd.Parameters.Add(new SQLiteParameter("@seq", seq));
                cmd.ExecuteNonQuery();
            }
        }

        public static bool SaveTransation(TransationTypes transationType, string item_cd, decimal qty, string strDate = null)
        {
            bool result = false;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
                {
                    conn.Open();
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into transation (type, item_cd, qty, date, created_at, created_by) values (@type, @item_cd, @qty, @date, @created_at, @created_by);";
                    cmd.Parameters.Add(new SQLiteParameter("@type", transationType == TransationTypes.입고 ? 1 : 2));
                    cmd.Parameters.Add(new SQLiteParameter("@item_cd", item_cd));
                    cmd.Parameters.Add(new SQLiteParameter("@qty", qty));
                    cmd.Parameters.Add(new SQLiteParameter("@date", strDate == null ? DateTime.Now.ToString("yyyy-MM-dd") : ""));
                    cmd.Parameters.Add(new SQLiteParameter("@created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")));
                    cmd.Parameters.Add(new SQLiteParameter("created_by", SessionManager.UserId));
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

        public static bool UpdateTransation(int seq, TransationTypes transationType, string item_cd, decimal qty, string date)
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
    transation
set
    type = @type, 
    item_cd = @item_cd, 
    qty = @qty,
    date = @date,
    updated_at = @updated_at,
    updated_by = @updated_by
where
    seq = @seq;";
                    cmd.Parameters.Add(new SQLiteParameter("@seq", seq));
                    cmd.Parameters.Add(new SQLiteParameter("@date", date));
                    cmd.Parameters.Add(new SQLiteParameter("@type", transationType == TransationTypes.입고 ? 1 : 2));
                    cmd.Parameters.Add(new SQLiteParameter("@item_cd", item_cd));
                    cmd.Parameters.Add(new SQLiteParameter("@qty", qty));
                    cmd.Parameters.Add(new SQLiteParameter("@updated_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"))); 
                    cmd.Parameters.Add(new SQLiteParameter("updated_by", SessionManager.UserId));
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
