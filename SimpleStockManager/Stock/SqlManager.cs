using BH_Library.Utils;
using SimpleStockManager.core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStockManager.Stock
{
    internal class SqlManager
    {
        public static DataTable LoadList(string date)
        {
            DataTable result = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"
SELECT 
	t.item_cd as item_cd, 
	min(i.item_name) as item_name, 
	sum(CASE WHEN t.type = 1 THEN t.qty ELSE t.qty * -1 END) as qty
FROM 
	transation as t
	LEFT JOIN
	item as i
	ON t.item_cd = i.item_cd
WHERE
	t.date <= @date
GROUP BY
	t.item_cd;";
                cmd.Parameters.Add(new SQLiteParameter("@date", date));
                result.Load(cmd.ExecuteReader());
            }
            return result;
        }

        public static DataTable LoadListDetail(string date, string item_cd)
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
WHERE
    t.date <= @date
    AND t.item_cd = @item_cd
ORDER BY
    t.date;";
                cmd.Parameters.Add(new SQLiteParameter("@date", date));
                cmd.Parameters.Add(new SQLiteParameter("@item_cd", item_cd));
                result.Load(cmd.ExecuteReader());
            }
            return result;
        }
    }
}
