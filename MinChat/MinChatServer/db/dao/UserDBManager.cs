using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinChatServer.db.minterface;
using MinChatServer.db.bean;

namespace MinChatServer.db.dao
{
    class UserDBManager:UserUtil
    {
        private static UserDBManager manager = null;

        /// <summary>
        /// 获得单例UserDBManager对象
        /// </summary>
        /// <returns></returns>
        public static UserDBManager getInstance()
        {
            if (manager == null)
            {
                manager = new UserDBManager();
            }
            return manager;
        }

        /// <summary>
        /// 检查某用户是否在数据库中
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool checkOneUser(string id)
        {
            return true;
        }

        /// <summary>
        /// 验证用户的登录
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool varifyUser(string userId, string pwd)
        {
            return true;
        }

        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="aUser"></param>
        /// <returns></returns>
        public bool addUser(User aUser)
        {
            return true;
        }

        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool deleteUser(string userId)
        {
            return true;
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<string> queryUser(string userId)
        {
            return null;
        }

        /// <summary>
        /// 添加好友
        /// </summary>
        /// <param name="masterId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool addFriend(string masterId, string userId)
        {
            return true;
        }

        /// <summary>
        /// 删除好友
        /// </summary>
        /// <param name="masterId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool deleteFriend(string masterId, string userId)
        {
            return true;
        }

        /// <summary>
        /// 查询每个人的所有好友
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<string> queryFriends(string userId)
        {
            return null;
        }

        /// <summary>
        /// 添加未读消息
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool addMsg(string userId, string msg)
        {
            return true;
        }

        /// <summary>
        /// 删除一个人的未读消息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool deleteMsg(string userId)
        {
            return true;
        }

        /// <summary>
        /// 得到一个人所有未读消息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<string> queryMsgs(string userId)
        {
            return null;
        }
    }
}
