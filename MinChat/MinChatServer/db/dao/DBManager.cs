using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinChatServer.db.minterface;

namespace MinChatServer.db.dao
{
    class DBManager : DBHelper
    {
        private static DBManager dbManager = null;

        /// <summary>
        /// 获得单例DBManager对象
        /// </summary>
        /// <returns></returns>
        public static DBHelper getInstance()
        {
            if (dbManager == null)
            {
                dbManager = new DBManager();
            }
            return dbManager;
        }

        #region
        /// <summary>
        /// 创建全局数据库
        /// </summary>
        /// <returns></returns>
        public bool createGlobalDb()
        {
            return true;
        }

        /// <summary>
        /// 创建用户信息表
        /// </summary>
        /// <returns></returns>
        public bool createUserTable()
        {
            return true;
        }

        /// <summary>
        /// 创建群信息表
        /// </summary>
        /// <returns></returns>
        public bool createGroupTable()
        {
            return true;
        }
        #endregion

        #region
        /// <summary>
        /// 创建用于存储群成员表的数据库
        /// </summary>
        /// <returns></returns>
        public bool creatGroupDb()
        {
            return true;
        }

        /// <summary>
        /// 创建每个群群成员信息表
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public bool createGroupPersonTable(string groupId)
        {
            return true;
        }
        #endregion

        #region
        /// <summary>
        /// 创建用户个人数据库
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool createUserDb(string userId)
        {
            return true;
        }

        /// <summary>
        /// 创建未读消息数据表
        /// </summary>
        /// <returns></returns>
        public bool createMsgTable()
        {
            return true;
        }

        /// <summary>
        /// 创建好友关系数据表
        /// </summary>
        /// <returns></returns>
        public bool createRelationTable()
        {
            return true;
        }

        /// <summary>
        /// 创建个人分组数据表
        /// </summary>
        /// <returns></returns>
        public bool createMgroupTable()
        {
            return true;
        }
        #endregion
    }
}
