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
    class DBManager : DBHelper
    {
        #region
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

        private static DBManager dbManager = null;

        /// <summary>
        /// 获得单例DBManager对象
        /// </summary>
        /// <returns></returns>
        public static DBManager getInstance()
        {
            if (dbManager == null)
            {
                dbManager = new DBManager();
            }
            return dbManager;
        }
        #endregion

        #region
        /// <summary>
        /// 创建全局数据库
        /// </summary>
        /// <returns>成功？</returns>
        public bool createGlobalDb()
        {
            if (!System.IO.File.Exists(Constant.globalDbPath + "global.db")) 
            {
                SQLiteConnection.CreateFile(Constant.globalDbPath + "global.db");
            }
            return true;
        }

        /// <summary>
        /// 创建用户信息表
        /// </summary>
        /// <returns>成功？</returns>
        public bool createUserTable()
        {

            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                DBcolumns.TABLE_USER + "(" +
                DBcolumns.USER_ID + " varchar(20) PRIMARY KEY," +
                DBcolumns.USER_PWD + " varchar(40) NOT NULL," +
                DBcolumns.USER_NAME + " varchar(40) NOT NULL," +
                DBcolumns.USER_SEX + " integer," +
                DBcolumns.USER_AGE + " integer," +
                DBcolumns.USER_BIRTHDAY + " date," +
                DBcolumns.USER_ADDRESS + " varchar(100)," +
                DBcolumns.USER_TIME + " date)";
            ExecuteNonQuery(cmdString, Constant.globalDbPath + "global.db");
            return true;
        }
        /// <summary>
        /// 创建群信息表
        /// </summary>
        /// <returns>成功？</returns>
        public bool createGroupTable()
        {
            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                DBcolumns.TABLE_GROUP + "(" +
                DBcolumns.GROUP_ID + " integer PRIMARY KEY AUTOINCREMENT," +
                DBcolumns.GROUP_NAME + " varchar(40) NOT NULL," +
                DBcolumns.GROUP_NUM + " integer," +
                DBcolumns.GROUP_TIME + " date NOT NULL," +
                DBcolumns.GROUP_NOTICE + " text," +
                DBcolumns.GROUP_TYPE + " varchar(20))";
            ExecuteNonQuery(cmdString, Constant.globalDbPath + "global.db");
            return true;
        }
        #endregion

        #region
        /// <summary>
        /// 创建用于存储群成员表的数据库
        /// </summary>
        /// <returns>成功？</returns>
        public bool createGroupDb()
        {
            string dbPath = Constant.groupDbPath;
            if (!System.IO.File.Exists(dbPath + "groupPerson.db"))
            {
                SQLiteConnection.CreateFile(dbPath + "groupPerson.db");
            }
            return true;
        }

        /// <summary>
        /// 创建每个群群成员信息表
        /// </summary>
        /// <param name="groupId">群ID</param>
        /// <returns>成功？</returns>
        public bool createGroupPersonTable(string groupId)
        {
            
            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                "group" + groupId + "(" +
                DBcolumns.GROUP_USER_ID + " varchar(20) PRIMARY KEY," +
                DBcolumns.GROUP_IN_TIME + " date NOT NULL," +
                DBcolumns.GROUP_STATU_TYPE + " integer)";
            ExecuteNonQuery(cmdString, Constant.groupDbPath + "groupPerson.db");
            return true;
        }
        #endregion

        #region
        /// <summary>
        /// 创建用户个人数据库
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>成功？</returns>
        public bool createUserDb(string userId)
        {
            string dbPath = Constant.userDbPath + "user" + userId + ".db";
            if (!System.IO.File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }
            return true;
        }

        /// <summary>
        /// 创建未读消息数据表
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>成功？</returns>
        public bool createMsgTable(string userId)
        {

            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                DBcolumns.TABLE_MSG + "(" +
                DBcolumns.MSG_ID + " integer PRIMARY KEY AUTOINCREMENT," +
                DBcolumns.MSG_TO + " varchar(20)," +
                DBcolumns.MSG_CONTENT + " text," +
                DBcolumns.MSG_TYPE + ")";
            ExecuteNonQuery(cmdString, Constant.userDbPath + "user" + userId + ".db");
            return true;
        }

        /// <summary>
        /// 创建好友关系数据表
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>成功？</returns>
        public bool createRelationTable(string userId)
        {
            
            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                DBcolumns.TABLE_RELATION + "(" +
                DBcolumns.RELATION_ID + " integer PRIMARY KEY AUTOINCREMENT," +
                DBcolumns.RELATION_USER_ID + " varchar(20)," +
                DBcolumns.FGROUP_ID + " integer," +
                DBcolumns.RELATION_TIME + " date,"+
                DBcolumns.REMARK + "varchar(40))";
            ExecuteNonQuery(cmdString, Constant.userDbPath + "user" + userId + ".db");
            return true;
        }

        /// <summary>
        /// 创建个人分组数据表
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns>成功？</returns>
        public bool createMgroupTable(string userId)
        {
            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                DBcolumns.TABLE_MGROUP + "(" +
                DBcolumns.MGROUP_ID + " integer PRIMARY KEY," +
                DBcolumns.MGROUP_NAME + " varchar(40) UNIQUE NOT NULL," +
                DBcolumns.MGROUP_NUM + " integer)";
            ExecuteNonQuery(cmdString, Constant.userDbPath + "user" + userId + ".db");
            return true;
        }
        #endregion
    }
}
