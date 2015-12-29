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
    class GroupDBManager:GroupUtil
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
        /// 添加一个群,个人分组也是
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public bool addGroup(Group group)
        {
            string cmdString = "INSERT INTO " +
                DBcolumns.TABLE_GROUP + " VALUES(" +
                group.GroupId + ",\'" +
                group.GroupName + "\'," +
                group.Num + ",\'" +
                group.Time + "\',\'" +
                group.Notice + "\',\'" +
                group.Type + "\')";
            ExecuteNonQuery(cmdString, Constant.globalDbPath);
            return true;
        }

        /// <summary>
        /// 删除一个群组
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public bool deleteGroup(int groupId)
        {
            string cmdString = "DELETE FROM " +
                DBcolumns.TABLE_GROUP + " WHERE " +
                DBcolumns.GROUP_ID + " = " + groupId;
            ExecuteNonQuery(cmdString, Constant.globalDbPath);
            return true;
        }

        /// <summary>
        /// 查询群的资料
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public string queryGroup(int groupId)
        {
            StringBuilder group = new StringBuilder();
            string cmdString = "SELETE * FROM "+
                DBcolumns.TABLE_GROUP+" WHERE " +
                DBcolumns.GROUP_ID + " = " + groupId;
            SQLiteConnection conn = new SQLiteConnection(Constant.globalDbPath);
            SQLiteCommand  cmd = new SQLiteCommand(cmdString,conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                group.Append(dr.GetString(1));
            }
            conn.Close();
            return group.ToString();
        }

        /// <summary>
        /// 用户加入群组
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="groupId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool userIntoGroup(string userId, int groupId, int type)
        {
            string cmdString = "INSERT INTO "+
                groupId + " VALUES(\'"+
                userId + "\',\'"+
                DateTime.Now.ToString()+", 2)";
            ExecuteNonQuery(cmdString, Constant.groupDbPath + "\\" + groupId + ".db");
            return true;
        }

        /// <summary>
        /// 查询群组所有成员
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public List<string> queryGroupMates(int groupId)
        {
            List<string> groupmates = new List<string>();
            string cmdString = "SELETE" +
                DBcolumns.GROUP_USER_ID + " FROM " +
                groupId;
            SQLiteConnection conn = new SQLiteConnection(Constant.groupDbPath);
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                groupmates.Add(dr.GetString(0));
            }
            conn.Close();
            return groupmates;
        }
    }
}
