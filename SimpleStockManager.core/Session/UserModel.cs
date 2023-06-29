using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStockManager.core.Session
{
    public class UserModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }

        public string UserMobile { get; set; }
        public string UserEmail { get; set; }
        public bool IsAdmin { get; set; }
        public UserTypes UserType { get; set; }
    }
}
