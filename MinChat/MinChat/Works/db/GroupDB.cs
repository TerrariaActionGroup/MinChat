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
            string path = Environment.CurrentDirectory + "\\db\\" + userId;
            string dbPath = path + "\\group.db";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            if (!System.IO.File.Exists(dbPath))
            {
                System.IO.File.Create(dbPath);
            }
            conn = new SQLiteConnection("Data Source=" + dbPath);
            string cmdString = "CREATE TABLE IF NOT EXISTS group(groupId integer PRIMARY KEY AUTOINCREMENT, groupName varchar(40), num integer, time date, notice text, type varchar(20));";
            conn.Open();
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
            conn.Close();
        }
        public bool addGroup(Group gr)
        {
            string cmdString = @"INSERT INTO group VALUES (" +
                gr.GroupId + "," +
                gr.GroupName + "," +
                gr.Num + "," +
                gr.Time + "," +
                gr.Notice + "," +
                gr.Type + "," + ")";
            conn.Open();
            SQLiteCommand sqlAddGroup = new SQLiteCommand(cmdString, conn);
            sqlAddGroup.ExecuteNonQuery();
            sqlAddGroup.Dispose();
            conn.Close();
            return true;
        }
        public bool quitGroup(string groupId)
        {
            string cmdString = "DELETE FROM group WHERE groupId = " + groupId;
            conn.Open();
            SQLiteCommand sqlDeleteGroup = new SQLiteCommand(cmdString, conn);
            sqlDeleteGroup.ExecuteNonQuery();
            sqlDeleteGroup.Dispose();
            conn.Close();
            return true;
        }
        public bool changeNotice(string groupId, string newNotice)
        {
            string cmdString = "UPDATE group SET notice =" +
                newNotice + "WHERE groupId = " + groupId ;
            conn.Open();
            SQLiteCommand sqlChangeNotice = new SQLiteCommand(cmdString, conn);
            sqlChangeNotice.ExecuteNonQuery();
            sqlChangeNotice.Dispose();
            conn.Close();
            return true;
        }
        public bool changeName(string groupId, string newName)
        {
            string cmdString = "UPDATE group SET groupName =" +
                newName + "WHERE groupId = " + groupId ;
            conn.Open();
            SQLiteCommand sqlChangeName = new SQLiteCommand(cmdString, conn);
            sqlChangeName.ExecuteNonQuery();
            sqlChangeName.Dispose();
            conn.Close();
            return true;
        }
        public bool changeType(string groupId, string newType)
        {
            string cmdString = "UPDATE group SET type =" +
                newType + "WHERE groupId = " + groupId ;
            conn.Open();
            SQLiteCommand sqlChangeType = new SQLiteCommand(cmdString, conn);
            sqlChangeType.ExecuteNonQuery();
            sqlChangeType.Dispose();
            conn.Close();
            return true;
        }
   
    }
}
