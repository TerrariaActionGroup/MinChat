using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChat.Settings
{
    class Constant
    {
        //服务器相关
        #region
        //public static string serverIP = "114.215.103.65";
        public static string serverIP = "127.0.0.1";
        public static int serverPort = 4530;
        #endregion

        //分隔符
        public static string SPLIT = "卍";

        //自定义消息类型
        #region
        public static int MSGTEXT = 1;
        public static int MSGIMG = 2;
        #endregion
    }
}
