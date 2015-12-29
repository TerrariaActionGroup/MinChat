using ESFramework.Server.UserManagement;
using ESPlus.Application.Group.Server;
using MinChatServer.db.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChatServer.es
{
    public class GroupManager : IGroupManager
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
        /// 获取用户的所有组友。
        /// </summary>       
        public List<string> GetGroupmates(string userID)
        {
            return null;
        }

        /// <summary>
        /// 获取目标组的所有成员。
        /// </summary>        
        public List<string> GetGroupMembers(string groupID)
        {
            GroupDBManager manager = GroupDBManager.getInstance();
            return manager.queryGroupMates(int.Parse(groupID));
        }
    }
}
