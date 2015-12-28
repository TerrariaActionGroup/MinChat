using ESPlus.Application.Basic.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChatServer.es
{
    public class BasicHandler : IBasicHandler
    {
        /// <summary>
        /// 此处验证用户的账号和密码。返回true表示通过验证。
        /// </summary>  
        public bool VerifyUser(string systemToken, string userID, string password, out string failureCause)
        {
            failureCause = "";
            return true;
        }
    }
}
