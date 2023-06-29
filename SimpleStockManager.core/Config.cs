using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleStockManager.core
{
    /// <summary>
    /// MAB 설정값을 관리하는 Class입니다.
    /// </summary>
    public static class Config
    {
        public static Mutex RunMutex;
        public static bool IsExitPossible = true; //종료가능 변수
        public static string AES_KEY = "ssm";
        public static DateTime DateRangeStart = DateTime.Now;
        public static DateTime DateRangeEnd = DateTime.Now;
    }
}
