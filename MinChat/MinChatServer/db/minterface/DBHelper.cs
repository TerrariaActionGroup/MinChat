using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChatServer.db.minterface
{
    interface DBHelper
    {
        #region
        /// <summary>
        /// 创建全局数据库
        /// </summary>
        /// <returns></returns>
        bool createGlobalDb();

        /// <summary>
        /// 创建用户信息表
        /// </summary>
        /// <returns></returns>
        bool createUserTable();

        /// <summary>
        /// 创建群信息表
        /// </summary>
        /// <returns></returns>
        bool createGroupTable();
        #endregion

        #region
        /// <summary>
        /// 创建用于存储群成员表的数据库
        /// </summary>
        /// <returns></returns>
        bool createGroupDb();

        /// <summary>
        /// 创建每个群群成员信息表
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        bool createGroupPersonTable(string groupId);
        #endregion

        #region
        /// <summary>
        /// 创建用户个人数据库
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool createUserDb(string userId);

        /// <summary>
        /// 创建未读消息数据表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool createMsgTable(string userId);
        
        /// <summary>
        /// 创建好友关系数据表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool createRelationTable(string userId);
        /// <summary>
        /// 创建个人分组数据表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool createMgroupTable(string userId);
        #endregion
    }
}
