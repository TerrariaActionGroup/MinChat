using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinChat.Communications.bean;
using System.Data.SQLite;

namespace MinChat.Works.db
{
    class GroupDB
    {
        protected string userId;
        protected SQLiteConnection conn;
        protected static GroupDB uniqueInstance;
        public static GroupDB OpenDB(string userId)
        {
            if (null == uniqueInstance)
            {
                uniqueInstance = new GroupDB(userId);
            }
            return uniqueInstance;
        }
        public GroupDB(string userId)
        {
            this.userId = userId; 

            string dbPath = Environment.CurrentDirectory + "/db/" + userId + "/group.db";
            conn = new SQLiteConnection(dbPath);
            string cmdString = "CREATE TABLE IF NOT EXISTS group(groupId integer, groupName varchar(40), num integer, time date, notice text, type varchar(20));";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
        }
        public bool addGroup(Group gr)
        {
            string cmdString = @"INSERT TO group VALUES (" +
                gr.GroupId + "," +
                gr.GroupName + "," +
                gr.Num + "," +
                gr.Time + "," +
                gr.Notice + "," +
                gr.Type + "," + ");";
            SQLiteCommand sqlAddGroup = new SQLiteCommand(cmdString, conn);
            sqlAddGroup.ExecuteNonQuery();
            sqlAddGroup.Dispose();
            return true;
        }
        public bool quitGroup(string groupId)
        {
            string cmdString = "DELETE FROM group WHERE groupId = " + groupId + ";";
            SQLiteCommand sqlDeleteGroup = new SQLiteCommand(cmdString, conn);
            sqlDeleteGroup.ExecuteNonQuery();
            sqlDeleteGroup.Dispose();
            return true;
        }
        public bool changeNotice(string groupId, string newNotice)
        {
            string cmdString = "UPDATE group SET notice =" +
                newNotice + "WHERE groupId = " + groupId + ";";
            SQLiteCommand sqlChangeNotice = new SQLiteCommand(cmdString, conn);
            sqlChangeNotice.ExecuteNonQuery();
            sqlChangeNotice.Dispose();
            return true;
        }
        public bool changeName(string groupId, string newName)
        {
            string cmdString = "UPDATE group SET groupName =" +
                newName + "WHERE groupId = " + groupId + ";";
            SQLiteCommand sqlChangeName = new SQLiteCommand(cmdString, conn);
            sqlChangeName.ExecuteNonQuery();
            sqlChangeName.Dispose();
            return true;
        }
        public bool changeType(string groupId, string newType)
        {
            string cmdString = "UPDATE group SET type =" +
                newType + "WHERE groupId = " + groupId + ";";
            SQLiteCommand sqlChangeType = new SQLiteCommand(cmdString, conn);
            sqlChangeType.ExecuteNonQuery();
            sqlChangeType.Dispose();
            return true;
        }
        public void Close()
        {
            if (null != conn)
            {
                conn.Close();
                conn = null;
            }
        }
    }
}
