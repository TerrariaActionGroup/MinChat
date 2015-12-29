using ESPlus.Application.Basic.Server;
using MinChatServer.db.dao;
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
            UserDBManager userDBManager = UserDBManager.getInstance();
            if (userDBManager.varifyUser(userID, password) == false)
            {
                failureCause = "账号或密码错误";
                return false;
            }
            failureCause = "";
            return true;
        }
    }
}
