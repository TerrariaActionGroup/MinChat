using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinChatServer.db.minterface;
using MinChatServer.db.bean;

namespace MinChatServer.db.dao
{
    class GroupDBManager:GroupUtil
    {
        private static GroupDBManager manager = null;

        /// <summary>
        /// 获得单例GroupDBManager对象
        /// </summary>
        /// <returns></returns>
        public static GroupDBManager getInstance()
        {
            if (manager == null)
            {
                manager = new GroupDBManager();
            }
            return manager;
        }

        /// <summary>
        /// 添加一个群,个人分组也是
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public bool addGroup(Group group)
        {
            return true;
        }

        /// <summary>
        /// 删除一个群组
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public bool deleteGroup(int groupId)
        {
            return true;
        }

        /// <summary>
        /// 查询群的资料
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public string queryGroup(int groupId)
        {
            return null;
        }

        /// <summary>
        /// 用户加入群组
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="groupId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool userIntoGroup(string userId, int groupId, int type)
        {
            return true;
        }

        /// <summary>
        /// 查询群组所有成员
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public List<string> queryGroupMates(int groupId)
        {
            return null;
        }
    }
}
