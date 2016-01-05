using MinChatServer.db.bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChatServer.db.minterface
{
    interface GroupUtil
    {
        /// <summary>
        /// 添加一个群,个人分组也是
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        bool addGroup(Group group);

        /// <summary>
        /// 删除一个群组
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        bool deleteGroup(int groupId);

        /// <summary>
        /// 查询群的资料
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        Group queryGroup(int groupId);

        /// <summary>
        /// 用户加入群组
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="groupId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        bool userIntoGroup(string userId, int groupId, int type);

        /// <summary>
        /// 查询群组所有成员
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        List<string> queryGroupMates(int groupId);
    }
}
