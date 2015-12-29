﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinChatServer.db.minterface;
using MinChatServer.db.bean;
using System.Data.SQLite;

namespace MinChatServer.db.dao
{
    
    class UserDBManager:UserUtil
    {
        private static void ExecuteNonQuery(string cmdString, string dbPath)
        {
            SQLiteConnection conn = new SQLiteConnection(dbPath);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        /// <summary>
        /// 检查某用户是否在数据库中
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool checkOneUser(string id)
        {
            string cmdString = "SELETE * FROM " +
                DBcolumns.TABLE_USER + "WHERE " +
                DBcolumns.USER_ID + " = \'" + id + "\'";
            SQLiteConnection conn = new SQLiteConnection(Constant.groupDbPath);
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
        /// <param name="userId"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool varifyUser(string userId, string pwd)
        {
            string cmdString = "SELETE * FROM " +
                DBcolumns.TABLE_USER + "WHERE " +
                DBcolumns.USER_ID + " = \'" +
                userId + "\' AND "+
                DBcolumns.USER_PWD + " = \'"+
                pwd;
            SQLiteConnection conn = new SQLiteConnection(Constant.groupDbPath);
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
        /// <param name="aUser"></param>
        /// <returns></returns>
        public bool addUser(User aUser)
        {
            string cmdString = "INSERT INTO "+
                DBcolumns.TABLE_USER+" VALUES(\'"+
                aUser.UserId+"\',\'"+
                aUser.UserPwd+"\',\'"+
                aUser.UserName+"\',"+
                aUser.Sex+","+
                aUser.Age+",\'"+
                aUser.Birthday+"\',\'"+
                aUser.Address+"\',\'"+
                aUser.Time+"\')";
            ExecuteNonQuery(cmdString, Constant.globalDbPath);
            return true;
        }

        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool deleteUser(string userId)
        {
            string cmdString = "DELETE FROM " +
                DBcolumns.TABLE_USER + " WHERE " +
                DBcolumns.USER_ID + " = \'" + userId + "\'";
            ExecuteNonQuery(cmdString, Constant.globalDbPath);
            return true;
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<string> queryUser(string userId)
        {
            List<string> userdata = new List<string>();
            string cmdString = "SELETE * FROM " +
                DBcolumns.TABLE_USER;
            SQLiteConnection conn = new SQLiteConnection(Constant.globalDbPath);
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                for(int i = 0;i < 8;i++)
                userdata.Add(dr.GetString(i));
            }
            conn.Close();
            return userdata;
        }

        /// <summary>
        /// 添加好友
        /// </summary>
        /// <param name="masterId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool addFriend(string masterId, string userId)
        {
            string cmdString = "INSERT INTO " +
                DBcolumns.TABLE_RELATION + " VALUES(\'" +
                masterId + "\',\'" +
                userId + "\',\'" +
                0 + "\',\'" +
                DateTime.Now.ToString() + "\')";
            ExecuteNonQuery(cmdString, Constant.globalDbPath);
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
            string cmdString = "DELETE FROM " +
                DBcolumns.TABLE_RELATION + " WHERE " +
                DBcolumns.RELATION_ID + " = \'" + masterId + "\' AND " +
                DBcolumns.RELATION_USER_ID + " = \'" + userId + "\'";
            ExecuteNonQuery(cmdString, Constant.globalDbPath);
            return true;
        }

        /// <summary>
        /// 查询每个人的所有好友
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<string> queryFriends(string userId)
        {
            List<string> friend = new List<string>();
            string cmdString = "SELETE "+
                DBcolumns.RELATION_USER_ID + " FROM " +
                DBcolumns.TABLE_RELATION;
            SQLiteConnection conn = new SQLiteConnection(Constant.userDbPath);
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
        /// <param name="userId"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool addMsg(string userId, string msg)
        {
            string cmdString = "SELECT COUNT(*) FROM " +
                DBcolumns.TABLE_MSG;
            SQLiteConnection conn = new SQLiteConnection(Constant.userDbPath + "\\" + userId + ".db");
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            int msgId = dr.GetInt32(0)+1;
            cmdString = "INSERT INTO " +
                DBcolumns.TABLE_MSG + " VALUES(" +
                msgId + ",\'" +
                userId + "\',\'" +
                msg + "\')";
            ExecuteNonQuery(cmdString, Constant.userDbPath + "\\" + userId + ".db");
            return true;
        }

        /// <summary>
        /// 删除一个人的未读消息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool deleteMsg(string userId)
        {
            string cmdString = "DELETE FROM " +
                DBcolumns.TABLE_MSG + " WHERE " +
                DBcolumns.MSG_TO + " = \'" + userId + "\'";
            ExecuteNonQuery(cmdString, Constant.globalDbPath);
            return true;
        }

        /// <summary>
        /// 得到一个人所有未读消息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<string> queryMsgs(string userId)
        {
            List<string> msg = new List<string>();
            string cmdString = "SELECT "+
                DBcolumns.MSG_CONTENT + " FROM " +
                DBcolumns.TABLE_MSG;
            SQLiteConnection conn = new SQLiteConnection(Constant.userDbPath + "\\" + userId + ".db");
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                msg.Add(dr.GetString(0));
            }
            return msg;
        }
    }
}
