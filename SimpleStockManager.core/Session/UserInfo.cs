using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStockManager.core.Session
{
    public class UserInfo
    {
        public string UserId { get; private set; }
        public string UserName { get; private set; }

        public string UserMobile { get; private set; }
        public string UserEmail { get; private set; }
        public bool IsAdmin { get; private set; }
        public UserTypes UserType { get; private set; }

        public void SetInfoAdmin()
        {
            UserId = "ssmadmin";
            UserName = "관리자";
            UserMobile = "010-9126-8196";
            UserEmail = "bhsoft.contact@gmail.com";
            IsAdmin = true;
            UserType = UserTypes.관리자;
        }

        public void SetInfo(UserModel userModel)
        {
            SetValue(userModel);
        }

        public void Refresh(UserModel userModel)
        {
            SetValue(userModel);
        }

        private void SetValue(UserModel userModel)
        {
            UserName = userModel.UserName;
            UserMobile = userModel.UserMobile;
            UserEmail = userModel.UserEmail;
            IsAdmin = userModel.IsAdmin;
            UserId = userModel.UserId;
            UserType = userModel.UserType;
        }
    }
}
