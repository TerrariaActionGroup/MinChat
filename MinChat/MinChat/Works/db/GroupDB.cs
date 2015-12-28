using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MinChat.Works.db
{
    class GroupDB
    {
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
            string dbPath = Environment.CurrentDirectory + "/db/" + userId + "/group.db";
            conn = new SQLiteConnection(dbPath);
            string cmdString = "CREATE TABLE IF NOT EXISTS group(groupId integer, groupName varchar(40), num integer, time date, notice text, type varchar(20));";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(cmdString, conn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();
        }
        public bool addGroup(string groupId)
        {
            return true;
        }
        public bool quitGroup(string groupId)
        {
            return true;
        }
        public bool changeNotice(string groupId, string newNotice)
        {
            return true;
        }
        public bool changeName(string groupId, string newName)
        {
            return true;
        }
        public bool changeType(string groupId, string newType)
        {
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
