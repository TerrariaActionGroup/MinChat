using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace MinChatWeb
{
    class UserDBManager
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
        /// 添加一个用户
        /// </summary>
        /// <param name="aUser"></param>
        /// <returns></returns>
        public bool addUser(CustomizeUser aUser)
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

        public Int64 getNewUserId()
        {
            string cmdString = "SELECT COUNT(*) FROM " +
                DBcolumns.TABLE_USER;
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + Constant.globalDbPath + "global.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            Int64 x = (Int64)cmd.ExecuteScalar();
            conn.Close();
            return x + 10000;
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
            ExecuteNonQuery(cmdString, Constant.globalDbPath + "global.db");
            return true;
        }
    }
}
