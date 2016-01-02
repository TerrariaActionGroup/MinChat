using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinChatServer.db.bean;
using System.Data.SQLite;

namespace MinChatServer.db.dao
{
    class DBManager
    {

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

        #region

        /// <summary>
        /// 创建用户个人数据库
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
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
        /// <returns></returns>
        public bool createMsgTable(string userId)
        {

            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                DBcolumns.TABLE_MSG + "(" +
                DBcolumns.MSG_ID + " integer PRIMARY KEY AUTOINCREMENT," +
                DBcolumns.MSG_TO + " varchar(20)," +
                DBcolumns.MSG_CONTENT + " text)";
            ExecuteNonQuery(cmdString, Constant.userDbPath + "user" + userId + ".db");
            return true;
        }

        /// <summary>
        /// 创建好友关系数据表
        /// </summary>
        /// <returns></returns>
        public bool createRelationTable(string userId)
        {
            
            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                DBcolumns.TABLE_RELATION + "(" +
                DBcolumns.RELATION_ID + " integer PRIMARY KEY AUTOINCREMENT," +
                DBcolumns.RELATION_USER_ID + " varchar(20)," +
                DBcolumns.FGROUP_ID + " integer," +
                DBcolumns.RELATION_TIME + " date)";
            ExecuteNonQuery(cmdString, Constant.userDbPath + "user" + userId + ".db");
            return true;
        }

        /// <summary>
        /// 创建个人分组数据表
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 创建群信息表
        /// </summary>
        /// <returns></returns>
        public bool createGroupTable(string userId)
        {
            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                DBcolumns.TABLE_GROUP + "(" +
                DBcolumns.GROUP_ID + " integer PRIMARY KEY AUTOINCREMENT," +
                DBcolumns.GROUP_NAME + " varchar(40) NOT NULL," +
                DBcolumns.GROUP_NUM + " integer," +
                DBcolumns.GROUP_TIME + " date NOT NULL," +
                DBcolumns.GROUP_NOTICE + " text," +
                DBcolumns.GROUP_TYPE + " varchar(20))";
            ExecuteNonQuery(cmdString, Constant.userDbPath + "user" + userId + ".db");
            return true;
        }
        #endregion
    }
}
