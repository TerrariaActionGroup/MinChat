using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace MinChatWeb
{
    class UserDBManager
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
        /// <summary>
        /// 获取一个(可能)唯一的用户ID
        /// </summary>
        /// <returns>用户ID</returns>
        public Int64 getNewUserId()
        {
            string cmdString = "SELECT COUNT(*) FROM " +
                DBcolumns.TABLE_USER;
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + Constant.globalDbPath + "global.db");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            Int64 x = (Int64)cmd.ExecuteScalar();
            conn.Close();
            return x + 10001;
        }

        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="userId">要删除用户的ID</param>
        /// <returns>成功？</returns>
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
