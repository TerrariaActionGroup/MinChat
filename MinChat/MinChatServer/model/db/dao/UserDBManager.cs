﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinChatServer.db.minterface;
using MinChatServer.db.bean;
using System.Data.SQLite;
using MinChatServer.model.db.bean;

namespace MinChatServer.db.dao
{

    class UserDBManager : UserUtil
    {
        /// <summary>
        /// 私有方法，打开数据库执行除select以外的操作
        /// </summary>
        /// <param name="cmdString">操作串</param>
        /// <param name="dbPath">数据库路径</param>
        private static void ExecuteNonQuery(string cmdString, string dbPath)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + dbPath);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
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
            string cmdString = "SELECT * FROM " +
                DBcolumns.TABLE_USER + " WHERE " +
                DBcolumns.USER_ID + " = \'" + id + "\'";
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + Constant.globalDbPath + "global.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        /// <summary>
        /// 验证用户的登录
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="pwd">密码</param>
        /// <returns>成功？</returns>
        public bool varifyUser(string userId, string pwd)
        {
            string cmdString = "SELECT * FROM " +
                DBcolumns.TABLE_USER + " WHERE " +
                DBcolumns.USER_ID + " = \'" +
                userId + "\' AND " +
                DBcolumns.USER_PWD + " = \'" +
                pwd + "\'";
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + Constant.globalDbPath + "global.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="aUser">用户</param>
        /// <returns>成功？</returns>
        public bool addUser(User aUser)
        {
            string cmdString = "INSERT INTO " +
                DBcolumns.TABLE_USER + " VALUES(\'" +
                aUser.UserId + "\',\'" +
                aUser.UserPwd + "\',\'" +
                aUser.UserName + "\'," +
                aUser.Sex + "," +
                aUser.Age + ",\'" +
                aUser.Birthday + "\',\'" +
                aUser.Address + "\',\'" +
                aUser.Time + "\')";
            ExecuteNonQuery(cmdString, Constant.globalDbPath + "global.db");
            return true;
        }

        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>成功？</returns>
        public bool deleteUser(string userId)
        {
            string cmdString = "DELETE FROM " +
                DBcolumns.TABLE_USER + " WHERE " +
                DBcolumns.USER_ID + " = \'" + userId + "\'";
            ExecuteNonQuery(cmdString, Constant.globalDbPath + "global.db");
            return true;
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>用户资料</returns>
        public User queryUser(string userId)
        {
            string cmdString = "SELECT * FROM " +
                DBcolumns.TABLE_USER + " WHERE " +
                DBcolumns.USER_ID + " =\'" + userId + "\'"; ;
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + Constant.globalDbPath + "global.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                User u = new User();
                u.UserId = dr.GetString(0);
                u.UserPwd = "";
                u.UserName = dr.GetString(2);
                u.Sex = dr.GetInt32(3);
                u.Age = dr.GetInt32(4);
                u.Birthday = dr.GetString(5);
                u.Address = dr.GetString(6);
                u.Time = dr.GetString(7);
                u.Remark = "";
                conn.Close();
                return u;
            }
            conn.Close();
            return null;
        }

        /// <summary>
        /// 添加好友
        /// </summary>
        /// <param name="masterId">用户ID</param>
        /// <param name="userId">好友ID</param>
        /// <returns>成功？</returns>
        public bool addFriend(string masterId, string userId)
        {
            string cmdString = "INSERT INTO " +
                DBcolumns.TABLE_RELATION + "(" +
                DBcolumns.RELATION_USER_ID + "," +
                DBcolumns.FGROUP_ID + "," +
                DBcolumns.RELATION_TIME + ") VALUES(\'" +
                userId + "\',\'" +
                0 + "\',\'" +
                DateTime.Now.ToString() + "\')";
            ExecuteNonQuery(cmdString, Constant.userDbPath + "user" + masterId + ".db");
            return true;
        }

        /// <summary>
        /// 删除好友
        /// </summary>
        /// <param name="masterId">用户ID</param>
        /// <param name="userId">好友ID</param>
        /// <returns>成功？</returns>
        public bool deleteFriend(string masterId, string userId)
        {
            string cmdString = "DELETE FROM " +
                DBcolumns.TABLE_RELATION + " WHERE " +
                //DBcolumns.RELATION_ID + " = \'" + masterId + "\' AND " +
                DBcolumns.RELATION_USER_ID + " = \'" + userId + "\'";
            ExecuteNonQuery(cmdString, Constant.userDbPath + "user" + masterId + ".db");
            return true;
        }

        /// <summary>
        /// 查询每个人的所有好友
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>好友ID列表</returns>
        public List<string> queryFriends(string userId)
        {
            List<string> friend = new List<string>();
            string cmdString = "SELECT " +
                DBcolumns.RELATION_USER_ID + " FROM " +
                DBcolumns.TABLE_RELATION;
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + Constant.userDbPath + "user" + userId + ".db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                friend.Add(dr.GetString(0));
            }
            conn.Close();
            return friend;
        }

        /// <summary>
        /// 添加未读消息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="msg">消息</param>
        /// <returns>成功？</returns>

        public bool addMsg(string userId, string msg, int type)
        {
            string cmdString = "INSERT INTO " +
                DBcolumns.TABLE_MSG + "(" +
                DBcolumns.MSG_TO + "," +
                DBcolumns.MSG_CONTENT + "," +
                DBcolumns.MSG_TYPE + ") VALUES(\'" +
                //msgId + ",\'" +
                userId + "\',\'" +
                msg + "\'," +
                type + ")";
            ExecuteNonQuery(cmdString, Constant.userDbPath + "user" + userId + ".db");
            return true;
        }

        /// <summary>
        /// 删除一个人的未读消息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>成功？</returns>
        public bool deleteMsg(string userId)
        {
            string cmdString = "DELETE FROM " +
                DBcolumns.TABLE_MSG;
            ExecuteNonQuery(cmdString, Constant.userDbPath + "user" + userId + ".db");
            return true;
        }

        /// <summary>
        /// 得到一个人所有未读消息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>（类型号 + Constant.SPLIT + 内容)</returns>
        public List<Msg> queryMsgs(string userId)
        {
            List<Msg> msg = new List<Msg>();
            Msg amsg = new Msg();
            string cmdString = "SELECT " +
                DBcolumns.MSG_CONTENT + "," +
                DBcolumns.MSG_TYPE + " FROM " +
                DBcolumns.TABLE_MSG;
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + Constant.userDbPath + "user" + userId + ".db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                amsg.Type = dr.GetInt32(1);
                amsg.Content = dr.GetString(0);
                msg.Add(amsg);
            }
            return msg;
        }
    }
}
