using ESFramework.Server.UserManagement;
using ESPlus.Application.Friends.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChatServer.es
{
    public class FriendsManager : IFriendsManager
    {
        #region UserManager
        /// <summary>
        /// 在线用户管理器。
        /// </summary> 
        private IUserManager userManager;
        public IUserManager UserManager
        {
            set { userManager = value; }
        }
        #endregion

        /// <summary>
        /// 获取好友列表。
        /// </summary>
        /// <param name="ownerID">主人的UserID</param>
        /// <param name="tag">自定义标签，比如当好友有分类时，可以传分类名称。如果传入null，表示获取所有好友。</param>
        /// <returns>好友列表</returns>
        public List<string> GetFriendsList(string ownerID, string tag)
        {
            return null;
        }
    }
}
