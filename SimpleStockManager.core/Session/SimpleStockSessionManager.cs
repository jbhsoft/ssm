using BH_Library.Utils; 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStockManager.core.Session
{
    public class SimpleStockSessionManager
    {
        public static SessionModel GetSessionHelper(string userID)
        {
            SessionModel model = new SessionModel();
            SimpleStockSessionManager manager = new SimpleStockSessionManager();
            if (userID.ToLower() == SimpleStockCommon.AdministratorID)
            {
                UserModel adminModel = new UserModel();
                adminModel.UserId = SimpleStockCommon.AdministratorID;
                adminModel.UserName = "관리자";
                adminModel.IsAdmin = true;
                model.UserModel = adminModel;
            }
            else
            {
                model.UserModel = manager.GetUserModel(userID); 
            }

            return model;
        }

        private SessionModel sessionModel = null;
        public SessionModel SessionModel { get { return sessionModel; } }

        private UserModel GetUserModel(string userId)
        {
            UserModel model = new UserModel(); 

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(SimpleStockCommon.SqlitePath))
            {
                conn.Open(); 
                SQLiteCommand cmd = conn.CreateCommand();  
                cmd.CommandText = "SELECT * FROM user WHERE staff_id = @staff_id;";
                cmd.Parameters.Add(new SQLiteParameter("@staff_id", userId));

                dt.Load(cmd.ExecuteReader());
            }

            if(dt.Rows.Count > 0)
            {
                model.UserId = userId;
                model.UserName = dt.Rows[0]["staff_name"].ToStringEx();
                model.IsAdmin = false;
                model.UserType = (UserTypes)dt.Rows[0]["staff_status"].ToIntEx();
            }


            return model;
        }
    }
}
