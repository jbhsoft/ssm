using SimpleStockManager.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStockManager.core.Session
{
    public class SessionHelper
    {
        private static SessionHelper _instance;

        public static SessionHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SessionHelper();
                return _instance;
            }
        }

        public static void InitiateAdmin(SessionModel sessionModel)
        {
            UserInfo ui = new UserInfo();
            ui.SetInfoAdmin();
            Instance.UserInfo = ui;
        }

        public static void Initiate(SessionModel sessionModel)
        {
            UserInfo ui = new UserInfo();
            if (sessionModel.UserModel != null)
            {
                ui.SetInfo(sessionModel.UserModel);
                Instance.UserInfo = ui;
            }
        }

        public UserInfo UserInfo
        {
            get;
            private set;
        }


        #region 갱신메소드

        internal void RefreshUserInfo(SessionModel sessionModel)
        {
            UserInfo.Refresh(sessionModel.UserModel);
        }

        #endregion 갱신메소드
    }
}
