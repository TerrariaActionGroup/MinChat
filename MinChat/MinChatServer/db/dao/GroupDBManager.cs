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
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + dbPath);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(cmdString, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        private static GroupDBManager manager = null;

        /// <summary>
        /// 获得单例GroupDBManager对象
        /// </summary>
        /// <returns></returns>
        public static GroupDBManager getInstance()
        {
            if (manager == null)
            {
                manager = new GroupDBManager();
            }
            return manager;
        }

        /// <summary>
        /// 添加一个群,个人分组也是
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public bool addGroup(Group group)
        {
            string cmdString = "INSERT INTO " +
                DBcolumns.TABLE_GROUP + "("+
                DBcolumns.GROUP_NAME+","+
                DBcolumns.GROUP_NUM + ","+
                DBcolumns.GROUP_TIME+","+
                DBcolumns.GROUP_NOTICE+","+
                DBcolumns.GROUP_TYPE+") VALUES(\'" +
                //group.GroupId + ",\'" +
                group.GroupName + "\'," +
                group.Num + ",\'" +
                group.Time + "\',\'" +
                group.Notice + "\',\'" +
                group.Type + "\')";
            ExecuteNonQuery(cmdString, Constant.globalDbPath + "user.db");
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
            ExecuteNonQuery(cmdString, Constant.globalDbPath + "user.db");
            return true;
        }

        /// <summary>
        /// 查询群的资料
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public Group queryGroup(int groupId)
        {
            string cmdString = "SELECT * FROM "+
                DBcolumns.TABLE_GROUP+" WHERE " +
                DBcolumns.GROUP_ID + " = " + groupId;
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + Constant.globalDbPath + "user.db");
            conn.Open();
            SQLiteCommand  cmd = new SQLiteCommand(cmdString,conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            int count = dr.FieldCount;
            if (dr.Read())
            {
                Group gr = new Group();
                gr.GroupId = dr.GetInt32(0);
                gr.GroupName = dr.GetString(1);
                gr.Num = dr.GetInt32(2);
                gr.Time = dr.GetString(3) ;
                gr.Notice = dr.GetString(4);
                gr.Type = dr.GetString(5);
                conn.Close();
                return gr;
            }
            conn.Close();
            return null;
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
            string cmdString = "INSERT INTO group" +
                groupId + " VALUES(\'" +
                userId + "\',\'" +
                DateTime.Now.ToString() + "\', " +
                type + ")";
            ExecuteNonQuery(cmdString, Constant.groupDbPath  + "groupPerson.db");
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
            string cmdString = "SELECT " +
                DBcolumns.GROUP_USER_ID + " FROM group" +
                groupId;
            SQLiteConnection conn = new SQLiteConnection("Data Source="+Constant.groupDbPath + "groupPerson.db");
            conn.Open();
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
