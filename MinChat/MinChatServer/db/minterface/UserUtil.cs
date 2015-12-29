using MinChatServer.db.bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinChatServer.db.minterface
{
    interface UserUtil
    {
        /// <summary>
        /// 检查某用户是否在数据库中
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool checkOneUser(string id);

        /// <summary>
        /// 验证用户的登录
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        bool varifyUser(string userId, string pwd);

        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="aUser"></param>
        /// <returns></returns>
        bool addUser(User aUser);

        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool deleteUser(string userId);

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<string> queryUser(string userId);

        /// <summary>
        /// 添加好友
        /// </summary>
        /// <param name="masterId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool addFriend(string masterId, string userId);

        /// <summary>
        /// 删除好友
        /// </summary>
        /// <param name="masterId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool deleteFriend(string masterId, string userId);

        /// <summary>
        /// 查询每个人的所有好友
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<string> queryFriends(string userId);

        /// <summary>
        /// 添加未读消息
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        bool addMsg(string userId, string msg);

        /// <summary>
        /// 删除一个人的未读消息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool deleteMsg(string userId);

        /// <summary>
        /// 得到一个人所有未读消息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<string> queryMsgs(string userId);
    }
}
