using DevExpress.XtraEditors.Internal;
using SimpleStockManager.core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStockManager.core.Session
{
    public class SessionManager
    {
        #region static Properties

        /// <summary>
        /// 현재 로그인한 유저 아이디
        /// </summary>
        public static string UserId
        {
            get
            {
                return GetCurrentSession().UserInfo.UserId;
            }
        }

        public static string UserName
        {
            get
            {
                return GetCurrentSession().UserInfo.UserName;
            }
        }

        #endregion static Properties

        private static SessionHelper _sessionHelper;

        public static SessionHelper GetSessionHelper(SessionModel sessionModel)
        {
            if (_sessionHelper == null)
            {
                SessionHelper.Initiate(sessionModel);
                _sessionHelper = SessionHelper.Instance;
            }

            return _sessionHelper;
        }

        public static SessionHelper GetSeetionHelperAdmin(SessionModel sessionModel)
        {
            if (_sessionHelper == null)
            {
                SessionHelper.InitiateAdmin(sessionModel);
                _sessionHelper = SessionHelper.Instance;
            }

            return _sessionHelper;
        }

        public static SessionHelper Current
        {
            get { return _sessionHelper; }
        }

        public static SessionHelper GetCurrentSession()
        {
            return _sessionHelper;
        }

        public static void RefreshSessionHelper(SessionModel sessionModel)
        {
            GetSessionHelper(sessionModel);

            _sessionHelper.RefreshUserInfo(sessionModel);
        }
    }
}
