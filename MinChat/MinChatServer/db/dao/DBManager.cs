using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinChatServer.db.minterface;
using MinChatServer.db.bean;
using System.Data.SQLite;

namespace MinChatServer.db.dao
{
    public class DBManager : DBHelper
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

        #region
        /// <summary>
        /// 创建全局数据库
        /// </summary>
        /// <returns></returns>
        public bool createGlobalDb()
        {
            if (!System.IO.File.Exists(Constant.globalDbPath))
            {
                SQLiteConnection.CreateFile(Constant.globalDbPath);
            }
            return true;
        }

        /// <summary>
        /// 创建用户信息表
        /// </summary>
        /// <returns></returns>
        public bool createUserTable()
        {

            string cmdString = "CREATE TABLE IF NOT EXISTS" +
                DBcolumns.TABLE_USER + "(" +
                DBcolumns.USER_ID + " varchar(20)," +
                DBcolumns.USER_PWD + " varchar(40)," +
                DBcolumns.USER_NAME + " varchar(40)," +
                DBcolumns.USER_SEX + " integer," +
                DBcolumns.USER_AGE + " integer," +
                DBcolumns.USER_BIRTHDAY + " date," +
                DBcolumns.USER_ADDRESS + " varchar(100)," +
                DBcolumns.USER_TIME + " time)";
            ExecuteNonQuery(cmdString, Constant.globalDbPath);
            return true;
        }
        /// <summary>
        /// 创建群信息表
        /// </summary>
        /// <returns></returns>
        public bool createGroupTable()
        {
            string cmdString = "CREATE TABLE IF NOT EXISTS" +
                DBcolumns.TABLE_GROUP + "(" +
                DBcolumns.GROUP_ID + " integer," +
                DBcolumns.GROUP_NAME + " varchar(40)," +
                DBcolumns.GROUP_NUM + " integer," +
                DBcolumns.GROUP_TIME + " date," +
                DBcolumns.GROUP_NOTICE + " text," +
                DBcolumns.GROUP_TYPE + " varchar(20))";
            ExecuteNonQuery(cmdString, Constant.globalDbPath);
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
            string dbPath = Constant.groupDbPath;
            if (!System.IO.File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }
            return true;
        }

        /// <summary>
        /// 创建每个群群成员信息表
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public bool createGroupPersonTable(string groupId)
        {
            
            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                groupId + "(" +
                DBcolumns.GROUP_USER_ID + " varchar(20)," +
                DBcolumns.GROUP_IN_TIME + " date," +
                DBcolumns.GROUP_STATU_TYPE + " integer)";
            ExecuteNonQuery(cmdString, Constant.groupDbPath);
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
            string dbPath = Constant.userDbPath + "\\" + userId + ".db";
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
        public bool createMsgTable()
        {

            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                DBcolumns.TABLE_MSG + "(" +
                DBcolumns.MSG_ID + " integer," +
                DBcolumns.MSG_TO + " varchar(20)," +
                DBcolumns.MSG_CONTENT + " text)";
            ExecuteNonQuery(cmdString, Constant.userDbPath);
            return true;
        }

        /// <summary>
        /// 创建好友关系数据表
        /// </summary>
        /// <returns></returns>
        public bool createRelationTable()
        {
            
            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                DBcolumns.TABLE_RELATION + "(" +
                DBcolumns.RELATION_ID + " varchar(20)," +
                DBcolumns.RELATION_USER_ID + " varchar(20)," +
                DBcolumns.FGROUP_ID + " integer" +
                DBcolumns.RELATION_TIME + " date)";
            ExecuteNonQuery(cmdString, Constant.userDbPath);
            return true;
        }

        /// <summary>
        /// 创建个人分组数据表
        /// </summary>
        /// <returns></returns>
        public bool createMgroupTable()
        {
            string cmdString = "CREATE TABLE IF NOT EXISTS " +
                DBcolumns.TABLE_MGROUP + "(" +
                DBcolumns.MGROUP_ID + " integer," +
                DBcolumns.MGROUP_NAME + " varchar(40)," +
                DBcolumns.MGROUP_NUM + " integer)";
            ExecuteNonQuery(cmdString, Constant.userDbPath);
            return true;
        }
        #endregion
    }
}
